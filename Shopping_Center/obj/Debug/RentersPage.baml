   M S B A M L   `   `   `  ����J  FShopping_Center, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Shopping_CenterShopping_Center  5      !    Shopping_Center.RentersPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Shopping_Center     5      -   5          N� Title$  RentersPage��5	      .��5      � ���#191f34 � RowDefinitions 5   
   �� 5      $
��108* �6   �� 5      $	��95* �6   �� 5      $	��97* �6   �� 5      $
��105* �6   �� 5      $	��44* �6    � ColumnDefinitions 5   
   �� 5      $
��325* �6   �� 5      $��3* �6   �� 5      $	��72* �6   .+�5   
   �� -   5        $��BtnAdd��5   D   $+��%Добавить арендатора��6   $��Center=�6R   $��2��6o   $	��130��6   $��15(�6�   $��
4,3.8,10,2q�6�   $��2��6�   �� 5   
   -   5        $��	BtnDelete��5   F   $)��#Удалить арендатора��6   $��Center=�6W   $��2��6t   $	��130��6�   $��15(�6�   $��4,3,10,10.6q�6�   $��3��6�   � 5   
   ���#464c61$��2��6$   $��
0,0,6,-0.4q�68   $��5��6L   6_   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DGRenters��5         AutoGenerateColumns .     
IsReadOnly . $��2��6T   $��
0,0,6,-0.4q�6h   $��5��6|      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$! Код арендатора��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6[   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *	id_renter+6h     5      $+ %Название арендатора��6%   $	 120 6b   	 6B   �� *Name_renter+6p     5      $ Телефон��6%   $	 100 6P   	 66   �� *Phone+6^     5       $ 
Адрес��6%   $	 120 6P   	 64   �� *	Address+6^     5!      $" Доп. информация��6%   $	 120 6b   	 6>   �� *Additional_info+6p   4  .System.Windows.Controls.DataGridTemplateColumn  5"      $
 auto 6)   
   CellTemplate
 5#      �� 5$      .R�5%      �� $��BtnEdit��6S   -   5        $ ��Редактировать��5%   %   6d   5&      5(      5*      5+      5-      