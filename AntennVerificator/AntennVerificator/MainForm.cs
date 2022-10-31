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
            //Animator.Start();
        }
        private void HideAllSubMenus()
        {
            panelSubMenu.Visible = false;
            panelSettingsSubMenu.Visible = false;
            panelPresets.Visible = false;
            //Continue if more panels are added
        }
        #region -- Button Events --
        private void btnMenu1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            uiControl.ShowSubMenu(panelSubMenu);
        }

        private void btnPresets_Click(object sender, EventArgs e)
        {
            uiControl.ShowSubMenu(panelPresets);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            uiControl.ShowSubMenu(panelSettingsSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uiControl.OpenChildForm(new Form2(), panelChildForm);
            uiControl.HideSubMenu(panelSubMenu);
        }

        private void btnAntennaDB_Click(object sender, EventArgs e)
        {
            uiControl.OpenChildForm(new Form3(), panelChildForm);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
