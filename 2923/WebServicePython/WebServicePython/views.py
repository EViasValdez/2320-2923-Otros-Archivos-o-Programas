import datetime
from django.contrib import messages
import requests
from django.shortcuts import redirect, render
from django.template import Template, Context
from django.http import Http404, HttpResponse
from .models import NuevoAlumno

def index(request): #primera vista
    url = "https://wspython-cb5cedbec989.herokuapp.com/"  # URL del servicio web
    response = requests.get(url)

    if response.status_code == 200:
        data = response.json()  # Parseamos la respuesta JSON
    else:
        data = []

    context = {
        'data': data,  # Pasamos los datos a la plantilla
    }
    return render(request, 'index.html', context)

def create(request):  # Vista para crear un nuevo alumno
    # Retorna [VIEW index, con registro hecho en nuevo_alumno_data]
    if request.method == "POST":
       # Obtener los datos del formulario enviado
        matricula = request.POST.get('matricula')
        nombre = request.POST.get('nombre')
        a_paterno = request.POST.get('a_paterno')
        a_materno = request.POST.get('a_materno')
        edad = request.POST.get('edad')
        grupo = request.POST.get('grupo')
        telefono = request.POST.get('telefono')
        correo = request.POST.get('correo')
        cuatrimestre = request.POST.get('cuatrimestre')
        carrera = request.POST.get('carrera')

        # Imprimir los datos recibidos para verificarlos
        print("Matrícula:", matricula)
        print("Nombre:", nombre)
        print("Apellido Paterno:", a_paterno)
        print("Apellido Materno:", a_materno)
        print("Edad:", edad)
        print("Grupo:", grupo)
        print("Teléfono:", telefono)
        print("Correo electrónico:", correo)
        print("Cuatrimestre:", cuatrimestre)
        print("Carrera:", carrera)

        # Datos del nuevo alumno en formato JSON
        nuevo_alumno_data = {
            'matricula': matricula,
            'nombre': nombre,
            'a_paterno': a_paterno,
            'a_materno': a_materno,
            'edad': edad,
            'grupo': grupo,
            'telefono': telefono,
            'correo': correo,
            'cuatrimestre': cuatrimestre,
            'carrera': carrera
        }

        # URL de la API externa donde se realizará la creación del alumno
        url = "https://wspython-cb5cedbec989.herokuapp.com/"

        try:
            # Realizar la solicitud POST a la API externa para crear el alumno
            response = requests.post(url, data=nuevo_alumno_data)
            print("Datos recibidos:", request.POST)

            # Si la solicitud es exitosa (código 200), redirigir a otra página
            if response.status_code == 200:
                messages.success(request, 'El alumno ha sido registrado exitosamente.')
                return redirect('index')
            else:
                # Mostrar un mensaje de error en la misma página
                error_message = 'No se pudo crear el alumno. Inténtalo nuevamente.'
                return render(request, 'create.html', {'error_message': error_message})

        except requests.exceptions.RequestException as e:
            # Mostrar un mensaje de error en la misma página
            error_message = 'Error al conectar con la API externa. Inténtalo nuevamente más tarde.'
            return render(request, 'create.html', {'error_message': error_message})
    else:
        # Si es una solicitud GET, mostrar el formulario para crear el alumno
        return render(request, 'create.html')


def delete(request, matricula):  # Vista para eliminar un alumno [parameters matricula=str|varchar=BD]
    #Retorna [VIEW index, Message.succes(function.sweetAlert)]
    url = f"https://wspython-cb5cedbec989.herokuapp.com/?matricula={matricula}"
    try:
        # Realizar la solicitud DELETE a la API externa para eliminar el alumno
        response = requests.delete(url)

        # Si la solicitud es exitosa (código 200), mostrar la alerta de éxito
        if response.status_code == 200:
            messages.success(request, 'El alumno ha sido eliminado exitosamente.')
            # Redirigir a la página de índice (o cualquier otra página que desees)
            return redirect('index')  
        else:
            # Mostrar un mensaje de error en la misma página
            error_message = 'No se pudo eliminar el alumno. Inténtalo nuevamente.'
            return render(request, 'delete.html', {'error_message': error_message})

    except requests.exceptions.RequestException as e:
        # Mostrar un mensaje de error en la misma página
        error_message = 'Error al conectar con la API externa. Inténtalo nuevamente más tarde.'
        return render(request, 'delete.html', {'error_message': error_message})

