   M S B A M L   `   `   `  ����K  GTeniskiTurniriUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TeniskiTurniriUI.ViewTeniskiTurniriUI.View  5   	   -    'TeniskiTurniriUI.View.StadionIzmeniView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TeniskiTurniriUI.View     5   	     � Title$  StadionIzmeniView��5   
   $	��420��6$   $	��310��61    � 
ResizeMode$ NoResize=�6=    � WindowStartupLocation$ CenterScreen=�6S   .��5	      � 
����·�.+�5
   
   �� $��ID��6   
����  �$��	ExtraBold"�6/   $
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t   $��90��6�   �� 5   
    �� 
IsReadOnly . 
����  �$��2q�6�   $
��Left=�6�   $��23��6�   $��
138,13,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��156��6   ��6   �� *Validacija.Stadion.idst+ �� UpdateSourceTrigger$ PropertyChanged=�6   �� 5   
   
���  ��$	��Top=�6W   $��
10,41,10,0q�6o   $��25��6�   ��6   �� *#!Validacija.ValidationErrors[idst]+6�   �� 5   
   $��Naziv��6   
����  �$��	ExtraBold"�62   $
��Left=�6I   $��	10,60,0,0q�6d   $	��Top=�6w   $��90��6�   �� 5   
   
����  �$��2q�6t   $
��Left=�6�   $��26��6�   $��
138,60,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Stadion.nazst+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6X   $	��Top=�6s   $��	10,94,0,0q�6�   $	��284��6�   $��25��6�   ��6   �� *$"Validacija.ValidationErrors[nazst]+6�   �� 5   
   -   5         ��Name$ izmeni��5      $��Izmeni��6!   
����  �$��20(�6D   $��	ExtraBold"�6R   
������ 
����  �$��4q�6�   $
��Left=�6�   $��
10,307,0,0q�6�   $	��Top=�6�   $��75��6�   ��6�   �� *EditCommand+�� 5   
   -   5        $ vratiSe��5      $��Vrati se��6"   
����  �$��20(�6G   $��	ExtraBold"�6U   
������ 
����  �$��4q�6�   $
��Left=�6�   $��204,307,0,0q�6�   $	��Top=�6�   $��90��6�   ��6�   �� *ExitCommand+�� 5   
   -   5         ��Name$ textBlockUspeh��5      $
��Wrap=�6,    �� TextAlignment$ Center=�6@   
��� � �$
��Left=�6j   $	��Top=�6�   $��
12,351,0,0q�6�   $	��282��6�   $��29��6�   5      5      