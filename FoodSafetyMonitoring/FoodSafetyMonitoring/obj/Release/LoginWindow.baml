   M S B A M L   `   `   `  ����   食品安全监测&     FoodSafetyMonitoring.LoginWindow   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    -   $	��379��$	��477��  � WindowStyle$
  None=� � AllowsTransparency . 
������ 
������  � 
ResizeMode$ NoResize=� � Topmost .  � WindowStartupLocation$ CenterScreen=� � 	Resources  �� MergedDictionaries �� Source��  �� $" Manager/Themes/combobox.xaml?��� $$ Manager/Themes/ImageLabel.xaml?��� $  Manager/Themes/Shared.xaml?��� $" Manager/Themes/CheckBox.xaml?�%    .���� $	��430��$	��315������  �� ImageSource$ /res/login.jpg��.+�n� -   $	��438��$��80��
������ 	 J� Opacity$	 0Q��� -   
 ��Name$	
 min��$��15��$��15��$��/res/small.png�� � ToolTip$ 	最小化��$	��Top=� �� Left$	 390��
 �� Top$ 1���� -   $

 exit��$��15��$��15��$��/res/shut.png��$ 关闭��$��Right=�$	��Top=�$	 410��$ 1���� -   $��cmbName��$��25��$	��192��$	 141��$	 169��$��0q�$��Center=�$
��Left=�
������  �� 
IsEditable .  �� SelectedIndex$ 0��G� -    G�Name$ 	_password��$��20��$��Center=�$	��187��$
��Left=�$	 148��$	 207��   DisabledForegroundBrush#��[  
������ $��0q��� -   $
 _login��$��/res/loginButton.png��$��30��$	��159��$	 153��$	 270�� � Cursor$
 Hand��$
��Fill=�����  �� 
TargetType" ��.���  �� Property � �� �� Value$ Center=���  �@J�RenderTransformOrigin$ 0.5,0.5&���  �@J�Opacity$ 1Q���  � z� ��  �� ScaleX$ 1Q� �� ScaleY$ 1Q�scaleTransform�� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � z� �� $	 1.1Q�$	 1.1Q���  �@J�Opacity$ 1Q��� -   $��txtMsg��$	 269��$	 241��$��21��$	��162��
���  ��$��12(�$��Center=�$��Center=��� -	   $��_rememberPassword��$��16��$	 190��$	 241��$��80��.��记住密码