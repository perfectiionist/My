   M S B A M L   `   `   `  ����C  ?MyDemApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MyDemAppMyDemApp  5   	       MyDemApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MyDemApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      .+�5   
   �� $��0��6   .+�5      �� $��Авторизация��6   $��Center=�5      $��50(�5      $
��Bold"�5      $	��Top=�5      5      �� 5   
   $��1��6   $	��Top=�5      .+�5      �� $��
Логин��5      $��	50 80 0 0q�5      $��25(�5      �� 5      -   5         ��Name$ TxbLogin��5      $��35��5      $	��300��5      $
��Left=�5       $��50 0 0 0q�5!      �� 5"      $��Пароль��5#      $��50 0 0 0q�5$      $��25(�5%      G� 5&      -   5         G�Name$ PsbPass��5'      $��35��5(      $	��300��5)      $
��Left=�5*      $��50 0 0 0q�5+      �� 5,      -   5         ��Name$ BtnAuth��5-      $	��200��5.      $��40��5/      $��	50 20 0 0q�50      $
��Left=�51      $��
Войти��52      $��20(�53      $
��Bold"�54      
����ح�56      57       � 58   
   -   5          �Name$ FrmMain��58      $��0��6     � NavigationUIVisibility$ 	Automatic=�59      5<      5=      5>      