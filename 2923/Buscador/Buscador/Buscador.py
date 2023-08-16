from unittest import result
import mysql.connector
from CLASES.table_info  import TableInfo

# Uso de la clase TableInfo
table_info = TableInfo('localhost', 'root', '', 'odapas')
num_fields = table_info.get_num_fields('sys_roles')
print(f"La tabla sys_roles tiene {num_fields} campos.")



# Obtener los resultados de la consulta
results = table_info.results()

# Crear un conjunto vacío para almacenar los resultados
result_set = set()

# Iterar sobre los resultados y agregarlos al conjunto
for row in results:
    result_set.add(row)

# Convertir el conjunto a una lista
result_list = list(result_set)

# Imprimir la lista resultante
print(result_list)

# Obtener los resultados de la consulta
results = table_info.results()

# Obtener la cantidad de resultados
num_results = len(results)

# Imprimir la cantidad de resultados
print(f"Hay {num_results} resultados en el campo sys_roles.")