using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinForms3Feature.Views;

namespace XamarinForms3Feature.ViewModels
{
    public class SkillItemViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _skill;

        public SkillsItemView SkillsItemView { get; set; }

        public ICommand CrossImageCommand { get; private set; }

        public SkillItemViewModel()
        {
            CrossImageCommand = new Command(OnDeleteSkillClicked);
        }

        private void OnDeleteSkillClicked()
        {
            if(SkillsItemView!=null)
            {
                SkillsItemView.OnDeleteSkill();
            }
        }

        public string Skill
        {
            get
            {
                return _skill;
            }
            set
            {
                _skill = value;

                OnPropertyChanged();

            }
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
