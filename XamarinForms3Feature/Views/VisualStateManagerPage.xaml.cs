using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinForms3Feature.Views
{
    public partial class VisualStateManagerPage : ContentPage
    {

        public VisualStateManagerPage()
        {
            InitializeComponent();
        }

        void PasswordTextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if(e!=null && e.NewTextValue!=null)
            {
                if(e.NewTextValue.Length<4)
                {
                    // Weak Passeord
                    LabelPassword.Text = "Weak Password";
                    VisualStateManager.GoToState(LabelPassword, "Weak");
                }
                else if (e.NewTextValue.Length < 8)
                {
                    // Medium Passeord
                    LabelPassword.Text = "Medium Password";
                    VisualStateManager.GoToState(LabelPassword, "Medium");
                }
                else if (e.NewTextValue.Length >= 8)
                {
                    // Strong Passeord
                    LabelPassword.Text = "Strong Password";
                    VisualStateManager.GoToState(LabelPassword, "Strong");
                }
            }
        }
    }
}
