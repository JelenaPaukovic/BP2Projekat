   M S B A M L   `   `   `  ����K  GTeniskiTurniriUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TeniskiTurniriUI.ViewTeniskiTurniriUI.View  5   	   0    *TeniskiTurniriUI.View.VipUlaznicaDodajView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TeniskiTurniriUI.View     5   	     � Title$  VipUlaznicaDodajView��5   	   $	��420��6&   $	��310��63    � 
ResizeMode$ NoResize=�6?    � WindowStartupLocation$ CenterScreen=�6U   .��5	      � 
����·�.+�5
   
   �� $��ID ulaznice��6   $
��Left=�6&   
����  �$��	ExtraBold"�6S   $��23��6j   $��	10,15,0,0q�6v   $	��Top=�6�   $��90��6�    J� RenderTransformOrigin$ -3.906,0.357&�6�   �� 5   
   $
��Left=�6   $��23��6.   $��
138,15,0,0q�6:   $	��Top=�6N   $	��156��6f   ��5      �� *SpisakUlaznica+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedValue 5      �� *IzabranaUlaznica+$ PropertyChanged=��� 5   
   
���  ��$��10(�6L   $
��Left=�6Z   $	��Top=�6u   $��0,38,0,0q�6�   $��22��6�   $	��294��6�   ��6   �� *IzabranaUlaznicaGreska+6�   �� 5   
   $��ID vip ulaznice��6   
����  �$��	ExtraBold"�6<   $
��Left=�6S   $��	10,60,0,0q�6n   $	��Top=�6�   $	��123��6�   �� 5   
   
����  �$��2q�6z   $
��Left=�6�   $��26��6�   $��
138,60,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��156��6�   ��6   �� * Validacija.ObicnaUlaznica.idvu+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6W   $	��Top=�6r   $��	10,86,0,0q�6�   $	��284��6�   $��24��6�   ��6   �� *#!Validacija.ValidationErrors[idvu]+6�   �� 5   
   $��Oznaka ulaznice��6   
����  �$��	ExtraBold"�6<   $
��Left=�6S   $��
12,115,0,0q�6n   $	��Top=�6�   $	��121��6�   �� 5   
   $
��Left=�6   $��28��6.   $��138,115,0,0q�6:   $	��Top=�6O   $	��156��6g    6s   �� *IzabranKnjizevniRod+$ PropertyChanged=�.@�5      �� .��6   VIP6    �� 5      .��6   OBICNA6#   5      �� 5   
   -   5         ��Name$ dodaj��5      $��Dodaj��6    
����  �$��20(�6B   $��	ExtraBold"�6P   
������ 
����  �$��4q�6�   $
��Left=�6�   $��
10,307,0,0q�6�   $	��Top=�6�   $��75��6�   ��6�   �� *
AddCommand+�� 5   
   -   5        $ vratiSe��5      $��Vrati se��6"   
����  �$��20(�6G   $��	ExtraBold"�6U   
������ 
����  �$��4q�6�   $
��Left=�6�   $��204,307,0,0q�6�   $	��Top=�6�   $��90��6�   ��6�   �� *ExitCommand+�� 5   
   -   5         ��Name$ textBlockUspeh��5      $
��Wrap=�6,   	 �� TextAlignment$	 Center=�6@   
��� � �$
��Left=�6j   $	��Top=�6�   $��
12,351,0,0q�6�   $	��282��6�   $��29��6�   5      5       