   M S B A M L   `   `   `  ����   EasySave_G3_V3_0!    EasySave_G3_V2_0.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml        MainWindow.Title  � Title#  �   $	��604��$
��1096��
�������.��� $��10q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� #���   $��36(�$
��Bold"�$��10q�&   System.Windows.Controls.DataGrid  -   $��SaveDataGrid��$��1��   AutoGenerateColumns$ False��$��	0,10,0,10q�   HeadersVisibility$ Column=�   CanUserAddRows$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 25 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+  $
 Name��$ *  �� *Name+  $ Source��$ *  �� *Source+  $ Target��$ *  �� *Target+  $ 
BackupType��$ *  �� *Type+  $ Description��$ *  �� *Description+  $
 Etat��$ *  �� *State+4  .System.Windows.Controls.DataGridCheckBoxColumn  $ Select��$ 80  �� *
IsSelected+4  .System.Windows.Controls.DataGridTemplateColumn    MainWindow.ProgressHeader# �  $	 100 	   CellTemplate	 �� .R�� 
 � Minimum$
 0Q� � Maximum$	 100Q�$��16��$��Center=� � Value �� *
Progress+ �� Mode$ OneWay=�  $ Modifier / Supprimer��$	 150 	 �� .R���  �� Orientation$ 
Horizontal=�$��Center=�.+��� -   $��5q� � ToolTip$ Modifier��.���� $��Segoe MDL2 Assets)�$	����$��18(��� -   $��5q�$ 	Supprimer��.���� $��Segoe MDL2 Assets)�$	����$��18(��� $��2��$ 
Horizontal=�$
��Left=�$��10q�.+��� -   $��60��$��60��$��5q�.���� $��Segoe MDL2 Assets)�$	����$��28(�$��Center=���   MainWindow.Play#���  $��Center=�$
��Bold"�$	��5,0q��� $��2��$ Vertical=�$��Right=�$��10q�.+��� $ 
Horizontal=�$��0,0,0,10q�.+��� -   $��Button_AddScenario��$��40��$��40��$��5q�.���� $��Segoe MDL2 Assets)�$	����$��20(���   MainWindow.Add#���  $��Center=�$
��Bold"�$	��5,0q��� $ 
Horizontal=�.+��� -   $��Settings��$��40��$��40��$��5q�.���� $��Segoe MDL2 Assets)�$	����$��20(���   MainWindow.Settings#���  $��Center=�$
��Bold"�$	��5,0q��� -     MainWindow.CMD#���  $
��Left=�$��39��$��	977,0,0,0q�$��Center=�$��60���� $��2��$
��Left=�$	��110��$��	144,0,0,0q�$��Center=�$	��799��.+�� -   $��Grid_Modify��$	��100�� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $
��Auto �$	��120���� $
��Auto �$	��120���� $
��Auto �$	��120���� $��* �$	��120��$	��360��.+��� $��0��  MainWindow.NameLabel#���  $	��Top=�$��36���� -	   $��
TxtBoxName��$��1���� $��1��$��0��  MainWindow.SourceLabel#���  $��2���� -
   $��TxTBoxSource��$��1��$��1���� $��2��$��0��  MainWindow.TargetLabel#���  �� -   $��TxTBoxTarget��$��2��$��1���� $��3��$��0�� 	 MainWindow.TypeLabel#��� 	 �� -   $��
CbBox_Type��$��3��$��1���� $��2�� 
 MainWindow.DescriptionLabel#��� 
 �� -   $��TxTBoxDescription��$��3��$��4���� -   $��Button_Back��$��2��$��3��  MainWindow.Cancel#���  �� -   $��Button_Validation��$��2��$��2��  MainWindow.Validate#���  