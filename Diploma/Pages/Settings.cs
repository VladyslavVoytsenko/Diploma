using System;
using System.Windows.Forms;
using System.Threading;


namespace Diploma.Pages
{
    public partial class Settings : Form
    {
        private int selectedIndex;
        [Obsolete("Obsolete")]
        public Settings()
        {
            InitializeComponent();
            //comboBoxLanguage.SelectedIndex = 1;
        }

        [Obsolete("Obsolete")]
        private void comboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLanguage.SelectedIndex == selectedIndex)
            {
                return;
            }
            switch (comboBoxLanguage.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    PagesContainer.Home.SuperUpdate();
                    selectedIndex = 0;
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("uk");
                    PagesContainer.Home.SuperUpdate();
                    selectedIndex = 1;
                    break;
            }
            Controls.Clear();
            InitializeComponent();
            
            comboBoxLanguage.SelectedIndex = selectedIndex;
        }
    }
}
