using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinForms3Feature.ViewModels;

namespace XamarinForms3Feature.Views
{
    public partial class FlexLayoutPage3 : ContentPage
    {
        public List<string> GenderList { get; set; }

        public FlexLayoutPage3()
        {
            InitializeComponent();

            HandleClickEvent();

            MakePickerList();

        }

        private void HandleClickEvent()
        {
            TapGestureRecognizer gestureRecognizer = new TapGestureRecognizer();
            gestureRecognizer.Tapped+= OnCheckClickEvent;
            ImageCheck.GestureRecognizers.Add(gestureRecognizer);
        }

        void OnCheckClickEvent(object sender, EventArgs e)
        {
            SkillItemViewModel skillItemViewModel = new SkillItemViewModel();

            SkillsItemView SkillsItemView = new SkillsItemView(skillItemViewModel);
            skillItemViewModel.Skill = SkillEntry.Text;
            SkillsItemView.DeleteSkill+= SkillsItemViewDeleteSkill;

            // Add Skill To FlexLayout
            FlexSkillContainer.Children.Add(SkillsItemView);

            SkillEntry.Text = "";
        }

        void SkillsItemViewDeleteSkill(object sender, SkillsItemView e)
        {
            if (e != null)
            {
                FlexSkillContainer.Children.Remove(e);
            }
        }

        private void MakePickerList()
        {
            GenderList = new List<string>();

            // Sex List
            GenderList.Add("Male");
            GenderList.Add("Female");

            GenderPicker.ItemsSource = GenderList;

        }

    }
}
