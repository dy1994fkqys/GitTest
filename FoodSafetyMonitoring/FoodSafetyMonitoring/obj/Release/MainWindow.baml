   M S B A M L   `   `   `  ����   食品安全监测%    FoodSafetyMonitoring.MainWindow   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml      � Title$  
MainWindow�� � AllowsTransparency .   � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � WindowState$ Normal=�
������  � Icon$ 	/logo.ico�� � 
ResizeMode$ NoResize=� � 	Resources  �� 
TargetType	 �� Property
 �� Value �� 
TargetType ��Name �� CornerRadius � ColumnDefinitions �� TextAlignment
 � Tag !� Visual F�Name �� Triggers P� Property P� Value �� 
TargetName   img �� Triggers �� ScaleX �� ScaleY��%�  '��       &	  �    �� " ��.��� 	 � ��
 �� " ��.R��� $ layout��
�������$��1,1,1,0q�#��z��$ 3��$��2,0,2,0q�._�� $��20�� �� �� $��25 �.+��� $ Center=�#��z��$��0��$��4,0,3,0q�$��宋体)�$��Center=�$��Center=�$��14(��� -   $��X��$��1��$��8��$��8��$��4,1,3,2q�# z��$��Center=���Z� ��Z� ���� .R�� .+��� ��!�  F� $ btnPath��+����        р�� ��� �    ��� р��     	
�������$��1�� P�  �@J�IsMouseOver . . ��� $ btnPath��	 � ��

 �  �� P�  �@��
IsSelected . . ��� 	 � ��

 ������� $ layout��	 � ��$
 
2,0,2,-1.5q�P�  �@��
IsSelected .  . ��� 	 � ��

 ������� " ��.��� 	 � ��$
 Center=��� 	 �@J�RenderTransformOrigin$
 0.5,0.5&��� 	 �@J�Opacity$
 1Q� P�  �@J�IsMouseOver . . ��� 	 � z�
 �� $	 1.1Q�$	 1.1Q��� 	 �@J�Opacity$
 1Q�.��� -    �Name$ g1�� � RowDefinitions �� $��28 ��� $��94 ��� $��27 ��� $��* ��� $��33 �.+�� -   $ grid_header��$��0������  �� ImageSource$ /res/title_bar.jpg�� �� $
��auto ��� �� $
��auto �.+���  �� Orientation$ 
Horizontal=�$
��Left=�$��20,0,5,0q�.+��� -    ��Name$ _date��$��宋体)�$��14(�$��Center=�
���   �$��Center=�$��0,0,20,0q��� -   $ _user��$��宋体)�$��14(�$��Center=�
���   �$��Center=�$��0,0,20,0q�加载中……n� -   $��1��
������  J� Opacity$ 0Q��� $ 
Horizontal=�$��2��$��Right=�$��Center=�$��5,0,5,0q�.+��� -     ��Name$	  min��$��25��$��25��#��[  $��/res/min.png��! � ToolTip$! 缩小��$��0,0,5,0q��� -   $	  max��$��25��$��25��#��[  $��/res/max.png��$! 	最大化��$��0,0,5,0q��� -	   $
  exit��$��25��$��25��#��[  $��/res/close.png��$! 关闭��$��0,0,5,0q�� -
   $ grid_MainMenu��$��1������ $ /res/mainmenu_bar.jpg�� �� $	��312 ��� �� $��89 ��� $��89 ��� $��89 ��� $��89 ��� $��89 ��� $��89 ��� $��89 ��� $��89 ��� $��89 �.+��� -   $  _title��$��/res/title.jpg���� -   $ _title_dept��$��楷体)�$��22(�$	��600"�$��Center=�
�������$��
100,0,10,0q��� -   $  _first��$��2��$��/res/firstpage_normal.jpg���� $��首页��$��2��$��宋体)�
�������$��14(�$��Center=�$��Bottom=�$��0,0,0,5q��� -   $  _detect��$��3��$��/res/detect_normal.jpg���� $��新建检测单��$��3��$��宋体)�
�������$��14(�$��Center=�$��Bottom=�$��0,0,0,5q��� -   $  _report��$��4��$��/res/report_normal.jpg���� $��统计报表��$��4��$��宋体)�
�������$��14(�$��Center=�$��Bottom=�$��0,0,0,5q��� -   $  	_analysis��$��5��$��/res/analysis_normal.jpg���� $��统计分析��$��5��$��宋体)�
�������$��14(�$��Center=�$��Bottom=�$��0,0,0,5q��� -   $  _task��$��6��$��/res/task_normal.jpg���� $��检测任务��$��6��$��宋体)�
�������$��14(�$��Center=�$��Bottom=�$��0,0,0,5q��� -   $  _warning��$��7��$��/res/warning_normal.jpg���� $��风险预警��$��7��$��宋体)�
�������$��14(�$��Center=�$��Bottom=�$��0,0,0,5q��� -   $  _system��$��8��$��/res/system_normal.jpg���� $��系统管理��$��8��$��宋体)�
�������$��14(�$��Center=�$��Bottom=�$��0,0,0,5q��� -   $  _help��$��9��$��/res/help_normal.jpg���� $��帮助��$��9��$��宋体)�
�������$��14(�$��Center=�$��Bottom=�$��0,0,0,5q�� $��2������ $ /res/childmenu_bar.jpg�� �� �� $	��712 ��� $��89 �.+�� -   $ 	grid_Menu��$��1������ -   _childmenubar��$ /res/childmenu_bar.jpg��� -   $ grid_Component��$��3��.+��� -   " ��Name$
" _tab��� -   $ grid_bottom��$��4������ $ /res/bottom_bar.jpg��.+��� 2  ,System.Windows.Markup.XmlAttributeProperties#  XmlSpace# preserve$��	0,0,120,0q�$��宋体)�$��14(�
���   �$��Right=�$��Center=�nl智锐达仪器科技南通有限公司版权所有    版本号：1.0    技术服务热线：0513-89169777