   M S B A M L   `   `   `  ����D  @NeNavredi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:NeNavredi.PagesNeNavredi.Pages  5   	   3clr-namespace:NeNavredi.ModelsNeNavredi.Models  5   	       NeNavredi.Pages.PdfOrder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:NeNavredi.Pages     5   	   1Modelsclr-namespace:NeNavredi.Models     5   	   -   5          � Title$  PdfOrder��5	   	   $	��450��6   $	��800��6'   $	��450��63   $	��800��6C    � 	Resources 5
         orderViewSource��%   &	        �� 5   
   6   5      .��5      � .+�5   
   � -   5         �Name$ grid1��5      {�.   � DataContext# [  60   $��Center=�6_   $��Center=�6|    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5"      �� $��0��6   $��Client :��6$   $
��Left=�67   $��3q�6R   $��0��6]   $��Center=�6j   �� 5#      -   5         ��Name$ clientIdTextBox��5#      $��1��6/   $
��Left=�6?   $	��NaN��6Z   $��3q�6g   $��0��6r   $��Center=�6�   $	��120��6�   ��6   �� *Client.Name+ �� Mode$ OneWay=�6�   �� 5$      $��0��6   $��Code:��6$   $
��Left=�64   $��3q�6O   $��1��6Z   $��Center=�6g   �� 5%      -   5        $ codeTextBox��5%      $��1��6+   $
��Left=�6;   $	��NaN��6V   $��3q�6c   $��1��6n   $��Center=�6�   $	��120��6�   ��6{   �� *Code+$ TwoWay=� �� NotifyOnValidationError . 	 �� ValidatesOnExceptions	 . 6�   �� 5&      $��0��6   $��Date:��6$   $
��Left=�64   $��3q�6O   $��2��6Z   $��Center=�6g   �� 5'      -   5        $ dateTextBox��5'      $��1��6+   $
��Left=�6;   $	��NaN��6V   $��3q�6c   $��2��6n   $��Center=�6�   $	��120��6�   ��6{   �� *Date+$ TwoWay=� . 	 . 6�   �� 5(      $��0��6   $	��Id:��6$   $
��Left=�62   $��3q�6M   $��3��6X   $��Center=�6e   �� 5)      -   5        $ 	idTextBox��5)      $��1��6)   $
��Left=�69   $	��NaN��6T   $��3q�6a   $��3��6l   $��Center=�6�   $	��120��6�   ��6y   �� *Id+$ TwoWay=� . 	 . 6�   �� 5*      $��0��6   $��Is Deleted:��6$   $
��Left=�6:   $��3q�6U   $��4��6`   $��Center=�6m   �� 5+      -   5        
 ��Name$
 isDeletedCheckBox��5+      $��1��62   $�� ��6B   $
��Left=�6M   $��3q�6�   $��4��6�   $��Center=�6�    d� 	IsChecked 6h   �� *	IsDeleted+$ TwoWay=� . 	 . 6�   �� 5,      $��0��6   $��
Status Id:��6$   $
��Left=�69   $��3q�6T   $��5��6_   $��Center=�6l   �� 5-      -   5        $ statusIdTextBox��5-      $��1��6/   $
��Left=�6?   $	��NaN��6Z   $��3q�6g   $��5��6r   $��Center=�6�   $	��120��6�   ��6   �� *
StatusId+$ TwoWay=� . 	 . 6�   �� 5.      $��0��6   $��Time:��6$   $
��Left=�64   $��3q�6O   $��6��6Z   $��Center=�6g   �� 5/      -	   5        $ timeTextBox��5/      $��1��6+   $
��Left=�6;   $	��NaN��6V   $��3q�6c   $��6��6n   $��Center=�6�   $	��120��6�   ��6{   �� *Time+$ TwoWay=� . 	 . 6�   &   System.Windows.Controls.DataGrid  50      -
   5          Name$ 	ServiceDg��50         AutoGenerateColumns .     
IsReadOnly . $	��100��6}   $��2��6�   $��7��6�   ��6F   �� *OrderService+   Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Service.Name+  53      $ Цена��6)    67   �� *Service.Price+56      �� 58      $��0��6   $��Organisation:��6$   $
��Left=�6<   $��3q�6W   $��8��6b   $��Center=�6o   �� 59      $��1��6   $
��Left=�6&   $	��NaN��6A   $��3q�6N   $��8��6Y   $��Center=�6�   $	��120��6�   ��6f   �� *Client.Organisation.Name+$ TwoWay=� . 	 . 6�   5:      5<      5=      