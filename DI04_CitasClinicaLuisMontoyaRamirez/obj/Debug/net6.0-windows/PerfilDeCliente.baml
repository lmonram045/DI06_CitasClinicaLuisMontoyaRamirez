   M S B A M L   `   `   `  ����^  ZDI04_CitasClinicaLuisMontoyaRamirez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:DI04_CitasClinicaLuisMontoyaRamirez.componentes/DI04_CitasClinicaLuisMontoyaRamirez.componentes  5   	   9    3DI04_CitasClinicaLuisMontoyaRamirez.PerfilDeCliente   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Luc=clr-namespace:DI04_CitasClinicaLuisMontoyaRamirez.componentes     5   	   -   5          � Title$  Añadir Cliente��5	   	   $	��275��6    $	��600��6-    � 
ResizeMode$ NoResize=�69   .��5      � -   5         �Name$ GridDatosCliente��5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��130 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Nombre:��6-   �� 5   
   -   5         ��Name$ TbNombre��5   /   $��0��6   $��1��6   ��5      �� *	.Nombre+ �� NotifyOnValidationError$
 True�� �� ValidatesOnDataErrors$
 True��5   3   �� 5!   
   $��1��6   $��0��6   $��
Apellidos:��6-   �� 5"   
   -   5        $ TbApellidos��5"   /   $��1��6   $��1��6   ��5#      �� *
.Apellidos+$
 True��$
 True��5$   6   �� 5&   
   $��2��6   $��0��6   $��
Teléfono:��6-   �� 5'   
   -   5        $ 
TbTelefono��5'   /   $��2��6   $��1��6   ��5(      �� *	.Telefono+$
 True��$
 True��5)   5   �� 5+   
   $��3��6   $��0��6   $��Email:��6-   �� 5,   
   -   5        $ TbEmail��5,   /   $��3��6   $��1��6   ��5-      �� *.Email+$
 True��$
 True��5.   2   �� 50   
   $��4��6   $��0��6   $
��DNI:��6-   H   BDI04_CitasClinicaLuisMontoyaRamirez.componentes.DniLetraComponente  51   
   -   5          Name$ DniComponente��51   =   $��4��6    $��1��6-   	   LongitudNumero$	 8��6T   �� 53   
   $��5��6   $��0��6   $��Dirección física:��6-   �� 54   
   -   5        $ TbDireccion��54   /   $��5��6   $��1��6   ��55      �� *
.Direccion+$
 True��$
 True��56   6   �� 58   
   $��6��6   $��0��6   $��Fecha de nacimiento:��6-   (  "System.Windows.Controls.DatePicker  59   
   -	   5        
  Name$
 DpFechaNacimiento��59   2   $��6��6   $��1��6"      SelectedDate 5:      �� *.FechaNacimiento+$
 True��$
 True���� 5<   
   $��7��6   $��0��6   $��Observaciones:��6-   �� 5=   
   -
   5        $ TbObservaciones��5=   /   $��7��6   $��1��6    �� TextWrapping$
 Wrap=�5?      ��5>      �� *.Observaciones+$
 True��$
 True��5?      �� 5B   
   -   5         ��Name$ 
BtnGuardar��5B      $��8��6   $��2��62   $��Center=�6F   $��Guardar cambios��5C      {�6F   ��  �� ElementName$ GridDatosCliente��5D      5E      