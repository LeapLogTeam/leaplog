   M S B A M L   `   `   `  ����B  >LeapLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LeapLogLeapLog  5          LeapLog.Dashboard   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:LeapLog     5      .��5	      � 
�������.+�5
   
   �� ���#008013$��	0,0,0,415q�6#   68   �� 5   
   -   5        $��
welcomeLbl��5      $��Getting Started Guide��6"   
�������$��48(�6U   $��Center=�6c   $��0,28,0,0q�6�   $	��Top=�6�   $��78��6�   $	��474��6�   � 5   
   -   5        $��accGrid��5      $y�Visible=�6   .+�5      �� 
�������$
��Left=�6*   $	��312��6E   $��266,150,0,0q�6R   
���   �$	��Top=�6v   $	��346��6�   �� 5      $��18(�6   $
��Left=�6&   $��	284,0,0,0q�6A   $����Accounting is the process of keeping financial accounts. It uses the accounting equation of A = L + OE, which represents the relationship between assets, liabilities, and owner's equity. For every transaction recorded, the total debits equal the total credits.��6T   $
��Wrap=�6`  $��Center=�6t  $	��181��6�  $	��311��6�  �� 5      $%��\images\asset-image-colored.jpg��6   $
��Left=�6=   $��75��6X   $��75��6d   $��284,369,0,0q�6o   $	��Top=�6�   �� 5      $)��#\images\liability-image-colored.jpg��6   $
��Left=�6A   $��75��6\   $��75��6h   $��402,369,0,0q�6s   $	��Top=�6�   �� 5      $"��\images\oe-image-colored.jpg��6   $
��Left=�6:   $��75��6U   $��75��6a   $��511,369,0,0q�6l   $	��Top=�6�   �� 5      $��=��6   $��20(�6    $
��Left=�6.   $��369,388,0,0q�6I   $	��Top=�6^   �� 5      $��+��6   $��20(�6    $
��Left=�6.   $��482,388,0,0q�6I   $	��Top=�6^   5      � 5   
   -   5        $��	assetGrid��5      $y�	Collapsed=�6    .+�5      �� 
�������$
��Left=�6*   $	��312��6E   $��265,150,0,0q�6R   
���   �$	��Top=�6v   $	��346��6�   �� 5      $
��Left=�6   $��293,174,0,0q�63   $����An asset is any resource owned by a business or person. Assets can include cash, buildings, equipment, or Accounts Receivable. Accounts receivable is an account that represents the debt owed to the business by clients. An asset account increases on the debit, or left side, of the account.��6H   $
��Wrap=�6q  $	��Top=�6�  $	��293��6�  $	��123��6�  �� 5      $%��\images\asset-image-colored.jpg��6   $
��Left=�6=   $	��100��6X   $��385,306,0,0q�6e   $	��Top=�6z   $	��100��6�   5      � 5   
   -   5        $��liabilityGrid��5      $y�	Collapsed=�6$   .+�5      �� 
�������$
��Left=�6*   $	��312��6E   $��267,150,0,0q�6R   
���   �$	��Top=�6v   $	��346��6�   �� 5      $
��Left=�6   $��295,175,0,0q�63   $����A liability can be thought of as debt to another entity. The most common example of a liability is the Accounts Payable account, which represents credit that the business owes to others. A liability account increases on the credit, or right side, of the account.��6H   $
��Wrap=�6V  $	��Top=�6j  $	��292��6�  $	��123��6�  �� 5      $)��#\images\liability-image-colored.jpg��6   $
��Left=�6A   $	��100��6\   $��387,307,0,0q�6i   $	��Top=�6~   $	��100��6�   5      � 5    
   -   5        $��oeGrid��5       $y�	Collapsed=�6   .+�5!      �� 
�������$
��Left=�6*   $	��312��6E   $��266,150,0,0q�6R   
���   �$	��Top=�6v   $	��346��6�   �� 5"      $
��Left=�6   $��294,174,0,0q�63   $����Owner's Equity is the business owner's investment into their company. An account that represents an owner's investment is a capital account. Many other accounts affect owner's equity including withdrawal, revenue, and expense accounts. An owner's equity account increases on the credit, or right side, of the account.��6H   $
��Wrap=�6�  $	��Top=�6�  $	��293��6�  $	��123��6�  �� 5#      $"��\images\oe-image-colored.jpg��6   $
��Left=�6:   $��76��6U   $��459,283,0,0q�6a   $	��Top=�6v   $��75��6�   �� 5$      $'��!\images\revenue-image-colored.jpg��6   $
��Left=�6?   $��74��6Z   $��459,373,0,0q�6f   $	��Top=�6{   $��75��6�   �� 5%      $(��"\images\expenses-image-colored.jpg��6   $
��Left=�6@   $��74��6[   $��346,373,0,0q�6g   $	��Top=�6|   $��75��6�   �� 5&      $*��$\images\withdrawal-image-colored.jpg��6   $
��Left=�6B   $��76��6]   $��346,283,0,0q�6i   $	��Top=�6~   $��75��6�   5'      �� 5)   
   -   5        $��accBtn��5)      $��What is Accounting?��6    $
��Left=�6>   $��
65,210,0,0q�6Y   $	��Top=�6m   $��35��6�   $	��132��6�   6�   �� 5*   
   -   5        $��assetBtn��5*      $��What is an Asset?��6!   $
��Left=�6=   $��
65,260,0,0q�6X   $	��Top=�6l   $��34��6�   $	��132��6�   6�   �� 5+   
   -   5        $��liabilityBtn��5+      $��What is a Liability?��6%   $
��Left=�6D   $��
65,318,0,0q�6_   $	��Top=�6s   $��34��6�   $	��132��6�   6�   �� 5,   
   -	   5        $��oeBtn��5,      $��What is Owner's Equity?��6   $
��Left=�6@   $��
65,376,0,0q�6[   $	��Top=�6o   $��34��6�   $	��132��6�   6�   �� 5-   
   ���#008013$��	0,496,0,0q�6#   68   5/      50      