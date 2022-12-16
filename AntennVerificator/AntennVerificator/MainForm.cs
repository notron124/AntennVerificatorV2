using System;
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
            //Continue if more panels are added
        }
        #region -- Button Events --
        private void btnMenu1_Click(object sender, EventArgs e)
        {
            //uiControl.OpenChildForm(new Form3(), panelChildForm);
            Form3 newForm = new Form3(this);
            newForm.Show();
            btnMenu1.Enabled = false;
            btnSettings.Enabled = false;
            btnAntennaDB.Enabled = false;
            btnPresets.Enabled = false;
            btnAbout.Enabled = false;
        }
        private void btnAntennaDB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нет блока");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для поверки антенн.\n" + "Разработана студентами ИРИТ-РТФ, группы РИ-490009:\n" + 
                "\nЖамбакиев Радий\n" + "Шестаков Сергей\n" + "Ждановских Владислав\n" + "Котельников Никита\n" + "\nЕкатеринбург 2022г");
        }
        #endregion

        private void btnPresets_Click_1(object sender, EventArgs e)
        {
            uiControl.OpenChildForm(new Instruction(), panelChildForm);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            uiControl.OpenChildForm(new DataBase(), panelChildForm);
        }
    }
}
