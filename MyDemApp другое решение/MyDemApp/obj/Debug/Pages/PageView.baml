   M S B A M L   `   `   `  ����C  ?MyDemApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MyDemApp.PagesMyDemApp.Pages  5          MyDemApp.Pages.PageView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:MyDemApp.Pages     5        N� Title$  PageView��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��5      .+�5      �� $6��0Фильтр по фамилии клиента:��6   $��5q�5      �� 5      $	��200��5      $��5q�5      ��5      �� *
FilterText+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5      -   5         ��Name$	 Add��5      $	��100��5      $��5q�5      $��Добавить��5      5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgListPerson��5         AutoGenerateColumns .  $��2��5          Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 5$   %   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5#   %   �� *Id+5$   %     5%      $# Дата добавления��6%   $	 2* 5'   %   
 5&   %   �� *Date+5'   %     5(      $ Оборудование��6%   $	 2* 5*   %   
 5)   %   �� *	Equipment+5*   %     5+      $' !Тип неисправности��6%   $	 1* 5-   %   
 5,   %   �� *Malfunction_type+5-   %     5.      $' !Описание проблемы��6%   $	 2* 50   %   
 5/   %   �� *Problem_desc+50   %     51      $ Клиент��6%   $	 2* 53   %   
 52   %   �� *Client+53   %     54      $ Статус��6%   $	 1* 56   %   
 55   %   �� *Status+56   %   58      59      5:      