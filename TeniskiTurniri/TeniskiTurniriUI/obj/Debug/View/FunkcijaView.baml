   M S B A M L   `   `   `  ����K  GTeniskiTurniriUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TeniskiTurniriUI.ViewTeniskiTurniriUI.View  5   	   (    "TeniskiTurniriUI.View.FunkcijaView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TeniskiTurniriUI.View     5   	   
�������  � Title$  Funkcije��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid     
IsReadOnly . $
��Left=�6�   $	��251��6�   $��
254,30,0,0q�6�   $	��Top=�6�   $	��508��6�   ��6%   �� *ListaRezultata+ �� Mode$ TwoWay=� �� NotifyOnSourceUpdated .  �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��17(�6   $
��Left=�6"   $��79��6=   $��	37,30,0,0q�6I   $
��Wrap=�6\   $=��7Pronadjite sve turnire koji se odrzavaju u jednom mestu��6p   $	��Top=�6�   $	��192��6�    J� RenderTransformOrigin$ 0.501,0.236&�6�   �� 5   
   $��Izađi��6   $
��Left=�6!   $��314.244,354,0,0q�6<   $	��Top=�6U   $	��110��6m   $��36��6y   ��6�   �� *ExitCommand+�� 5   
   $��Pronadji��6   $
��Left=�6$   $��
76,184,0,0q�6?   $	��Top=�6S   $	��110��6k   $��36��6w   ��6�   �� *PronadjiCommand+�� 5   
   $
��Left=�6   $��48��6-   $��
37,114,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6b   $	��192��6z   ��6�   �� *IzabranoMesto+$ PropertyChanged=�5      5      