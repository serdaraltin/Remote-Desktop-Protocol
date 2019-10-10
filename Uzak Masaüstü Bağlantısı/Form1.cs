using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MSTSCLib;

namespace Uzak_Masaüstü_Bağlantısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                axMsTscAxNotSafeForScripting1.Server = textBox1.Text;
                axMsTscAxNotSafeForScripting1.UserName = textBox2.Text;
                IMsTscNonScriptable secured = (IMsTscNonScriptable)axMsTscAxNotSafeForScripting1.GetOcx();
                secured.ClearTextPassword = textBox3.Text;
                axMsTscAxNotSafeForScripting1.Connect();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Bağlantı Hatası", "Pc’ye Ulaşılamadı." + "Hata:" + Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
        
                if (axMsTscAxNotSafeForScripting1.Connected.ToString() == "1")
                    axMsTscAxNotSafeForScripting1.Disconnect();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Bağlantı Hatası", "Pc’ye Ulaşılamadı." + "Hata:" + Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
