   M S B A M L   `   `   `  ����  食品安全监测&     FoodSafetyMonitoring.LoginWindow   5   	   R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      -   5        $	��379��5      $	��477��6     � WindowStyle$
  None=�6    � AllowsTransparency . 
������ 
������  � 
ResizeMode$ NoResize=�6~    � Topmost .  � WindowStartupLocation$ CenterScreen=�6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $" Manager/Themes/combobox.xaml?�6%   �� 5	      $$ Manager/Themes/ImageLabel.xaml?�6%   �� 5
      $  Manager/Themes/Shared.xaml?�6%   �� 5      $" Manager/Themes/CheckBox.xaml?�6%   %    5      .��5   
   �� $	��430��6   $	��315��6   ��5      �� 5       �� ImageSource$ /res/login.jpg��6   6<   .+�5      n� -   5        $	��438��5      $��80��6    
������ 	 J� Opacity$	 0Q�6E   6p   �� 5      -   5        
 ��Name$	
 min��5   D   $��15��6   $��15��6    $��/res/small.png��6,    � ToolTip$ 	最小化��6k   $	��Top=�6{    �� Left$	 390��6�   
 �� Top$ 1��6�   �� 5      -   5        $

 exit��5   C   $��15��6   $��15��6    $��/res/shut.png��6,   $ 关闭��6l   $��Right=�6z   $	��Top=�6�   $	 410��6�   $ 1��6�   �� 5      -   5        $��cmbName��5      $��25��6#   $	��192��6/   $	 141��6;   $	 169��6M   $��0q�6^   $��Center=�6r   $
��Left=�6�   
������  �� 
IsEditable .  �� SelectedIndex$ 0��6V  5      G� 5      -   5         G�Name$ 	_password��5      $��20��6-   $��Center=�69   $	��187��6\   $
��Left=�6h   $	 148��6�   $	 207��6�      DisabledForegroundBrush#��[  6�   
������ $��0q�6�   5      �� 5      -   5        $
 _login��5      $��/res/loginButton.png��6$   $��30��6B   $	��159��6N   $	 153��6Z   $	 270��6l    � Cursor$
 Hand��6�   $
��Fill=�6�   ��5      �� 5        �� 
TargetType" ��6   .�5!      ��  �� Property � �� �� Value$ Center=�6<   6M   �� 5"       �@J�RenderTransformOrigin$ 0.5,0.5&�6>   6P   �� 5#       �@J�Opacity$ 1Q�60   6<   �� 5$       � z� 5%      �� 5&       �� ScaleX$ 1Q�6-    �� ScaleY$ 1Q�68   scaleTransform��6C   5(       �� Triggers 5)      P� 5*       P� Property �@J�IsMouseOver P� Value . . �5+      ��  � z� 5,   "   �� 5-   &   $	 1.1Q�65   $	 1.1Q�6B   5/      �� 50       �@J�Opacity$ 1Q�68   51      52      54      56      �� 57      -   5        $��txtMsg��57   G   $	 269��6   $	 241��6*   $��21��6;   $	��162��6U   
���  ��$��12(�6s   $��Center=�6�   $��Center=�6�   �� 59      -	   5        $��_rememberPassword��59      $��16��60   $	 190��6<   $	 241��6N   $��80��6_   .��6k   记住密码6q   5:      5;      