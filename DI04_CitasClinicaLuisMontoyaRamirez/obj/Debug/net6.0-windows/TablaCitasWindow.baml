   M S B A M L   `   `   `  ����^  ZDI04_CitasClinicaLuisMontoyaRamirez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:DI04_CitasClinicaLuisMontoyaRamirez#DI04_CitasClinicaLuisMontoyaRamirez  5   	   :    4DI04_CitasClinicaLuisMontoyaRamirez.TablaCitasWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Clocal1clr-namespace:DI04_CitasClinicaLuisMontoyaRamirez     5   	   $	��300��5   	   $	��400��6   $	��600��5	   	   $	��800��6     � Title$  Tabla de Citas��5
   	   $	��450��6    $	��650��6-   .��5      � -   5         �Name$ 	TablaGrid��5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridCitas��5      $��0��5         AutoGenerateColumns$ False��5      $��Stretch=�5      $��Stretch=�5      $��10,10,10,10q�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Día��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Dia+6J     5      $
 Hora��6%   $
 Auto 6L    63   �� *Hora+6L     5      $ Nombre��6%   $
 Auto 6P    65   �� *Nombre+6P     5       $ 	Apellidos��6%   $
 Auto 6V    68   �� *	Apellidos+6V     5!      $ Motivo��6%   $ * 6P    65   �� *Motivo+6P     5"      $ Observaciones��6%   $ * 6^    6<   �� *Observaciones+6^     5#      $ Forma de Pago��6%   $
 Auto 6Z    6<   �� *	FormaPago+6Z   5%      �� 5'   
   $��1��6   	 �� Orientation$	 
Horizontal=�6"   $��Center=�6;   $��0,10,0,0q�6X   .+�5(      �� -   5        
 ��Name$
 	BtnVolver��5(      $��Volver��6(   $	��100��69   $��30��6E   $��20,20,20,20q�6i   �� 5)      -   5        $
 BtnEliminar��5)      $��Eliminar��6*   $	��100��6=   $��30��6I   $��20,20,20,20q�6o   5*      5-      5.      