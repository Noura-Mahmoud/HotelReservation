   M S B A M L   `   `   `  ����@  <Start, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:StartStart  5   	       Start.FinalizeBillWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Start     5   	     � Title$  FinalizeBillWindow��5   	   $	��450��6$   $	��800��61   .��5	      � .+�5
   
   �� -   5         ��Name$ BtnBillNext��5
      $
��Next��6&   $
��Left=�65   $��471,337,0,0q�6P   $	��Top=�6e   $��44��6}   $	��129��6�   $
��Bold"�6�   $��20(�6�   $��Century)�6�   6�   �� 5   
   -   5         ��Name$ ComboPaymentType��5       �� Text$ Payement Type��6-   $
��Left=�6B   $��
52,230,0,0q�6]   $	��Top=�6q   $	��163��6�   $��34��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$ Payement��6�    �� 
IsEditable$
 True��6�   $��16(�6�   6�   �� 5   
   -   5        $ 
ComboMonth��5      $
��Left=�6'   $��
52,292,0,0q�6B   $	��Top=�6V   $��82��6n   $��23��6y   $
 True��6�   $ MM��6�   6�   �� 5   
   -   5        $ 	ComboYear��5      $
��Left=�6&   $��147,290,0,0q�6A   $	��Top=�6V   $��71��6n   $��25��6y   $
 True��6�   $ YY��6�   �� 5   
   -   5         ��Name$ txtCVC��5      $
��Left=�6"   $��229,290,0,0q�6=    �� TextWrapping$
 Wrap=�6R   $	��CVC��6f   $	��Top=�6q   $��73��6�   $��25��6�   �� 5   
   -   5        $ txtPaymentCardNumber��5      $
��Left=�60   $��317,229,0,0q�6K   $
 Wrap=�6`   $��9999-9999-9999-9999��6t   $	��Top=�6�   $	��178��6�   $��35��6�   6�   �� 5   
   $
��Left=�6   $��	52,20,0,0q�6+   $	��Top=�6>   $��38��6V   $	��548��6b   $��18(�6n   $[��UReservation                                                                         $��6|   �� 5   
   $
��Left=�6   $��	52,63,0,0q�6+   $	��Top=�6>   $��38��6V   $	��548��6b   $��18(�6n   $]��WCurrent Bill                                                                          $��6|   �� 5   
   $
��Left=�6   $��
52,106,0,0q�6+   $	��Top=�6?   $��38��6W   $	��484��6c   $��18(�6o   $^��XFood Bill                                                                              $��6}   �� 5   
   $
��Left=�6   $��361,144,0,0q�6+   $	��Top=�6@   $��38��6X   $	��175��6d   $��18(�6p   $"��Tax                        $��6~   �� 5   
   $
��Left=�6   $��361,177,0,0q�6+   $	��Top=�6@   $��38��6X   $	��175��6d   $��18(�6p   $ ��Total                    $��6~   $
��Bold"�6�   �� 5   
   -   5         ��Name$ cardTypeLbl��5      $��
Card Type:��6%   $
��Left=�6:   $��361,289,0,0q�6U   $	��Top=�6j   $��87��6�   $
��Bold"�6�   $��14(�6�   �� 5   
   -   5        $ lblReservationBill��5      $
��Left=�6,   $��
439,24,0,0q�6G   $	��Top=�6[   $��30��6s   $��71��6   �� 5   
   -	   5        $ lblCurrentBill��5      $
��Left=�6(   $��
439,67,0,0q�6C   $	��Top=�6W   $��30��6o   $��71��6{   �� 5   
   -
   5        $ lblFoodBill��5      $
��Left=�6&   $��437,107,0,0q�6A   $	��Top=�6V   $��30��6n   $��73��6z   �� 5   
   -   5        $ lblTax��5      $
��Left=�6!   $��437,145,0,0q�6<   $	��Top=�6Q   $��30��6i   $��73��6u   �� 5   
   -   5        $ lblTotal��5      $
��Left=�6"   $��437,178,0,0q�6=   $	��Top=�6R   $��30��6j   $��73��6v   $
��Bold"�6�   $��16(�6�   �� 5   
   -   5        $ lblCardType��5      $�� ��6%   $
��Left=�60   $��448,292,0,0q�6K   $	��Top=�6`   $	��125��6x   $��26��6�   5      5      