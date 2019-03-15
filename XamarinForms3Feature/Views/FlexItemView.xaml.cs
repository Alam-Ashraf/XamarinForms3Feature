using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinForms3Feature.Views
{
    public partial class FlexItemView : ContentView
    {
        public Image ImageBanner { get; set; }

        public FlexItemView()
        {
            InitializeComponent();

            ImageBanner = Image;
        }
    }
}
