   M S B A M L   `   `   `  ����J  FShopping_Center, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Shopping_CenterShopping_Center  5      #    Shopping_Center.PavilionsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Shopping_Center     5      -   5          N� Title$  PavilionsPage��5	      .��5      � ���#191f34 � RowDefinitions 5   
   �� 5      $	��53* �6   �� 5      $	��37* �6   �� 5      $	��60* �6    � ColumnDefinitions 5   
   �� 5      $
��130* �6   �� 5      �� 5      $	��29* �6   .+�5   
   � ���#464c61$��2��6$   $��0,0,4.8,-0.4q�68   $��3��6N   6a   �� 5   
   -   5        $��BtnAdd��5   -   $'��!Добавить павильон��6   $��Center=�6P   $��2��6m   $	��130��6}   $��13(�6�   $��4.8,87.6,10,113.6q�6�   $��1��6�   $��2��6�   �� 5   
   -   5        $��	BtnDelete��5   ,   $%��Удалить павильон��6   $��Center=�6U   $��2��6r   $	��130��6�   $��14(�6�   $��4.8,80.4,10,9.6q�6�   $��2��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGPavilions��5         AutoGenerateColumns .     
IsReadOnly . $��2��6V   $��0,0,4.8,-0.4q�6j   $��3��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$# Номер павильона��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6b   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6>   �� *Number_pavilion+6o     5      $ Код ТЦ��6%   $	 100 6\   	 65   �� *id_shopping_center+6j     5      $ Этаж��6%   $ 50 6M   	 63   �� *Floor+6Z     5      $ Статус��6%   $ 50 6P   	 65   �� *Status+6]     5      $ Площадь��6%   $ 50 6O   	 66   �� *Area+6\     5       $" Цена за кв. метр��6%   $ 50 6f   	 6?   �� *Price_square_meter+6s     5!      $9 3Коэфф. добавочной стоимости��6%   $ 50 6n   	 6J   �� *Coeff_add_price+6{   4  .System.Windows.Controls.DataGridTemplateColumn  5"      $
 auto 6)   
   CellTemplate
 5#      �� 5$      .R�5%      �� $��BtnEdit��6S   -   5        $ ��Редактировать��5%   %   6d   5&      5(      5*      �� 5+   
   $'��!Фильтр по статусу:��6   
�������$��9.8,76,10,56.4q�6A   $��2��6Y   �� 5,   
   -   5         ��Name$ ComboStatus��5,   D   $��2��6Y   $
��Left=�6i   $��27��6�   $��9.8,102,0,0q�6�   $	��Top=�6�   $	��125��6�   �� 5-   
   $#��Фильтр по этажу:��6   
�������$��9.8,0,10,131.4q�6?   $��2��6W   �� 5.   
   -   5        $��
ComboFloor��5.      $��2��6T   $
��Left=�6d   $��24��6   $��
9.8,27,0,0q�6�    �� Text$ TextBox��6�   $	��Top=�6�   $	��125��6�   �� 5/   
   $%��Поиск по площади:��6   
�������$��9.8,158,10,90.6q�6@   $��2��6Y   $��2��6i   �� 50   
   -   5        $��
AreaTextTo��50      $��2��6I   $
��Left=�6Y   $��21��6t   $��9.8,46.6,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��125��6�   $��1��6�   �� 51   
   -	   5        $��AreaTextFrom��51      $��2��6K   $
��Left=�6[   $��21��6v   $��9.8,20.6,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��125��6�   $��1��6�   52      53      