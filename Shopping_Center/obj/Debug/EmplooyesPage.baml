   M S B A M L   `   `   `  ����J  FShopping_Center, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Shopping_CenterShopping_Center  5      #    Shopping_Center.EmplooyesPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Shopping_Center     5      -   5          N� Title$  EmplooyesPage��5	      .��5      � ���#191f34 � RowDefinitions 5   
   �� 5      $
��108* �6   �� 5      $	��95* �6   �� 5      $	��97* �6   �� 5      $
��105* �6   �� 5      $	��44* �6    � ColumnDefinitions 5   
   �� 5      $
��325* �6   �� 5      $��3* �6   �� 5      $	��72* �6   .+�5   
   �� -   5        $��BtnAdd��5   D   $+��%Добавить сотрудника��6   $��Center=�6R   $��2��6o   $	��130��6   $��15(�6�   $��
4,3.8,10,2q�6�   $��2��6�   �� 5   
   -   5        $��	BtnDelete��5   F   $)��#Удалить сотрудника��6   $��Center=�6W   $��2��6t   $	��130��6�   $��15(�6�   $��4,3,10,10.6q�6�   $��3��6�   � 5   
   ���#464c61$��2��6$   $��
0,0,6,-0.4q�68   $��5��6L   6_   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGEmplooyes��5         AutoGenerateColumns .     
IsReadOnly . $��2��6V   $��
0,0,6,-0.4q�6j   $��5��6~   $	��450��6�   $��Bottom=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$! Код сотрудника��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6]   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *id_emplooye+6j     5      $ Фамилия��6%   $	 100 6R   	 66   �� *	Surname+6`     5       $ Имя��6%   $	 100 6K   	 62   �� *Name+6Y     5!      $ Отчество��6%   $	 120 6W   	 67   �� *Second_name+6e     5"      $ 
Логин��6%   $	 100 6N   	 64   �� *Login+6\     5#      $ Пароль��6%   $	 100 6R   	 65   �� *
Password+6`     5$      $ Роль��6%   $	 120 6L   	 63   �� *Role+6Z     5%      $ Телефон��6%   $ 70 6P   	 66   �� *Phone+6]     5&      $ Пол��6%   $ 50 6M   	 62   �� *Gender+6Z   4  .System.Windows.Controls.DataGridTemplateColumn  5(      $ Фото��6)   
   CellTemplate
 5)      �� 5*      .R�5+      �� $��50��6=   ��6$   �� *Photo+6=   5,      5.        50      $
 auto 6)   
 51      �� 52      .R�53      �� $��BtnEdit��6S   -   5        $ ��Редактировать��53   %   6d   54      56      58      �� 59   
   $'��!Фильтр по фамилии:��6   
�������$��
4,34,10,49q�6A   $��2��6U   �� 5:   
   -   5         ��Name$ ComboSurname��5:      $��2��6Z   $
��Left=�6j   $��29��6�   $��4,59,0,0q�6�   $	��Top=�6�   $	��130��6�   5;      5=      