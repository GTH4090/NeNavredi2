   M S B A M L   `   `   `  ����D  @NeNavredi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:NeNavredi.PagesNeNavredi.Pages  5      &     NeNavredi.Pages.OrganisationBill   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:NeNavredi.Pages     5      -   5          N� Title$%  Счёт предприятию��5	      .��5      � -   5         �Name$ MainGrid��5      .+�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   $��Center=�6I   .+�5      �� $��Предприятие��6   .��5      �� -   5         ��Name$ OrganisationCbx��5       �� DisplayMemberPath$
 Name��64   6M   5      �� 5      $&�� Период для оплаты��6   .��5      �� $ 
Horizontal=�6   .+�5      �� $��С��6   $
��Auto��6(   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ FromDp��5   !   61   �� 5      $
��по��6   $
��Auto��6)     5      -   5        $
 ToDp��5   !   6/   5      5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ 	ServiceDg��5         AutoGenerateColumns .     
IsReadOnly . $	��100��6X   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Название��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Service.Name+  5      $
 Цена��6)    67   �� *Service.Price+5      �� 5       $!��Финальная цена��6   .��5!      �� -   5        $��FinalPriceLb��5!      5"      �� 5#      -   5         ��Name$ OkBtn��5#      $
��Ок��6$   61   5$      5%      5&      