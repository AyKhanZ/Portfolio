   M S B A M L   `   `   `  ����L  HAdminEcommerceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AdminEcommerceApp.ViewAdminEcommerceApp.View  5      I)clr-namespace:AdminEcommerceApp.ViewModelAdminEcommerceApp.ViewModel  5
      ,    &AdminEcommerceApp.View.AddCategoryView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:AdminEcommerceApp.View     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:mD1http://materialdesigninxaml.net/winfx/xaml/themes  5	      2vm)clr-namespace:AdminEcommerceApp.ViewModel  5
      -   5        $!��AdminAddCategoryProductView��5         MaterialDesignBody#���   5      $��Regular"�5      $��14(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      
������   MaterialDesignFont#���  5      $	��650��5      $	��920��6   .��5      �� $��Center=�6   $	��550��6,   $
��30 0q�69   .+�5   
   � $
��0 50q�6    � ColumnDefinitions 5      �� 5      $
��0.8* �6#   �� 5      �� 5      .+�5      �� $��0��6   $��Center=�6)   .+�5       �� $��22(�6   $	��150��6*   $��34��66   $
��Left=�5!      
�������$��Categories: ��6J   �� 5#      
������� �� CornerRadius$ 10��6,   $��36��6>   $	��240��6J   $
��Left=�6V   ._�5$      �� $��28��6   $��18(�6+   $��	10 0 10 0q�5%       �� DisplayMemberPath$
 Name��62   
���   �
���   �)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Choose category��5&      -  'MaterialDesignThemes.Wpf.ComboBoxAssist   ShowSelectedItem$
 True��5'      ��5(      �� *
Categories+ �� SelectedItem 5)      �� *SelectedCategory+5*      5+      �� 5-      $��1��6   $��Center=�6)   .+�5.      �� $��22(�6   $	��250��6*   $��34��66   $
��Left=�5/      
�������$��Selected category name: ��6J   �� 51      $��18(�6   
����������	#FF484848$��34��53      $	��270��6&   $
��Left=�62   ��51   *   �� *SelectedCategory.Name+53   2   54      �� 56      $��2��6   $��Center=�6)   .+�57      �� $��22(�6   $	��250��6*   $��34��66   $
��Left=�58      
�������$��Change category name: ��6J   �� 5:      $��18(�6   
����������	#FF484848$��34��5<      $	��270��6&   $
��Left=�62   ��5:   (   �� *ChangedCategory.Name+5<   2   5=      5>      ]� 5@   
   .+�5A      �� +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��6   $
��Left=�67   $��	150 0 0 0q�5B      $	��200��6$   $��50��60   $��Delete��6<   $��30(�6M   $��Right=�5C      ���	#FFB90808
����������	#FFB90808��5D      �� *DeleteCategoryCommand+{�6;   �� *IsEnabledToDelete+	 J� Effect	 5E      3  -System.Windows.Media.Effects.DropShadowEffect  5F      
   
BlurRadius$
 15Q�6'      	Direction$ 0Q�67      RenderingBias$ Quality=�6E      ShadowDepth$ 1Q�6]      Color$ Black��6m   5H      �� 5K      $ 15��6   $��Right=�67   $��	0 0 150 0q�5L      $	��200��6$   $��50��60   $��Update��6<   $��30(�6M   $��Right=�5M      ���	#FFAF7600
����������	#FFAF7600��5N      �� *UpdateCategoryCommand+	 5O        5P      $
 15Q�6'   $ 0Q�67   $ Quality=�6E   $ 1Q�6]   $ Black��6m   5R      5S      �� 5X   
   $��Center=�6   $��	0,50,0,50q�62   .+�5Y      �� $��24(�6   $��Add category: ��6&   $	��200��5Z      $��34��6(   
�������$
��Left=�6G   $
��Bold"�6b   �� 5[      $��18(�6   
����������	#FF484848$��34��5]      $	��400��6&   $
��Left=�62   ��5[   $   �� *NewCategory.Name+5]   2   5^      � 5`   
   $
��50 0q�6    5a      �� 5b      $
��0.3* �6#   �� 5c      .+�5f      �� $��0��6   $��50��6%   $��90��61   $ 15��5g   !   ���	#FF4E93FF$��Center=�5i   !   ���	#FF4E93FF��5h   !   �� *BackToAllProductsCommand+.��5j      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowBack=�6   
�������$	��100��5l   &   $��50��62   $��Center=�6>   $��Center=�6Y   	 5m        5n      $
 15Q�6'   $ 0Q�67   $ Quality=�6E   $ 1Q�6]   $ Black��6m   5p      �� 5s      $��2��6   $ 15��6%   $��20q�5t      $	��300��6   $��50��6)   $��Add category��65   $��30(�6L   $��Center=�5u      ���	#FF05AF00
����������	#FF05AF00��5v      �� *AddCategoryCommand+	 5w        5x      $
 15Q�6'   $ 0Q�67   $ Quality=�6E   $ 1Q�6]   $ Black��6m   5z      5|      5}      5~      