   M S B A M L   `   `   `  ����  食品安全监测%    FoodSafetyMonitoring.MainWindow   5   	   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5        � Title$  
MainWindow��5       � AllowsTransparency .   � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$
 None=�6[    � WindowState$ Normal=�6n   
������  � Icon$ 	/logo.ico��6�    � 
ResizeMode$ NoResize=�6�    � 	Resources 5       �� 
TargetType	 �� Property
 �� Value �� 
TargetType ��Name �� CornerRadius � ColumnDefinitions �� TextAlignment
 � Tag !� Visual F�Name �� Triggers P� Property P� Value �� 
TargetName   img �� Triggers �� ScaleX �� ScaleY��%�  '��       &	  �    �� 5   
   " ��6   .�5      �� 	 � ��
 5      �� 5	      " ��6&   .R�5
      �� $ layout��6!   
�������$��1,1,1,0q�6D   #��z��6^   $ 3��5   !   $��2,0,2,0q�62   ._�5      � $��20��6#    5   "   �� 5   &   �� 5   &   $��25 �67   .+�5   "   �� $ Center=�6-   #��z��6D   $��0��6d   $��4,0,3,0q�6t   $��宋体)�6�   $��Center=�5      $��Center=�6)   $��14(�6F   �� 5      -   5        $��X��5      $��1��6   $��8��60   $��8��6;   $��4,1,3,2q�6E   # z��5      $��Center=�5   8   ��6   Z� ��6!   Z� ��5      �� 5      .R�5      � .+�5      �� ��5      !� 5       5      F� 5      $ btnPath��6   +����        р�� ��� �    ��� р��     	
�������$��1��5      5!      5#      5$       5%      P� 5&       �@J�IsMouseOver . . �5'      �� $ btnPath��6   	 � ��

 �  ��6>   5(      5*      5,      5-      5.       5/      P� 50       �@��
IsSelected . . �51   "   �� 	 � ��

 �����6?   �� 52   "   $ layout��6)   	 � ��$
 
2,0,2,-1.5q�6O   53      P� 54       �@��
IsSelected .  . �55   "   �� 	 � ��

 �����6?   56      58      5:      5;      �� 5<   
   " ��6   .�5=      �� 	 � ��$
 Center=�64   6E   �� 5>      	 �@J�RenderTransformOrigin$
 0.5,0.5&�66   6H   �� 5?      	 �@J�Opacity$
 1Q�6(   64    5@      P� 5A       �@J�IsMouseOver . . �5B      �� 	 � z�
 5C      �� 5D      $	 1.1Q�6-   $	 1.1Q�6:   5F      �� 5G      	 �@J�Opacity$
 1Q�60   5H      5I      5K      5L      .��5M      � -   5         �Name$ g1��5M       � RowDefinitions 5Q   
   �� 5R      $��28 �6   �� 5S      $��94 �6   �� 5T      $��27 �6   �� 5U      $��* �6   �� 5V      $��33 �6   .+�5X   
   � -   5        $ grid_header��5X      $��0��6   ��5Y      �� 5Z       �� ImageSource$ /res/title_bar.jpg��6   6@    5\      �� 5]      $
��auto �6#   �� 5^      �� 5_      $
��auto �6#   .+�5a      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   $��20,0,5,0q�6M   .+�5b      �� -   5         ��Name$ _date��5b      $��宋体)�6+   $��14(�6;   $��Center=�6I   
���   �$��Center=�6x   $��0,0,20,0q�6�   6�   �� 5c      -   5        $ _user��5c      $��宋体)�6+   $��14(�6;   $��Center=�6I   
���   �$��Center=�6x   $��0,0,20,0q�6�   加载中……6�   5d      n� 5e      -   5        $��1��5e      
������  J� Opacity$ 0Q�6Y   6g   �� 5f      $ 
Horizontal=�6   $��2��63   $��Right=�6C   $��Center=�6`   $��5,0,5,0q�6{   .+�5g      �� -   5          ��Name$	  min��5g   c   $��25��6   $��25��6#   #��[  6/   $��/res/min.png��6M   ! � ToolTip$! 缩小��6�   $��0,0,5,0q�6�   �� 5h      -   5        $	  max��5h   c   $��25��6   $��25��6#   #��[  6/   $��/res/max.png��6M   $! 	最大化��6�   $��0,0,5,0q�6�   �� 5i      -	   5        $
  exit��5i   e   $��25��6   $��25��6#   #��[  6/   $��/res/close.png��6M   $! 关闭��6�   $��0,0,5,0q�6�   5j      5k      � 5l   
   -
   5        $ grid_MainMenu��5l      $��1��6   ��5m      �� 5n      $ /res/mainmenu_bar.jpg��6   6C    5p      �� 5q      $	��312 �6#   �� 5r      �� 5s      $��89 �6#   �� 5t      $��89 �6#   �� 5u      $��89 �6#   �� 5v      $��89 �6#   �� 5w      $��89 �6#   �� 5x      $��89 �6#   �� 5y      $��89 �6#   �� 5z      $��89 �6#   �� 5{      $��89 �6#   .+�5}      �� -   5        $  _title��5}      $��/res/title.jpg��6$   �� 5~      -   5        $ _title_dept��5~      $��楷体)�6.   $��22(�6>   $	��600"�6L   $��Center=�6]   
�������$��
100,0,10,0q�6�   6�   �� 5      -   5        $  _first��5      $��2��6$   $��/res/firstpage_normal.jpg��64   �� 5�      $��首页��6   $��2��6"   $��宋体)�62   
�������$��14(�6V   $��Center=�6d   $��Bottom=�6�   $��0,0,0,5q�6�   �� 5�      -   5        $  _detect��5�      $��3��6%   $��/res/detect_normal.jpg��66   �� 5�      $��新建检测单��6   $��3��6%   $��宋体)�65   
�������$��14(�6Y   $��Center=�6g   $��Bottom=�6�   $��0,0,0,5q�6�   �� 5�      -   5        $  _report��5�      $��4��6%   $��/res/report_normal.jpg��65   �� 5�      $��统计报表��6   $��4��6$   $��宋体)�64   
�������$��14(�6X   $��Center=�6f   $��Bottom=�6�   $��0,0,0,5q�6�   �� 5�      -   5        $  	_analysis��5�      $��5��6'   $��/res/analysis_normal.jpg��67   �� 5�      $��统计分析��6   $��5��6$   $��宋体)�64   
�������$��14(�6X   $��Center=�6f   $��Bottom=�6�   $��0,0,0,5q�6�   �� 5�      -   5        $  _task��5�      $��6��6#   $��/res/task_normal.jpg��63   �� 5�      $��检测任务��6   $��6��6$   $��宋体)�64   
�������$��14(�6X   $��Center=�6f   $��Bottom=�6�   $��0,0,0,5q�6�   �� 5�      -   5        $  _warning��5�      $��7��6&   $��/res/warning_normal.jpg��66   �� 5�      $��风险预警��6   $��7��6$   $��宋体)�64   
�������$��14(�6X   $��Center=�6f   $��Bottom=�6�   $��0,0,0,5q�6�   �� 5�      -   5        $  _system��5�      $��8��6%   $��/res/system_normal.jpg��65   �� 5�      $��系统管理��6   $��8��6$   $��宋体)�64   
�������$��14(�6X   $��Center=�6f   $��Bottom=�6�   $��0,0,0,5q�6�   �� 5�      -   5        $  _help��5�      $��9��6#   $��/res/help_normal.jpg��63   �� 5�      $��帮助��6   $��9��6"   $��宋体)�62   
�������$��14(�6V   $��Center=�6d   $��Bottom=�6�   $��0,0,0,5q�6�   5�      � 5�   
   $��2��6   ��5�      �� 5�      $ /res/childmenu_bar.jpg��6   6D    5�      �� 5�      �� 5�      $	��712 �6#   �� 5�      $��89 �6#   .+�5�      � -   5        $ 	grid_Menu��5�   #   $��1��6   ��5�      �� 5�      -   5        _childmenubar��$ /res/childmenu_bar.jpg��5�   8   6_   5�      5�      � 5�   
   -   5        $ grid_Component��5�      $��3��6'   .+�5�      �� -   5        " ��Name$
" _tab��5�      5�      5�      � 5�   
   -   5        $ grid_bottom��5�      $��4��6$   ��5�      �� 5�      $ /res/bottom_bar.jpg��6   6A   .+�5�      �� 2  ,System.Windows.Markup.XmlAttributeProperties#  XmlSpace# preserve6�   $��	0,0,120,0q�6   $��宋体)�6@   $��14(�6Q   
���   �$��Right=�6r   $��Center=�6�   nl智锐达仪器科技南通有限公司版权所有    版本号：1.0    技术服务热线：0513-891697776�   5�      5�      5�      