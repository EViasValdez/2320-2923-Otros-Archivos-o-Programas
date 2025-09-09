# models.py

class NuevoAlumno:
    def __init__(self, matricula, nombre, a_paterno, a_materno, edad, grupo, telefono, correo, cuatrimestre, carrera):
        self.matricula = matricula
        self.nombre = nombre
        self.a_paterno = a_paterno
        self.a_materno = a_materno
        self.edad = edad
        self.grupo = grupo
        self.telefono = telefono
        self.correo = correo
        self.cuatrimestre = cuatrimestre
        self.carrera = carrera