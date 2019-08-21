using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms3Feature.Views;

namespace XamarinForms3Feature.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation Navigation { get; set; }

        public ICommand FlexLayou1Command { get; private set; }
        public ICommand FlexLayou2Command { get; private set; }
        public ICommand FlexLayou3Command { get; private set; }
        public ICommand VisualStateManager1Command { get; private set; }
        public ICommand VisualStateManager2Command { get; private set; }
        public ICommand CascadingStyleSheetCommand { get; private set; }
        public ICommand BindableLayoutCommand { get; private set; }

        public MainPageViewModel()
        {
            FlexLayou1Command = new Command(OnFlexLayout1Click);
            FlexLayou2Command = new Command(OnFlexLayout2Click);
            FlexLayou3Command = new Command(OnFlexLayout3Click);
            VisualStateManager1Command = new Command(OnStateManager1Click);
            VisualStateManager2Command = new Command(OnStateManager2Click);
            CascadingStyleSheetCommand = new Command(OnCascadingStyleSheetClick);
            BindableLayoutCommand = new Command(OnBindableLayoutClick);
        }

        private void OnFlexLayout1Click()
        {
            // Flex Layout 1 Click
            if(Navigation!=null)
            {
                Navigation.PushAsync(new FlexLayoutPage());
            }
        }

        private void OnFlexLayout2Click()
        {
            // Flex Layout 2 Click
            if (Navigation != null)
            {
                Navigation.PushAsync(new FlexLayoutPage2());
            }
        }

        private void OnFlexLayout3Click()
        {
            // Flex Layout 2 Click
            if (Navigation != null)
            {
                Navigation.PushAsync(new FlexLayoutPage3());
            }
        }


        private void OnStateManager1Click()
        {
            // Flex Layout 2 Click
            if (Navigation != null)
            {
                Navigation.PushAsync(new VisualStateManagerPage());
            }
        }

        private void OnStateManager2Click()
        {
            // Flex Layout 2 Click
            if (Navigation != null)
            {
                Navigation.PushAsync(new VisualStateManager2Page());
            }
        }

        private void OnCascadingStyleSheetClick()
        {
            // Flex Layout 2 Click
            if (Navigation != null)
            {
                Navigation.PushAsync(new CSSPage());
            }
        }

        private void OnBindableLayoutClick()
        {
            // Flex Layout 2 Click
            if (Navigation != null)
            {
                Navigation.PushAsync(new BindableLayoutPage());
            }
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
