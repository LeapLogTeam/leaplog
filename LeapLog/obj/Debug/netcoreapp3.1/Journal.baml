   M S B A M L   `   `   `  ����B  >LeapLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LeapLogLeapLog  5          LeapLog.Journal   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:LeapLog     5      
�������.��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5           Name$  	entryGrid��5   y   $	��0.5q�6      RowHeaderWidth$ 0Q�6)   ���#d6d6d6���#d6d6d6   
IsReadOnly$
 True��6g   $��Center=�6�   $	��281��6�   $	��Top=�6�   $	��725��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��	0,176,0,0q�6�   ${�False��6     AlternatingRowBackground �	#FFE4E4E4   VerticalGridLinesBrush �	#FFD6D6D6   HorizontalGridLinesBrush 6D  Z�    ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      �� 	 �� Property	 � ��
 �� Value
 �#23426463   �� 5      	 � ��

 �����63   �� 5      	 � ��$
 12(�61   �� 5      	 � ��$
 Center=�6C   �� 5      	 � ��$	
 0.5q�68   �� 5      	 � ��
 �#d6d6d664   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 61 63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *Date+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Accounts��6)   $
 250  6;      CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6)   .+�5    "   �� ��6,   �� *
Account1+�� 5!   "   ��6,   �� *
Account2+5"      5#      5%        5'      $
 Type��6)   $	 150 67    5(      �� 5)      .R�5*      �� $ Vertical=�6)   .+�5+   "   �� ��6,   �� *Type1+�� 5,   "   ��6,   �� *Type2+5-      5.      50        52      $ Debit��6)   $	 130 68    53      �� 54      .R�55      �� $ Vertical=�6)   .+�56   "   �� ��6,   �� *Debit+�� 57   "   $�� ��6,   58      59      5;        5=      $ Credit��6)   $ * 69    5>      �� 5?      .R�5@      �� $ Vertical=�6)   .+�5A   "   �� $�� ��6,   �� 5B   "   ��6,   �� *Credit+5C      5D      5F      5H      �� 5K   
   -   5        $��
account1TB��5K      $��2��6   $
��Left=�61   $��22��6L   $��
296,41,0,0q�6X    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $��94��6�   6�   �� 5L   
   -   5        $��type1CB��5L       $��3��6   $
��Left=�6/   $��20��6J   $��
412,41,0,0q�6V   $	��Top=�6j   $	��108��6�   .@�5M      �� $��Asset��6   6-   �� 5N      $��	Liability��6   61   �� 5O      $��Owners Equity��6   65   �� 5P      $��Revenue��6   6/   �� 5Q      $��Expense��6   6/   �� 5R      $��
Withdrawal��6   62   5S      �� 5T   
   -   5        $��debitTB��5T      $��4��6   $
��Left=�6.   $��22��6I   $��
541,41,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $��95��6�   �� 5U   
   -   5        $��
account2TB��5U      $��5��6   $
��Left=�61   $��22��6L   $��
296,89,0,0q�6X   $
 Wrap=�6l   $	��Top=�6�   $��94��6�   �� 5V   
   -   5        $��type2CB��5V       $��6��6   $
��Left=�6/   $��20��6J   $��
411,89,0,0q�6V   $	��Top=�6j   $	��108��6�   .@�5W      �� $��Asset��6   6-   �� 5X      $��	Liability��6   61   �� 5Y      $��Owners Equity��6   65   �� 5Z      $��Revenue��6   6/   �� 5[      $��Expense��6   6/   �� 5\      $��
Withdrawal��6   62   5]      �� 5^   
   -   5        $��creditTB��5^      $��7��6   $
��Left=�6/   $��22��6J   $��
541,89,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $��95��6�   �� 5_   
   -   5        $��addEntryBtn��5_      $��8��6   $��	Add Entry��61   $
��Left=�6E   $��24��6`   $��430,129,0,0q�6l   $	��Top=�6�   $��70��6�   ���#353535���#d9d9d9$
��Bold"�6�   $��Normal$�6�    � 	Resources 5`      ��%^   '��       �� 5a      " ��6   .�5b      �� 	 �@��CornerRadius$
 5��65   5c      5d      5e      �� 5g   
   $��Debit Amount��6   $
