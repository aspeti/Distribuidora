   M S B A M L   `   `   `  ����H  DDistribuidora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DistribuidoraDistribuidora  5   	       Distribuidora.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Distribuidora     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ 
MainWindow��5   	   $	��550��6   $	��725��6)    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K    � WindowStyle$
 None=�6p    � WindowState$ 	Maximized=�6�    � 	Resources 5        MenuCollapse �� TargetProperty	 �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame
 O� KeyTime O� Value  MenuOpen��%�  &	       &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $	 GridMenu��6a   .\�5        $
 0��6'   $	 200Q�63     5      $
 	0:0:0:0.5��6'   $ 35Q�6;   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $	 GridMenu��6a   .\�5        $
 0��6'   $ 35Q�63     5      $
 	0:0:0:0.5��6'   $	 200Q�6;   5      5       5"       � Triggers 5#   
   :� 5$       :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ btnCollapseMenu��6:   .[�5%      �� #��[ 6"   5&      :� 5'      $ ButtonBase.Click��6   $ btnOpenMenu��6:   .[�5(      �� #��[ 6"   5)      .��5,      � ���#C1BDBA.+�5.   
   � -   5         �Name$ GridMain��5.      $��
200 70 0 0q�6!   $
��Auto��65   $
��Auto��6B   50      � 52   
   ���#3F51B5$��70��6$   $	��Top=�60   .+�53      �� $#��Bienvenido a la Distribuidora��6   
�������$��18(�6P   $
��Bold"�6^   $��Center=�6p   $��Center=�6�   �� 54      $��Center=�6   $��Right=�64    �� Orientation$ 
Horizontal=�6P   .+�55      �� $��Ususario��6   
�������$��Center=�6?   '  !MaterialDesignThemes.Wpf.PopupBox  56      
�������$��Center=�6=      PopupContent. 57      �� $	��180��6!   .+�58      �� $��Datos de la cuenta��6!   �� 59      $��	Acerca de��6!   �� 5:      �� 5;      -   5         ��Name$ btnSalir��5;   !   $��Salir��63   6C   5=      5>      5?      5A      � 5B   
   -   5        $ GridMenu��5B      ���#36404e$	��200��66   $
��Left=�6B   .+�5C      �� .+�5D      � 
�������$	��180��6*   $
��auto��67   .+�5E      �� -   5        $ btnCollapseMenu��5E      $	��Top=�66   $��Right=�6N   $��30��6j   $��30��6u   $��0q�6�   $y�Visible=�6�   ��6�   Z� ��6�   Z� .��5F      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�62   
����  �$��25��6U   $��25��6a   5G      �� 5H      -   5        $ btnOpenMenu��5H      $	��Top=�62   $��Right=�6J   $��30��6f   $��30��6q   $��0q�6�   $y�Hidden=�6�   ��6}   Z� ��6�   Z� .��5I        $
 Menu=�62   
����  �$��25��6P   $��25��6\   5J      �� 5K      -   5         ��Name$ imgJogo��5K      $	��140��6.   $	��100��6:   $.��(/Distribuidora;component/img/faforal.png��6G   5L      �� 5M      -   5         ��Name$ lvwMenu��5M      
�������$��Hidden=�6?   .@�5N      �� -   5         ��Name$ itemHome��5N   #   .��5O      �� $ 
Horizontal=�6%   .+�5P        $
 Home=�66   $��27��6B   $��27��6N   $��0 0 10 0q�6Y   $
��Left=�6k   $��Center=�6�   �� 5Q      $��Inicio��6(   $��13(�66   $
��Bold"�6D   $��Center=�6V   5R      5S      �� 5U      -	   5        $ itemCategoria��5U   #   .��5V      �� $ 
Horizontal=�6%   .+�5W        $ Database=�66   $��27��6F   $��27��6R   $��0 0 10 0q�6]   $
��Left=�6o   $��Center=�6�   �� 5X      $��Categorías��6(   $��13(�6:   $
��Bold"�6H   $��Center=�6Z   5Y      5Z      �� 5\      -
   5        $ itemProductos��5\   #   .��5]      �� $ 
Horizontal=�6%   .+�5^        $ Store=�66   $��27��6C   $��27��6O   $��0 0 10 0q�6Z   $
��Left=�6l   $��Center=�6�   �� 5_      $��	Productos��6(   $��13(�69   $
��Bold"�6G   $��Center=�6Y   5`      5a      �� 5c      -   5        $ itemPedidos��5c   #   .��5d      �� $ 
Horizontal=�6%   .+�5e        $ Money=�66   $��27��6C   $��27��6O   $��0 0 10 0q�6Z   $
��Left=�6l   $��Center=�6�   �� 5f      $��Pedidos��6(   $��13(�67   $
��Bold"�6E   $��Center=�6W   5g      5h      �� 5j      -   5        $ itemClientes��5j   #   .��5k      �� $ 
Horizontal=�6%   .+�5l        $ UserBox=�66   $��27��6E   $��27��6Q   $��0 0 10 0q�6\   $
��Left=�6n   $��Center=�6�   �� 5m      $��Clientes��6(   $��13(�68   $
��Bold"�6F   $��Center=�6X   5n      5o      �� 5p      -   5        $ itemUsuarios��5p   #   .��5q      �� $ 
Horizontal=�6%   .+�5r        $ Users=�66   $��27��6C   $��27��6O   $��0 0 10 0q�6Z   $
��Left=�6l   $��Center=�6�   �� 5s      $��Usuarios��6(   $��13(�68   $
��Bold"�6F   $��Center=�6X   5t      5u      5w      5x      5y      5z      5{      