def update(request, matricula): # Vista para actualizar [parameters matricula=str|varchar=BD]
    #Retorna [VIEW, Message.success(function.sweetAlert)]
    if request.method == "GET":
        # Obtener los datos del alumno usando la matrícula proporcionada en la URL
        alumno_data = obtener_datos_alumno(matricula)

        # Si se encontraron los datos del alumno, puedes pasarlos al formulario para su edición
        if alumno_data:
            return render(request, 'update.html', {'alumno_data': alumno_data})
        else:
            # Si no se encontraron los datos del alumno, mostrar un mensaje de error o redirigir a otra página
            error_message = 'No se encontraron datos para el alumno con la matrícula proporcionada.'
            return render(request, 'index.html', {'error_message': error_message})

    elif request.method == "POST":
        # Obtener los datos del formulario enviado
        nombre = request.POST.get('nombre')
        a_paterno = request.POST.get('a_paterno')
        a_materno = request.POST.get('a_materno')
        edad = request.POST.get('edad')
        grupo = request.POST.get('grupo')
        telefono = request.POST.get('telefono')
        correo = request.POST.get('correo')
        cuatrimestre = request.POST.get('cuatrimestre')
        carrera = request.POST.get('carrera')

        # Datos del alumno a actualizar en formato JSON
        alumno_data = {
            'matricula': matricula,
            'nombre': nombre,
            'a_paterno': a_paterno,
            'a_materno': a_materno,
            'edad': edad,
            'grupo': grupo,
            'telefono': telefono,
            'correo': correo,
            'cuatrimestre': cuatrimestre,
            'carrera': carrera
        }

        # URL de la API externa donde se realizará la actualización del alumno
        url = f"https://wspython-cb5cedbec989.herokuapp.com/?matricula={matricula}&nombre={nombre}&a_paterno={a_paterno}&a_materno={a_materno}&edad={edad}&grupo={grupo}&telefono={telefono}&correo={correo}&cuatrimestre={cuatrimestre}&carrera={carrera}"

        try:
            # Realizar la solicitud PUT a la API externa para actualizar el alumno
            response = requests.put(url)

            # Si la solicitud es exitosa (código 200), redirigir a otra página o mostrar un mensaje de éxito
            if response.status_code == 200:
                # Puedes redirigir a la página de éxito o mostrar un mensaje en la misma página
                messages.success(request, f'El alumno {nombre} - {matricula} ha sido modificado exitosamente.')
                return redirect('index')
            else:
                # Mostrar un mensaje de error en la misma página
                error_message = 'No se pudo actualizar el alumno. Inténtalo nuevamente.'
                return render(request, 'index.html', {'error_message': error_message})

        except requests.exceptions.RequestException as e:
            # Mostrar un mensaje de error en la misma página
            error_message = 'Error al conectar con la API externa. Inténtalo nuevamente más tarde.'
            return render(request, 'index.html', {'error_message': error_message})

    else:
        # Manejar otros métodos HTTP si es necesario
        pass

def obtener_datos_alumno(matricula): # Funcion para obtener alumno, parameters [matricula=str|varchar:BD]
    #Retorna [Request URL method GET, de otra forma NONE]
    # URL de la API externa para obtener los datos del alumno
    url = f"https://wspython-cb5cedbec989.herokuapp.com/?matricula={matricula}"

    try:
        # Realizar la solicitud GET a la API externa para obtener los datos del alumno
        response = requests.get(url)

        # Verificar si la solicitud fue exitosa (código 200)
        if response.status_code == 200:
            # Obtener los datos del alumno del cuerpo de la respuesta en formato JSON
            alumno_data = response.json()
            return alumno_data
        else:
            # Si la solicitud no fue exitosa, retornar None o lanzar una excepción personalizada según tu preferencia
            return None
    except requests.exceptions.RequestException as e:
        # Si ocurre un error durante la solicitud, retornar None o lanzar una excepción personalizada
        return None

def hora(request): #segunda vista
    fecha_actual=datetime.datetime.now()
    html="<html><body><h2>Fecha y hora actuales %s.</h2></body></html>" % fecha_actual
    return HttpResponse(html)

def horas_adelante(request, offset): #tercera vista, recibe parametros [offset=int]
    #Retorna [HTML reponse]
    try:
        offset=int(offset)
    except ValueError:
        raise Http404()
    dt=datetime.datetime.now()+datetime.timedelta(hours=offset)
    html="<html><body><h2>En %s hora(s), serán las %s.</h2></body></html>" % (offset, dt)
    return HttpResponse(html)