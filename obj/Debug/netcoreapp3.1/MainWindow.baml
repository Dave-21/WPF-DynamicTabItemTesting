   M S B A M L   `   `   `  ����L  HDynamicTestingWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:DynamicTestingWPFDynamicTestingWPF  5   	   K*clr-namespace:DynamicTestingWPF.ViewModelsDynamicTestingWPF.ViewModels  5   	   "    DynamicTestingWPF.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:DynamicTestingWPF     5   	   A
viewmodels*clr-namespace:DynamicTestingWPF.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5         BooleanToVisibility��%   &	        �� 5   
   6'   5      .��5      � .+�5   
   �� $
��Hide��6   $
��Left=�6E   $��
478,17,0,0q�6`   $	��Top=�6t   $	��100��6�   ��6    �� *HidePanelCommand+6�   �� 5   
   $
��Show��6   $
��Left=�6E   $��
583,17,0,0q�6`   $	��Top=�6t   $	��100��6�   ��6    �� *ShowPanelCommand+6�   �� 5   
   $��0,63,0,0q�6   .@�5      �� $��Datasets��6   .��5      2   ,DynamicTestingWPF.DatasetsTabItemUserControl  -   5          Name$ datasetsUserControl��5   3   $	��800��6P   $	��355��6\   5      �� 5      $��Graphs��6   y�6&   �� *IsPanelVisible+ �� 	Converter# [  .��5       0   *DynamicTestingWPF.GraphsTabItemUserControl  -   5          Name$ graphsUserControl��5    1   $	��800��6L   $	��355��6X   5!      5"      �� 5#   
   $,��&Show/Hide Controls from MainWindow -->��6   $��229,14,327,394q�6A   �� 5$   
   -   5        $��openFile��5$      $��Cache Image��6!   $
��Left=�67   $��
701,17,0,0q�6R   $	��Top=�6f   $��20��6~   $��89��6�   6�   �� 5%   
   -   5        $��getCachedImage��5%      $��Get Cached Image��6'   $
��Left=�6B   $��	46,28,0,0q�6]   $	��Top=�6p   $��30��6�   $	��103��6�   6�   �� 5&   
   -   5        $��selectGetFileTextBox��5&      $
��Left=�6/   $��
154,40,0,0q�6J   $��TextBox��6^    �� TextWrapping$
 Wrap=�6m   $	��Top=�6�   $	��120��6�   5'      5(      