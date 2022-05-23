using System;
using System.Windows.Forms;
using System.Threading;


namespace Diploma.Pages
{
    public partial class Settings : Form
    {
        private int selectedIndex;
        public Settings()
        {
            InitializeComponent();
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
                    //comboBoxLanguage.Text = "English";
                    selectedIndex = 0;
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("uk");
                    PagesContainer.Home.SuperUpdate();
                    //comboBoxLanguage.Text = "Ukrainian";
                    selectedIndex = 1;
                    break;
            }
            Controls.Clear();
            InitializeComponent();
            
            comboBoxLanguage.SelectedIndex = selectedIndex;
            
            //comboBoxLanguage.Text = SelectedText;
        }
    }
}
