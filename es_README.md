# Linkar Demo Desktop App. Windows. Linux. Mac

Funcionamiento de un cliente persistente alimentando unas clases Linkar y mostrando la información resultante sobre unos formularios.

#MainWindow

Esta ventana recoge la información para ejecutar el login del LinkarClient y permite hacer el logout del cliente. Una vez hecho el login tendremos acceso al resto de formularios.

#Customers (FormCustomers)

Este formulario trabaja con las clases CLkCustomer y CLkCustomers incluidas en la carpeta BL.

El botón Select llama al método de selección de la clase plural (CLkCustomers) que se usa con la opción calculate para cargar todos los datos seleccionados. En el cuadro de selección puede escribir un nombre de cliente o su id. 
Tras situarnos en el registro deseado se podrán usar el resto de botones para llamar a las operaciones CRUD (Create, Read, Update y Delete) situadas en la clase singular (ClkCustomer).

#Items (FormItems)

Este formulario trabaja con las clases CLkItem y CLkItems incluidas en la carpeta BL.
El botón Select llama al método de selección de la clase plural (CLkItems) que se usa con la opción "calculate" para cargar todos los datos seleccionados. En el cuadro de selección, puede escribir la descripción de un item o su id. 
Tras situarnos en el registro deseado se podrán usar el resto de botones para llamar a las operaciones CRUD (Create, Read, Update y Delete) situadas en la clase singular (ClkItem).

#Orders Details (FormOrdersDetails)

Este formulario trabaja con las clases CLkOrder, MV_LstItems_CLkOrder, SV_LstPartial_ClkOrder y CLkOrders, incluidas en la carpeta BL.
El botón Select llama al método de selección de la clase plural (CLkOrders) que se usa con la opción onlyitems para cargar únicamente el grid de la izquierda. La información de cada registro es leída al situarse en dicho registro mediante una Read con la opción calculate. En el cuadro de selección, puede escribir el código de un Order para ir directamente a ese registro. 
Al tratarse de un formulario de solo lectura no se dispone de los métodos CRUD (Create, Read, Update y Delete) en la clase ClkOrder.
El tratamiento de los multivalores y subvalores queda a cargo de las clases MV_LstItems_ClkOrder y SV_LstPartial_ClkOrder y ClkOrders.

#Orders Lists (FormOrdersList)

Este formulario trabaja con las clases CLkOrder, MV_LstItems_CLkOrder, SV_LstPartial_ClkOrder y CLkOrders, incluidas en la carpeta BL.
El botón Select llama al método de selección de la clase plural (CLkOrders) que se usa con la opción calculate para cargar todos los datos seleccionados. En el cuadro de selección, puede escribir el código de un Order para ir directamente a ese registro.
Al situarse sobre un multivalor se cargarán de forma automática sus subvalores sobre el grid asociado.
Al tratarse de un formulario de solo lectura no se dispone de los métodos CRUD (Create, Read, Update y Delete) en la clase ClkOrder.
El tratamiento de los multivalores y subvalores queda a cargo de las clases MV_LstItems_ClkOrder y SV_LstPartial_ClkOrder y ClkOrders.
