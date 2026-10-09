using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAV_E_commerce
{
    public partial class AccueilForm : Form
    {
        public AccueilForm()
        {
            InitializeComponent();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Message_Click(object sender, EventArgs e)
        {
            Form message = new MessageForm();
            message.Show();
        }
        private void Historic_Click(object sender, EventArgs e)
        {
            Form historic = new HistoricForm();
            historic.Show();
            
        }
    }
}
