   M S B A M L   `   `   `  ����K  GTeniskiTurniriUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TeniskiTurniriUI.ViewTeniskiTurniriUI.View  5   	   *    $TeniskiTurniriUI.View.IgracDodajView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TeniskiTurniriUI.View     5   	     � Title$  IgracDodajView��5      $	��420��6   $	��310��6+    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterScreen=�6M   .��5	      � 
����·�.+�5
   
   �� $��ID��6   
����  �$��	ExtraBold"�6/   $
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t   $��90��6�   �� 5   
   
����  �$��2q�6q   $
��Left=�6�   $��23��6�   $��
128,13,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��166��6�   ��6   �� *Validacija.Igrac.idig+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6W   $	��Top=�6r   $��	10,41,0,0q�6�   $	��284��6�   $��20��6�   ��6   �� *#!Validacija.ValidationErrors[idig]+6�   �� 5   
   $	��Ime��6   
����  �$��	ExtraBold"�60   $
��Left=�6G   $��	10,66,0,0q�6b   $	��Top=�6u   $��90��6�   �� 5   
   
����  �$��2q�6q   $
��Left=�6�   $��23��6�   $��
138,69,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Igrac.imei+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6W   $	��Top=�6r   $��	10,92,0,0q�6�   $	��284��6�   $��24��6�   ��6   �� *#!Validacija.ValidationErrors[imei]+6�   �� 5   
   $��Prezime��6   
����  �$��	ExtraBold"�64   $
��Left=�6K   $��
10,121,0,0q�6f   $	��Top=�6z   $	��123��6�   �� 5   
   
����  �$��2q�6q   $
��Left=�6�   $��23��6�   $��138,124,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Igrac.przi+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6W   $	��Top=�6r   $��
10,152,0,0q�6�   $	��284��6�   $��25��6�   ��6   �� *#!Validacija.ValidationErrors[przi]+6�   �� 5   
   $��Datum rodjenja��6   
����  �$��	ExtraBold"�6;   $
��Left=�6R   $��
10,179,0,0q�6m   $	��Top=�6�   $	��113��6�   �� 5   
   
����  �$��2q�6r   $
��Left=�6�   $��23��6�   $��138,182,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Igrac.datri+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6X   $	��Top=�6s   $��
10,210,0,0q�6�   $	��284��6�   $��31��6�   ��6   �� *$"Validacija.ValidationErrors[datri]+6�   �� 5   
   $��Drzava��6   
����  �$��	ExtraBold"�63   $
��Left=�6J   $��
10,246,0,0q�6e   $	��Top=�6y   $	��113��6�   �� 5   
   
����  �$��2q�6q   $
��Left=�6�   $��23��6�   $��138,249,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Igrac.drzi+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6X   $	��Top=�6s   $��
10,277,0,0q�6�   $	��284��6�   $��25��6�   ��6   �� *#!Validacija.ValidationErrors[drzi]+6�   �� 5   
   -   5         ��Name$ dodaj��5      $��Dodaj��6    
����  �$��20(�6B   $��	ExtraBold"�6P   
������ 
����  �$��4q�6�   $
��Left=�6�   $��
10,307,0,0q�6�   $	��Top=�6�   $��75��6�   ��6�   �� *
AddCommand+�� 5   
   -   5        $ vratiSe��5      $��Vrati se��6"   
����  �$��20(�6G   $��	ExtraBold"�6U   
������ 
����  �$��4q�6�   $
��Left=�6�   $��204,307,0,0q�6�   $	��Top=�6�   $��90��6�   ��6�   �� *ExitCommand+�� 5!   
   -   5         ��Name$ textBlockUspeh��5!      $
��Wrap=�6,    �� TextAlignment$ Center=�6@   
��� � �$
��Left=�6j   $	��Top=�6�   $��
12,351,0,0q�6�   $	��282��6�   $��29��6�   5"      5#      