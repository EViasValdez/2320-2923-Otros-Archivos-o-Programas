import mysql.connector



class TableInfo:

    def __init__(self, host, user, password, database):
        self.host = host
        self.user = user
        self.password = password
        self.database = database

    def get_num_fields(self, table_name):
        try:
            # Conectarse a la base de datos
            cnx = mysql.connector.connect(
                host=self.host,
                user=self.user,
                password=self.password,
                database=self.database
            )
            cursor = cnx.cursor()

            # Obtener la estructura de la tabla
            query = f"DESCRIBE {table_name}"
            cursor.execute(query)

            # Contar el n�mero de columnas
            num_fields = len(cursor.fetchall())

            # Cerrar la conexion y el cursor
            cursor.close()
            cnx.close()

            return num_fields
        except mysql.connector.Error as err:
            print("Error al conectar a la base de datos:", err)

    def results(self):
        try:
            cnx = mysql.connector.connect(
                user=self.user,
                password=self.password,
                host=self.host,
                database=self.database
            )
            cursor = cnx.cursor()

            query = "SELECT name FROM sys_roles"
            cursor.execute(query)

            result_set = set()
            for row in cursor:
                result_set.add(row[0])

            cursor.close()
            cnx.close()

            return result_set

        except mysql.connector.Error as err:
            print("Error al conectar a la base de datos:", err)