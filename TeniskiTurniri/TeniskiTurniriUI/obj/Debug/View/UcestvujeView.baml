   M S B A M L   `   `   `  ����K  GTeniskiTurniriUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TeniskiTurniriUI.ViewTeniskiTurniriUI.View  5   	   )    #TeniskiTurniriUI.View.UcestvujeView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TeniskiTurniriUI.View     5   	   
������  � Title$  UcestvujeView��5   	   $��330.337��6   $��570.787��60   .��5	      � $��	0,0,4.2,0q�6    � ColumnDefinitions 5
   
   �� 5      $	��43* �6   �� 5      $
��237* �6   .+�5   
   �� $&�� Igraci koji ucestvuju na turniru��6   $
��Bold"�6;   
����  �$��20(�6_   $
��Left=�6m   $��41��6�   $��88.6,10,0,0q�6�   $	��Top=�6�   $	��311��6�   $��1��6�   �� 5   
   $��Turnir��6   
����  �$
��Bold"�63   $��18(�6E   $
��Left=�6T   $	��Top=�6o   $��	43,71,0,0q�6�   $��36��6�   $	��117��6�   $��2��6�   �� 5   
   $��Igrac��6   
����  �$
��Bold"�62   $��18(�6D   $
��Left=�6S   $	��Top=�6n   $��
43,111,0,0q�6�   $��36��6�   $	��117��6�   $��2��6�   �� 5   
   $��Oprema��6   
����  �$
��Bold"�63   $��18(�6E   $
��Left=�6T   $	��Top=�6o   $��
43,152,0,0q�6�   $��45��6�   $	��117��6�   $��2��6�   �� 5   
   $
��Left=�6   $��36��6.   $��73.976,71,0,0q�6:   $	��Top=�6Q   $	��170��6i   $��1��5   ^   ��5      �� *
SviTurniri+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedValue 5      �� *SelektovaniTurnir+$ PropertyChanged=�6^   �� 5   
   $��36��6   $��73.6,111,230,0q�6   $	��Top=�67   $��1��5   ]   ��5      �� *	SviIgraci+$ PropertyChanged=� 5      �� *SelektovaniIgrac+$ PropertyChanged=�6]   �� 5   
   $��40��6   $��73.6,152,230,0q�6   $	��Top=�67   $��1��5   [   ��5      �� *	SvaOprema+$ PropertyChanged=� 5      �� *IzabranaOprema+$ PropertyChanged=�6[   �� 5   
   
���  ��$��10(�6J   $
��Left=�6X   $	��Top=�6s   $��253.976,69,0,0q�6�   $��36��6�   $	��193��6�   $��1��6�   ��6   �� *IzabraniTurnirGreska+6�   �� 5   
   
���  ��$��10(�6I   $
��Left=�6W   $	��Top=�6r   $��253.976,109,0,0q�6�   $��36��6�   $	��193��6�   $��1��6�   ��6   �� *IzabraniIgracGreska+6�   �� 5   
   
���  ��$��10(�6J   $
��Left=�6X   $	��Top=�6s   $��253.6,152,0,0q�6�   $��40��6�   $	��193��6�   $��1��6�   ��6   �� *IzabranaOpremaGreska+6�   �� 5   
   $��Dodeli igraca turniru��6   
����  �$
��Bold"�6C   $��18(�6U   $
��Left=�6d   $��54��6   $��23.6,197,0,0q�6�   $	��Top=�6�   $	��190��6�   $��1��6�   ��6�   �� *
AddCommand+6�   �� 5   
   $��Odustani��6   
����  �$
��Bold"�66   $��18(�6H   $
��Left=�6V   $��54��6q   $��253.6,197,0,0q�6}   $	��Top=�6�   $	��128��6�   $��1��6�   ��6�   �� *ExitCommand+6�   5!      5"      