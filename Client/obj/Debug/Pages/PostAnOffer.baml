   M S B A M L   `   `   `  ����
  Client    Client.Pages.PostAnOffer   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFirstFloor.ModernUI, Version=1.0.9.0, Culture=neutral, PublicKeyToken=bc9b0c37bf06c6a90mui&http://firstfloorsoftware.com/ModernUI  5      -   5          >�Name$  onloaded��5      .��5
      �    ContentRoot#��[  6   $��Center=�60   $��Center=�6M    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��60 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $	��200 �6   .+�5   
   �� $��3q�6   $��0��6   $��0��6(   $��Title:��68   �� 5   
   $��3q�6   $��1��6   $��0��6(   $��Description:��68   �� 5   
   $��3q�6   $��2��6   $��0��6(   $��	Category:��68   �� 5   
   $��3q�6   $��3��6   $��0��6(   $��	Location:��68   �� 5   
   $��3q�6   $��4��6   $��0��6(   $��Contact:��68   �� 5   
   $��3q�6   $��5��6   $��0��6(   $��Start:��68   �� 5   
   $��3q�6   $��6��6   $��0��6(   $
��End:��68   �� 5    
   -   5         ��Name$ postOfferTitle��5       $��1��6*   $��0��6:   $��3q�6G   �� 5!   
   -   5        $ postOfferDescription��5!      $��1��60   $��1��6@   $��3q�6M   �� 5"   
   -   5         ��Name$ postOfferCategory��5#       �� DisplayMemberPath$
 Name��5"   ;   $��1��5#   2   $��2��6B   $��3q�6O   ��5"      ��  �� Path$ 
Categories�5%      �� 5&   
   -   5        $ postOfferLocation��5&      $��1��6-   $��3��6=   $��3q�6J   �� 5'   
   -   5        $ postOfferContact��5'      $��1��6,   $��4��6<   $��3q�6I   (  "System.Windows.Controls.DatePicker  5(   
   -   5          Name$ postOfferStart��5(      $��1��6-   $��5��6=   $��3q�6J     5)   
   -   5        $ postOfferEnd��5)      $��1��6+   $��6��6;   $��3q�6H   �� 5*   
   -	   5         ��Name$ registerButton��5*      $��1��6H   $��7��6X   $��Right=�6e   $��90��5+      $��30��6   $��0,3,3,0q�6*   $��Publish��6;   51      52      