��Left=�6'   $��24��6B   $��
541,15,0,0q�6N   $	��Top=�6b   $	��100��6z   �� 5h   
   $��Account to Debit��6   $
��Left=�6+   $��24��6F   $��
293,15,0,0q�6R   $	��Top=�6f   $	��100��6~   �� 5i   
   $��Account to Credit��6   $
��Left=�6,   $��24��6G   $��
293,60,0,0q�6S   $	��Top=�6g   $	��104��6   �� 5j   
   $��Credit  Amount��6   $
��Left=�6)   $��24��6D   $��
538,59,0,0q�6P   $	��Top=�6d   $��96��6|   $ 
0.75,0.583&�6�   z�5k      V� 5l      .~�5m      �� �� 5n      �� 5o       �� Angle$ -0.299Q�6&   T� 5p      5q      5s      �� 5t   
   $��Account Type��6   $
��Left=�6'   $��27��6B   $��
424,14,0,0q�6N   $	��Top=�6b   $��82��6z   $ 0.5,0.5&�6�   z�5u      V� 5v      .~�5w      �� �� 5x      �� 5y      $
 0.24Q�6&   T� 5z      5{      5}      �� 5~   
   $��Account Type��6   $
��Left=�6'   $��28��6B   $��
424,61,0,0q�6N   $	��Top=�6b   $��82��6z   $ 
0.37,0.264&�6�   �� 5   
   -	   5         ��Name$ 
user_Input��5      $��0��6   $
��Left=�63   $��	63,42,0,0q�6N   $
 Wrap=�6a   $	��Top=�6u   $	��128��6�   $ 0.566,2.187&�6�   $��22��6�   6�   �� 5�   
   -
   5         ��Name$ label��5�      $��Select Existing Database:��6   $
��Left=�6C   $��	54,16,0,0q�6^   $	��Top=�6q   $	��146��6�   �� 5�   
   -   5         ��Name$ enter_button��5�      $��1��6   $��Add New Database��64   $
��Left=�6O   $��
67,100,0,0q�6j   $	��Top=�6~   $ -0.135,0.384&�6�   $��24��6�   $	��120��6�   $
��Bold"�6�   ���#353535���#d9d9d9 5�      ��%^   '��       �� 5�      " ��6   .�5�      �� 	 �@��CornerRadius$
 5��65   5�      5�      5�      �� 5�   
   -   5        $ label1��5�      $��Or��6    $
��Left=�6-   $��
115,69,0,0q�6H   $	��Top=�6\   �� 5�   
   -   5        $ toExcel��5�      $��Export to Excel��6"   $��Center=�6<   $��	0,470,0,0q�6Y   $	��Top=�6l   $��94��6�   $��24��6�   $
��Bold"�6�   ���#008013���#008013
�������$ 0.649,0.457&�6   5�      ��%^   '��       �� 5�      " ��6   .�5�      �� 	 �@��CornerRadius$
 5��65   5�      5�      5�      �� 5�   
   -   5        $��	warningTB��5�      $��Center=�6#   
�������$y�	Collapsed=�6S   $��60��6k   $��	0,217,0,0q�6w   $����Error: Please make sure you are not entering quotation marks in your account names and that you are entering numbers for credit and debit.��6�   $
 Wrap=�6  $	��Top=�60  $	��312��6H  �� 5�   
   -   5        $��	warningAT��5�      $��Center=�6#   
�������$y�	Collapsed=�6S   $��18��6j   $��	0,217,0,0q�6v   $A��;Error: please also select an account type for both entries.��6�   $
 Wrap=�6�   $	��Top=�6�   $	��312��6�   �� 5�   
   -   5        $��	warningAN��5�      $��Center=�6#   
