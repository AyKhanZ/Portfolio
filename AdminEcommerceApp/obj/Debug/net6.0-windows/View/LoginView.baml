   M S B A M L   `   `   `  ����L  HAdminEcommerceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AdminEcommerceApp.ViewAdminEcommerceApp.View  5      I)clr-namespace:AdminEcommerceApp.ViewModelAdminEcommerceApp.ViewModel  5
      &     AdminEcommerceApp.View.LoginView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:AdminEcommerceApp.View     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:mD1http://materialdesigninxaml.net/winfx/xaml/themes  5	      2vm)clr-namespace:AdminEcommerceApp.ViewModel  5
      -   5        $��MyAdminLoginView��5         MaterialDesignBody#���   5      $��Regular"�5      $��14(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      ���#131313  MaterialDesignFont#���  5      $	��650��5      $	��920��6   .��5      ��  �� CornerRadius$ 10��6   ._�5   
   �  � RowDefinitions 5      �� 5      $��5 �6    �� 5      $��0.07* �6    �� 5      .+�5      �� $��1��6   $��LOG IN��6%   
�������$��14(�6F   $
��Left=�6T   $��Center=�6o   $��10,0,0,0q�6�   �� 5       $��2��6   $	��350��6"   $	��450��6.   $ 10��6;   $��Center=�6M   ���	#FF484848$��Center=�6    J� Effect 5"      3  -System.Windows.Media.Effects.DropShadowEffect  5#         
BlurRadius$ 15Q�6'      	Direction$ 0Q�67      RenderingBias$ Quality=�6E      ShadowDepth$ 1Q�6]   	   Color$	 Black��6m   ._�5&      � $��15 10q�6    5'      �� 5(      $
��0.6* �6(   �� 5)      $��1* �6(   �� 5*      $
��1.3* �6(   �� 5+      $��1* �6(   �� 5,      $
��1.3* �6(   �� 5-      $��3* �6(   .+�52      �� $��1��6    $��Login��6-   $
��Left=�53       $��Bottom=�6;   
�������$��18(�54   3   ]� 55      $��2��6    .+�56      �� $��16(�6"   
 �� 	MaxLength$
 15��60   
�������
������  �� 
CaretBrush
 �����
�������$��0,0,0,1q�59   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter login��5:   "   $��35��5;   "   $	��285��6.   $��Right=�5<   "   $��Center=�5>   "   ��5=   "   �� *
User.Login+5>   "   '  !MaterialDesignThemes.Wpf.PackIcon  5?         Kind$ Contact=�6&   $
��Left=�5@   "   $��35��68   $��35��6D   $��Center=�5A   "   ���	#DDFFFFFF6=   5C      �� 5G      $��3��6    $��Password��6-   
�������$��18(�5H   3   $
��Left=�5I       $��Bottom=�6;   $��0,15,0,5q�5J       ]� 5K      $��4��6    .+�5L      G� -   5        $
��Pass��5P   &   $��16(�5L   &    G� 	MaxLength$ 15��64   
�������
������  G� 
CaretBrush
 �����
�������$��35��5O   &   $	��285��62   $ Enter password��5P   2   $��Right=�5Q   &   $��Center=�6=     5R      $ Password=�6&   $
��Left=�5S   &   $��35��6<   $��35��6H   $��Center=�5T   &   ���	#DDFFFFFF6A   5U      �� 5Y      $��5��6   $��Log in��6*   $��Center=�5Z      $��Center=�66   $��26(�5[      $	��200��6'   $��50��63   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5\      ���	#FF673AB7
����������	#FF673AB7��5^      �� *LoginCommand+��5_      ��  �� ElementName$
 Pass�� 5`        5a      $ 15Q�6/   $ 0Q�6?   $ Quality=�6M   $ 1Q�6e   $	 Black��6u   5c      5d      5e      5f      5g      5h      