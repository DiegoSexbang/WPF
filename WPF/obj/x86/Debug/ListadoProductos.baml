   M S B A M L   `   `   `  ����  WPF    WPF.ListadoProductos   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  ListadoProductos��5   	   $	��378��6"   $	��531��6/   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��258* �6   �� 5      $	��20* �6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��GrillaProductos��5
   i      AutoGenerateColumns . $	��200��6.   $
��Left=�6;   $��	90,70,0,0q�6V   $	��Top=�6�   $	��295��6�   ��6�   �� 6�   �� 5   
   -   5        $��txtCodProducto��5   L   $��23��6   $
��Left=�6   $��	90,41,0,0q�69   $	��Top=�6b   $��81��6z   6�   �� 5   
   -   5        $��txtNombreProducto��5   M   $��23��6   $
��Left=�6   $��
199,41,0,0q�69   $	��Top=�6f   $	��120��6~   6�   �� 5   
   -   5        $��label1��5   [   $��Codigo��6   $��28��6!   $
��Left=�6-   $��	90,12,0,0q�6H   $	��Top=�6i   �� 5   
   -   5        $��label2��5   ^   $��Producto��6   $��28��6#   $
��Left=�6/   $��
199,12,0,0q�6J   $	��Top=�6l   �� 5   
   -   5        $��	btnBuscar��5   M   $��23��6   $
��Left=�6   $��
325,40,0,0q�69   $	��Top=�6^   $��38��6v   .��5      �� $��imagenes\Buscar.png��6   $��15��61   $��19��6=   6J   5      �� 5   
   -   5        $��
btnLimpiar��5   L   $��23��6   $��Right=�6   $��	0,41,65,0q�69   $	��Top=�6^   $��38��6v   .��5      �� $��15��6   $��imagenes\refresh.gif��6    $��19��6>   5      5      5      