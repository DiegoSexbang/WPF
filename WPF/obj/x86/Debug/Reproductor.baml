   M S B A M L   `   `   `  ����  WPF    WPF.Reproductor   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Reproductor��5   	   $	��392��6   $	��526��6*   .��5      �  � RowDefinitions 5   
   �� 5      $
��350* �6   �� 5      $��3* �6   .+�5
   
   �� $��Center=�6   $��Center=�62   $��
49,0,55,44q�6M   $	��400��6a   $	��306��6m   .+�5      r� -   5        $��myMedia��5       r� LoadedBehavior$ Manual=�6*   $	��275��6B   $	��221��6N    r� IsMuted .  6k   �� 5      .+�5      �� -   5        $��
lblCancion��5   /   $�� ��6   $��22��6#   $	��375��6A   �� 5      
�������$��5q�6/   	Seek To6C   �� 5      -   5         ��Name$ timelineSlider��5      $��	75,5,74,5q�61   $��23��6g   5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��56,310,48,10q�6.   .+�5      �� -   5        $
��Play��5      $��0,0,10,0q�6$   $��5q�66   6B   �� 5      -   5        $��Pause��5      $��0,0,10,0q�6%   $��5q�67   6C   �� 5      -   5         ��Name$ muteButt��5      $
��Mute��6'   $��0,0,10,0q�66   $��5q�6H   6T   �� 5      -   5        $
 Open��5      $
��Open��6#   $��0,0,10,0q�62   $��5q�6D   6P   5      5      5      