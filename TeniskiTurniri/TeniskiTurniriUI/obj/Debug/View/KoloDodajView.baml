   M S B A M L   `   `   `  ����K  GTeniskiTurniriUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TeniskiTurniriUI.ViewTeniskiTurniriUI.View  5   	   )    #TeniskiTurniriUI.View.KoloDodajView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TeniskiTurniriUI.View     5   	     � Title$  KoloDodajView��5      $	��420��6   $	��310��6+    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterScreen=�6M   .��5	      � 
����·�.+�5   
   �� $
��Left=�6   $��29��6.   $��
138,65,0,0q�6:   $	��Top=�6N   $	��156��6f    J� RenderTransformOrigin$ 0.496,-1.49&�5   e   ��5      �� *SpisakOdrzavanja+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedValue 5      �� *IzabranoOdrzavanje+$ PropertyChanged=�6e   �� 5   
   
���  ��$��10(�6N   $
��Left=�6\   $	��Top=�6w   $��	22,96,0,0q�6�   $��25��6�   $	��282��6�   $ 0.513,-6.56&�6�   ��6   �� *IzabranoOdrzavanjeGreska+6�   �� 5   
   $��ID kola��6   
����  �$��	ExtraBold"�64   $
��Left=�6K   $��
10,121,0,0q�6f   $	��Top=�6z   $	��123��6�   �� 5   
   
����  �$��2q�6o   $
��Left=�6�   $��26��6�   $��138,126,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��156��6�   $ 0.471,1.323&�6�   ��6   �� *Validacija.Kolo.idk+$ PropertyChanged=�6�   �� 5   
   
���  ��$
��Left=�6V   $	��Top=�6q   $��
10,152,0,0q�6�   $	��284��6�   $��25��6�   ��6   �� *" Validacija.ValidationErrors[idk]+6�   �� 5   
   $��
Odrzavanje��6   $
��Left=�6%   
����  �$��	ExtraBold"�6R   $��29��6i   $��	10,62,0,0q�6u   $	��Top=�6�   $��90��6�   $ 0.508,1.837&�6�   �� 5   
   -   5         ��Name$ dodaj��5      $��Dodaj��6    
����  �$��20(�6B   $��	ExtraBold"�6P   
������ 
����  �$��4q�6�   $
��Left=�6�   $��
10,307,0,0q�6�   $	��Top=�6�   $��75��6�   ��6�   �� *
AddCommand+�� 5   
   -   5        $ vratiSe��5      $��Vrati se��6"   
����  �$��20(�6G   $��	ExtraBold"�6U   
������ 
����  �$��4q�6�   $
��Left=�6�   $��204,307,0,0q�6�   $	��Top=�6�   $��90��6�   ��6�   �� *ExitCommand+�� 5   
   -   5         ��Name$ textBlockUspeh��5      $
��Wrap=�6,   	 �� TextAlignment$	 Center=�6@   
��� � �$
��Left=�6j   $	��Top=�6�   $��
12,351,0,0q�6�   $	��282��6�   $��29��6�   5      5      