   M S B A M L   `   `   `  ����E  ADeliveries, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Deliveries
Deliveries  5   	   3clr-namespace:Deliveries.ModelDeliveries.Model  5   	       Deliveries.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Deliveries     5   	   0Modelclr-namespace:Deliveries.Model     5   	     � Title$!  Приём поставок��5	   	   $	��350��6    $	��800��6-    � DataContext 69   ��  �� RelativeSource �� *Self+.��5
      � -   5         �Name$
 grid��5
       � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��90 �6   .+�5   
   �� -   5        $��Отчеты��5      $
��Left=�6"   $��10,0,0,0q�6=   $��Center=�6O   $	��115��6j   6v   �� 5   
   -   5         ��Name$ cbSupply��5      $
��Left=�6%   $��	10,28,0,0q�6@   $��1��6S   $	��Top=�6`   $	��205��6x    J� RenderTransformOrigin$ 0.503,0.677&�6�   $��30��6�   ��5      �� *	Suppliers+ �� SelectedItem 65   �� *SelectedSupplier+��5      �� 5      .R�5      �� ��6    �� *SupplierName+5      5      �� 5   
   $��Поставщик��6   $
��Left=�6$   $��10,2,0,0q�6?   $��1��6Q   $	��Top=�6^   $	��205��6v   �� 5   
   $��Продукт��6   $
��Left=�6"   $��	272,2,0,0q�6=   $��1��6P   $	��Top=�6]   $	��154��6u   �� 5   
   -   5        $ 	cbProduct��5      $
��Left=�6&   $��
272,28,0,0q�6A   $��1��6U   $	��Top=�6b   $	��154��6z   $��30��6�   ��5      �� *
Products+ 64   �� *SelectedProducts+��5      �� 5      .R�5      �� ��6    �� *ProductName+5      5!      �� 5"   
   -   5         ��Name$ tbName��5"      $
��Left=�6"   $��
468,28,0,0q�6=   $��1��6Q   	 �� TextWrapping$
	 Wrap=�6^   $��0��6r   $	��Top=�6{   $	��144��6�   $��30��6�   5#   4   �� 5$   
   $ ��Количество(кг)��6   $
��Left=�6)   $��	468,2,0,0q�6D   $��1��6W   $	��Top=�6d   $ 0.579,0.592&�6|   $	��144��6�   �� 5%   
   -   5        $(��"Ещё один поставщик��5%      $
��Left=�6.   $��	145,0,0,0q�6I   $��Center=�6\   $��20��6w   $	��139��6�   6�   �� 5&   
   -   5        $2��,Очистить список приёмки��5&      $
��Left=�63   $��	309,0,0,0q�6N   $��Center=�6a   
 � ToolTip$[
 UНажать если вы случайно ввели не нужные данные��5'      $	��159��6J   6V   �� 5(   
   -   5        $0��*Завершить приём товара��5(      $
��Left=�62   $��	486,0,0,0q�6M   $��Center=�6`   $	��163��6{   6�   5)      5*      