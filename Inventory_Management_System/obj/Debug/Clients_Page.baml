   M S B A M L   `   `   `  ����V  RInventory_Management_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Inventory_Management_SystemInventory_Management_System  5      .    (Inventory_Management_System.Clients_Page   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Inventory_Management_System     5        N� Title$  Clients_Page��5
       N� 
Background �	#FF2479AA.��5      � .+�5   
   �� $��Client Name:��6   $
��Left=�6'   $��	25,78,0,0q�6B   $	��Top=�6U   $��Arial)�6m   $��16(�6�   �� 5   
   $��Client Phone:��6   $
��Left=�6(   $��
25,128,0,0q�6C   $	��Top=�6W   $��Arial)�6o   $��16(�6�   �� 5   
   $��Client Mail:��6   $
��Left=�6'   $��
25,181,0,0q�6B   $	��Top=�6V   $��Arial)�6n   $��16(�6�   �� 5   
   $��Client Address:��6   $
��Left=�6*   $��
25,235,0,0q�6E   $	��Top=�6Y   $��Arial)�6q   $��16(�6�   �� 5   
   $
��Left=�6   $	��185��60   $��
175,78,0,0q�6=   $	��Top=�6Q   $	��117��6i   .+�5      �� -   5        $��TxtClientName��5      $��23��6+    �� TextWrapping$
 Wrap=�67   $�� ��6K   %  Xceed.Wpf.Toolkit.MaskedTextBox  5      -   5        $��MskdClientPhone��5   !      Mask$ (000)-000-0000��68   $
��0,32q�6N   6^   �� 5      -   5        $��TxtClientMail��5   "   $��23��6   $
 Wrap=�67   $�� ��6K   �� 5      -   5        $��TxtClientAddress��5   "   $��23��6   $
��0,32q�6:   $
 Wrap=�6H   $�� ��6\   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��	grdClient��5      $
��Left=�6$   $	��271��6?   $��
328,51,0,0q�6L   $	��Top=�6`   $	��462��6x   6�   �� 5   
   $��Client Information��6   $
��Left=�6/   $	��285��6J   $��	10,37,0,0q�6W   $	��Top=�6j   $	��300��6�   $��16(�6�   
���   �6�   �� 5   
   -   5        $��Btn_ClientAdd��5      $	��Add��6&   $
��Left=�64   $��
27,346,0,0q�6O   $	��Top=�6c   $��75��6{   6�   �� 5   
   -   5        $��Btn_ClientEdit��5      $
��Edit��6'   $
��Left=�66   $��131,346,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $��Btn_ClientDelete��5      $��Delete��6)   $
��Left=�6:   $��235,346,0,0q�6U   $	��Top=�6j   $��75��6�   6�   5      5      