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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
            //Animator.Start();
        }
        private void CustomizeDesign()
        {
            panelSubMenu.Visible = false;
            panelSettingsSubMenu.Visible = false;
            panelPresets.Visible = false;
            //Continue if more panels are added
        }

        private void HideSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
                subMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu);
        }

        private void btnPresets_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPresets);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSettingsSubMenu);
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
        }

        private void btnAntennaDB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
        }
    }
}
