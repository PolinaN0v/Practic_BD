   M S B A M L   `   `   `  ����J  FShopping_Center, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Shopping_CenterShopping_Center  5      )    #Shopping_Center.ShoppingCentersPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Shopping_Center     5      -   5          N� Title$  ShoppingCentersPage��5	      .��5      � ���#191f34 � RowDefinitions 5   
   �� 5      $
��108* �6   �� 5      $	��95* �6   �� 5      $	��97* �6   �� 5      $
��105* �6   �� 5      $	��44* �6    � ColumnDefinitions 5   
   �� 5      $
��325* �6   �� 5      $��3* �6   �� 5      $	��72* �6   .+�5   
   �� -   5        $��BtnGoPavilions��5   -   $'��!Список павильонов��6   $��Center=�6`   $��2��6}   $	��130��6�   $��13(�6�   $��
4,5,10,1.2q�6�   $��1��6�   �� 5   
   -   5        $��BtnAdd��5   '   $��Добавить ТЦ��6   $��Center=�6J   $��2��6g   $	��130��6w   $��15(�6�   $��
4,3.8,10,2q�6�   $��2��6�   �� 5   
   -   5        $��	BtnDelete��5   &   $��Удалить ТЦ��6   $��Center=�6O   $��2��6l   $	��130��6|   $��15(�6�   $��4,3,10,10.6q�6�   $��3��6�   � 5   
   ���#464c61$��2��6$   $��
0,0,6,-0.4q�68   $��5��6L   6_   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGShopCenter��5         AutoGenerateColumns .     
IsReadOnly . $��2��6W   $��
0,0,6,-0.4q�6k   $��5��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Код ТЦ��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6\   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   �� *id_shopping_center+6i     5       $ Название ТЦ��6%   $	 100 6c   	 6:   �� *Name_shopping_center+6q     5!      $ Статус��6%   $	 100 6P   	 65   �� *Status+6^     5"      $&  Кол-во павильонов��6%   $	 120 6g   	 6@   �� *Quantity_pavilions+6u     5#      $ 
Город��6%   $	 100 6M   	 64   �� *City+6[     5$      $ Цена��6%   $	 100 6M   	 63   �� *Price+6[     5%      $9 3Коэфф. добавочной стоимости��6%   $	 120 6n   	 6J   �� *Coeff_add_price+6|     5&      $ Этажность��6%   $ 70 6Z   	 68   �� *Number_floors+6g   4  .System.Windows.Controls.DataGridTemplateColumn  5(      $ Фото��6)   
   CellTemplate
 5)      �� 5*      .R�5+      �� $	��150��6=   ��6$   �� *Photo+6=   5,      5.        50      $
 auto 6)   
 51      �� 52      .R�53      �� $��BtnEdit��6=   -   5        $ ��Редактировать��53   %   6d   54      56      58      �� 59   
   $'��!Фильтр по статусу:��6   
�������$��
4,20,10,68q�6A   $��2��6U   �� 5:   
   -   5         ��Name$ ComboStatus��5:      $��2��6(   $
��Left=�68   $��22��6S   $��4,40,0,0q�6_   $	��Top=�6q   $	��130��6�   6�   �� 5;   
   $%��Фильтр по городу:��6   
�������$��
4,62,10,22q�6@   $��2��6T   �� 5<   
   -   5        $ 	ComboCity��5<      $��2��6&   $
��Left=�66   $��22��6Q   $��4,86,0,0q�6]   $	��Top=�6o   $	��130��6�   6�   5=      5?      