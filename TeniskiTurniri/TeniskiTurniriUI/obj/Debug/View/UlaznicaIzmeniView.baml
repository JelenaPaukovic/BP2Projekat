   M S B A M L   `   `   `  ����K  GTeniskiTurniriUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TeniskiTurniriUI.ViewTeniskiTurniriUI.View  5   	   .    (TeniskiTurniriUI.View.UlaznicaIzmeniView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TeniskiTurniriUI.View     5   	     � Title$  UlaznicaIzmeniView��5   
   $	��420��6%   $	��310��62    � 
ResizeMode$ NoResize=�6>    � WindowStartupLocation$ CenterScreen=�6T   .��5	      � 
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
 Wrap=�6�   $	��Top=�6�   $	��156��6   ��6   �� *Validacija.Ulaznica.idu+ �� UpdateSourceTrigger$ PropertyChanged=�6   �� 5   
   
���  ��$	��Top=�6V   $��
10,36,10,0q�6n   $��24��6�   ��6   �� *" Validacija.ValidationErrors[idu]+6�   �� 5   
   $��Datum odrzavanja��6   
����  �$��	ExtraBold"�6=   $
��Left=�6T   $��	10,60,0,0q�6o   $	��Top=�6�   $	��123��6�   �� 5   
   
����  �$��2q�6u   $
��Left=�6�   $��26��6�   $��
138,60,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Ulaznica.datom+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6X   $	��Top=�6s   $��	10,86,0,0q�6�   $	��284��6�   $��24��6�   ��6   �� *$"Validacija.ValidationErrors[datom]+6�   �� 5   
   $��Vreme odrzavanja��6   
����  �$��	ExtraBold"�6=   $
��Left=�6T   $��
10,110,0,0q�6o   $	��Top=�6�   $	��123��6�   �� 5   
   
����  �$��2q�6u   $
��Left=�6�   $��26��6�   $��138,110,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Ulaznica.vreme+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6X   $	��Top=�6s   $��
10,136,0,0q�6�   $	��284��6�   $��24��6�   ��6   �� *$"Validacija.ValidationErrors[vreme]+6�   �� 5   
   $��	Broj reda��6   
����  �$��	ExtraBold"�66   $
��Left=�6M   $��
10,160,0,0q�6h   $	��Top=�6|   $	��113��6�   �� 5   
   
����  �$��2q�6v   $
��Left=�6�   $��26��6�   $��138,160,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Ulaznica.brreda+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6Y   $	��Top=�6t   $��
10,186,0,0q�6�   $	��284��6�   $��24��6�   ��6   �� *%#Validacija.ValidationErrors[brreda]+6�   �� 5   
   $��Broj sedista��6   
����  �$��	ExtraBold"�69   $
��Left=�6P   $��
10,210,0,0q�6k   $	��Top=�6   $	��113��6�   �� 5   
   
����  �$��2q�6u   $
��Left=�6�   $��26��6�   $��138,210,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Ulaznica.brsed+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6X   $	��Top=�6s   $��
10,236,0,0q�6�   $	��284��6�   $��24��6�   ��6   �� *$"Validacija.ValidationErrors[brsed]+6�   �� 5   
   $��Tip ulaznice��6   
����  �$��	ExtraBold"�69   $
��Left=�6P   $��
12,260,0,0q�6k   $	��Top=�6   $	��121��6�   $��26��6�   �� 5   
   $
��Left=�6   $��26��6.   $��138,260,0,0q�6:   $	��Top=�6O   $	��156��6g    �� SelectedValuePath$ Content��6s    �� SelectedValue 6�   �� * Validacija.ObicnaUlaznica.ozno+$ PropertyChanged=�.@�5       �� .��6   VIP6    �� 5!      .��6   OBICNA6#   5#      �� 5$   
   
���  ��$
��Left=�6W   $	��Top=�6r   $��
10,286,0,0q�6�   $	��284��6�   $��21��6�   ��6   �� *#!Validacija.ValidationErrors[tipu]+6�   �� 5&   
   -   5         ��Name$ izmeni��5&      $��Izmeni��6!   
����  �$��20(�6D   $��	ExtraBold"�6R   
������ 
����  �$��4q�6�   $
��Left=�6�   $��
10,307,0,0q�6�   $	��Top=�6�   $��75��6�   ��6�   �� *EditCommand+�� 5'   
   -   5        $ vratiSe��5'      $��Vrati se��6"   
����  �$��20(�6G   $��	ExtraBold"�6U   
������ 
����  �$��4q�6�   $
��Left=�6�   $��204,307,0,0q�6�   $	��Top=�6�   $��90��6�   ��6�   �� *ExitCommand+�� 5)   
   -   5        	 ��Name$	 textBlockUspeh��5)      $
��Wrap=�6,   
 �� TextAlignment$
 Center=�6@   
��� � �$
��Left=�6j   $	��Top=�6�   $��
12,351,0,0q�6�   $	��282��6�   $��29��6�   5+      5,      