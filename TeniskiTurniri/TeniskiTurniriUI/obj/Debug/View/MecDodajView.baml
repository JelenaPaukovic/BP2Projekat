   M S B A M L   `   `   `  ����K  GTeniskiTurniriUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TeniskiTurniriUI.ViewTeniskiTurniriUI.View  5   	   (    "TeniskiTurniriUI.View.MecDodajView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TeniskiTurniriUI.View     5   	     � Title$  MecDodajView��5   	   $	��420��6   $	��800��6+    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterScreen=�6M   .��5	      � 
����·�.+�5
   
   �� $��ID��6   
����  �$��	ExtraBold"�6/   $
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t   $��90��6�   �� 5   
   
����  �$��2q�6o   $
��Left=�6�   $��23��6�   $��
138,13,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Mec.idm+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   
���  ��$	��Top=�6V   $��10,36,483.6,0q�6n   $��24��6�   ��6   �� *" Validacija.ValidationErrors[idm]+6�   �� 5   
   $��
Datum meca��6   
����  �$��	ExtraBold"�67   $
��Left=�6N   $��	10,60,0,0q�6i   $	��Top=�6|   $��90��6�   �� 5   
   
����  �$��2q�6p   $
��Left=�6�   $��26��6�   $��
138,60,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Mec.datom+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6X   $	��Top=�6s   $��	10,86,0,0q�6�   $	��284��6�   $��24��6�   ��6   �� *$"Validacija.ValidationErrors[datom]+6�   �� 5   
   $��Broj gledalaca��6   
����  �$��	ExtraBold"�6;   $
��Left=�6R   $��
10,110,0,0q�6m   $	��Top=�6�   $	��123��6�   �� 5   
   
����  �$��2q�6n   $
��Left=�6�   $��26��6�   $��138,110,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Mec.brg+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6V   $	��Top=�6q   $��
10,136,0,0q�6�   $	��284��6�   $��24��6�   ��6   �� *" Validacija.ValidationErrors[brg]+6�   �� 5   
   $��
Ime igraca��6   
����  �$��	ExtraBold"�67   $
��Left=�6N   $��
10,210,0,0q�6i   $	��Top=�6}   $	��113��6�   �� 5   
   
����  �$��2q�6p   $
��Left=�6�   $��26��6�   $��138,210,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Mec.imeig+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6X   $	��Top=�6s   $��
10,286,0,0q�6�   $	��284��6�   $��21��6�   ��6   �� *$"Validacija.ValidationErrors[imeig]+6�   �� 5   
   $��Prezime igraca��6   
����  �$��	ExtraBold"�6;   $
��Left=�6R   $��
10,260,0,0q�6m   $	��Top=�6�   $	��113��6�   �� 5   
   
����  �$��2q�6p   $
��Left=�6�   $��26��6�   $��138,260,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Mec.przig+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6X   $	��Top=�6s   $��
10,236,0,0q�6�   $	��284��6�   $��24��6�   ��6   �� *$"Validacija.ValidationErrors[przig]+6�   �� 5    
   $
��Kolo��6   $
��Left=�6   
����  �$��	ExtraBold"�6L   $��40��6c   $��
392,13,0,0q�6o   $	��Top=�6�   $��90��6�   �� 5!   
   $
��Left=�6   $��23��6.   $��
482,13,0,0q�6:   $	��Top=�6N   $	��241��6f   ��5"      �� *
SpisakKola+$ PropertyChanged=� �� SelectedValue 5#      �� *IzabranoKolo+$ PropertyChanged=��� 5$   
   
���  ��$��10(�6H   $
��Left=�6V   $	��Top=�6q   $��
392,53,0,0q�6�   $��39��6�   $	��331��6�   ��6   �� *IzabranoKoloGreska+6�   �� 5'   
   -   5         ��Name$ dodaj��5'      $��Dodaj��6    
����  �$��20(�6B   $��	ExtraBold"�6P   
������ 
����  �$��4q�6�   $
��Left=�6�   $��
10,307,0,0q�6�   $	��Top=�6�   $��75��6�   ��6�   �� *
AddCommand+�� 5(   
   -   5        $ vratiSe��5(      $��Vrati se��6"   
����  �$��20(�6G   $��	ExtraBold"�6U   
������ 
����  �$��4q�6�   $
��Left=�6�   $��204,307,0,0q�6�   $	��Top=�6�   $��90��6�   ��6�   �� *ExitCommand+�� 5*   
   -   5         ��Name$ textBlockUspeh��5*      $
��Wrap=�6,    �� TextAlignment$ Center=�6@   
��� � �$
��Left=�6j   $	��Top=�6�   $��
12,351,0,0q�6�   $	��282��6�   $��29��6�   �� 5+   
   $��Stadion��6   $
��Left=�6"   
����  �$��	ExtraBold"�6O   $��40��6f   $��
12,160,0,0q�6r   $	��Top=�6�   $��90��6�   �� 5,   
   $
��Left=�6   $��23��6.   $��138,160,0,0q�6:   $	��Top=�6O   $	��156��6g   ��5-      �� *SpisakStadiona+$ PropertyChanged=� 5.      �� *IzabraniStadion+$ PropertyChanged=��� 5/   
   
���  ��$��10(�6K   $
��Left=�6Y   $	��Top=�6t   $��
12,188,0,0q�6�   $��22��6�   $	��298��6�   ��6   �� *IzabraniStadionGreska+6�   50      51      