import mysql.connector
mysqldb = mysql.connector.connect(host="localhost", user="root",password="", database="customerinformation")
mysqlcursor = mysqldb.cursor()

mysqlcursor.execute("create table customers(name CHAR(30), surname CHAR(15), ID INT(10), address VARCHAR(100), contactdetails INT(10)")

mysqldb.close()




file = open("CustomerInformation.txt", "r")
contents = file.read()
print(contents)
file.close()

    