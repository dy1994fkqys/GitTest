   M S B A M L   `   `   `  ����M  I食品安全监测, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:FoodSafetyMonitoring.Manager.UserControls)FoodSafetyMonitoring.Manager.UserControls  5      1    +FoodSafetyMonitoring.Manager.SysUserManager   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      Nusercontrols7clr-namespace:FoodSafetyMonitoring.Manager.UserControls    5      Z VWPFToolkit.Extended, Version=1.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4Z	toolkitexJhttp://schemas.microsoft.com/winfx/2006/xaml/presentation/toolkit/extended  5        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5	      $" Themes/ImageButtonStyle.xaml?�6%   �� 5
      $ Themes/TextBox.xaml?�6%   �� 5      $ Themes/PasswordBox.xaml?�6%   �� 5      $ Themes/ComboBox.xaml?�6%   �� 5      $ Themes/TextBlock.xaml?�6%   �� 5      $ Themes/StackPanel.xaml?�6%   �� 5      $ Themes/Image.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   $��6��6,   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $
��0.6* �6   �� 5      $	��12* �6   �� 5      $��68 �6   .+�5   
   � 
������� 5      �� 5       $
��auto �6#   �� 5!      $
��auto �6#   .+�5#      �� $��宋体)�6   $��用户列表��6*   $	��600"�66   $��10,0,0,0q�6G   D   >FoodSafetyMonitoring.Manager.UserControls.TextboxSearchControl  5$      -   5          Name$ 	txtSearch��5$   0   D   >FoodSafetyMonitoring.Manager.UserControls.TextboxSearchControl   
ImageClick$% TextboxSearchControl_ImageClick��6C   $��1��6p   $��35��6�   $	��Top=�6�   $	��220��6�   5%      �� 5&   
   -   5        $��lvlist��5&      $��0q�69   $��1��6M   $��10,10,10,10q�6Z   ��6!   �� ��5'      �� 5(       �� 
TargetType" ��6   .�5)      ��  �� Property � ��	 �� Value$	 30��6/   �� 5*       � ��$	 0q�6/   5+      ��5-      �� 5.      .R�5/      �� $
��Auto=�6#   $
��Auto=�6F   .��50      �� 51      52      
 �� View
 54      �� 55      ! �� ColumnHeaderContainerStyle 56      �� 57      .�58      ��  � ��$	 0��6H   �� 59       � y�$	 Hidden=�6L   5:      .P�5<      ��  �� CellTemplate 5=      �� 5>      .R�5?   "   ��  ��Name$ 	imageLogo��6(   $��20��6;   $��Images/role.png��6F   6b   5@      5B      �� 5C       5D      �� 5E      .R�5F   "   �  5G   &   �� 5H   *   $��25 �68   �� 5I   *   .+�5K   &   �� $��0��60   
���   �$��14(�6l   $	��180��6z   $��宋体)�6�   $��Center=�6�   ��6>   �� *	INFO_USER+6�   �� 5L   &   $��1��60   ��6=   �� *	INFO_NAME+6[   5M   #   5N      5P      �� 5Q       5R      �� 5S      .R�5T   "   �� $��	btnModify��6)   -   5        $��20��5T   :   $��20��6E    !  ListModifyImageButtonTemplate#��[  6R   
 � Tag 6�   �� *	RECO_PKID+6�   5U      5W      �� 5X       5Y      �� 5Z      .R�5[   "   �� $��	btnDelete��6)   -   5        $��20��5[   :   $��20��6E    ! ListDeleteImageButtonTemplate#��[ 6Q    6�   �� *	RECO_PKID+6�   5\      5^      5_      5a      �� 5b   
   -   5        $��	btnCreate��5b      $	��104��6#   $��38��6/   $��2��6=     CreateImageButtonTemplate#��[ 6K   $	��Top=�6�   $��Center=�6�   �� 5c   
   $��1��6   $��Stretch=�6'   $��Center=�6C   $��6��6`   $��3��6j   6}   � 5d   
   $��2��6   
�������.+�5e      �� $��详细信息��6   $	��600"�6%   $��宋体)�66   5f      � 5g   
   $��1��6   $��2��6   $��Center=�6,   $��	0,30,0,30q�6I   ��5h      �� 5i       �� ImageSource$&  /Manager/Images/content_back.png��6    j� Stretch$
 Fill=�6L   6]   .+�5k      � $��80,20,80,20q�6    5l      �� 5m      $��* �6$   �� 5n      $��* �6$   �� 5o      $��* �6$   �� 5p      $��3* �6$   �� 5q      $��5* �6$    5s      �� 5t      �� 5u      �� 5v      $	��100 �6'   �� 5w      .+�5y      �� $��0��6   
登录名:65   �� 5z      -   5        $��
_loginName��5z   *   $��1��6   $��Center=�6a   $	��180��6|   6�   �� 5{      $��2��6   	姓名:62   �� 5|      -   5        $��txtUserName��5|   *   $��3��6   $��Center=�6b   $	��180��6}   6�   �� 5~      $��1��6   $��0��6)   $��Center=�6:   角色类型:6\   �� 5      -   5        $��cmbRoleType��5      $��1��6.   $��1��6;   
������� �� MaxDropDownHeight$	 200��6^   �� 5�      $��1��6   $��2��6)   $��Center=�6;   所属部门:6]   �� 5�      -	   5        $��_department��5�      $��1��6.   $��3��6;   
�������$	 200��6^   6v   �� 5�      $��2��6   $��0��6)   启用时间:6A   A   ;FoodSafetyMonitoring.Manager.UserControls.DatePickerControl  5�      -
   5          Name$ dtpStartDate��5�   1   $��2��6G   $��1��6T   $��Center=�6d      Format$ 	ShortDate=�6   6�   �� 5�      $��2��6   $��2��6)   停用时间:6A     5�      -   5        $ 
dtpEndDate��5�   1   A   ;FoodSafetyMonitoring.Manager.UserControls.DatePickerControl   GotFocus$ FrameworkElement_GotFocus��6�   $��2��6E   $��3��6R   $��Center=�6c   $ 	ShortDate=�6~   6�   �� 5�      2  ,System.Windows.Markup.XmlAttributeProperties  XmlSpace preserve6;   $��3��6   $��0��6)   备    注:6[   �� 5�      -   5        $��
txtComment��5�      $��3��6-   $��1��6:   $��3��6J    �� TextWrapping$
 Wrap=�6_   $
��Left=�6s   $	��500��6�   $��80��6�   " �� VerticalScrollBarVisibility$
 Auto=�6�   �� 5�      -   5        $��txtMsg��5�      $��4��6,   $��4��69   
���  ��$��14(�6_   $��宋体)�6m   6�   5�      5�      �� 5�   
   $��2��6   $��2��6"    �� Orientation$ 
Horizontal=�62   $��Center=�6K   $	��Top=�6h   .+�5�      �� -   5        $��btnSave��5�      $��84��6$   $��38��6/   $��2��6=     SaveImageButtonTemplate#��[ 6M   $��0,0,20,0q�6�   �� 5�      -   5        $��	btnCancel��5�      $��84��6&   $��38��61   $��3��6>     CancelImageButtonTemplate#��[ 6N   $��	20,0,20,0q�6�   �� 5�      -   5        $��btnReset��5�      $��84��6%   $��38��60   $��3��6=     ResetImageButtonTemplate#��[ 6M   $��20,0,0,0q�6�   5�      5�      5�      