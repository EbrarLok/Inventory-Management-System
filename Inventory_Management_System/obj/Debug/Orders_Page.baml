   M S B A M L   `   `   `  ����V  RInventory_Management_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Inventory_Management_SystemInventory_Management_System  5      -    'Inventory_Management_System.Orders_Page   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Inventory_Management_System     5        N� Title$  Orders_Page��5
      .��5      � ���	#FF2479AA$
��1012��6"   $	��553��6/   .+�5   
   �� $��Order Name:��6   $
��Left=�6&   $��3,46,0,0q�6A   $	��Top=�6S   $��Arial)�6k   $��16(�6~   �� 5   
   $��Order Type:��6   $
��Left=�6&   $��3,96,0,0q�6A   $	��Top=�6S   $��Arial)�6k   $��16(�6~   �� 5   
   $��Courier Company:��6   $
��Left=�6+   $��	3,149,0,0q�6F   $	��Top=�6Y   $��Arial)�6q   $��16(�6�   �� 5   
   $��Parcel Tracking Number:��6   $
��Left=�62   $��	3,203,0,0q�6M   $	��Top=�6`   $��Arial)�6x   $��16(�6�   �� 5   
   $��Transaction Date:��6   $
��Left=�6,   $��	3,257,0,0q�6G   $	��Top=�6Z   $��Arial)�6r   $��16(�6�   �� 5   
   $��Shipment Fee:��6   $
��Left=�6(   $��	3,310,0,0q�6C   $	��Top=�6V   $��Arial)�6n   $��16(�6�   �� 5   
   $
��Left=�6   $	��292��60   $��
194,46,0,0q�6=   $	��Top=�6Q   $	��149��6i   .+�5      �� -   5        $��TxtOrderName��5      $��23��6*    �� TextWrapping$
 Wrap=�66   $�� ��6J   �� 5      -   5        $��TxtOrderType��5      $��23��6*   $
��0,27q�66   $
 Wrap=�6D   $�� ��6X   �� 5      -   5        $��TxtCourierComp��5      $��23��6,   $	��0,5q�68   $
 Wrap=�6E   $�� ��6Y   %  Xceed.Wpf.Toolkit.MaskedTextBox  5      -   5        $��MskdTrackNumber��5   !      Mask$ 00000000000��68   $
��0,28q�6K   (  "System.Windows.Controls.DatePicker  5      -   5        $��DpOrderDate��5      $	��0,5q�6,   �� 5      -   5        $��TxtShipmentFee��5      $��23��6,   $
��0,23q�68   $
 Wrap=�6F   $�� ��6Z   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��	grdOrders��5      $
��Left=�6$   $	��292��6?   $��
360,46,0,0q�6L   $	��Top=�6`   $	��556��6x   6�   �� 5   
   -   5        $��Btn_OrderAdd��5      $	��Add��6%   $
��Left=�63   $��
33,387,0,0q�6N   $	��Top=�6b   $��75��6z   6�   �� 5   
   -	   5        $��Btn_OrderEdit��5      $
��Edit��6&   $
��Left=�65   $��137,387,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5   
   -
   5        $��Btn_OrderDelete��5      $��Delete��6(   $
��Left=�69   $��241,387,0,0q�6T   $	��Top=�6i   $��75��6�   6�   5       5!      