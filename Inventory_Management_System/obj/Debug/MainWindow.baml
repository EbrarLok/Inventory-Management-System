   M S B A M L   `   `   `  ����V  RInventory_Management_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Inventory_Management_SystemInventory_Management_System  5   	   ,    &Inventory_Management_System.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   X TXceed.Wpf.Toolkit, Version=4.1.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Inventory_Management_System     5   	     � Title$  
MainWindow��5	   	   $��584.017��6   $
��1020��6-    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $= 7/Inventory_Management_System;component/css/MyStyle.xaml?�6%   5      %    5      .��5      � ���	#FF2479AA J� RenderTransformOrigin$ 0.5,0.5&�6"   z�5   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.044Q�6"   T� 5      5      .+�5   
   �� $!��Inventory Management System��6   $
��Left=�66   $��339,151,0,0q�6Q   $	��Top=�6f   $ 0.497,0.709&�6~   $��Segoe Script)�6�   $��20(�6�   �� 5   
   $ ��.\Icons\Main_Form_Icon.png��6   $
��Left=�64   $	��100��6O   $��
464,46,0,0q�6\   $	��Top=�6p   $	��100��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5       �� 5!   
   -   5         ��Name$ Btn_Product��5!         btnhoverdisabled#��[  6&   $�� ��6P   $
��Left=�6[   $��258,220,0,0q�6v   $	��Top=�6�   $��94��6�   $��95��6�    � Cursor$
 Hand��6�   4  .System.Windows.Automation.AutomationProperties	   Name$	 Btn_Product��6�   ��5"      �� 5#      
 �� ImageSource$
 Icons/Products_Icon.png��6   5%      �� 5'   
   -   5        $��Btn_AssetsandLiab��5'      #��[  6*   $�� ��6T   $
��Left=�6_   $��464,220,0,0q�6z   $	��Top=�6�   $��94��6�   $��95��6�   $
 Hand��6�   ��5(      �� 5)      $
 Icons/Ast_Lbl_Icon.png��6   5+      �� 5,   
   -   5        $��
Btn_Orders��5,      #��[  6#   $�� ��6M   $
��Left=�6X   $��656,215,0,0q�6s   $	��Top=�6�   $��94��6�   $��95��6�   $
 Hand��6�   ��5.      �� 5/      $
 Icons/Orders_Icon.png��6   51      �� 52   
   -   5        $ Btn_Clients��52      #��[  6'   $�� ��6Q   $
��Left=�6\   $��258,372,0,0q�6w   $	��Top=�6�   $��94��6�   $��95��6�   $
 Hand��6�   ��53      �� 54      $
 Icons/Clients_Icon.png��6   56      �� 57   
   -   5        $��Btn_Reports��57      #��[  6$   $�� ��6N   $
��Left=�6Y   $��464,372,0,0q�6t   $	��Top=�6�   $��94��6�   $��95��6�   $
 Hand��6�   ��58      �� 59      $
 Icons/Reports_Icon.png��6   5;      �� 5<   
   -   5        $��	Btn_Users��5<      #��[  6"   $�� ��6L   $
��Left=�6W   $��656,372,0,0q�6r   $	��Top=�6�   $��94��6�   $��95��6�   $
 Hand��6�   ��5=      �� 5>      $
 Icons/Users_Icon.png��6   5@      �� 5A   
   $��Products��6   $
��Left=�6#   $��275,315,0,0q�6>   $	��Top=�6S   �� 5B   
   $��Assets and Liabilities��6   $
��Left=�61   $��464,315,0,0q�6L   $	��Top=�6a   �� 5C   
   $��Orders��6   $
��Left=�6!   $��683,315,0,0q�6<   $	��Top=�6Q   �� 5D   
   $��Clients��6   $
��Left=�6"   $��286,472,0,0q�6=   $	��Top=�6R   �� 5E   
   $��Reports��6   $
��Left=�6"   $��485,472,0,0q�6=   $	��Top=�6R   �� 5F   
   $��Users��6   $
��Left=�6    $��683,472,0,0q�6;   $	��Top=�6P   5H      5I      