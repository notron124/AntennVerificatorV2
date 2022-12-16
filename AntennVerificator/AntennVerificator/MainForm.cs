﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntennVerificator
{
    public partial class MainForm : Form
    {
        #region -- Variables --
        private readonly UIControl uiControl = new UIControl();
        #endregion

        public MainForm()
        {
            InitializeComponent();
            HideAllSubMenus();
            Animator.Start();
        }
        private void HideAllSubMenus()
        {
            panelPresets.Visible = false;
            //Continue if more panels are added
        }
        #region -- Button Events --

        private void btnPresets_Click(object sender, EventArgs e)
        {
            uiControl.ShowSubMenu(panelPresets);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnAntennaDB_Click(object sender, EventArgs e)
        {
            uiControl.OpenChildForm(new DataBase(), panelChildForm);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для поверки антенн.\n" + "Разработана студентами ИРИТ-РТФ, группы РИ-490009:\n" + 
                "\nЖамбакиев Радий\n" + "Шестаков Сергей\n" + "Ждановских Владислав\n" + "Котельников Никита\n" + "\nЕкатеринбург 2022г");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            uiControl.OpenChildForm(new Instruction(), panelChildForm);
            uiControl.HideSubMenu(panelPresets);
        }
        #endregion

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            uiControl.OpenChildForm(new Calculator(), panelChildForm);
        }
    }
}
