using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinForms3Feature.ViewModels;

namespace XamarinForms3Feature.Views
{
    public partial class SkillsItemView : ContentView
    {
        // Event Handle for deleting view
        public event EventHandler<SkillsItemView> DeleteSkill;

        SkillItemViewModel SkillItemViewModel;

        Label Skill;
        Image Cross;

        public SkillsItemView(SkillItemViewModel SkillItemViewModel)
        {
            InitializeComponent();

            Skill = LabelSkill;
            Cross = ImgCross;

            this.SkillItemViewModel = SkillItemViewModel;
            SkillItemViewModel.SkillsItemView = this;

            BindingContext = SkillItemViewModel;
        }

        public void OnDeleteSkill()
        {
            if(DeleteSkill!=null)
            {
                DeleteSkill.Invoke(this, this);
            }
        }
    }
}
