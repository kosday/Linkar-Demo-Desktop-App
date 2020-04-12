# Linkar Demo Desktop App. Windows. Linux. Mac

This demo shows how a persistent client works with an automatic class and shows database information on a form.

executable in https://kosday.com/resources/

# MainWindow 
  This window gets mandatory information that allows LinkarClient login and logout. If we have already done the login you will have access to the other forms.

# Customers (FormCustomers): 
  This form uses the CLkCustomer and CLkCustomers classes. 
  A Select button calls the selection method from the (ClkICustomers) plural  class.This class uses the "calculate" option to change all selected data.
  Enter a Customer name or ID in the selection dialog.
  When you set a record, buttons will be enabled to call CRUD operations (Create, Read, Update, and Delete) located in the (ClkItem) singular class.

# Items (FormItems): 
  This form uses the CLKItems and CLKItem classes.
  A Select button calls the selection method from the (ClkItems) plural class. This class uses the "calculate" option to change all selected data.
  Enter an item name or ID in the selection dialog.
  When you set a record, buttons will be enabled to call CRUD operations (Create, Read, Update, and Delete) located in the singular class (ClkItem)

# Orders Details (FormOrdersDetails): 
  This form uses CLkOrder, MV_LstItems_CLkOrder, SV_LstPartial_ClkOrder and CLkOrders classes.
  Select button calls the selection method from the (ClkOrders) plural class that is used with the "only items" option to charge grid left side. 
  Each record information will be read when you set the record, through a Read with the "calculate" option.
  In the selection dialog enter an Order code and go to that record.
  MV_LstItems_ClkOrder y SV_LstPartial_ClkOrder y ClkOrders classes property control multivalues and subvalues. 
  
# Orders List (FormOrdersList): 
  This form uses CLkOrder, MV_LstItems_CLkOrder, SV_LstPartial_ClkOrder and CLkOrders classes.
  Select button calls the selection method from the (ClkOrders) plural class that is used with the "calculate" option to change all the data.
  In the selection dialog you can write an Order code to directly go to that record.
  Setting a multivalue line in the grid, all its subvalues will be changed automatically in the grid located below.
  MV_LstItems_ClkOrder y SV_LstPartial_ClkOrder y ClkOrders classes property control multivalues and subvalues. 
