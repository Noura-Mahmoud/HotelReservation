   M S B A M L   `   `   `  ����@  <Start, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:StartStart  5   	       Start.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Start     5   	   -   5          � 
ResizeMode$  CanMinimize=�5   	    � Title$ 	LoginPage��5	   	   $	��450��6   $	��567��6(    � WindowStyle$ ThreeDBorderWindow=�64   ���	#FF875184 � SizeToContent$ WidthAndHeight=�6m    � WindowStartupLocation$ CenterScreen=�6�   ��5
      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFB3CCE5��6   � 5      $ White��6    � Offset$ 1Q�6)   5      .��5      � .+�5   
   �� $��2��6   $��Login��6    $
��Left=�60   $��	53,51,0,0q�6K   $	��Top=�6^   $��2��6v   $��49��6�   $	��132��6�   $��22(�6�   $��Elephant)�6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF468C7D��6#   � 5      $ 	#FF8F1DC0��6#   $ 1Q�65   5      5      �� 5   
   $��Username��6   $��92,95,205,308q�6#   $��3��6:   $��2��6J   $��18(�6^   $
��Bold"�6l   $��Cambria)�6~   �� 5   
   -   5        	 ��Name$	 txtUsername��5      
 �� TextWrapping$

 Wrap=�6'   $��92,140,82,251q�6;   $��3��6R   $��2��6b   ���	#FFACC1FF$��2,2,2,2q�6�   $��Center=�6�   $��	10,0,10,0q�6�   $��16(�6�   G� 5   
   -   5         G�Name$ txtPassword��5      $
��Left=�6+   $��
92,253,0,0q�6F   $	��Top=�6Z   $��46��6r   $��2,2,2,2q�6~   ���	#FFACC1FF$��Center=�6�   $��	10,0,10,0q�6�   $��16(�6  $	��393��6  �� 5   
   -   5         ��Name$ 	btnSignIn��5      $��Sign in��6$   $��227,342,239,62q�66   $
��Bold"�6N   $��14(�6`   ���	#FF89A7B5���	#FF010014$��Cambria)�6�   �� 5   
   -   5        $ 
btnLicense��5      $��license��6%   $
��Left=�67   $��491,409,0,0q�6R   $��76��6g   $��25��6r   $	��Top=�6~   ���	#FF9ABDCB$��Cambria)�6�   �� 5   
   -   5         ��Name$ txtBlockUsrnm��5      $
��Wrap=�6+   $��Username��6?   $��129,146,106,258q�6O   $��3��6h   $��2��6x   $��16(�6�    J� IsHitTestVisible$ False��6�   $��Center=�6�   $
��Left=�6�   ��5       �� 5!       �� Color# � ��6"   5#      �� 5)   
   -   5         ��Name$ lblError��5)      $��3��6"   $�� ��62   $
��Left=�6>   $��129,313,0,0q�6Y   $	��Top=�6n   $��2��6�   $	��237��6�   ���	#FFF90000$��Cambria Math)�6�   $��16(�6�   4  .System.Windows.Automation.AutomationProperties   Name$ lblError��6�   5+      5,      