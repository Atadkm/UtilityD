   M S B A M L   `   `   `  ���� C  ?UtilityD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:UtilityDUtilityD      UtilityD.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:UtilityD     _ [ICSharpCode.AvalonEdit, Version=6.0.1.278, Culture=neutral, PublicKeyToken=9cc39be672370310?
avalonedit.http://icsharpcode.net/sharpdevelop/avalonedit  -     � Title$  Utility��$	��320��$	��575��
������  � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�.��� .+��� ���	#FF323232 �� CornerRadius$ 4��
������ $��10,10,135,10q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect  ._�� $	��300��$	��Top=�.+��� ���	#FF1E1E1E$ 
4, 4, 0, 0��$��	0,0,0,270q�._�� -    �Name$ TopBox1��
������ .+���  �� BitmapScalingMode$ HighQuality=�$��Images/Utility Logo.png��$��	2,2,403,1q��� -   	 ��Name$	 MiniButton1��$��Segoe MDL2 Assets)�$	����   UniversalButtons#��[  
������ 
������ $��Right=�$	��Top=�$��30��
�������$��0,0,30,0q�$��29���� -   $	 CloseButton1��$��Segoe MDL2 Assets)�$	����#��[  
������ 
������ $
��Left=�$	��Top=�$��30��
�������$��29��$��	400,0,0,0q��� 
�������$��
0,26,0,284q��� -   
 ��Name$
 	InputBox1��$��
Token Here��$��Center=�$��Center=�$
��Left=�$��25�� �� TextWrapping$
 Wrap=�$	��Top=�$	��380�����	#FF1E1E1E
�������$��	10,41,0,0q�$��10(���Z�  �� SelectionBrush Z� '  !ICSharpCode.AvalonEdit.TextEditor  -     Name$ TextEditor1��   
IsReadOnly . ���	#FF1E1E1E
������ 
�������$   HorizontalScrollBarVisibility$
 Auto=�"   VerticalScrollBarVisibility$
 Auto=�$
��Left=�$��	10,71,0,0q�$	��Top=�$	��219��$	��410��   Text.  � 	Resources  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 4��. �� -   $	 SetTokenButton��$��390,41,10,234q�#��[  ���	#FF1E1E1E
������ 
������� � ToolTip _� ���#181818$��0q�
�������$��Segou UI)�$��	Set Token��  ToolTip#��[ .���� $��Images/Set Token Icon.png��$��20���� -    ��Name$ SettingsBorder��$��445,10,10,10q����	#FF323232
������ $ 4��   ._�� .+��� ���	#FF1E1E1E$ 
4, 4, 0, 0��$��	0,0,0,270q�._��� $��Settings��$
��Left=�$	��Top=�$	��120��$��30��
�������$��14(��� -	    ��Name$ TopMostCheck��
�������  UniversalCheckBox#��[ $��10,35,10,250q�$��Top Most���� -
   $
 SetPrefixBox��$��Center=�$��Center=�$
��Left=�$��24��$
 Wrap=�$	��Top=�$	��100�����	#FF1E1E1E
�������$��	10,55,0,0q�$��Prefix Here����Z�  Z� �� -   $	 SetPrefixButton��#��[  $��
Set Prefix�����	#FF1E1E1E
�������
������ $��10,79,10,197q�$��12(�$��24���� -   $	 NihonButton��#��[  $��Nihon Discord�����	#FF1E1E1E
�������
������ $��10,271,10,5q�$��12(�$��24���� -   $	 UtilityButton��#��[  $��Utility Discord�����	#FF1E1E1E
�������
������ $��10,247,10,29q�$��12(�$��24��