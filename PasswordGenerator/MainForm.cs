using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        PasswordGeneratorForm form = null;
        void f_Disposed(object sender, EventArgs e)
        {
            form = null;
        }

        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(224, 191, 230);
            this.labelLogin.ForeColor = Color.FromArgb(102, 45, 145);
            this.labelPassword.ForeColor = Color.FromArgb(102, 45, 145);
            this.logBtn.BackColor = Color.FromArgb(102, 45, 145);
            this.logBtn.ForeColor = Color.FromArgb(224, 191, 230);
            this.changeBtn.BackColor = Color.FromArgb(102, 45, 145);
            this.changeBtn.ForeColor = Color.FromArgb(224, 191, 230);

        }
        

        private void changeBtn_Click(object sender, EventArgs e)
        {
           if(form == null)
           {
                form = new PasswordGeneratorForm();
                form.Disposed += new EventHandler(f_Disposed);
                form.ShowDialog();
           } 
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");

        }
    }
}
