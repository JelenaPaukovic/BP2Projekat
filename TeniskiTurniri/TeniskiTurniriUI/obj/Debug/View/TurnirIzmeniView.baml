   M S B A M L   `   `   `  ����K  GTeniskiTurniriUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TeniskiTurniriUI.ViewTeniskiTurniriUI.View  5   	   ,    &TeniskiTurniriUI.View.TurnirIzmeniView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TeniskiTurniriUI.View     5   	     � Title$  TurnirIzmeniView��5   
   $	��420��6#   $	��800��60    � 
ResizeMode$ NoResize=�6<    � WindowStartupLocation$ CenterScreen=�6R   .��5	      � 
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
 Wrap=�6�   $	��Top=�6�   $	��156��6   ��6   �� *Validacija.Turnir.idtur+ �� UpdateSourceTrigger$ PropertyChanged=�6   �� 5   
   
���  ��$	��Top=�6X   $��
10,41,10,0q�6p   $��25��6�   ��6   �� *$"Validacija.ValidationErrors[idtur]+6�   �� 5   
   $��Naziv��6   
����  �$��	ExtraBold"�62   $
��Left=�6I   $��	10,66,0,0q�6d   $	��Top=�6w   $��90��6�   �� 5   
   
����  �$��2q�6t   $
��Left=�6�   $��23��6�   $��
138,69,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Turnir.naztur+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6Y   $	��Top=�6t   $��	10,94,0,0q�6�   $	��284��6�   $��25��6�   ��6   �� *%#Validacija.ValidationErrors[naztur]+6�   �� 5   
   $��Mesto odrzavanja��6   
����  �$��	ExtraBold"�6=   $
��Left=�6T   $��
10,121,0,0q�6o   $	��Top=�6�   $	��123��6�   �� 5   
   
����  �$��2q�6v   $
��Left=�6�   $��23��6�   $��138,124,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Turnir.mestotur+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6[   $	��Top=�6v   $��
10,152,0,0q�6�   $	��284��6�   $��25��6�   ��6   �� *'%Validacija.ValidationErrors[mestotur]+6�   �� 5   
   $��Datum pocetka��6   
����  �$��	ExtraBold"�6:   $
��Left=�6Q   $��
10,179,0,0q�6l   $	��Top=�6�   $	��113��6�   �� 5   
   
����  �$��2q�6s   $
��Left=�6�   $��23��6�   $��138,182,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Turnir.datpt+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6X   $	��Top=�6s   $��
10,210,0,0q�6�   $	��284��6�   $��31��6�   ��6   �� *$"Validacija.ValidationErrors[datpt]+6�   �� 5   
   $��Datum zavrsetka��6   
����  �$��	ExtraBold"�6<   $
��Left=�6S   $��
10,246,0,0q�6n   $	��Top=�6�   $	��113��6�   �� 5   
   
����  �$��2q�6s   $
��Left=�6�   $��23��6�   $��138,249,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Turnir.datzt+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6X   $	��Top=�6s   $��
10,277,0,0q�6�   $	��284��6�   $��25��6�   ��6   �� *$"Validacija.ValidationErrors[datzt]+6�   �� 5   
   -   5         ��Name$ izmeni��5      $��Izmeni��6!   
����  �$��20(�6D   $��	ExtraBold"�6R   
������ 
����  �$��4q�6�   $
��Left=�6�   $��
10,307,0,0q�6�   $	��Top=�6�   $��75��6�   ��6�   �� *EditCommand+�� 5   
   -   5        $ vratiSe��5      $��Vrati se��6"   
����  �$��20(�6G   $��	ExtraBold"�6U   
������ 
����  �$��4q�6�   $
��Left=�6�   $��204,307,0,0q�6�   $	��Top=�6�   $��90��6�   ��6�   �� *ExitCommand+�� 5!   
   -   5         ��Name$ textBlockUspeh��5!      $
��Wrap=�6,    �� TextAlignment$ Center=�6@   
��� � �$
��Left=�6j   $	��Top=�6�   $��
12,351,0,0q�6�   $	��282��6�   $��29��6�   �� 5"   
   $��
Kategorija��6   $
��Left=�6%   
����  �$��	ExtraBold"�6R   $��40��6i   $��
392,13,0,0q�6u   $	��Top=�6�   $��90��6�   �� 5#   
   $
��Left=�6   $��23��6.   $��
482,13,0,0q�6:   $	��Top=�6N   $	��241��6f   ��5$      �� *SpisakKategorija+$ PropertyChanged=�	 �� SelectedValue	 5%      �� *IzabranaKategorija+$ PropertyChanged=��� 5&   
   
���  ��$��10(�6N   $
��Left=�6\   $	��Top=�6w   $��
392,53,0,0q�6�   $��39��6�   $	��331��6�   ��6   �� *IzabranaKategorijaGreska+6�   5)      5,      