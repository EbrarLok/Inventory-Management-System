   M S B A M L   `   `   `  ����V  RInventory_Management_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Inventory_Management_SystemInventory_Management_System  5      /    )Inventory_Management_System.Products_Page   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Inventory_Management_System     5        N� Title$  Products_Page��5
      .��5      � -   5        $��prdctgrd��5      ���	#FF2479AA$
��1012��62   $	��553��6?   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
grdProduct��5      $
��Left=�6'   $	��393��6B   $��
390,28,0,0q�6O   $	��Top=�6c   $	��536��6{   6�   �� 5   
   $��Product Information��6   $
��Left=�60   $	��393��6K   $��	10,28,0,0q�6X   $	��Top=�6k   $	��347��6�   $��16(�6�   ���	#7F000000.��5      � $
��Left=�6   $	��329��6.   $��10,10,-2,-53q�6;   $	��Top=�6Q   $	��327��6i   .+�5      �� $��Product ID:��6   $
��Left=�6.   $��-3,8,0,0q�6I   $	��Top=�6[   $��Arial)�6s   $��16(�6�   �� 5      $��Product Name:��6   $
��Left=�60   $��	-3,58,0,0q�6K   $	��Top=�6^   $��Arial)�6v   $��16(�6�   �� 5      $��Product Quantity:��6   $
��Left=�64   $��
-3,111,0,0q�6O   $	��Top=�6c   $��Arial)�6{   $��16(�6�   �� 5      $��Product Price��6   $
��Left=�60   $��
-3,165,0,0q�6K   $	��Top=�6_   $��Arial)�6w   $��16(�6�   �� 5      $��Product Description:��6   $
��Left=�67   $��
-3,219,0,0q�6R   $	��Top=�6f   $��Arial)�6~   $��16(�6�   �� 5      $��Product Category:��6   $
��Left=�64   $��
-3,272,0,0q�6O   $	��Top=�6c   $��Arial)�6{   $��16(�6�   �� 5      $
��Left=�6   $	��323��68   $��	171,1,0,0q�6E   $	��Top=�6X   $	��147��6p   .+�5      %  Xceed.Wpf.Toolkit.MaskedTextBox  -   5        $��MskdProductId��5   )      Mask$ 0��6>   $
��0,13q�6G   �� 5      -   5        $��TxtProductName��5      $
��0,13q�64   $��23��6B    �� TextWrapping$
 Wrap=�6N   $�� ��6b     5      -   5        $��MskdProductQuantity��5   )   $ 00000��6D   $
��0,19q�6Q     5      -   5        $��MskdProductPrice��5   )   $ 00000��6A   $
��0,19q�6N   �� 5      -   5        $��Txt_ProductDesc��5      $
��0,13q�65   $��23��6C   $
 Wrap=�6O   $�� ��6c   �� 5      -   5        $��CmbProductCategory��5      $	��0,3q�69   .@�5      �� $��
Electronic��6'   �� 5       $
��Book��6'   �� 5!      $��Other��6'   5"      5#      5$      5%      �� 5&   
   -	   5        $��Btn_ProductAdd��5&      $	��Add��6'   $
��Left=�65   $��
36,439,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5'   
   -
   5        $��Btn_ProductEdit��5'      $
��Edit��6(   $
��Left=�67   $��140,439,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 5(   
   -   5        $��Btn_ProductDelete��5(      $��Delete��6*   $
��Left=�6;   $��244,439,0,0q�6V   $	��Top=�6k   $��75��6�   6�   5.      5/      