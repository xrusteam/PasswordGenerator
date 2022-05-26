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
        public static string ExampleText { get; private set; }
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
            this.saveBtn.BackColor = Color.FromArgb(102, 45, 145);
            this.saveBtn.ForeColor = Color.FromArgb(224, 191, 230);
            Dictionary<char, char> Same = new Dictionary<char, char>();

        }
        const string Lower_Case = "abcdefghijklmnopqrstuvwxyz";
        const string Upper_Case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string Numeric_Case = "1234567890";
        const string Special_Char = "!#$%&()*+-,./:;<>=?@[]^_{}|~№'";
        string[] Similar_Char = new string[9] { "b6", "c(", "gq9", "CG", "LlI1|", "Oo0", "S5", "VU", "Z2i" };

        private void generateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                passTextBox.Text = PasswordGen(chkLower.Checked, chkUpper.Checked, chkNum.Checked, chkSpecial.Checked, chkSim.Checked, int.Parse(lengthTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string GenerateRAndompassword(string charSet,int length)
        {
            Random rnd = new Random();
            string password = "";
            for (int i = 0; i < length; i++)
            {
                password += charSet[rnd.Next(charSet.Length - 1)];
            }


            return password;
        }

        public string PasswordGen(bool lowerCase, bool upperCase, bool numericCase, bool specialChar, bool similarChar, int length)
        {
            string charSet = "";
            
            if (lowerCase)
                charSet += Lower_Case;
            if (upperCase)
                charSet += Upper_Case;
            if (numericCase)
                charSet += Numeric_Case;
            if (specialChar)
                charSet += Special_Char;

            string password = GenerateRAndompassword(charSet, length);

            if (similarChar)
            {
                foreach(string same in Similar_Char)
                {
                    for(int i=0;i<same.Length;i++)
                    {
                        if (password.Contains(same[i].ToString()))
                        {
                            for(int j = i + 1; j < same.Length; j++)
                            {
                                password=password.Replace(same[j], same[i]);
                            }
                            break;
                        }
                    }
                }
            }

            return  password;
        }
        private string Shipher(string shiph)
        {
            string newshiph = "";
            foreach(char a in shiph)
            {
                newshiph +=(char)(a*3+20);
            }
            return newshiph;
        }

        private void PasswordGeneratorForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterParent;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string newpassword =Shipher(passTextBox.Text);


        }
    }
}

