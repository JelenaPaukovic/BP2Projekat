   M S B A M L   `   `   `  ����K  GTeniskiTurniriUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TeniskiTurniriUI.ViewTeniskiTurniriUI.View  5   	   /    )TeniskiTurniriUI.View.OdrzavanjeDodajView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TeniskiTurniriUI.View     5   	     � Title$  OdrzavanjeDodajView��5   
   $	��420��6&   $	��310��63    � 
ResizeMode$ NoResize=�6?    � WindowStartupLocation$ CenterScreen=�6U   .��5	      � 
����·�.+�5
   
   �� $��ID��6   
����  �$��	ExtraBold"�6/   $
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t   $��90��6�   �� 5   
   
����  �$��2q�6v   $
��Left=�6�   $��23��6�   $��
138,13,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Odrzavanje.idod+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   
���  ��$	��Top=�6W   $��
10,36,10,0q�6o   $��24��6�   ��6   �� *#!Validacija.ValidationErrors[idod]+6�   �� 5   
   $��Datum pocetka��6   
����  �$��	ExtraBold"�6:   $
��Left=�6Q   $��	10,74,0,0q�6l   $	��Top=�6   $	��123��6�    J� RenderTransformOrigin$ 0.494,-0.906&�6�   �� 5   
   
����  �$��2q�6w   $
��Left=�6�   $��26��6�   $��
138,74,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   $ 0.487,-0.585&�6�   ��6   �� *Validacija.Odrzavanje.datpo+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6X   $	��Top=�6s   $��
10,105,0,0q�6�   $	��284��6�   $��24��6�   ��6   �� *$"Validacija.ValidationErrors[datpo]+6�   �� 5   
   $��Datum zavrsetka��6   
����  �$��	ExtraBold"�6<   $
��Left=�6S   $��
10,142,0,0q�6n   $	��Top=�6�   $	��113��6�   �� 5   
   
����  �$��2q�6w   $
��Left=�6�   $��26��6�   $��138,142,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� *Validacija.Odrzavanje.datzo+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6X   $	��Top=�6s   $��
10,173,0,0q�6�   $	��284��6�   $��26��6�   ��6   �� *$"Validacija.ValidationErrors[datzo]+6�   �� 5   
   $��Turnir��6   $
��Left=�6!   
����  �$��	ExtraBold"�6N   $��29��6e   $��
12,217,0,0q�6q   $	��Top=�6�   $��90��6�   $ 0.508,1.837&�6�   �� 5   
   $
��Left=�6   $��29��6.   $��138,217,0,0q�6:   $	��Top=�6O   $	��156��6g   ��5      �� *SpisakTurnira+$ PropertyChanged=� �� SelectedValue 5      �� *IzabraniTurnir+$ PropertyChanged=��� 5   
   
���  ��$��10(�6J   $
��Left=�6X   $	��Top=�6s   $��
12,263,0,0q�6�   $��25��6�   $	��282��6�   ��6   �� *IzabraniTurnirGreska+6�   �� 5    
   -   5         ��Name$ dodaj��5       $��Dodaj��6    
����  �$��20(�6B   $��	ExtraBold"�6P   
������ 
����  �$��4q�6�   $
��Left=�6�   $��
10,307,0,0q�6�   $	��Top=�6�   $��75��6�   ��6�   �� *
AddCommand+�� 5!   
   -   5        $ vratiSe��5!      $��Vrati se��6"   
����  �$��20(�6G   $��	ExtraBold"�6U   
������ 
����  �$��4q�6�   $
��Left=�6�   $��204,307,0,0q�6�   $	��Top=�6�   $��90��6�   ��6�   �� *ExitCommand+�� 5#   
   -   5         ��Name$ textBlockUspeh��5#      $
��Wrap=�6,   	 �� TextAlignment$	 Center=�6@   
��� � �$
��Left=�6j   $	��Top=�6�   $��
12,351,0,0q�6�   $	��282��6�   $��29��6�   5%      5&      