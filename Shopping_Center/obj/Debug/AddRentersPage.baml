   M S B A M L   `   `   `  ����J  FShopping_Center, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Shopping_CenterShopping_Center  5      $    Shopping_Center.AddRentersPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Shopping_Center     5        N� Title$  AddRentersPage��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��60* �6   �� 5      $
��200* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $!��Код арендатора��6   $��0��6*   $��Center=�67   6T   �� 5   
   $+��%Название арендатора��6   $��1��6/   $��Center=�6<   6Y   �� 5   
   $��Телефон��6   $��2��6#   $��Center=�60   6M   �� 5   
   $��
Адрес��6   $��3��6!   $��Center=�6.   6K   �� 5   
   $"��Доп. информация��6   $��4��6+   $��Center=�68   6U   �� 5   
    �� 	MaxLength$ 30��6-   $��0��6<   $��1��6I   $	��100��6Y   $��30��6e   $
��Left=�6q   ��6   �� *	id_renter+6�   �� 5   
   $��1��6/   $��1��6<   $	��100��6L   $��30��6X   $
��Left=�6d   ��6   �� *Name_renter+6�   �� 5    
   $��2��6)   $��1��66   $	��100��6F   $��30��6R   $
��Left=�6^   ��6   �� *Phone+6{   �� 5!   
   $ 30��6+   $��3��6:   $��1��6G   $	��600��6W   $��30��6c   $
��Left=�6o   ��6   �� *	Address+6�   �� 5"   
   $ 7��63   $��4��6A   $��1��6N   $	��600��6^   $��30��6j   $
��Left=�6v   ��6   �� *Additional_info+6�   �� 5$   
   -   5        $��BtnSave��5$   ;   $��Сохранить��6   $��1��6J   $��Right=�6Z   $��5��6v   6�   �� 5%   
   -   5        $��BtnSaveEdit��5%   Q   $;��5Сохранить отредактированное��6   $��1��6d   $��Right=�6t   $��9��6�   $��0,0.2,90,-0.4q�6�   $	��184��6�   6�   5&      5'      