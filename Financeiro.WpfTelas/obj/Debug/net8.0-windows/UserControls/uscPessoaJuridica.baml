   M S B A M L   `   `   `  ����N  JFinanceiro.WpfTelas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Financeiro.WpfTelas.UserControls Financeiro.WpfTelas.UserControls  5      8    2Financeiro.WpfTelas.UserControls.uscPessoaJuridica   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Financeiro.WpfTelas.UserControls     5      .��5	      � $��10q�6   .+�5
   
   ��    BorderCadastro#��[  6   ._�5      �   � RowDefinitions  5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��0��6   $��0��6*    �� Orientation$ Vertical=�6:     ComumStackPanel#��[ 6R   .+�5      �� $��Razão Social��6      
ComumBlock#��[ 64   �� 5        ComumBox#��[ 6     errorTemplate =� ErrorTemplate# [ 5      ��5      �� *_RazaoSocial+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True�� �� NotifyOnValidationError$
 True��5      5      �� 5      $��0��6   $��1��6*   $ Vertical=�6:   #��[ 6R   .+�5      �� $��NomeFantasia��6    #��[ 64   �� 5      #��[ 6   # [ 5      ��5      �� *_NomeFantasia+$ TwoWay=�$ PropertyChanged=�$
 True��$
 True��5      5       �� 5!      $��1��6   $��0��6*   $ Vertical=�6:   #��[ 6R   .+�5"      �� $
��CNPJ��6    #��[ 6,   �� 5#      #��[ 6   # [ 5%      ��5$      �� *_CNPJ+$ TwoWay=�$ PropertyChanged=�$
 True��$
 True��5%      5&      �� 5'      $��1��6   $��2��6*   $ Vertical=�6:   #��[ 6R   .+�5(      �� $��Inscrição Estadual��6    #��[ 6:   �� 5)      #��[ 6   # [ 5+      ��5*      �� *_IE+$ TwoWay=�$ PropertyChanged=�$
 True��$
 True��5+      5,      0   *Financeiro.WpfTelas.UserControls.uscPessoa  5-      $��3��6"   $��2��6/   5.      5/      50      51      