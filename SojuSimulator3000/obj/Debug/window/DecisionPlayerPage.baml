   M S B A M L   `   `   `  ����L  HSojuSimulator3000, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SojuSimulator3000SojuSimulator3000  5   	   *    $SojuSimulator3000.DecisionPlayerPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SojuSimulator3000     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5	   	     � Title$  
MainWindow��5   	   $	��720��6   $
��1280��6)   $
��1280��66   $	��720��6F   ��5      
� 5   
   .��5      �  � Color$ 	#FF379499��6    � Offset$ 0.848Q�6-   5      .��5      � -   5         �Name$ grille��5       � ColumnDefinitions 5   
   �� 5      $��1073.6 �6   �� 5      .+�5   
   �� $��831,47,45.6,112.4q�6    J� RenderTransformOrigin$ 	0.25,0.45&�6+   $0��*/SojuSimulator3000;component/bin/soju3.png��6M   $��2��6�   �� 5   
   -   5         ��Name$ nameAffiche��5   �   
�������$&�� SojuSimulator3000
Name Player : ��6$   $
��Left=�6S   $��	374,6,0,0q�6n   $	��Top=�6�   $	��410��6�   $��40(�6�   $
��Bold"�6�   $	��102��6�   6�   �� 5   
   -   5         ��Name$ 	StartGame��5   �   $
��Next��6   ���#131641$
��Left=�65   $��891,614,0,0q�6P   $	��Top=�6e   $	��310��6}   $ 
0.338,2.35&�6�   $y�Visible=�6�   $��2��6�   �� 5   
   $
��Left=�6   $��67��6/   $��
62,295,0,0q�6;   $	��Top=�6O   $	��249��6g   ��5       �� 5!       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5"      � $ Black��6#   $ 0.012Q�61   � 5#      $ 	#FF3700B2��6#   $ 1Q�65   5%      5(      �� 5)   
   
�������$��Number of workers :��6$   $
��Left=�6B   $��
77,303,0,0q�6]   $	��Top=�6q   $	��218��6�   $��14(�6�   $
��Bold"�6�   $��46��6�   �� 5*   
   -   5        
 ��Name$
 nombreSalarie��5*   �   $
��Left=�6   $��25��6-   {�.  $��
77,324,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   
�������$��14(�6�   $
��Bold"�6�   ��6�   Z� ��6   Z� �� 5+   
   -   5        $�� ��5+      $��270,324,0,0q�6   $��30��6N   $	��Top=�6Z   $
��Left=�6r   $��29��6�   '  !MaterialDesignThemes.Wpf.PackIcon  5,   
   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$
 Plus=�6"   $ 	1.531,7.5&�6.   $��275,329,0,0q�6P   ���	#DDFFFFFF$��20��6|   $��20��6�   {�.  6�   �� 5-   
   $
��Left=�6   $��67��6/   $��
62,191,0,0q�6;   $	��Top=�6O   $	��249��6g   ��5.      �� 5/      $ 0.5,1&�6&   $	 0.5,0&�67   .��50      � $ Black��6#   $ 0.012Q�61   � 51      $ 	#FF3700B2��6#   $ 1Q�65   53      56      �� 57   
   
�������$��Number of machines :��6$   $
��Left=�6C   $��
77,199,0,0q�6^   $	��Top=�6r   $	��218��6�   $��14(�6�   $
��Bold"�6�   $��46��6�   �� 58   
   -   5        $
 nombreMachin��58   �   $
��Left=�6   $��25��6-   {�.  $��
77,220,0,0q�6K   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   
�������$��14(�6�   $
��Bold"�6�   ��6�   Z� ��6�   Z� �� 59   
   -   5        $�� ��59      $��270,220,0,0q�6   $��30��6N   $	��Top=�6Z   $
��Left=�6r   $��29��6�     5:   
   $
 Plus=�6"   $ 	1.531,7.5&�6.   $��275,225,0,0q�6P   ���	#DDFFFFFF$��20��6|   $��20��6�   {�.  6�   �� 5;   
   -   5        $�� ��5;   /   $��228,220,0,0q�6:   $��30��6O   $	��Top=�6[   $
��Left=�6s   $��29��6�     5<   
   $ Minus=�6"   $ 	1.531,7.5&�6/   $��233,225,0,0q�6Q   ���	#DDFFFFFF$��20��6}   $��20��6�   {�.  6�   �� 5=   
   -	   5        $�� ��5=      $��228,324,0,0q�6   $��30��6M   $	��Top=�6Y   $
��Left=�6q   $��29��6�     5>   
   $ Minus=�6"   $ 	1.531,7.5&�6/   $��233,329,0,0q�6Q   ���	#DDFFFFFF$��20��6}   $��20��6�   {�.  6�   �� 5?   
   -
   5        $ money��5?   �   
�������$��Money :��6$   $
��Left=�66   $��
62,125,0,0q�6Q   $	��Top=�6e   $	��315��6}   $��25(�6�   $
��Bold"�6�   $��42��6�   6�   �� 5@   
   -   5        $ priceMachines��5@   �   
�������$��Price Machins :��6$   $
��Left=�6>   $��414,191,0,0q�6Y   $	��Top=�6n   $	��315��6�   $��20(�6�   $
��Bold"�6�   $��42��6�   6�   �� 5A   
   -   5        $ priceFireWorkers��5A   �   
�������$��Price Fire Workers :��6$   $
��Left=�6C   $��414,225,0,0q�6^   $	��Top=�6s   $	��355��6�   $��20(�6�   $
��Bold"�6�   $��33��6�   6�   �� 5B   
   -   5        $ priceIngNormalSoju��5B   �   
�������$%��Price ingredients normal soju :��6$   $
��Left=�6N   $��414,258,0,0q�6i   $	��Top=�6~   $	��399��6�   $��20(�6�   $
��Bold"�6�   $��32��6�   6�   �� 5C   
   $
��Left=�6   $��67��6/   $	��Top=�6;   $	��249��6S   $��
62,391,0,0q�6_   ��5D      �� 5E      $ 0.5,1&�6&   $	 0.5,0&�67   .��5F      � $ Black��6#   $ 0.012Q�61   � 5G      $ 	#FF3700B2��6#   $ 1Q�65   5I      5L      �� 5M   
   
�������$(��"Number of Normal soju
To product :��6$   $
��Left=�6U   $	��Top=�6p   $	��218��6�   $��14(�6�   $
��Bold"�6�   $��46��6�   $��
77,399,0,0q�6�   �� 5N   
   -   5        $
 productNormalSoju��5N   �   $
��Left=�6   $��27��6-   $
 Wrap=�69   $�� ��6M   $	��Top=�6U   $	��122��6m   
������� �� 
CaretBrush
 ����� �� SelectionBrush
 �����
�������$��0,0,0,2q�6�   $��173,418,0,0q�6�   �� 5O   
   $
��Left=�6   $��67��6/   $	��Top=�6;   $	��249��6S   $��
62,562,0,0q�6_   ��5P      �� 5Q      $ 0.5,1&�6&   $	 0.5,0&�67   .��5R      � $ Black��6#   $ 0.012Q�61   � 5S      $ 	#FF3700B2��6#   $ 1Q�65   5U      5X      �� 5Y   
   
�������$��Marketing :��6$   $
��Left=�6:   $	��Top=�6U   $	��218��6m   $��14(�6y   $
��Bold"�6�   $��46��6�   $��
77,570,0,0q�6�   �� 5Z   
   -   5        $
 marketingSell��5Z   �   $
��Left=�6   $��27��6-   $
 Wrap=�69   $�� ��6M   $	��Top=�6U   $	��122��6m   
�������
 �����
 �����
�������$��0,0,0,2q�6�   $��173,589,0,0q�6�   �� 5[   
   $
��Left=�6   $��67��6/   $	��Top=�6;   $	��249��6S   $��
62,473,0,0q�6_   ��5\      �� 5]      $ 0.5,1&�6&   $	 0.5,0&�67   .��5^      � $ Black��6#   $ 0.012Q�61   � 5_      $ 	#FF3700B2��6#   $ 1Q�65   5a      5d      �� 5e   
   
�������$��Price of Normal soju :��6$   $
��Left=�6E   $	��Top=�6`   $	��218��6x   $��14(�6�   $
��Bold"�6�   $��46��6�   $��
77,481,0,0q�6�   �� 5f   
   -   5        $
 priceNormalSoju��5f   �   $
��Left=�6   $��27��6-   $
 Wrap=�69   $�� ��6M   $	��Top=�6U   $	��122��6m   
�������
 �����
 �����
�������$��0,0,0,2q�6�   $��173,500,0,0q�6�   �� 5g   
   -   5        $ stockNormalSoju��5g   �   
�������$��Stock Soju :��6$   $
��Left=�6;   $��414,290,0,0q�6V   $	��Top=�6k   $	��412��6�   $��20(�6�   $
��Bold"�6�   $��42��6�   6�   �� 5h   
   
�������$)��#One worker can produce 16000 bottle��6$   $
��Left=�6R   $��414,320,0,0q�6m   $	��Top=�6�   $	��412��6�   $��20(�6�   $
��Bold"�6�   $��42��6�   �� 5i   
   
�������$0��*The limit of price is between 800 and 3000��6$   $
��Left=�6Y   $��414,348,0,0q�6t   $	��Top=�6�   $	��412��6�   $��20(�6�   $
��Bold"�6�   $��42��6�   �� 5j   
   -   5        $ estimationBottle��5j   �   
�������$&�� Estimation bottle of this year :��6$   $
��Left=�6O   $��414,376,0,0q�6j   $	��Top=�6   $	��412��6�   $��20(�6�   $
��Bold"�6�   $��42��6�   6�   5l      5m      