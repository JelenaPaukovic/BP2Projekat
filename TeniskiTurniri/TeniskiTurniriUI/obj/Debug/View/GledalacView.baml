   M S B A M L   `   `   `  ����K  GTeniskiTurniriUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TeniskiTurniriUI.ViewTeniskiTurniriUI.View  5   	   (    "TeniskiTurniriUI.View.GledalacView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TeniskiTurniriUI.View     5   	     � Title$  GledalacView��5   	   $	��600��6   $	��600��6+    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterScreen=�6M   .��5	      � 
������.+�5
   
   �� $��GLEDALAC��6   
����  �$��35(�66   $
��Bold"�6D   $
��Wrap=�6V    �� TextAlignment$ Center=�6j   $��10,10,10,384q�6�   �� 5   
   $��Dodaj��6   
����  �$��4q�64   
������ 
����  �$��30(�6s   $��	ExtraBold"�6�   $
��Left=�6�   $��	10,61,0,0q�6�   $	��Top=�6�   $	��185��6�   $��64��6�   ��6�   �� *
AddCommand+�� 5   
   $��Obrisi��6   
����  �$��4q�65   
������ 
����  �$��30(�6t   $��	ExtraBold"�6�   $
��Left=�6�   $��
200,61,0,0q�6�   $	��Top=�6�   $	��185��6�   $��64��6�   ��6�   �� *RemoveCommand+�� 5   
   $��Izmeni��6   
����  �$��4q�65   
������ 
����  �$��30(�6t   $��	ExtraBold"�6�   $
��Left=�6�   $��
390,61,0,0q�6�   $	��Top=�6�   $	��185��6�   $��64��6�   ��6�   �� *EditCommand+&   System.Windows.Controls.DataGrid  5   
   
����  �$��4q�6&      AutoGenerateColumns .  $	��280��6�   $
��Left=�6�   $��
10,130,0,0q�6  $	��Top=�6-  $	��565��6E     SelectionMode$ Single=�6Q     
IsReadOnly .  �� SelectedItem 6:   �� *IzabraniGledalac+ �� UpdateSourceTrigger$ PropertyChanged=���6�   �� 	 �� Path$	 Gledaoci�$ PropertyChanged=�
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *idg+5      5      5      