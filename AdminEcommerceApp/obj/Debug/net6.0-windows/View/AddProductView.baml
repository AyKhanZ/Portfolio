   M S B A M L   `   `   `  ����L  HAdminEcommerceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AdminEcommerceApp.ViewAdminEcommerceApp.View  5      I)clr-namespace:AdminEcommerceApp.ViewModelAdminEcommerceApp.ViewModel  5
      +    %AdminEcommerceApp.View.AddProductView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:AdminEcommerceApp.View     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:mD1http://materialdesigninxaml.net/winfx/xaml/themes  5	      2vm)clr-namespace:AdminEcommerceApp.ViewModel  5
      -   5        $!��AdminAddCategoryProductView��5         MaterialDesignBody#���   5      $��Regular"�5      $��14(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      
������   MaterialDesignFont#���  5      $	��650��5      $	��920��6   .��5      �� .+�5   
   �� $��Center=�6   $	��700��62   $	��550��6>   .+�5      ]� $	��250��6   $��0 20 0 0q�6%   .+�5      �� $	��Top=�6   $	��220��6.   $	��200��6:    �� CornerRadius$ 15��6G   $	��1.6q�6Y   
���������5      �� 5       �� ImageSource 6%   �� *image+5      �� 5      $��Bottom=�6   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5      $��35��6;   $	��110��6G   ���	#FFC78223���	#FFC78223��5   1   �� *ImageDownoload+.��5       '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	FileImage=�6"   $��35��65   $��30��6@   5!      5"      �� 5#      $��Center=�6   $	��270��64   $��	25 0 25 0q�6A   .+�5%      �� $	��0 5q�6   .+�5&      �� $��18(�6    $��Name: ��6.   $	��120��5'       $��25��6,   
�������$
��Left=�6K   �� 5(      $��16(�6   
����������	#FF484848$��30��5*      $	��350��6*   $
��Left=�66   ��5(   ,   �� *Product.Name+5*   6   5+      �� 5.      $	��0 5q�6   .+�5/      �� $��18(�6    $��Description:��6.   $��20��6B   $	��120��6N   
�������$
��Left=�50   3   �� 51      $��16(�6    �� TextWrapping$
 Wrap=�6R   
����������	#FF484848$��30��52   H   $	��450��6T   $
��Left=�6`   ��51   ,   �� *Product.Description+52   `   53      �� 56      $	��0 5q�6   .+�57      �� $��18(�6    $��60��6.   $��25��69   $��Mark: ��6E   $
��Left=�58       
�������6;   �� 59      $��16(�6   $��30��6K   $	��350��6W   
����������	#FF484848$
��Left=�5:   H   ��59   ,   �� *Product.Make+5:   H   5;      � 5>      $	��0 5q�6    � ColumnDefinitions 5?      �� 5@      �� 5A      .+�5D      �� $��0��6!   .+�5E      �� $��18(�6$   $��90��62   $��25��6=   $
��Left=�5F   $   
�������$��
Category: ��6R   �� 5H      
�������$ 10��64   $��35��6F   $	��180��6R   $
��Left=�6^   ._�5I      �� $��25��6'   $��16(�63   $��	10 0 10 0q�5J   '    �� DisplayMemberPath$
 Name��6:   
���   �
���   �)  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Choose category��5K   '   -  'MaterialDesignThemes.Wpf.ComboBoxAssist
   ShowSelectedItem$

 True��5L   '   ��5M   '   �� *
Categories+ �� SelectedItem 5N   '   �� *SelectedCategory+5O      5P      � 5Q      $��1��6    5R      �� 5S      �� 5T      .+�5V      �� $��Center=�6%   .+�5W      �� $��20(�6(   $
��Left=�66   
�������$��70��5X   $   $��28��6/   $��Price: ��6;   �� 5Y      $��16(�6&   $��30��6K   $	��150��6W   
����������	#FF484848$
��Left=�5Z   L   ��5Y   4   �� *Price+5Z   L   5[      �� 5\      $��1��6$   $
��Left=�64   $��Center=�6O   $��0 30 0 0q�6j   $��$��6|   
�������$��20(�6�   $
��Bold"�6�   5]      5^      5_      5`      � 5b   
   $
��40 0q�6   $��90��6    5c      �� 5d      $
��0.3* �6#   �� 5e      .+�5h      �� $��0��6   $��50��6%   $��90��61   $ 15��5i   !   ���	#FF4E93FF$��Center=�5k   !   ���	#FF4E93FF��5j   !   �� *BackToAllProductsCommand+.��5l        $ 	ArrowBack=�6   
�������$	��100��5n   &   $��50��62   $��Center=�6>   $��Center=�6Y    J� Effect 5o      3  -System.Windows.Media.Effects.DropShadowEffect  5p         
BlurRadius$ 15Q�6'      	Direction$ 0Q�67      RenderingBias$ Quality=�6E      ShadowDepth$ 1Q�6]      Color$ Black��6m   5r      �� 5u      $��2��6   $ 15��6%   $��20q�5v      $	��300��6   $��50��6)   $��Add product��65   $��30(�6K   $��Center=�5w      ���	#FF05AF00
����������	#FF05AF00��5x      �� *AddProductCommand+ 5y        5z      $ 15Q�6'   $ 0Q�67   $ Quality=�6E   $ 1Q�6]   $ Black��6m   5|      5~      5      5�      