using System;
using System.Windows.Forms;

namespace AntennVerificator
{
    public class UIControl
    {
        private Form activeForm = null;

        public void HideSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
                subMenu.Visible = false;
        }

        public void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        public void OpenChildForm(Form childForm, Panel panel)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
