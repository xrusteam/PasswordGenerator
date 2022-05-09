
namespace PasswordGenerator
{
    partial class PasswordGeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLength = new System.Windows.Forms.Label();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.chkSim = new System.Windows.Forms.CheckBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.chkLower = new System.Windows.Forms.CheckBox();
            this.chkNum = new System.Windows.Forms.CheckBox();
            this.labelOptions = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLength.Location = new System.Drawing.Point(412, 31);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(163, 26);
            this.labelLength.TabIndex = 0;
            this.labelLength.Text = "Длина пароля:";
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSpecial.Location = new System.Drawing.Point(35, 78);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(309, 24);
            this.chkSpecial.TabIndex = 1;
            this.chkSpecial.Text = "Включить специальные символы";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // chkSim
            // 
            this.chkSim.AutoSize = true;
            this.chkSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSim.Location = new System.Drawing.Point(35, 124);
            this.chkSim.Name = "chkSim";
            this.chkSim.Size = new System.Drawing.Size(268, 24);
            this.chkSim.TabIndex = 2;
            this.chkSim.Text = "Включить похожие символы";
            this.chkSim.UseVisualStyleBackColor = true;
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkUpper.Location = new System.Drawing.Point(35, 174);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(287, 24);
            this.chkUpper.TabIndex = 3;
            this.chkUpper.Text = "Включить заглавные символы";
            this.chkUpper.UseVisualStyleBackColor = true;
            // 
            // chkLower
            // 
            this.chkLower.AutoSize = true;
            this.chkLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkLower.Location = new System.Drawing.Point(35, 223);
            this.chkLower.Name = "chkLower";
            this.chkLower.Size = new System.Drawing.Size(279, 24);
            this.chkLower.TabIndex = 4;
            this.chkLower.Text = "Включить строчные символы";
            this.chkLower.UseVisualStyleBackColor = true;
            // 
            // chkNum
            // 
            this.chkNum.AutoSize = true;
            this.chkNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNum.Location = new System.Drawing.Point(35, 267);
            this.chkNum.Name = "chkNum";
            this.chkNum.Size = new System.Drawing.Size(279, 24);
            this.chkNum.TabIndex = 5;
            this.chkNum.Text = "Включить числовые символы";
            this.chkNum.UseVisualStyleBackColor = true;
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOptions.Location = new System.Drawing.Point(30, 27);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(130, 26);
            this.labelOptions.TabIndex = 6;
            this.labelOptions.Text = "Параметры";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(617, 36);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(143, 22);
            this.lengthTextBox.TabIndex = 7;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(617, 179);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(143, 22);
            this.passTextBox.TabIndex = 8;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.Location = new System.Drawing.Point(444, 174);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(131, 29);
            this.labelPass.TabIndex = 9;
            this.labelPass.Text = "Password:";
            // 
            // generateBtn
            // 
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Location = new System.Drawing.Point(617, 267);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(143, 42);
            this.generateBtn.TabIndex = 10;
            this.generateBtn.Text = "Сгенерировать";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // PasswordGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.labelOptions);
            this.Controls.Add(this.chkNum);
            this.Controls.Add(this.chkLower);
            this.Controls.Add(this.chkUpper);
            this.Controls.Add(this.chkSim);
            this.Controls.Add(this.chkSpecial);
            this.Controls.Add(this.labelLength);
            this.Name = "PasswordGeneratorForm";
            this.Text = "PasswordGeneratorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.CheckBox chkSim;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.CheckBox chkLower;
        private System.Windows.Forms.CheckBox chkNum;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button generateBtn;
    }
}