   M S B A M L   `   `   `  ����O  KWPF_students_tigeeva, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPF_students_tigeevaWPF_students_tigeeva  5   	   %    WPF_students_tigeeva.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WPF_students_tigeeva     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ studentsDataGrid��5         AutoGenerateColumns$ False��6-   ���	#FFBDD9E9   RowBackground �#FFEFD5   HorizontalGridLinesBrush �#696969   VerticalGridLinesBrush �#696969   AlternatingRowBackground
 �����   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6%   	   Header$	 Имя��6J   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *Name+6J     5      $ 60 6%   $	 Возраст��6H   
 60   �� *Age+6H     5      $	 120 6%   $	 Средний балл��6I   
 61   �� *GPA+6I   5      �� 5   
   -   5        $'��!Добавить студента��5      $
��Left=�6-   $��
10,352,0,0q�6H   $	��Top=�6\    J� RenderTransformOrigin$ -7.967,2.052&�6t   $��34��6�   $	��152��6�   $��Arial)�6�   $��14(�6�   
���   ����	#FF6A5E0B���	#FFE2BC40��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 ��ح�63   �� 5       � �� 5      �� 5       �� 
TargetType" ��6.   .R�5   "   ��  ��Name$ Border��6)   #��z��69   ._�5   &   �� $��Center=�67   $��Center=�6T   5   #    �� Triggers 5   "   P� 5   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5    *   ��  �� 
TargetName$ Border��6W    � �� �#F0E68C5!   '   5#      5%      5&      5(      5)      5*      