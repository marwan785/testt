   M S B A M L   `   `   `  ����C  ?WpfApp10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp10WpfApp10  5          WpfApp10.data_grid   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WpfApp10     5        N� Title$  	data_grid��5	      .��5      � ��5   
   �� 5       �� ImageSource$ download.jpeg��6    � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ d_grid��5      $��120,25,120,24q�6#   $��1��6:      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+6J     5      $
 name��6%    63   �� *names+6O     5      $ address��6%    66   �� *
addresss+6U     5      $ 
department��6%    69   �� *department.specilaztion+6g   5      �� 5   
   -   5        $��delet��5      $
��Left=�6!   $��
94,115,0,0q�6<   $	��Top=�6P   $��29��6h   $	��105��6t   6�   �� 5   
   -   5        $
��edit��5      $
��Left=�6    $��257,112,0,0q�6;   $	��Top=�6P   $	��111��6h   $��30��6t   6�   �� 5    
   -   5        $��search��5       $
��Left=�6"   $��
734,41,0,0q�6=   $	��Top=�6Q   $��56��6i   $��29��6t   6�   �� 5!   
   $��student  id��6   $��50��6&   $��20(�62   $��10,10,676,165q�6@   �� 5"   
   -   5         ��Name$ st_id��5"      $
��Left=�6!   $��
134,17,0,0q�6<   	 �� TextWrapping$
	 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��172��6�   �� 5#   
   $��	debartent��6   $	��100��6$   $��50��60   $��20(�6<   $��10,60,690,115q�6J   �� 5$   
   -   5        $ debart��5$      $
��Left=�6"   $��
134,67,0,0q�6=   $
	 Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��178��6�   �� 5%   
   -   5        $ 	search_tx��5%      $
��Left=�6%   $��
592,10,0,0q�6@   $
	 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��177��6�   5'      5(      