�������$y�	Collapsed=�6S   $��18��6j   $��	0,217,0,0q�6v   $-��'Error: blank accounts are not accepted.��6�   $
 Wrap=�6�   $	��Top=�6�   $	��219��6�   � 5�   
   -   5         �Name$ journalHelpWindow1��5�      $y�	Collapsed=�6+   .+�5�      �� $��Center=�6   $	��504��66   
���   �$��Center=�6R   $	��745��6m   ���#bdbdbd J� Opacity$	 0.5Q�6�   �� 5�      $��\images\journalsnip.png��6   $��10,60,10,-69q�65   6M   �� 5�      ���#96251c$��Calibri)�6-   $��18(�6B   $��Center=�6P   $��	0,216,0,0q�6m   $����The journal allows the user to record financial transactions. Begin by first creating a journal table. After you type its name and click the 'Add New Journal' button, fill out the entry form.��6�   $
��Wrap=�6G  $	��Top=�6[  $��80��6s  $	��596��6  �� 5�      ���#96251c$��Calibri)�6-   $��18(�6B   $��Center=�6P   $��	0,301,0,0q�6m   $����To switch between tables that have already been created, simply type the name of the existing table and start filling out your entry. You do not need to click the 'Add New Journal' button to switch between tables.��6�   $
��Wrap=�6]  $	��Top=�6q  $��72��6�  $	��596��6�  �� 5�      -   5        $��forwardButton��5�      $
��Next��6*   $
��Left=�69   $��694,302,0,0q�6T   $	��Top=�6i   $��20��6�   $��35��6�   $
��Bold"�6�   ���#96251c���#96251c
������� 5�      ��%^   '��       �� 5�      " ��6   .�5�      �� 	 �@��CornerRadius$
 5��69   5�      5�      5�      �� 5�      $��\images\red-one.jpg��6   $
