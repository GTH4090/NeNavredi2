   M S B A M L   `   `   `  ����D  @NeNavredi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:NeNavredi	NeNavredi  5   	       NeNavredi.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:NeNavredi     5   	   -   5          � Title$  	NeNavredi��5   	   $	��450��6   $	��800��6+   $	��450��6:   $	��800��6G   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ BackBtn��5      $��
Назад��6"   $
��Left=�62   6M   �� 5   
   -   5        $��TitleLb��5      $
��Auto��6   �� 5   
   -   5        $ ExitBtn��5      $��
Выход��6"   $��Right=�6H    � 5   
   -   5          �Name$ 	MainFrame��5        � NavigationUIVisibility$ Hidden=�6#   $��1��6C     � Source$ /Pages/Auth.xaml?�6P   6j   5      5      