   M S B A M L   `   `   `  ����@  <Start, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:StartStart  5   	       Start.FoodMenu   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Start     5   	   -   5          � Title$  FoodMenu��5   	   $	��450��6   $	��800��6'    � SizeToContent$ WidthAndHeight=�63    � WindowStartupLocation$ CenterScreen=�6R    � 
ResizeMode$ NoResize=�6w   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFF9F9F9��6   � 5      $ White��6    � Offset$ 1Q�6)   5      .��5      � .+�5   
   �� 
���   �$��1q�6%   $��31,58,286,0q�69   $	��303��6N   $	��Top=�6[   ._�5      � $��Center=�6   $	��482��60   $��0,-8,0,8q�6<    � ColumnDefinitions 5      �� 5      �� 5      	 � RowDefinitions	 5      �� 5      �� 5      .+�5      �� $��Food Selection��6   $
��Bold"�61   $��16(�6C   �� 5      $��0��6   $��58,20,56,36q�6(   $��/images/breakfask.jpg��6=   $��95��6\   $	��127��6h   �� 5      -   5        
 ��Name$
 CheckBreakfast��5      $��0��63   $��BreakFast ($7)��6C   $
��Left=�6\   $��
26,110,0,0q�6w   $	��Top=�6�   $��20��6�   $	��105��6�   6�   �� 5      -   5         ��Name$ txtBreakfastQuantity��5      $��0��68   $
��Left=�6H   $��
45,133,0,0q�6c    �� TextWrapping$
 Wrap=�6w   $	��Top=�6�   $	��120��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$ 	Quantity?��6�   $��2��6�   �� 5      $��/images/lunch.png��6   $��28,17,29,32q�63   $��1��6H   �� 5      -   5        $
 
CheckLunch��5      $��1��6/   $��Lunch ($15)��6?   $
��Left=�6U   $��
26,112,0,0q�6p   $	��Top=�6�   $��20��6�   $	��105��6�   6�   �� 5       -   5        $ txtLunchQuantity��5       $��1��64   $
��Left=�6D   $��
45,135,0,0q�6_   $
 Wrap=�6s   $	��Top=�6�   $	��120��6�   $ 	Quantity?��6�   $��2��6�   �� 5!      $��0��6   $��
58,4,56,51q�6(   $
��Fill=�6<   $��/images/dinner.png��6K   $��95��6g   $	��127��6s   $��1��6   �� 5"      -   5        $
 CheckDinner��5"      $��0��60   $��1��6@   $��Dinner ($15)��6M   $
��Left=�6d   $��
26,100,0,0q�6   $	��Top=�6�   $��20��6�   $	��105��6�   6�   �� 5#      -   5        $ txtDinnerQuantity��5#      $��0��65   $��1��6E   $
��Left=�6R   $��
45,123,0,0q�6m   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   $ 	Quantity?��6�   5$      5%      �� 5&   
   -   5         ��Name$ needsBorder��5&      
���   �$��1q�6:   $��578,49,42,139q�6N   ._�5'      � 	 5(      �� 5)      $	��13* �6$   �� 5*      $	��48* �6$   .+�5,      �� $��Special needs��6   $
��Bold"�60   $��16(�6B   �� 5-      -	   5        $
 checkCleaning��5-      $��Cleaning��62   $
��Left=�6E   $��	18,15,0,0q�6`   $��1��6s   $	��Top=�6�   $��36��6�   $	��136��6�   �� 5.      -
   5        $
 checkTowels��5.      $��Towels��60   $
��Left=�6A   $��	18,46,0,0q�6\   $��1��6o   $	��Top=�6|   $��15��6�   $��71��6�   �� 5/      -   5        $
 checkSurprise��5/      $��Sweetest Surprise��62   $
��Left=�6N   $��	18,81,0,0q�6i   $��1��6|   $	��Top=�6�   $��15��6�   $	��150��6�   51      52      �� 53   
   $��Food and Menu��6   $
��Left=�6(   $��	46,17,0,0q�6C   $	��Top=�6V   $��33��6n   $	��302��6z   $��20(�6�   $
��Bold"�6�   $��Cambria)�6�   �� 54   
   -   5         ��Name$ btnNext��54      $
��Next��6"   $
��Left=�61   $��589,316,0,0q�6L   $	��Top=�6a   $��36��6y   $	��159��6�   6�   56      57      