��Left=�61   $��45��6L   $	��Top=�6X   $��50��6p   $��10,5,0,0q�6{   �� 5�      $��\images\red-two.jpg��6   $
��Left=�61   $��50��6L   $��	238,5,0,0q�6X   $	��Top=�6k   $��53��6�   $ 0.484,0.455&�6�   �� 5�      ���#96251c$��Calibri)�6-   $��18(�6B   $��Center=�6P   $��	0,397,0,0q�6m   $����The 'Export to Excel' button saves and exports all the data you have entered into an excel file that is separated into worksheets.��6�   $
��Wrap=�6
  $	��Top=�6  $��72��66  $	��596��6B  5�      � 5�   
   -   5        $ journalHelpWindow2��5�      $y�	Collapsed=�6+   .+�5�      �� $��Center=�6   $	��504��65   
���   �$��Center=�6Q   $	��745��6l   ���#bdbdbd$	 0.5Q�6�   �� 5�      $��\images\journalsnip.png��6   $��10,60,10,-69q�65   6M   �� 5�      ���#96251c$��Calibri)�6-   $��14(�6B   $��Center=�6P   $��	0,202,0,0q�6m   $����An example of a journal entry using assets would be to purchase equipment with cash. You are increasing one asset and decreasing another.��6�   $
��Wrap=�6  $	��Top=�6%  $��40��6=  $	��606��6I  �� 5�      $��\images\asset-example.png��6   $��Center=�67   $��50��6T   $��	0,242,0,0q�6`   $	��Top=�6s   $	��606��6�   �� 5�      -   5        $��
backButton��5�      $��20��6'   $��35��63   $
��Bold"�6>   ���#96251c���#96251c
�������$
��Back��6�   $
��Left=�6�   $��
17,304,0,0q�6�   $	��Top=�6�    5�      ��%^   '��       �� 5�      " ��6   .�5�      �� 	 �@��CornerRadius$
 5��69   5�      5�      5�      �� 5�      -   5        $��forwardButton2��5�      $��20��6+   $��35��67   $
��Bold"�6B   ���#96251c���#96251c
�������$
��Next��6�   $
��Left=�6�   $��694,302,0,0q�6�   $	��Top=�6�    5�      ��%^   '��       �� 5�      " ��6   .�5�      �� 	 �@��CornerRadius$
 5��69   5�      5�      5�      �� 5�      ���#96251c$��Calibri)�6-   $��14(�6B   $��Center=�6Q   $��	0,290,0,0q�6n   $����An example of a journal entry using a liability is buying supplies on credit. You get the supplies now, but will have a debt to pay later.��6�   $
��Wrap=�6  $	��Top=�6'  $��34��6?  $	��606��6K  �� 5�      $��\images\liability-ex.png��6   $��Center=�66   $��42��6S   $	��Top=�6_   $	��606��6w   $��	0,330,0,0q�6�   �� 5�      ���#96251c$��Calibri)�6-   $��14(�6B   $
��Left=�6Q   $��
70,372,0,0q�6l   $����An example of a journal entry using owner's equity is to invest money into your business. Bob invests money, so both cash and owner's equity increase.��6�   $
��Wrap=�6  $	��Top=�62  $��42��6J  $	��478��6V  �� 5�      $��\images\oe-example.png��6   $��Center=�64   $��42��6Q   $	��Top=�6]   $	��606��6u   $��	0,414,0,0q�6�   5�      � 5�   
   -   5        $ journalHelpWindow3��5�      $y�	Collapsed=�6+   .+�5�      �� $��Center=�6   $	��504��65   
���   �$��Center=�6Q   $	��745��6l   ���#bdbdbd$	 0.5Q�6�   �� 5�      $��\images\journalsnip.png��6   $��10,60,10,-69q�65   6M   �� 5�      -   5        $��backButton2��5�      $
��Back��6(   $
��Left=�67   $��
17,304,0,0q�6R   $	��Top=�6f   $��20��6~   $��35��6�   $
��Bold"�6�   ���#96251c���#96251c
������� 5�      ��%^   '��       �� 5�      " ��6   .�5�      �� 	 �@��CornerRadius$
 5��69   5�      5�      5�      �� 5�      ���#96251c$��Calibri)�6-   $��14(�6B   $
��Left=�6Q   $��
73,204,0,0q�6l   $����An example of a  a journal entry using a withdrawal is if Bob, the owner, chooses to withdraw money from their business for their own personal expenses. Withdrawal accounts are always debited.��6�   $
��Wrap=�6H  $	��Top=�6\  $��43��6t  $	��590��6�  �� 5�      $'��!\images\drawing-example-image.png��6   $
��Left=�6?   $��44��6Z   $	��Top=�6f   $	��590��6~   $��
73,247,0,0q�6�   �� 5�      ���#96251c$��Calibri)�6-   $��14(�6B   $
��Left=�6Q   $��
73,299,0,0q�6l   $����An example of a journal entry using a revenue account is when the business generates sales income. Both cash and revenue increase. Revenue accounts are always credited.��6�   $
��Wrap=�60  $	��Top=�6D  $��50��6\  $	��590��6h  �� 5�      $'��!\images\revenue-example-image.png��6   $
��Left=�6?   $��46��6Z   $	��Top=�6f   $	��590��6~   $��
73,334,0,0q�6�   �� 5�      ���#96251c$��Calibri)�6-   $��14(�6B   $��Center=�6Q   $��	0,380,0,0q�6n   $����An example of a journal entry using an expense account is when an owner needs to pay their employees' salary. The expense account is increased and cash is decreased. Expense accounts are always debited.��6�   $
��Wrap=�6S  $	��Top=�6g  $��65��6  $	��599��6�  �� 5�      $'��!\images\expense-example-image.png��6   $
��Left=�6?   $��50��6Z   $	��Top=�6f   $	��590��6~   $��
73,415,0,0q�6�   5�      �� 5�   
   -   5        $ journalHelpButton��5�      $
��Help��6,   $
��Left=�6;   $��
685,10,0,0q�6V   $	��Top=�6j   $��50��6�   $��24��6�   $
��Bold"�6�   ���#96251c���#96251c
������� 5�      ��%^   '��       �� 5�      " ��6   .�5�      �� 	 �@��CornerRadius$
 5��65   5�      5�      5�      5�      5�      