using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SFA.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomFrame :  Frame
    {
        public static readonly BindableProperty TextProperty =
        BindableProperty.Create(
        propertyName: nameof(Text),
        returnType: typeof(string),
        declaringType: typeof(CustomFrame),
        defaultValue: default(string),
        propertyChanged: HandleTextPropertyChanged);

        public static readonly BindableProperty Text1Property =
        BindableProperty.Create(
        propertyName: nameof(Text),
        returnType: typeof(string),
        declaringType: typeof(CustomFrame),
        defaultValue: default(string),
        propertyChanged: HandleText1PropertyChanged);

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public string Text1
        {
            get => (string)GetValue(Text1Property);
            set => SetValue(Text1Property, value);
        }

        private static void HandleTextPropertyChanged(
        BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomFrame)bindable;
            if (control != null)
            {
                control.value.Text = (string)newValue;
            }
        }
        private static void HandleText1PropertyChanged(
        BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomFrame)bindable;
            if (control != null)
            {
                control.value1.Text = (string)newValue;
            }
        }
        public CustomFrame()
        {
            InitializeComponent();
        }
    }
}