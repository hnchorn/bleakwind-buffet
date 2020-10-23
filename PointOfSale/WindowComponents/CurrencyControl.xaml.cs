/*
 * Author: Hannah Chorn
 * Class name: CurrencyControl.xaml.cs
 * Purpose: Class used to represent and handle all currency interactions
 * on cash payments in the GUI interface.
 */

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
        /// <summary>
        /// Identitifies the CurrencyControl.Label XAML attached property.
        /// </summary>
        static FrameworkPropertyMetadata labelMetaData = new FrameworkPropertyMetadata(" ", FrameworkPropertyMetadataOptions.AffectsRender);
        public static DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(CurrencyControl), labelMetaData);

        /// <summary>
        /// Identitifies the CurrencyControl.CustomerQuantity XAML attached property.
        /// </summary>
        static FrameworkPropertyMetadata customerQuantityMetaData = new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault);
        public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CurrencyControl), customerQuantityMetaData);

        /// <summary>
        /// Identitifies the CurrencyControl.ChangeQuantity XAML attached property.
        /// </summary>
        static FrameworkPropertyMetadata changeQuantityMetaData = new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender);
        public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CurrencyControl), changeQuantityMetaData);

        /// <summary>
        /// Identifies the CurrencyControl.Step XAML attached property.
        /// </summary>
        public static DependencyProperty StepProperty = DependencyProperty.Register("Step", typeof(int), typeof(CurrencyControl), new PropertyMetadata(1));

        /// <summary>
        /// Initializes the CurrencyControl GUI interface.
        /// </summary>
        public CurrencyControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Represents how much to increment or decrement each time a button is clicked.
        /// </summary>
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

        /// <summary>
        /// Represents the label of the bills/coins.
        /// </summary>
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

        /// <summary>
        /// Represents the quantity of bills/coins a customer is wanting to use to pay.
        /// </summary>
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

        /// <summary>
        /// Represents the quantity of bills/coins a customer will receive in change.
        /// </summary>
        public int ChangeQuantity
        {
            get
            {
                return (int)GetValue(ChangeQuantityProperty);
            }
            set
            {
                SetValue(ChangeQuantityProperty, value);
                if(ChangeQuantity != 0)
                {
                    Change.Foreground = Brushes.Green;
                    ChangeBorder.BorderBrush = Brushes.Green;
                }
            }
        }

        //Click handle if the increment or decrement button is clicked.
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
    }
}
