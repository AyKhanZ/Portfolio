   M S B A M L   `   `   `  ����K  GUserEcommerceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:UserEcommerceApp.ViewUserEcommerceApp.View  5      G(clr-namespace:UserEcommerceApp.ViewModelUserEcommerceApp.ViewModel  5
      %    UserEcommerceApp.View.LoginView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:UserEcommerceApp.View     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:mD1http://materialdesigninxaml.net/winfx/xaml/themes  5	      1vm(clr-namespace:UserEcommerceApp.ViewModel  5
      -   5        $��MyLoginView��5         MaterialDesignBody#���   5      $��Regular"�5      $��14(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      ���#131313  MaterialDesignFont#���  5      $	��650��5      $	��920��6   .��5      ��  �� CornerRadius$ 10��6   ._�5   
   �  � RowDefinitions 5      �� 5      $��5 �6    �� 5      $��0.07* �6    �� 5      .+�5      �� $��1��6   $
��Left=�6%   $��Center=�6@   $��LOG IN��5      
�������$��14(�64   $��10,0,0,0q�6B   �� 5!      $��2��6   $	��350��6"   $	��450��6.   $ 10��6;   $��Center=�6M   ���	#FF484848$��Center=�5"   ,    J� Effect 5#      3  -System.Windows.Media.Effects.DropShadowEffect  5$         
BlurRadius$ 15Q�6'      	Direction$ 0Q�67      RenderingBias$ Quality=�6E      ShadowDepth$ 1Q�6]   	   Color$	 Black��6m   ._�5&      � $��15 10q�6    5'      �� 5(      $
��0.5* �6(   �� 5)      $��1* �6(   �� 5*      $
��1.5* �6(   �� 5+      $��1* �6(   �� 5,      $
��1.5* �6(   �� 5-      $��1* �6(   �� 5.      $��3* �6(   .+�50      �� $��1��6    $��Username��6-   $
��Left=�51       $��Bottom=�6;   
�������$��18(�52   3   ]� 53      $��2��6    .+�54      �� $��16(�6"   
 �� 	MaxLength$
 15��60   
�������
������  �� 
CaretBrush
 �����
�������$��0,0,0,1q�57   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter username��58   "   $��35��59   "   $	��285��6.   $��Right=�5:   "   $��Center=�5<   "   ��5;   "   �� *
user.Login+5<   "   '  !MaterialDesignThemes.Wpf.PackIcon  5=         Kind$ Contact=�6&   $
��Left=�5>   "   $��35��68   $��35��6D   $��Center=�5?   "   ���	#DDFFFFFF6=   5A      �� 5B      $��3��6    $��Password��6-   
�������$��18(�5C   3   $
��Left=�5D       $��Bottom=�6;   $��0,15,0,5q�5E       ]� 5F      $��4��6    .+�5G      G� -   5        $
��Pass��5K   &   $��16(�5G   &    G� 	MaxLength$ 15��64   
�������
������  G� 
CaretBrush
 �����
�������$��35��5J   &   $	��285��62   $ Enter password��5K   2   $��Right=�5L   &   $��Center=�6=     5M      $ Password=�6&   $
��Left=�5N   &   $��35��6<   $��35��6H   $��Center=�5O   &   ���	#DDFFFFFF6A   5P      �� 5Q      -   5         ��Name$ registerButton��5T   2   $��5��5Q       � Cursor$
 Hand��5R      $	��130��6'   $��25��63   $��Normal"�5S      $��Right=�6-   $	��Top=�6I   
������ 
����  ���5U      Z� ��5W      �� *RegistrationCommand+��5X      �� 5Y      ���	#FF008DEA$��65��6;   B� 5Z      $��12(�6(   .�67   Not a user?6D   5[      5]      �� 5^      $��6��6   $��Log in��6*   $��Center=�5_      $��Center=�66   $��26(�5`      $	��200��6'   $��50��63   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5a      ���	#FF673AB7
����������	#FF673AB7��5c      �� *LoginCommand+��5d      ��  �� ElementName$
 Pass�� 5e        5f      $ 15Q�6/   $ 0Q�6?   $ Quality=�6M   $ 1Q�6e   $	 Black��6u   5h      5i      5j      5k      5l      5m      