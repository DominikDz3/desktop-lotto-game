   M S B A M L   `   `   `  ����D  @LottoGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LottoGame	LottoGame  5   	       LottoGame.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:LottoGame     5   	   -   5          � Title$  LottoGame v1.0��5   	   $	��450��5	   	   $	��800��6    � 
ResizeMode$ NoResize=�5
   	   .��5      � ���	#FF252525 � RowDefinitions 5   
   �� 5      $��55 �6   �� 5      $	��380 �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   5      �� 5      $	��650 �6   .+�5   
   �� $��Center=�6   $��50��61   $��Center=�6=   $	��150��6X   ���	#FF1716166d   �� 5   
   $��Center=�6   $	��384��61   $��Center=�6>   $	��150��6Y   ���	#FF171616$��1��6v   �� 5   
   -   5         ��Name$ Username��5      $
��Left=�6&   $��10,6,0,0q�6A   $
��Wrap=�6S   $��*Użytkownik*��6g   $	��Top=�6{   ���	#FFFF9300$��18(�6�   $��Bahnschrift)�6�   $��22��6�   $	��107��6�   �� 5   
   -   5        $ Balance��5      $��Center=�6%   $��0,31,0,0q�6B   $
��Wrap=�6T   $	��Top=�6h   $��Bahnschrift)�6�   
�������$��14��6�   $	��130��6�   �� 5   
   -   5         ��Name$ NewDrawButton��5      $��Nowe losowanie��6(   $��Center=�6A   $��0,21,0,0q�6^   $��1��6p   $	��Top=�6}   $��45��6�   $	��150��6�   ���	#FF5C5C5C���	#FF171616$��Bahnschrift)�6�   $��16(�6  ��6�   Z� 6  �� 5   
   $��Historia gier��6   $��Center=�6)   $��0,66,0,0q�6F   $��1��6X   $	��Top=�6e   $��45��6}   $	��150��6�   ���	#FF5C5C5C���	#FF171616$��Bahnschrift)�6�   $��16(�6�   ��6�   Z� 6�   �� 5   
   -   5        $ CreditsButton��5      $��Autor��6(   $��Center=�68   $��1��6U   $	��Top=�6b   $��45��6z   $	��150��6�   ���	#FF5C5C5C���	#FF171616$��Bahnschrift)�6�   $��16(�6�   $��	0,310,0,0q�6�   ��6�   Z� 6   � 5   
   -   5          �Name$ NewDrawFrame��5        � Source$ DefaultPage.xaml?�6&   $��1��6@   $��1��6P     � NavigationUIVisibility$ Hidden=�6]   �� 5   
   $��Tabela wygranych��6   $��Center=�6,   $��	0,116,0,0q�6I   $��1��6\   $	��Top=�6i   $��45��6�   $	��150��6�   ���	#FF5C5C5C���	#FF171616$��Bahnschrift)�6�   $��16(�6�   ��6�   Z� 6�   5      5       