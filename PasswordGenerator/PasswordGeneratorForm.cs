using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGeneratorForm : Form
    {
        public PasswordGeneratorForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(224, 191, 230);
            this.labelOptions.ForeColor = Color.FromArgb(102, 45, 145);
            this.chkSpecial.ForeColor = Color.FromArgb(102, 45, 145);
            this.chkSim.ForeColor = Color.FromArgb(102, 45, 145);
            this.chkUpper.ForeColor = Color.FromArgb(102, 45, 145);
            this.chkLower.ForeColor = Color.FromArgb(102, 45, 145);
            this.chkNum.ForeColor = Color.FromArgb(102, 45, 145);
            this.labelLength.ForeColor = Color.FromArgb(102, 45, 145);
            this.labelPass.ForeColor = Color.FromArgb(102, 45, 145);
            this.generateBtn.BackColor = Color.FromArgb(102, 45, 145);
            this.generateBtn.ForeColor = Color.FromArgb(224, 191, 230);
        }
        const string Lower_Case = "abcdefghijklmnopqrstuvwxyz";
        const string Upper_Case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string Numeric_Case = "1234567890";
        const string Special_Char = "!#$%&()*+-,./:;<>=?@[]^_{}|~№'";
        const string Similar_Char = "b6c(gq9CGLlI1|Oo0S5VUZ2i";

        private void generateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                passTextBox.Text = PasswordGen(chkLower.Checked, chkUpper.Checked, chkNum.Checked, chkSpecial.Checked, chkSim.Checked, int.Parse(lengthTextBox.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string PasswordGen(bool lowerCase,bool upperCase,bool numericCase,bool specialChar,bool similarChar,int length )
        {
            char[] password = new char[length];
            string charSet = "";
            Random rnd = new Random();
            if (lowerCase)
                charSet += Lower_Case;
            if (upperCase)
                charSet += Upper_Case;
            if (numericCase)
                charSet += Numeric_Case;
            if (specialChar)
                charSet += Special_Char;
            if (similarChar)
                charSet += Similar_Char;
            for(int i = 0; i < length; i++)
            {
                password[i] = charSet[rnd.Next(charSet.Length - 1)];
            }
            return string.Join(null, password);
        }
    }
}

