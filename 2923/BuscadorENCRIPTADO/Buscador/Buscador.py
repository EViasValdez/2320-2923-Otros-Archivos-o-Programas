# -*- coding: utf-8 -*-
from unittest import result
#crypto
from cryptography.fernet import Fernet
#conexion MySQL
import mysql.connector
from CLASES.table_info  import TableInfo

# Uso de la clase TableInfo
table_info = TableInfo('localhost', 'root', '', 'odapas')
num_fields = table_info.get_num_fields('sys_roles')
print(f"La tabla sys_roles tiene {num_fields} campos.")

#escribir y guardar clave 
def genera_clave():
    clave = Fernet.generate_key()
    with open("clave.key","wb") as archivo_clave:
        archivo_clave.write(clave)

#cargar clave 
def cargar_calve():
    return open("clave.key", "rb").read()

# Obtener los resultados de la consulta
Resultados = table_info.Resultados()

# Crear un conjunto vac�o para almacenar los resultados
result_set = set()

# Iterar sobre los resultados y agregarlos al conjunto
for row in Resultados:
    result_set.add(row)
 
# Convertir el conjunto a una lista
result_list = list(result_set)

# Imprimir la lista resultante
print(result_list)

# Obtener los resultados de la consulta
Resultados = table_info.Resultados()

# Obtener la cantidad de resultados
num_results = len(Resultados)

# Imprimir la cantidad de resultados
print(f"Hay {num_results} resultados en el campo sys_roles.")
print("\n")

# Proseso de encriptacion 
# Crear y guardar clave 
genera_clave()

# Cargar clave 
clave = cargar_calve()

# Encriptar mensaje
msg = ''.join(result_list).encode()

# Inicioamos 
f = Fernet(clave)

# Encriptamos mensaje 
encriptado = f.encrypt(msg)

# Mensaje encriptado
print("\n mensaje encriptado")
print(encriptado)

# Desencriptado
Desencriptado = f.decrypt(encriptado)

# Mensaje original 
print("\n mensaje desencriptado")
print(Desencriptado)