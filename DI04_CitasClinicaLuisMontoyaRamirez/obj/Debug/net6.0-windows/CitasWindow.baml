   M S B A M L   `   `   `  ����^  ZDI04_CitasClinicaLuisMontoyaRamirez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:DI04_CitasClinicaLuisMontoyaRamirez#DI04_CitasClinicaLuisMontoyaRamirez  5   	   5    /DI04_CitasClinicaLuisMontoyaRamirez.CitasWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Clocal1clr-namespace:DI04_CitasClinicaLuisMontoyaRamirez     5   	   -   5          � Title$  CitasWindow��5   	   $	��290��6   $	��750��6*    � 
ResizeMode$ NoResize=�66   .��5   
   � -   5         �Name$ gridAddCita��5      $y�Visible=�6$   $	��425��69   $	��Top=�6F    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $	��100 �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Fecha��6   $��0��6$   $��0��61   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DpFecha��5      $��0��6*   $��1��67      SelectedDate 6G   �� *Fecha+ �� NotifyOnValidationError$
 True�� �� ValidatesOnDataErrors$
 True��6�   �� 5      $
��Hora��6   $��1��6#   $��0��60   �� 5      -   5        	 ��Name$	 CbHora��5      $��1��6'   $��1��64   
 �� SelectedValue
 6D   �� *Hora+$
 True��$
 True���� 5       $��Paciente��6   $��2��6'   $��0��64   �� 5!      -   5        $	 
CbPaciente��5!      $��2��6+   $��1��68   
 6H   �� *Email+$
 True��$
 True���� 5"      $��Motivo��6   $��3��6%   $��0��62   �� 5#      -   5         ��Name$ TbMotivo��5#      $��3��6(   $��1��65   ��6E   �� *Motivo+$
 True��$
 True��6�   �� 5$      $��Observaciones��6   $��4��6,   $��0��69   �� 5%      -   5        $ TbObservaciones��5%      $��4��6/   $��1��6<   ��6L   �� *Observaciones+$ False��$
 True���� 5&      $��Método de pago��6   $��5��6-   $��0��6:   �� 5'      -   5        $	 CbMetodoPago��5'      $��5��6-   $��1��6:   
 6J   �� *
MetodoPago+$
 True��$
 True���� 5(      -	   5         ��Name$ 
BtnAddCita��5(      $��Añadir��6)   $��6��6:   $��0��6G   6W   �� 5)      -
   5        $ BtnCancelCita��5)      $��Cancelar��6,   $��6��6?   $��1��6L   6\   5*      5+      