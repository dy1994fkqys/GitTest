   M S B A M L   `   `   `  ����M  I食品安全监测, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:FoodSafetyMonitoring.Manager.UserControls)FoodSafetyMonitoring.Manager.UserControls  5      1    +FoodSafetyMonitoring.Manager.SysWarningInfo   5      R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      Nusercontrols7clr-namespace:FoodSafetyMonitoring.Manager.UserControls    5        � 	Resources  5       �� MergedDictionaries �� SourceC   =FoodSafetyMonitoring.Manager.UserControls.BackGroundConverter   
_converter  _style_listviewItem �� 
TargetType �� Property �� Value �� 	Converter �� RelativeSource�� 5   
    5      �� 5      $ Themes/ComboBox.xaml?�6%   �� 5	      $ Themes/TextBlock.xaml?�6%   �� 5
      $ Themes/StackPanel.xaml?�6%   �� 5      $" Themes/ImageButtonStyle.xaml?�6%   %�   &	        &	      7     5      6/   �� 5      " ��60   .�5      ��  � �� 5      �� 5      8    6"   �� *Self+6I   5      �� 5       � ��
 �   �6?   5      5      .��5       �  � RowDefinitions 5!   
   �� 5"      $��* �6   �� 5#      $��* �6   �� 5$      $��30 �6   �� 5%      $��12.5* �6   .+�5'   
   � $��0��6   .+�5(      �� .+�5)      �� $��10��6   设置日期:62   A   ;FoodSafetyMonitoring.Manager.UserControls.DatePickerControl  5+      -   5        	  Name$	 reportDate_kssj��5+   1   $��Center=�6J   
   Format$
 	ShortDate=�6e   �� 5,      $��10��6   $��5,0,0,0q�6+   至6?     5-      -   5        $	 reportDate_jssj��5-   1   $��Center=�6J   $
 	ShortDate=�6e   5.      5/      � 50   
   $��1��6   .+�51      �� .+�52      �� 2  ,System.Windows.Markup.XmlAttributeProperties  XmlSpace preserve62   $��10��检测站点:6H   �� 53      -   5        $��_detect_dept��53      
������� �� MaxDropDownHeight$	 200��6B   $	��150��6Z   �� 54       preserve62   $��10��检测项目:6H   �� 55      -   5        $��_detect_item��55      
�������$	 200��6B   $	��150��6Z   �� 56       preserve62   $��10��检测对象:6H   �� 57      -   5        $��_detect_object��57      
�������$	 200��6D   $	��150��6\   �� 5:      -   5        $��_query��5:      $��84��6'   $��38��62     SelectImageButtonTemplate#��[ 6>   $��50,0,0,0q�6q   $��Center=�6�   6�   �� 5;      -   5        $��_export��5;      $��84��6(   $��38��63     ExportImageButtonTemplate#��[ 6?   $��50,0,0,0q�6r   $��Center=�6�   6�   5<      5=      �� 5>   
   -   5         ��Name$ _title��5>      $��2��6$   $��16(�61   $	��100"�6?   $
��Left=�6P   $��Center=�6k   6�   � 5?   
   -	   5         �Name$ 	grid_info��5?      $��3��6   .+�5@      K   EFoodSafetyMonitoring.Manager.UserControls.UcTableOperableView_NoTitle  -
   5          Name$ 
_tableview��5@   7   
������ $��5q�6d   5U      5V      5W      