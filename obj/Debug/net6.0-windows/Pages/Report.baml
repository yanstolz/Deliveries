   M S B A M L   `   `   `  ����E  ADeliveries, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Deliveries.PagesDeliveries.Pages  5   	       Deliveries.Pages.Report   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Deliveries.Pages     5   	     � Title$  Report��5   	   $	��450��6   $	��800��6%   .��5	      �  � RowDefinitions 5
   
   �� 5      $��60 �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ deliverySummaryGrid��5         AutoGenerateColumns$ False��60   $��1��6L      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Поставщик��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *SupplierName+  5      $ Продукт��6%    66   �� *ProductName+  5      $ 
Масса��6%    64   �� *Weight+  5      $ 
Сумма��6%    64   �� *Result+5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
dpDateFrom��5      $
��Left=�6)   $��25,0,0,0q�6D   $��Center=�6V     5   
   -   5        $ dpDateTo��5      $
��Left=�6'   $��	155,0,0,0q�6B   $��Center=�6U   �� 5   
   -   5         ��Name$ bSearch��5   !   $��
Поиск��6   $
��Left=�62   $��	273,0,0,0q�6M   $��Center=�6`   $��24��6{   $��85��6�   6�   5      5      