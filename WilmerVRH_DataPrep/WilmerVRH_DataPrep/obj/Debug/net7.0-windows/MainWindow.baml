   M S B A M L   `   `   `  ����M  IWilmerVRH_DataPrep, Version=2.0.1.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WilmerVRH_DataPrepWilmerVRH_DataPrep  5   	   #    WilmerVRH_DataPrep.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WilmerVRH_DataPrep     5   	     � Title$   WilmerVRH DataPrep Program��5   	   $	��870��6,   $	��550��69    � 
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
 ��Name$
 TestNameLabel��5/      $��
Scene Name��6,   $��12(�6A   
�������$	��100��6b   $��20��6n   $��0��6z   $
��Left=�6�   $��	10,10,0,0q�6�   $��2��6�   $	��Top=�6�   6�   �� 51      -   5        $
 	EasyLabel��51      $
��Easy��6(   $��12(�67   $��Center=�6E   
�������$��60��6|   $
��Auto��6�   $��0��6�   $
��Left=�6�   $��
140,10,0,0q�6�   6�   �� 52      -   5        $
 MediumLabel��52      $��Medium��6*   $��12(�6;   $��Center=�6I   
�������$��60��6�   $
��Auto��6�   $��0��6�   $
��Left=�6�   $��
210,10,0,0q�6�   6�   �� 53      -	   5        $
 	HardLabel��53      $
��Hard��6(   $��12(�67   $��Center=�6E   
�������$��60��6}   $
��Auto��6�   $��0��6�   $
��Left=�6�   $��
280,10,0,0q�6�   6�   �� 55      -
   5         ��Name$ TaskListBox��55      ���	#FF202020���#FAFAFA$��	10,0,10,0q�6X   $
��Auto=�56      $��Disabled=�57      $��1��58      ��59      �� 5:      .R�5;      � $ 
Horizontal=�6$   5<      5>      �� 5@      -   5         ��Name$ 	TimeLabel��5@      $��Time Between Scenes (s):��6'   $��12(�6J   
�������$
��Auto��6k   $��25��6x   $��2��6�   $	��Top=�6�   $
��Left=�6�   $��	10,10,0,0q�6�   �� 5A      -   5         ��Name$ TimeTextBox��5A      $��1��6+   $��Center=�64   $��12(�6X   
�������$��60��6y   $��20��6�   $��2��6�   $	��Top=�6�   $
��Left=�6�   $��
150,15,0,0q�6�   �� 5C      -   5        $ NumberofPlaylistsLabel��5C      $��Number of Playlists:��64   $��12(�6S   
�������$
��Auto��6t   $��25��6�   $��2��6�   $	��Top=�6�   $
��Left=�6�   $��	10,45,0,0q�6�   �� 5D      -   5        $ NumberOfPlaylistsTextBox��5D      $��1��68   $��Center=�6A   $��12(�6e   
�������$��60��6�   $��20��6�   $��2��6�   $	��Top=�6�   $
��Left=�6�   $��
150,50,0,0q�6�   �� 5F      -   5        $
 CreatePlaylist��5F      $��Create Playlist��6-   $��14(�6G   $	��200��6U   $��50��6a   $��2��6m   $	��Top=�6z   $��Right=�6�   $��	0,10,60,0q�6�   6�   5I      5J      5K      