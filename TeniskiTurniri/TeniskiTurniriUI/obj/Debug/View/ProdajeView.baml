   M S B A M L   `   `   `  ����K  GTeniskiTurniriUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TeniskiTurniriUI.ViewTeniskiTurniriUI.View  5   	   '    !TeniskiTurniriUI.View.ProdajeView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TeniskiTurniriUI.View     5   	   
������  � Title$  ProdajeView��5   	   $��330.337��6   $��570.787��6.   .��5	      � $��	0,0,4.2,0q�6    � ColumnDefinitions 5
   
   �� 5      $	��43* �6   �� 5      $
��237* �6   .+�5   
   �� $��Prodavanje ulaznica��6   $
��Bold"�6.   
����  �$��20(�6R   $
��Left=�6`   $��41��6{   $��88.6,10,0,0q�6�   $	��Top=�6�   $	��200��6�   $��1��6�   �� 5   
   $��Turnir��6   
����  �$
��Bold"�63   $��18(�6E   $
��Left=�6T   $	��Top=�6o   $��	43,71,0,0q�6�   $��36��6�   $	��117��6�   $��2��6�   �� 5   
   $��Ulaznica��6   
����  �$
��Bold"�65   $��18(�6G   $
��Left=�6V   $	��Top=�6q   $��
43,111,0,0q�6�   $��36��6�   $	��117��6�   $��2��6�   �� 5   
   $
��Left=�6   $��36��6.   $��73.976,71,0,0q�6:   $	��Top=�6Q   $	��170��6i   $��1��5   ^   ��5      �� *
SviTurniri+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedValue 5      �� *SelektovaniTurnir+$ PropertyChanged=�6^   �� 5   
   $
��Left=�6   $��36��6.   $��73.976,111,0,0q�6:   $	��Top=�6R   $	��170��6j   $��1��5   `   ��5      �� *SveUlaznice+$ PropertyChanged=� 5      �� *SelektovanaUlaznica+$ PropertyChanged=�6`   �� 5   
   
���  ��$��10(�6J   $
��Left=�6X   $	��Top=�6s   $��253.976,69,0,0q�6�   $��36��6�   $	��193��6�   $��1��6�   ��6   �� *IzabraniTurnirGreska+6�   �� 5   
   
���  ��$��10(�6L   $
��Left=�6Z   $	��Top=�6u   $��253.976,109,0,0q�6�   $��36��6�   $	��193��6�   $��1��6�   ��6   �� *IzabranaUlaznicaGreska+6�   �� 5   
   $��Prodaj��6   
����  �$
��Bold"�64   $��18(�6F   $
��Left=�6U   $��54��6p   $��23.976,197,0,0q�6|   $	��Top=�6�   $	��128��6�   $��1��6�   ��6�   �� *
AddCommand+6�   �� 5   
   $��Odustani��6   
����  �$
��Bold"�66   $��18(�6H   $
��Left=�6V   $��54��6q   $��218.976,197,0,0q�6}   $	��Top=�6�   $	��128��6�   $��1��6�   ��6�   �� *ExitCommand+6�   5      5      