   M S B A M L   `   `   `  ����N  JFinanceiro.WpfTelas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Financeiro.WpfTelas.UserControls Financeiro.WpfTelas.UserControls  5      0    *Financeiro.WpfTelas.UserControls.uscPessoa   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Financeiro.WpfTelas.UserControls     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6"    �� Orientation$ Vertical=�62      ComumStackPanel#��[  6J   .+�5      �� $��Telefone��6     
ComumBlock#��[ 6(   �� 5        ComumBox#��[ 6     errorTemplate =� ErrorTemplate# [ 5      ��5      �� *	_Telefone+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True�� �� NotifyOnValidationError$
 True��5      5      �� 5   
   $��0��6   $��1��6"   $ Vertical=�62   #��[  6J   .+�5      �� $��Celular��6   #��[ 6'   �� 5      #��[ 6   # [ 5      ��5      �� *
_Celular+$ TwoWay=�$ PropertyChanged=�$
 True��$
 True��5      5       �� 5!   
   $��1��6   $��0��6"   $ Vertical=�62   #��[  6J   .+�5"      �� $��Email��6   #��[ 6%   �� 5#      #��[ 6   # [ 5%      ��5$      �� *_Email+$ TwoWay=�$ PropertyChanged=�$
 True��$
 True��5%      5&      �� 5'   
   $��2��6   $��0��6"   $ Vertical=�62   #��[  6J   .+�5(      �� $��Estado Federal��6   #��[ 6.   �� 5)      -   5         ��Name$ 	cmbEstado��5)   4   $��8��6   $��1��6$   # [ 5*      	 �� DisplayMemberPath$	 
_Descricao��5+      
 �� SelectedValuePath$
 	_IdEstado��5,        ComumComboBox#��[ 61   6X   5-      �� 5.   
   $��2��6   $��1��6"   $ Vertical=�62   #��[  6J   .+�5/      �� $��	Municipio��6   #��[ 6)   �� 50      -   5        $ cmbMunicipio��50   4   $��8��6   $��1��6$   # [ 52      $	 
_Descricao��53      $
 _IdMunicipio��54      #��[ 64    �� SelectedItem 50   J   ��  �� Path$ 
_Municipio�$ TwoWay=�$ PropertyChanged=�$
 True��$
 True��54   4   55      �� 56   
   $��3��6   $��0��6"   $ Vertical=�62   #��[  6J   .+�57      �� $��
Logradouro��6   #��[ 6*   �� 58      #��[ 6   # [ 5:      ��59      �� *_Logradouro+$ TwoWay=�$ PropertyChanged=�$
 True��$
 True��5:      5;      �� 5<   
   $��3��6   $��1��6"   $ Vertical=�62   #��[  6J   .+�5=      �� $��Bairro��6   #��[ 6&   �� 5>      #��[ 6   # [ 5@      ��5?      �� *	_Bairro+$ TwoWay=�$ PropertyChanged=�$
 True��$
 True��5@      5A      �� 5B   
   $��4��6   $��0��6"   $ Vertical=�62   #��[  6J   .+�5C      �� $	��CEP��6   #��[ 6#   �� 5D      #��[ 6   # [ 5F      ��5E      �� *_CEP+$ TwoWay=�$ PropertyChanged=�$
 True��$
 True��5F      5G      �� 5H   
   $��4��6   $��1��6"   $ Vertical=�62   #��[  6J   .+�5I      �� $��Numero��6   #��[ 6&   �� 5J      #��[ 6   # [ 5L      ��5K      �� *	_Numero+$ TwoWay=�$ PropertyChanged=�$
 True��$
 True��5L      5M      5N      5O      