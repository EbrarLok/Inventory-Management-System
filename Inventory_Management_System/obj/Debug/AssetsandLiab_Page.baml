   M S B A M L   `   `   `  ����V  RInventory_Management_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Inventory_Management_SystemInventory_Management_System  5      4    .Inventory_Management_System.AssetsandLiab_Page   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:Inventory_Management_System     5        N� Title$  AssetsandLiab_Page��5
       N� 
Background �	#FF2479AA.��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��grdAssetsandLiab��5      $
��Left=�6+   $	��311��6F   $��
311,10,0,0q�6S   $	��Top=�6g   $	��489��6   5      �� 5   
   -   5        $��	Btn_ALAdd��5      $	��Add��6"   $
��Left=�60   $��
37,386,0,0q�6K   $	��Top=�6_   $��74��6w   6�   �� 5   
   $��Activity Information��6   $
��Left=�61   $	��311��6L   $��	10,10,0,0q�6Y   $	��Top=�6l   $	��296��6�   � 5   
   $
��Left=�6   $	��264��6*   $��	10,27,0,0q�67   $	��Top=�6J   $	��199��6b   .+�5      �� $��Product Id:��6   $
��Left=�6*   $��	10,34,0,0q�6E   $	��Top=�6X   $��Arial)�6p   �� 5      $��
Situation:��6   $
��Left=�6)   $��	10,67,0,0q�6D   $	��Top=�6W   $��Arial)�6o   �� 5      $��Description:��6   $
��Left=�6+   $��5,99,0,0q�6F   $	��Top=�6X   $��Arial)�6p   �� 5      $��Transaciton Date:��6   $
��Left=�60   $��	7,128,0,0q�6K   $	��Top=�6^   $��Arial)�6v   �� 5      $��	Quantity:��6   $
��Left=�6(   $��	7,167,0,0q�6C   $	��Top=�6V   $��Arial)�6n   �� 5      $��Price:��6   $
��Left=�6%   $��
10,211,0,0q�6@   $	��Top=�6T   $��Arial)�6l   �� 5      $��Drawee:��6   $
��Left=�6&   $��
10,240,0,0q�6A   $	��Top=�6U   $��Arial)�6m   �� 5      $
��Left=�6   $	��230��64   $��162,34,-79,0q�6A   $	��Top=�6W   $	��116��6o   .+�5      �� -   5        $��TxtProductIdAL��5      $��23��60    �� TextWrapping$
 Wrap=�6<   $�� ��6P   �� 5      -   5        $��TxtSituation��5      $��23��6.   $
 Wrap=�6:   $��TextBox��6N   $
��0,12q�6]   �� 5      -   5        $��TxtDescript��5      $��23��6-   $
 Wrap=�69   $��TextBox��6M   (  "System.Windows.Controls.DatePicker  5      -   5        $��
DateTimeAL��5      �� 5       -   5        $��TxtQuantityAL��5       $��23��6/   $
 Wrap=�6;   $�� ��6O   $
��0,10q�6W   �� 5!      -   5         ��Name$ TxtPrice��5!      $��23��6,   $
��0,12q�68   $
 Wrap=�6F   $�� ��6Z   �� 5"      -	   5        $��	TxtDrawee��5"      $��23��6+   $
 Wrap=�67   $��TextBox��6K   5#      5$      �� 5&   
   -
   5        $��Btn_ProductDelete��5&      $��Delete��6*   $
��Left=�6;   $��230,386,0,0q�6V   $	��Top=�6k   $��76��6�   6�   �� 5'   
   -   5        $��Btn_ProductEdit��5'      $
��Edit��6(   $
��Left=�67   $��134,386,0,0q�6R   $	��Top=�6g   $��75��6   6�   5*      5,      