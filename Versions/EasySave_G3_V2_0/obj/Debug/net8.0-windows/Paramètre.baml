   M S B A M L   `   `   `  ����  EasySave_G3_V2_0    ParametresWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Paramètres��5   	   $	��500��6   $	��600��6)   ���#f5f5f5$
��Bold"�5      $��14(�60    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         HoverAccent �� Color �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   
BlurRadius	   Opacity
 �� Triggers P� Property P� Value��%�  &	        '�� !     7   �� 5
   
   $ #7E57C2��6.   �� 5   
   " ��6   .�5      ��  � �� �#e0e0e06+   �� 5       � ��
 �   �6+   �� 5       � ��$	 5,2q�6(   �� 5       � ��$	 5,0q�6'   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� �#b0b0b06,   �� 5       � ��$ 1q�60   �� 5       � ��$ SemiBold"�6+   �� 5       �@J�Effect 5        5      $ 1Q�6'   $ 2Q�67   $		 0.2Q�6F   5      
 5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � ��8   63   �� 5       � ��
 �����63   5      5      5       .��5"      �� $
��Auto=�6   .��5#   
   �� $��20q�6   .+�5&      �� $��🎛️ Paramètres��6   $��24(�6.   ���#444$��0,0,0,15q�6N   �� 5)      .+�5,      �� $ ��📝 Format du fichier log��6   ���#E3F2FD$��0,0,0,10q�5-   0   ���#90CAF9$��1q�6X   $��10q�6l   .��5.      ��  �� Orientation$ 
Horizontal=�6!   .+�5/      �� -   5         ��Name$ 
CB_TypeLog��5/   #   $	��150��67   .@�50      �� $
��JSON��6+   �� 51      $	��XML��6+   52      53      54      �� 57      $!��🔐 Extensions à chiffrer��6   ���#E8F5E9$��0,0,0,10q�58   0   ���#A5D6A7$��1q�6X   $��10q�6l   .��59      �� .+�5:      �� $ 
Horizontal=�6%   $��0,0,0,5q�6>   .+�5;      �� -   5        $��TxtNouvelleExtension��5;   &   $	��120��6B   �� 5<      -   5        $��Ajouter��5<   %   67   �� 5=      -   5        $��	Supprimer��5=   %   69   5>      �� 5?      -   5        $��LstExtensions��5?   "   $��80��67   5@      5A      �� 5D      $#��📦 Logiciels métier (.exe)��6   ���#FFFDE7$��0,0,0,10q�5E   0   ���#FFF59D$��1q�6X   $��10q�6l   .��5F      �� .+�5G      �� $ 
Horizontal=�6%   $��0,0,0,5q�6>   .+�5H      �� -   5        $��TxtNouveauLogiciel��5H   &   $	��220��6@    �� 
IsReadOnly$
 True��6L   �� 5I      -   5        $��	Parcourir��5I   %   69   �� 5J      -   5        $��Ajouter��5J   %   67   �� 5K      -	   5        $��	Supprimer��5K   %   69   5L      �� 5M      -
   5        $��LstLogiciels��5M   "   $��80��66   5N      5O      �� 5R      $ ��🌐 Langue de l'interface��6   ���#F3E5F5���#CE93D8$��1q�5S   F   $��10q�6Z   .��5T      �� $ 
Horizontal=�6!   .+�5U      �� -   5        $ 	CB_Langue��5U   #   $	��150��66   .@�5V      �� $��Anglais��6+    �� 
IsSelected$
 True��6=   �� 5W      $��	Français��6+   �� 5X      $��Allemand��6+   5Y      5Z      5[      5]      �� 5`      $ 
Horizontal=�6   $��Center=�62   $��0,20,0,0q�6O   .+�5a      �� -   5        $��Valider��5a      $	��120��6+   67   �� 5b      -   5        $��Annuler��5b      $	��120��6+   67   5c      5e      5f      5g      