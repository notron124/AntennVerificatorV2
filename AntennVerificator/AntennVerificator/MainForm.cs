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


        private void btnSettings_Click(object sender, EventArgs e)
        {
            uiControl.OpenChildForm(new DataBase(), panelChildForm);
        }

        private void btnAntennaDB_Click(object sender, EventArgs e)
        {
            uiControl.OpenChildForm(new HelpForm(), panelChildForm);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            uiControl.OpenChildForm(new About(), panelChildForm);
        }
        #endregion

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            uiControl.OpenChildForm(new Calculator(), panelChildForm);
        }

        private void btnPresets_Click(object sender, EventArgs e)
        {
            uiControl.OpenChildForm(new Instruction(), panelChildForm);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
