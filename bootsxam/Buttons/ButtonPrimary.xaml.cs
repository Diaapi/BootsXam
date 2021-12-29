using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bootsxam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Button : ContentView
    {
        public BindableProperty ButtonTextProperty = BindableProperty.Create(nameof(ButtonText),typeof(string),typeof(Button),defaultValue: string.Empty,defaultBindingMode: BindingMode.OneWay, propertyChanged: TitleTextProperty);

        private static void TitleTextProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (Button)bindable;
            control.btn.Text = newValue?.ToString();
        }

        public string ButtonText {
            get 
            {
                return base.GetValue(ButtonTextProperty).ToString();
            }
            set 
            { 
            base.SetValue(ButtonTextProperty, value);
            } 
        }
        public Button()
        {
            InitializeComponent();
        }
    }
}