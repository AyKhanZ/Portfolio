   M S B A M L   `   `   `  ����K  GUserEcommerceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:UserEcommerceApp.ViewUserEcommerceApp.View  5      G(clr-namespace:UserEcommerceApp.ViewModelUserEcommerceApp.ViewModel  5
      $    UserEcommerceApp.View.CardView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:UserEcommerceApp.View     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:mD1http://materialdesigninxaml.net/winfx/xaml/themes  5	      1vm(clr-namespace:UserEcommerceApp.ViewModel  5
      -   5        $��
MyCardView��5         MaterialDesignBody#���   5      $��Regular"�5      $��14(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      
������   MaterialDesignFont#���  5      $	��650��5      $	��920��6   .��5      ��  �� CornerRadius$ 10��6   ._�5   
   �  � RowDefinitions 5      �� 5      $��5 �6    �� 5      $��0.07* �6    �� 5      .+�5      �� $��1��6   $
��Left=�6%   $	��Top=�6@   $��MY CARD��5      
�������$��14(�65   $��10,0,0,0q�6C   �� 5!      $��2��6   $	��400��6"   $	��700��6/   $ 10��6;   $��Center=�6M   ���	#FF0E1646$��Center=�5"   ,    J� Effect 5#      3  -System.Windows.Media.Effects.DropShadowEffect  5$         
BlurRadius$ 15Q�6'      	Direction$ 0Q�67      RenderingBias$ Quality=�6E      ShadowDepth$ 1Q�6]   	   Color$	 Black��6m   ._�5'      � $	��350��6   $	��600��6%   $��Center=�61    5(      �� 5)      $
��0.8* �6(   �� 5*      $
��1.5* �6(   �� 5,      $
��2.3* �6(   �� 5.      $��2* �6(   .+�51      �� $��0��6    $��16 digit code:��6-   $
��Left=�52      $��Bottom=�67   
�������$��18(�53   /   �� 54      $��1��6   $��18(�6+   
 �� 	MaxLength$
 16��69   
�������
������  �� 
CaretBrush
 �����
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$  0000  0000  0000  0000��56      $��35��57      $	��250��6*   $
��Left=�66   $��Center=�59      ��58      �� *UserPayment.SixteenDigitCode+59      � 5;      $��2��6    5=      �� 5>      $
��0.7* �6,   �� 5?      $��1* �6,    � ColumnDefinitions 5B      �� 5C      �� 5D      .+�5G      �� $��0��6$   $��0��61   $
��EXP:��6A   $
��Left=�5H      $��Bottom=�67   
�������$��18(�5I   /   �� 5K      $��1��6"   $��0��6/   $��18(�6?   $
 5��6M   
�������
������ 
 �����
�������$  00 / 00��5M      $��35��5N      $��80��6*   $
��Left=�65   $��Center=�5P      ��5O      �� *UserPayment.EXP+5P      �� 5S      $��1��6$   $��0��64   $
��CVV:��6A   $
��Left=�5T      $��Bottom=�67   
�������$��18(�5U   /   �� 5V      $��1��6"   $��1��62   $��18(�6?   $
 3��6M   
�������
������ 
 �����
�������$
  000��5X      $��35��5Y      $��50��6*   $
��Left=�65   $��Center=�5[      ��5Z      �� *UserPayment.CVV+ �� FallbackValue$	 000��5[      5_      � 5b      $��5��6   $��
30 0 30 0 q�6(    5c      �� 5d      �� 5e      $��5* �6/   .+�5h      �� $��0��6!   $��50��61   $��70��6=   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5i   !   ���	#FF2C6AFF$��Center=�5j   A   ��6!   �� *BackCommand+.��5k      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowBack=�6*   
�������$��60��6N   $��50��6Y   $��Center=�6e   $��Center=�6�    5l        5m   "   $ 15Q�63   $ 0Q�6C   $ Quality=�5n   ;   $ 1Q�5o   ;   $	 Black��6K   5q      �� 5s      $��Add Card��6!   $��1��64   $��Center=�5t      $��Center=�6:   $��28(�5u      $	��200��6+   $��50��67   
�������$ 15��5v      ���	#FF2C6AFF��5w      �� *AddCardCommand+ 5x        5y   "   $ 15Q�63   $ 0Q�6C   $ Quality=�5z   ;   $ 1Q�5{   ;   $	 Black��6K   5}      5~      5      5�      5�      5�      5�      