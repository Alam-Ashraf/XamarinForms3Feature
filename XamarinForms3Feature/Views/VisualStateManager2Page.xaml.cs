using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinForms3Feature.Views
{
    public partial class VisualStateManager2Page : ContentPage
    {
        public VisualStateManager2Page()
        {
            InitializeComponent();

            // Size change event
            SizeChanged+= OnSizeChanged;
        }

        void OnSizeChanged(object sender, EventArgs e)
        {
            if(Width>Height)
            {
                // Landscape
                VisualStateManager.GoToState(FlexLayout, "Landscape");
            }
            else
            {
                // Portrait
                VisualStateManager.GoToState(FlexLayout, "Portrait");
            }
        }

    }


}
