   M S B A M L   `   `   `  ����D  @NeNavredi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:NeNavredi.PagesNeNavredi.Pages  5   	   3clr-namespace:NeNavredi.ModelsNeNavredi.Models  5   	        NeNavredi.Pages.ClientEdit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:NeNavredi.Pages     5   	   1Modelsclr-namespace:NeNavredi.Models     5   	   -   5          � Title$  
ClientEdit��5	   	   $	��450��6   $	��800��6)   $	��450��66   $	��800��6F    � 	Resources 5
         clientViewSource��%   &	        �� 5   
   6   5      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   $��Center=�6I   .+�5      � -   5         �Name$ grid1��5       � DataContext# [  6"    � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $
��Auto �6'    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��0��6   $��Birth Date:��6(   $
��Left=�6>   $��3q�6Y   $��0��6d   $��Center=�6q   (  "System.Windows.Controls.DatePicker  5       -   5          Name$ birthDateDatePicker��5       $��1��6:   $
��Left=�6J   $��3q�6e   $��0��6p   $��Center=�6�      SelectedDate 6}   �� *	BirthDate+	 �� Mode$	 TwoWay=�
 �� NotifyOnValidationError
 .  �� ValidatesOnExceptions . 6�   �� 5!      $��0��6   $��Email:��6(   $
��Left=�69   $��3q�6T   $��1��6_   $��Center=�6l   �� 5"      -   5         ��Name$ emailTextBox��5"      $��1��60   $
��Left=�6@   $	��NaN��6[   $��3q�6h   $��1��6s   $��Center=�6�   $	��120��6�   ��6�   �� *Email+$	 TwoWay=�
 .  . 6�   �� 5#      $��0��6   $��First Name:��6(   $
��Left=�6>   $��3q�6Y   $��2��6d   $��Center=�6q   �� 5$      -   5        $ firstNameTextBox��5$      $��1��64   $
��Left=�6D   $	��NaN��6_   $��3q�6l   $��2��6w   $��Center=�6�   $	��120��6  ��6�   �� *	FirstName+$	 TwoWay=�
 .  . 6  �� 5%      $��0��6   $��
Last Name:��6(   $
��Left=�6=   $��3q�6X   $��3��6c   $��Center=�6p   �� 5&      -   5        $ lastNameTextBox��5&      $��1��63   $
��Left=�6C   $	��NaN��6^   $��3q�6k   $��3��6v   $��Center=�6�   $	��120��6�   ��6�   �� *
LastName+$	 TwoWay=�
 .  . 6�   �� 5'      $��0��6   $��Organisation Id:��6(   $
��Left=�6C   $��3q�6^   $��4��6i   $��Center=�6v   �� 5(      -   5         ��Name$ organisationIdCbx��5(      $��1��66   $
��Left=�6F   $	��NaN��6a   $��3q�6n   $��4��6y    �� DisplayMemberPath$
 Name��6�   $��Center=�6�   $	��120��6�    �� SelectedItem 6�   �� *Organisation+6�   �� 5)      $��0��6   $��Passport Number:��6(   $
��Left=�6C   $��3q�6^   $��5��6i   $��Center=�6v   �� 5*      -   5        $ passportNumberTextBox��5*      $��1��69   $
��Left=�6I   $	��NaN��6d   $��3q�6q   $��5��6|   $��Center=�6�   $	��120��6  ��6�   �� *PassportNumber+$	 TwoWay=�
 .  . 6  �� 5+      $��0��6   $��Passport Serial:��6(   $
��Left=�6C   $��3q�6^   $��6��6i   $��Center=�6v   �� 5,      -	   5        $ passportSerialTextBox��5,      $��1��69   $
��Left=�6I   $	��NaN��6d   $��3q�6q   $��6��6|   $��Center=�6�   $	��120��6  ��6�   �� *PassportSerial+$	 TwoWay=�
 .  . 6  �� 5-      $��0��6   $��Patronomic:��6(   $
��Left=�6>   $��3q�6Y   $��7��6d   $��Center=�6q   �� 5.      -
   5        $ patronomicTextBox��5.      $��1��65   $
��Left=�6E   $	��NaN��6`   $��3q�6m   $��7��6x   $��Center=�6�   $	��120��6  ��6�   �� *
Patronomic+$	 TwoWay=�
 .  . 6  �� 5/      $��0��6   $��Phone:��6(   $
��Left=�69   $��3q�6T   $��8��6_   $��Center=�6l   �� 50      -   5        $ phoneTextBox��50      $��1��60   $
��Left=�6@   $	��NaN��6[   $��3q�6h   $��8��6s   $��Center=�6�   $	��120��6�   ��6�   �� *Phone+$	 TwoWay=�
 .  . 6�   51      �� 52      -   5         ��Name$ OkBtn��52      $
��Ок��6$   61   53      57      58      