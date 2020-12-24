using System.Windows;
using System.Windows.Controls;

namespace WpfUserControlDataBinding.UserControls
{
    /// <summary>
    ///     Interaction logic for FieldUserControl.xaml
    /// </summary>
    public partial class FieldUserControl : UserControl
    {
        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(
            "Label", typeof(string), typeof(FieldUserControl));

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            "Value", typeof(string), typeof(FieldUserControl));

        public FieldUserControl()
        {
            InitializeComponent();

            LayoutRoot.DataContext = this;
        }

        public string Label
        {
            get => (string) GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public string Value
        {
            get => (string) GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }
    }
}