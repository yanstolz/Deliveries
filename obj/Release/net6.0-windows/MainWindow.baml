   M S B A M L   `   `   `  ���� E  ADeliveries, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Deliveries
Deliveries  3clr-namespace:Deliveries.ModelDeliveries.Model      Deliveries.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Deliveries     0Modelclr-namespace:Deliveries.Model       � Title$!  Приём поставок��$	��350��$	��800�� � DataContext ��  �� RelativeSource �� *Self+.��� -    �Name$
 grid�� � RowDefinitions �� $��60 ��� $��90 �.+��� -   $��Отчеты��$
��Left=�$��10,0,0,0q�$��Center=�$	��115���� -    ��Name$ cbSupply��$
��Left=�$��	10,28,0,0q�$��1��$	��Top=�$	��205�� J� RenderTransformOrigin$ 0.503,0.677&�$��30������ *	Suppliers+ �� SelectedItem �� *SelectedSupplier+���� .R��� ���� *SupplierName+�� $��Поставщик��$
��Left=�$��10,2,0,0q�$��1��$	��Top=�$	��205���� $��Продукт��$
��Left=�$��	272,2,0,0q�$��1��$	��Top=�$	��154���� -   $ 	cbProduct��$
��Left=�$��
272,28,0,0q�$��1��$	��Top=�$	��154��$��30������ *
Products+ �� *SelectedProducts+���� .R��� ���� *ProductName+�� -    ��Name$ tbName��$
��Left=�$��
468,28,0,0q�$��1��	 �� TextWrapping$
	 Wrap=�$��0��$	��Top=�$	��144��$��30���� $ ��Количество(кг)��$
��Left=�$��	468,2,0,0q�$��1��$	��Top=�$ 0.579,0.592&�$	��144���� -   $(��"Ещё один поставщик��$
��Left=�$��	145,0,0,0q�$��Center=�$��20��$	��139���� -   $2��,Очистить список приёмки��$
��Left=�$��	309,0,0,0q�$��Center=�
 � ToolTip$[
 UНажать если вы случайно ввели не нужные данные��$	��159���� -   $0��*Завершить приём товара��$
��Left=�$��	486,0,0,0q�$��Center=�$	��163��