   M S B A M L   `   `   `  ����T  PWpfUserControlDataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WpfUserControlDataBindingWpfUserControlDataBinding  5   	   _4clr-namespace:WpfUserControlDataBinding.UserControls&WpfUserControlDataBinding.UserControls  5   	   *    $WpfUserControlDataBinding.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:WpfUserControlDataBinding     5   	   MuserControls4clr-namespace:WpfUserControlDataBinding.UserControls     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � DataContext 5
   	   ��  �� RelativeSource �� *Self+.��5      �� 
��� � �.+�5   
   �� $A��;The Entry field which has a binding to the Window Property:��6   $
��20,0q�5      �� 5   
   $��	20,0,20,0q�5      ��5      �� *WindowPropertyText+ �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5   
   $4��.The TextBlock which shows the window property:��6   $��
20,20,20,0q�5      �� 5   
   ��6   �� *WindowPropertyText+�� 5   
   
����d�.+�5      �� $G��AThe Entry field which has a binding to the User Control Property:��6   $
��20,0q�5      =   7WpfUserControlDataBinding.UserControls.FieldUserControl  5         Label$ This is the Label��5         Value 5      �� *WindowPropertyText+ �� Mode$ TwoWay=�$ PropertyChanged=�5      5      5      