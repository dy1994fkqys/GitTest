   M S B A M L   `   `   `  ����   食品安全监测/    )FoodSafetyMonitoring.Manager.SetTaskGrade   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    $	��400��$	��200��  � WindowStyle$
  None=� � Topmost .  � WindowStartupLocation$ CenterScreen=�
������  � 
ResizeMode$ NoResize=� � 	Resources  �� MergedDictionaries �� Source��  �� $ Themes/TextBlock.xaml?��� $ Themes/TextBox.xaml?�%    .���  � RowDefinitions �� $��40 ��� $	��160 �.+�� ����  �� ImageSource$! ../res/条件栏背head.png��	 j� Stretch$
	 Fill=�.+�� $��0��$��40��.+�n� -   $	��380��$��10��
������ 
 J� Opacity$
 0Q��� $��30��$	��347��$
��Left=�参数重置�� -    ��Name$
 exit��$��31��$��30��$��../res/close1.png�� � ToolTip$ 关闭��$��Right=�$	��Top=�� $��1������ $! ../res/信息栏背body.png��$
	 Fill=� �� $��50 ��� $��30 ��� $��40 �.+�� $��0��.+��� .+��� -    ��Name$ _grade_down��$	��100�� �� Left$ 70��
 �� Top$ 20���� $��宋体)�$��16(�$��%��$��20��$	 180��$ 20��$��0q��� $��宋体)�$��16(�$��-��$��20��$��Center=�$	 200��$ 20��$��0q��� -   $ 	_grade_up��$	��100��$	 220��$ 20���� $��宋体)�$��16(�$��%��$��20��$��Center=�$	 330��$ 20��$��0q��� -    ��Name$ _txtmsg��$��1��$��宋体)�$��14(�$	��200��
���  ��$��Center=��� -   $��btnSave��$��2��$��80��$��28��.��确定