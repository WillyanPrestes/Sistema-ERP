   M S B A M L   `   `   `  ����N  JFinanceiro.WpfTelas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Financeiro.WpfTelas.UserControls Financeiro.WpfTelas.UserControls  5      9    3Financeiro.WpfTelas.UserControls.uscCadastroProduto   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Financeiro.WpfTelas.UserControls     5      $	��330��5      ���#ECF0F1.��5
      � $��10q�6   .+�5   
   ��    BorderCadastro#��[  6   ._�5      �� .+�5      �� $��Cadastro de Produto��6     ComumTitulo#��[ 67   � 5        � RowDefinitions  5      �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(    � ColumnDefinitions 5      �� 5      $��* �6+   �� 5       $��* �6+   �� 5!      $��* �6+   .+�5#      �� $��0��6!   $��0��6.    �� Orientation$ Vertical=�6>   $��3��6U     ComumStackPanel#��[ 6i   .+�5$      �� $��Descrição��6$     
ComumBlock#��[ 65   �� 5%        ComumBox#��[ 6#     errorTemplate =� ErrorTemplate# [ 5'      ��5&   #   ��  �� Path$ 
_Descricao� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True�� �� NotifyOnValidationError$
 True��5'      5(      �� 5*      $��1��6!   $��0��6.   $ Vertical=�6>   #��[ 6U   .+�5+      �� $��Custo��6$   #��[ 61   �� 5,      #��[ 6#   # [ 5.      ��5-   #   �� $ _Custo�$ TwoWay=�$ PropertyChanged=�	 �� StringFormat$	 N2��$
 True��$
 True��5.      5/      �� 51      $��1��6!   $��1��6.   $ Vertical=�6>   #��[ 6U   .+�52      �� $��Margem Lucro��6$   #��[ 68   �� 53      #��[ 6#   # [ 55      ��54      �� $ _MargemLucro�$ TwoWay=�$	 N2��$ PropertyChanged=�$
 True��$
 True��55      56      �� 58      $��1��6!   $��2��6.   $ Vertical=�6>   #��[ 6U   .+�59      �� $��Preço da Venda��6$   #��[ 6:   �� 5:      #��[ 6#   # [ 5<      ��5;   !   �� $ _PrecoVenda�$ TwoWay=�$ PropertyChanged=�$	 N2��$
 True��$
 True��5<      5=      �� 5>      $��2��6!   $��0��6.   $ Vertical=�6>   #��[ 6U   .+�5?      �� $��Estoque Minimo��6$   #��[ 6:   �� 5@      #��[ 6#   # [ 5B      ��5A      �� $ _EstoqueMinimo�$ TwoWay=�$ PropertyChanged=�$	 N2��$
 True��$
 True��5B      5C      �� 5E      $��2��6!   $��1��6.   $ Vertical=�6>   #��[ 6U   .+�5F      �� $��Estoque Atual��6$   #��[ 69   �� 5G      #��[ 6#   # [ 5I      ��5H      �� $ _EstoqueAtual�$ TwoWay=�$ PropertyChanged=�$	 N2��$
 True��$
 True��5I      5J      �� 5L      $��2��6!   $��2��6.   $ Vertical=�6>   #��[ 6U   .+�5M      �� $��Unidade de Medida��6$   #��[ 6=   �� 5N      #��[ 6#   # [ 5P      ��5O      �� $ _UnidadeMedida�$ TwoWay=�$ PropertyChanged=�$
 True��$
 True��5P      5Q      �� 5T      $��3��6!   $��0��6.   $ Vertical=�6>   $��2��6U   #��[ 6i   .+�5U      �� $��Categoria do Produto��6$   #��[ 6A   �� 5V      -   5        
 ��Name$
 cmbCategoria��5V   @   $��8��6#   $��1��60   # [ 5X       �� DisplayMemberPath$ 
_Descricao��5Y       �� SelectedValuePath$ _IdCategoriaProduto��5Z        ComumComboBox#��[ 6G    �� SelectedItem 5V   V   �� $ _CategoriaProduto�$ TwoWay=�$ PropertyChanged=�$
 True��$
 True��5Z   G   5\      5]      5^      5_      5`      5a      