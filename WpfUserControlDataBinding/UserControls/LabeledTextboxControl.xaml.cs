using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using WpfUserControlDataBinding.Annotations;

namespace WpfUserControlDataBinding.UserControls
{
    public partial class LabeledTextBoxControl : INotifyPropertyChanged
    {
        public enum LabelPositions
        {
            Left,
            Above
        }

        public static readonly DependencyProperty LabelTextProperty = DependencyProperty.Register(
            "LabelText", typeof(string), typeof(LabeledTextBoxControl), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            "Value", typeof(string), typeof(LabeledTextBoxControl), new PropertyMetadata(default(string)));

        LabelPositions _labelPosition;

        public LabeledTextBoxControl()
        {
            InitializeComponent();

            LayoutRoot.DataContext = this;

            SetLabelPosition(_labelPosition);
        }

        public string LabelText
        {
            get => (string) GetValue(LabelTextProperty);
            set => SetValue(LabelTextProperty, value);
        }

        public string Value
        {
            get => (string) GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public LabelPositions LabelPosition
        {
            get => _labelPosition;
            set
            {
                if (value == _labelPosition) return;
                _labelPosition = value;
                SetLabelPosition(value);

                OnPropertyChanged();
            }
        }

        void SetLabelPosition(LabelPositions value)
        {
            switch
                (value)
            {
                case LabelPositions.Above:
                    LayoutRoot.Orientation = Orientation.Vertical;
                    break;
                case LabelPositions.Left:
                    LayoutRoot.Orientation = Orientation.Horizontal;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}