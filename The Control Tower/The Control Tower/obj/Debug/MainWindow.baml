   M S B A M L   `   `   `  ����L  HThe Control Tower, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:The_Control_TowerThe_Control_Tower  5   	   "    The_Control_Tower.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:The_Control_Tower     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Flight Control��5	   	   $��500         ��6    $	��600��5
      .��5      � .+�5   
   �� -   5         ��Name$ 	lvwEvents��5      $��29,257,31,10q�6Q    �� View 5      �� 5      .P�5      ��  �� Width$	 600��6%   5      5      �� 5   
   -   5         ��Name$ btnAddPlane��5      $��	Add Plane��6&   $
��Left=�6:   $��
65,227,0,0q�6U   $	��Top=�6i   $	��140��6�   6�   �� 5   
   -   5        $ 
btnTakeOff��5      $��Take Off��6%   $
��Left=�68   $��253,227,0,0q�6S   $	��Top=�6h   $	��128��6�   6�   �� 5   
   -   5         ��Name$ lblName��5      $
��Name��6!   $
��Left=�60   $��	51,29,0,0q�6K   $	��Top=�6^   �� 5   
   -   5        $ lblFlightId��5      $��	Flight ID��6%   $
��Left=�69   $��	51,64,0,0q�6T   $	��Top=�6g   �� 5   
   -   5        $ lblDestination��5      $��Destination��6(   $
��Left=�6>   $��
51,104,0,0q�6Y   $	��Top=�6m   �� 5   
   -   5        $ lblFlightTime��5      $��Flight Time��6'   $
��Left=�6=   $��
53,145,0,0q�6X   $	��Top=�6l   �� 5   
   -   5         ��Name$ tbxName��5      $
��Left=�6#   $��
135,24,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��120��6�   �� 5   
   -	   5        $ tbxFlightID��5      $
��Left=�6'   $��
135,68,0,0q�6B   $
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $	��120��6�   �� 5   
   -
   5        $ tbxDestination��5      $
��Left=�6*   $��135,108,0,0q�6E   $
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $ tbxFlightTime��5      $
��Left=�6)   $��135,149,0,0q�6D   $
 Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��120��6�   �� 5   
   -   5        $ 
lvwFlights��5      $��276,10,10,286q�6R    5      �� 5      .P�5       �� $	 300��6%   5!      5#      �� 5$   
   -   5        $ btnAltitude��5$      $��Change Altitude��6&   $
��Left=�6@   $��424,227,0,0q�6[   $	��Top=�6p   $	��122��6�   6�   �� 5%   
   -   5        $ tbxAltitude��5%      $
��Left=�6'   $��427,204,0,0q�6B   $
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��120��6�   �� 5&   
   -   5        $ lblAltitude��5&      $��Altitude (M)��6%   $
��Left=�6<   $��427,178,0,0q�6W   $	��Top=�6l   5(      5)      