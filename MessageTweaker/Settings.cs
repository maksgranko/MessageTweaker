using System;
using System.Windows.Forms;

namespace MessageTweaker
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            InitializeConfiguration();
        }
        public void InitializeConfiguration()
        {
            Timeout_TextBox.Text = Properties.Settings.Default.Timeout.ToString();
            UTC_offset.Text = Properties.Settings.Default.UTC.ToString();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Timeout_TextBox_TextChanged(object sender, EventArgs e)
        {
            ushort temp = 15;
            try
            {
                if (Convert.ToUInt16(Timeout_TextBox.Text) > 65535 || Convert.ToUInt16(Timeout_TextBox.Text) < 0)
                {
                    Timeout_TextBox.Text = "15";
                }

                temp = Convert.ToUInt16(Timeout_TextBox.Text);
                Timeout_TextBox.Text = temp.ToString();
                Properties.Settings.Default.Timeout = temp;

            }
            catch (System.FormatException)
            {
                Properties.Settings.Default.Timeout = 15;
                Timeout_TextBox.Text = "15";
            }
            catch (System.OverflowException)
            {
                Properties.Settings.Default.Timeout = 15;
                Timeout_TextBox.Text = "15";
            }
        }

        private void UTC_offset_TextChanged(object sender, EventArgs e)
        {
            ushort temp = 3;
            try
            {
                if (Convert.ToUInt16(UTC_offset.Text) > 23 || Convert.ToUInt16(UTC_offset.Text) < 0)
                {
                    UTC_offset.Text = "3";
                }

                temp = Convert.ToUInt16(UTC_offset.Text);
                UTC_offset.Text = temp.ToString();
                Properties.Settings.Default.UTC = temp;

            }
            catch (System.FormatException)
            {
                Properties.Settings.Default.UTC = 3;
                UTC_offset.Text = "3";
            }
            catch (System.OverflowException)
            {
                Properties.Settings.Default.UTC = 3;
                UTC_offset.Text = "3";
            }
        }

    }
}
