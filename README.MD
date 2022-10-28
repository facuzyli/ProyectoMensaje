# Solicitud:
Se pide desarrollar un sistema para la mensajería interna de una empresa. Para esto, vamos a utilizar una entidad denominada Mensaje.
## Relevamiento de Datos:
* ID del Registro.
* Asunto. (debe tener entre 10 y 50 caracteres).
* Mensaje. (no debe estar vacío).
* Emisor del Mensaje.
* Receptor del Mensaje.
* Urgencia (Si el mensaje es urgente o no lo es).
* Fecha y Hora de Envío.

A su vez, se quiere registrar en una tabla los siguientes campos SOLO para aquellos mensajes que sean urgentes:
* Asunto
* Fecha y Hora de envío

*** Solo deberán actualizarse los campos de la tabla auxiliar en caso de que haya finalizado correctamente la creación del mensaje en la base de datos, por ende, deberá utilizar transacciones, si la actualización de la tabla auxiliar genera un error deberá retrocederse el estado de la base de datos (no permitir el alta del mensaje correspondiente). 


Se pide generar el código necesario para persistir el objeto en base de datos, para ello:
* Generar el proyecto de base de datos. El mismo deberá contener dos tablas (Mensajes y Auxiliar). 
* Implementar la arquitectura de capas aprendida en clases. 
* Utilizar Transacciones (TransactionScope) en la capa que corresponda. 
* Escribir algoritmos en C# que permitan: 
* Insertar nuevos mensajes en la base de datos. 
* Actualizar la tabla auxiliar con el último asunto del mensaje que se grabó en la base de datos y la fecha de envío del mismo. 
* El primer registro de la tabla auxiliar se puede realizar a mano.
* Mostrar el listado de los mensajes en una grilla. 
* El método que lista deberá retornar una lista de mensajes NO un DataSet. 
* Utilizar parámetros al ejecutar comando en la base de datos. 
