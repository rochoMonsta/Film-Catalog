   M S B A M L   `   `   `  ����F  BFilmCatalog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FilmCatalog.ViewsFilmCatalog.Views  5      +    %FilmCatalog.Views.AuthorizationWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:FilmCatalog.Views     5      V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5        $
��1080��5	      $	��600��5
        � 
ResizeMode$  NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � DataContext 5      �� *AuthorizationViewModel+   Locator �� Source# [  .��5      � ��5   
   �� 5       �� 
StartPoint$ 0.1, 0&�6"    �� EndPoint$ 0.9, 1&�66   .��5      �  � Offset$ 1Q�6     PurplePC � Color# [ 6*   � 5      $ 0Q�6     LightPurplePC# [ 6*   5      .+�5   
   �� $	��540��5      $	��Top=�5      
���   �	 �� CornerRadius$	 0, 0, 180, 0��5      �� 5   
   
 �� Orientation$
 
Horizontal=�6   .+�5      �� $	��500��6   .+�5      �� $	��400��5       $��15,60,15,30q�5!      $��Center=�5"      $	��Top=�5#      $+��%/Resources/Images/FilmMainPicture.png��5$      5%      �� 5&      -   5        $	��500��5(      $��0,60,0,0q�5)        
TabControl#��[ 5*      .@�5+      �� $	��248��5,       ! AuthorizationUserSignInButton#���  5-        TabItem#��[ 5.      .��5/      �� $��20,40q�6!   .+�50      �� $��10q�6%   $
 
Horizontal=�61   .+�51      '  !MaterialDesignThemes.Wpf.PackIcon  $��35��52   !   $��35��53   !   
�������   Kind$
 User=�55   !   �� 56      $	��405��57   !   $��35��58   !   $
��10,0q�59   !     AuthorizationUserLoginHint)  #MaterialDesignThemes.Wpf.HintAssist   Hint# �  5:   !     AuthorizationTextBox#��[ 5;   !    � ToolTip# �  5=   !   ��5<   !   �� *	UserLogin+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5=   !   5>      �� 5?      $��10q�6%   $
 
Horizontal=�61   .+�5@        $��35��5A   !   $��35��5B   !   
�������$
 Lock=�5D   !   G� 5E      -   5        $��passwordLoginBox��5F   !   $	��405��5H   !   $��35��5I   !   $
��10,0q�5J   !     AuthorizationPasswordBox#��[ 5K   !    !	 AuthorizationUserPasswordHint# � 	 5L   !    � Cursor$ IBeam��6[   5M      �� 5N      $��Center=�6%   .+�5O      ��  
 AuthorizationErrorLabel#��[
 6G   ��6$   �� *ErrorLabelText+6G   �� 5P      -   5        $	��100��5Q   !   $��40��5R   !   $��Center=�5S   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5T   !     PurpleC#���  5U   !   #���  5V   !   $��2q�5W   !     AuthorizationLoginButton#���  5Y   !   $
 Hand��5Z   !   
�������  MaterialDesignRaisedButton#��[ 5\   !   5]      5^      5_      �� 5`      $	��248��5a       ! AuthorizationUserSignUpButton#���  5b      #��[ 5c      .��5d      �� $��20,40q�6!   .+�5e      �� $��10q�6%   $
 
Horizontal=�61   .+�5f        $��35��5g   !   $��35��5h   !   
�������$
 User=�5j   !   �� 5k      $	��405��5l   !   $��35��5m   !   $
��10,0q�5n   !   # �  5o   !   #��[ 5p   !   # �  5r   !   ��5q   !   �� *	UserLogin+$ TwoWay=�$ PropertyChanged=�5r   !   5s      �� 5t      $��10q�6%   $
 
Horizontal=�61   .+�5u        $��35��5v   !   $��35��5w   !   
�������$
 Lock=�5y   !   G� 5z      -   5        $��passwordRegisterBox��5{   !   $	��405��5}   !   $��35��5~   !   $
��10,0q�5   !   #��[ 5�   !   # � 	 5�   !   5�      �� 5�      $��10q�6%   $
 
Horizontal=�61   .+�5�        $��35��5�   !   $��35��5�   !   
�������$ 	LockCheck=�5�   !   G� 5�      -   5        $ ��confirmPasswordRegisterBox��5�   !   $	��405��5�   !   $��35��5�   !   $
��10,0q�5�   !   #��[ 5�   !    ( $AuthorizationUserConfirmPasswordHint# �  5�   !   5�      �� 5�      $��10q�6%   $��Center=�61   .+�5�      �� #��[
 6G   ��6$   �� *ErrorLabelText+6G   �� 5�      -   5        $	��100��5�   !   $��40��5�   !   $��Center=�5�   !   $ 10��5�   !   #���  5�   !   #���  5�   !   $��2q�5�   !     AuthorizationRegisterButton#���  5�   !   $
 Hand��5�   !   
�������#��[ 5�   !   5�      5�      5�      5�      �� 5�      $��80��6   .+�5�      �� -   5        $��40��5�      $��40��5�      $��10,20q�5�      $
 Hand��5�       & "MaterialDesignFloatingActionButton#��[ 5�       ' #AuthorizationUserCloseButtonToolTip# �  5�      ��5�      Z� .��5�        $��30��5�      $��30��5�      
�������$ Close=�5�      5�      5�      5�      5�      5�      