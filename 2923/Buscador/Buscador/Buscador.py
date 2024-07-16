from unittest import result
import mysql.connector
from CLASES.Table_Info import TableInfo

# Uso de la clase TableInfo.
Table_Info = TableInfo('localhost', 'root', '', 'odapas')
num_fields = Table_Info.get_num_fields('sys_roles')
print(f"La tabla sys_roles tiene {num_fields} campos.")

# Obtener los resultados de la consulta.
Results = Table_Info.Results()

# Crear un conjunto vacio para almacenar los resultados.
result_set = set()

# Iterar sobre los resultados y agregarlos al conjunto.
for row in Results:
    result_set.add(row)

# Convertir el conjunto a una lista.
result_list = list(result_set)

# Imprimir la lista resultante.
print(result_list)

# Obtener los resultados de la consulta.
Results = Table_Info.Results()

# Obtener la cantidad de resultados.
Num_results = len(Results)

# Imprimir la cantidad de resultados.
print(f"Hay {Num_results} resultados en el campo sys_roles.")