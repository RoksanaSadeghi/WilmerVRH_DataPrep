   M S B A M L   `   `   `  ����M  IWilmerVRH_DataPrep, Version=2.0.1.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WilmerVRH_DataPrepWilmerVRH_DataPrep  5   	   '    !WilmerVRH_DataPrep.PracticeScenes   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WilmerVRH_DataPrep     5   	     � Title$  WilmerVRH Practice Scenes��5   	   $	��400��6+   $	��550��68    � 
ResizeMode$ CanResizeWithGrip=�5	   	    � 	Resources 5         lB �� 
TargetType �� Property �� Value � Orientation��%�  &	        �� 5   
   " ��6   .�5      ��  � ��$ Disabled=�5      �� 5       � ��$ Disabled=�5      �� 5       � ��$
 Left=�5      �� 5       � ��$	 Top=�5      �� 5       � ��$	 Top=�5      �� 5       � ��$
 Left=�5      �� 5       � �� 5      �� 5      .R�5      � $ 
Horizontal=�6$   5      5       5!      5$      .��5&      �� $
��Auto=�6   .��5'   
   � -   5         �Name$ MainGrid��5'       � RowDefinitions 5(      �� 5)      -   5        	 ��Name$	 LabelsGR��5)       $
��Auto �62   �� 5*      -   5        $	 ListGR��5*       $
��Auto �60   �� 5+      -   5        $	 	OptionsGR��5+       $
��Auto �63   �� 5,      -   5        $	 SubmitGR��5,       $
��Auto �62   .+�5/      �� -   5        
 ��Name$
 TaskListBox��5/      ���	#FF202020���#FAFAFA$��	10,0,10,0q�6X   $
��Auto=�50      $��Disabled=�51      $��1��52      ��53      �� 54      .R�55      � $ 
Horizontal=�6$   56      58      �� 5:      -   5         ��Name$ TestNameBtn��5:      $��
Scene Name��6*   $��12(�6?   
�������$	��100��6`   $��20��6l   $��0��6x   $
��Left=�6�   $��	10,10,0,0q�6�   $	��Top=�6�   6�   �� 5<      -   5        $ Select��5<      $��Select Practice Scenes��6%   $��14(�6F   $	��400��6T   $��50��6`   $��2��6l   $	��Top=�6y   $��Center=�6�   $��0,10,0,0q�6�   6�   5?      5@      5A      