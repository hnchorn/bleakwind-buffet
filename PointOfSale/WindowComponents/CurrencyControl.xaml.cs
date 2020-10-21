using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        static FrameworkPropertyMetadata customerQuantityMetaData = new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault);
        /// <summary>
        /// Identitifies the CurrencyControl.Value XAML attached property.
        /// </summary>
        public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CurrencyControl), customerQuantityMetaData);

        static FrameworkPropertyMetadata labelMetaData = new FrameworkPropertyMetadata(" ", FrameworkPropertyMetadataOptions.AffectsRender);
        public static DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(CurrencyControl), labelMetaData);

        static FrameworkPropertyMetadata changeQuantityMetaData = new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender, HandleValueChanged);
        public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CurrencyControl), changeQuantityMetaData);

        /// <summary>
        /// Identifies the CurrencyControl.Step XAML attached property.
        /// </summary>
        public static DependencyProperty StepProperty = DependencyProperty.Register("Step", typeof(int), typeof(CurrencyControl), new PropertyMetadata(1));

        /// <summary>
        /// Identifies the CurrencyControl.ValueClamped event
        /// </summary>
        public static readonly RoutedEvent ValueClampedEvent = EventManager.RegisterRoutedEvent("ValueClamped", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CurrencyControl));

        /// <summary>
        /// Event that is triggered when the value of this CurrencyControl changes.
        /// </summary>
        public event RoutedEventHandler ValueClamped
        {
            add
            {
                AddHandler(ValueClampedEvent, value);
            }
            remove
            {
                RemoveHandler(ValueClampedEvent, value);
            }
        }

        public CurrencyControl()
        {
            InitializeComponent();
        }

        int MinValue
        {
            get { return 0; }
        }

        int MaxValue
        {
            get { return 50; }
        }

        public int Step
        {
            get
            {
                return (int)GetValue(StepProperty);
            }
            set
            {
                SetValue(StepProperty, value);
            }
        }

        public string Label
        {
            get
            {
                return (string)GetValue(LabelProperty);
            }
            set
            {
                SetValue(LabelProperty, value);
            }

        }

        public int CustomerQuantity
        {
            get
            {
                return (int)GetValue(CustomerQuantityProperty);
            }
            set
            {
                SetValue(CustomerQuantityProperty, value);
            }
        }

        public int ChangeQuantity
        {
            get
            {
                return (int)GetValue(ChangeQuantityProperty);
            }
            set
            {
                SetValue(ChangeQuantityProperty, value);
            }
        }


        void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                switch (button.Name)
                {
                    case "Increment":
                        CustomerQuantity += Step;
                        break;
                    case "Decrement":
                        CustomerQuantity -= Step;
                        break;
                }
            }
            e.Handled = true;
        }

        static void HandleValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if(e.Property.Name == "CustomerQuantity" && sender is CurrencyControl control)
            {
                if(control.CustomerQuantity < control.MinValue)
                {
                    control.CustomerQuantity = control.MinValue;
                    control.RaiseEvent(new RoutedEventArgs(ValueClampedEvent));
                }
                if(control.CustomerQuantity > control.MaxValue)
                {
                    control.CustomerQuantity = control.MaxValue;
                    control.RaiseEvent(new RoutedEventArgs(ValueClampedEvent));
                }
            }
            if (e.Property.Name == "ChangeQuantity" && sender is CurrencyControl control2)
            {
                if (control2.ChangeQuantity < control2.MinValue)
                {
                    control2.ChangeQuantity = control2.MinValue;
                    control2.RaiseEvent(new RoutedEventArgs(ValueClampedEvent));
                }
                if (control2.ChangeQuantity > control2.MaxValue)
                {
                    control2.ChangeQuantity = control2.MaxValue;
                    control2.RaiseEvent(new RoutedEventArgs(ValueClampedEvent));
                }
            }
        }


    }
}
