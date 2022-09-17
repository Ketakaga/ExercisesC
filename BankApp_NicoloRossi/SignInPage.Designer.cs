namespace BankApp_NicoloRossi
{
    partial class SignInPage
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_errorAccount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBx_Pass = new System.Windows.Forms.TextBox();
            this.txtbx_AccNum = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_confPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_confirmPssw = new System.Windows.Forms.Label();
            this.lbl_length = new System.Windows.Forms.Label();
            this.lbl_Up = new System.Windows.Forms.Label();
            this.lbl_Num = new System.Windows.Forms.Label();
            this.lbl_lower = new System.Windows.Forms.Label();
            this.lbl_accountN = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_special = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ChkBox_ShowPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankApp_NicoloRossi.Properties.Resources.money;
            this.pictureBox1.Location = new System.Drawing.Point(513, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_errorAccount
            // 
            this.lbl_errorAccount.AutoSize = true;
            this.lbl_errorAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorAccount.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorAccount.Location = new System.Drawing.Point(25, 222);
            this.lbl_errorAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_errorAccount.Name = "lbl_errorAccount";
            this.lbl_errorAccount.Size = new System.Drawing.Size(0, 29);
            this.lbl_errorAccount.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(320, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 54);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bank App";
            // 
            // TxtBx_Pass
            // 
            this.TxtBx_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Pass.Location = new System.Drawing.Point(17, 255);
            this.TxtBx_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_Pass.MaxLength = 16;
            this.TxtBx_Pass.Name = "TxtBx_Pass";
            this.TxtBx_Pass.Size = new System.Drawing.Size(325, 49);
            this.TxtBx_Pass.TabIndex = 2;
            this.toolTip1.SetToolTip(this.TxtBx_Pass, "Set your password for online account");
            this.TxtBx_Pass.UseSystemPasswordChar = true;
            this.TxtBx_Pass.TextChanged += new System.EventHandler(this.TxtBx_Pass_TextChanged);
            // 
            // txtbx_AccNum
            // 
            this.txtbx_AccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_AccNum.Location = new System.Drawing.Point(13, 102);
            this.txtbx_AccNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_AccNum.MaxLength = 8;
            this.txtbx_AccNum.Name = "txtbx_AccNum";
            this.txtbx_AccNum.Size = new System.Drawing.Size(214, 49);
            this.txtbx_AccNum.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtbx_AccNum, "Insert your bank Account Number");
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(272, 573);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(220, 111);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btn_exit, "Close register form");
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(12, 573);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(198, 111);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Register";
            this.toolTip1.SetToolTip(this.btn_login, "Create the account with passoword specified");
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Account Number";
            // 
            // txtbx_confPass
            // 
            this.txtbx_confPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_confPass.Location = new System.Drawing.Point(12, 443);
            this.txtbx_confPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_confPass.MaxLength = 16;
            this.txtbx_confPass.Name = "txtbx_confPass";
            this.txtbx_confPass.Size = new System.Drawing.Size(325, 49);
            this.txtbx_confPass.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtbx_confPass, "Repeat the same password to confirm");
            this.txtbx_confPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 397);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 42);
            this.label6.TabIndex = 24;
            this.label6.Text = "Confirm Password";
            // 
            // lbl_confirmPssw
            // 
            this.lbl_confirmPssw.AutoSize = true;
            this.lbl_confirmPssw.ForeColor = System.Drawing.Color.Red;
            this.lbl_confirmPssw.Location = new System.Drawing.Point(8, 498);
            this.lbl_confirmPssw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_confirmPssw.Name = "lbl_confirmPssw";
            this.lbl_confirmPssw.Size = new System.Drawing.Size(0, 22);
            this.lbl_confirmPssw.TabIndex = 25;
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.ForeColor = System.Drawing.Color.Red;
            this.lbl_length.Location = new System.Drawing.Point(398, 307);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(294, 22);
            this.lbl_length.TabIndex = 26;
            this.lbl_length.Text = "- Lenght between 8 and 16 char";
            // 
            // lbl_Up
            // 
            this.lbl_Up.AutoSize = true;
            this.lbl_Up.ForeColor = System.Drawing.Color.Red;
            this.lbl_Up.Location = new System.Drawing.Point(398, 366);
            this.lbl_Up.Name = "lbl_Up";
            this.lbl_Up.Size = new System.Drawing.Size(242, 22);
            this.lbl_Up.TabIndex = 27;
            this.lbl_Up.Text = "- At least one Upper Case";
            // 
            // lbl_Num
            // 
            this.lbl_Num.AutoSize = true;
            this.lbl_Num.ForeColor = System.Drawing.Color.Red;
            this.lbl_Num.Location = new System.Drawing.Point(398, 430);
            this.lbl_Num.Name = "lbl_Num";
            this.lbl_Num.Size = new System.Drawing.Size(180, 22);
            this.lbl_Num.TabIndex = 28;
            this.lbl_Num.Text = "- At least a number";
            // 
            // lbl_lower
            // 
            this.lbl_lower.AutoSize = true;
            this.lbl_lower.ForeColor = System.Drawing.Color.Red;
            this.lbl_lower.Location = new System.Drawing.Point(398, 397);
            this.lbl_lower.Name = "lbl_lower";
            this.lbl_lower.Size = new System.Drawing.Size(242, 22);
            this.lbl_lower.TabIndex = 29;
            this.lbl_lower.Text = "- At least one Lower Case";
            // 
            // lbl_accountN
            // 
            this.lbl_accountN.AutoSize = true;
            this.lbl_accountN.ForeColor = System.Drawing.Color.Red;
            this.lbl_accountN.Location = new System.Drawing.Point(14, 155);
            this.lbl_accountN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_accountN.Name = "lbl_accountN";
            this.lbl_accountN.Size = new System.Drawing.Size(0, 22);
            this.lbl_accountN.TabIndex = 30;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.ForeColor = System.Drawing.Color.Red;
            this.lbl_password.Location = new System.Drawing.Point(17, 352);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(0, 22);
            this.lbl_password.TabIndex = 31;
            // 
            // lbl_special
            // 
            this.lbl_special.AutoSize = true;
            this.lbl_special.ForeColor = System.Drawing.Color.Red;
            this.lbl_special.Location = new System.Drawing.Point(398, 339);
            this.lbl_special.Name = "lbl_special";
            this.lbl_special.Size = new System.Drawing.Size(226, 22);
            this.lbl_special.TabIndex = 32;
            this.lbl_special.Text = "- One Special Character";
            // 
            // ChkBox_ShowPass
            // 
            this.ChkBox_ShowPass.AutoSize = true;
            this.ChkBox_ShowPass.Location = new System.Drawing.Point(17, 311);
            this.ChkBox_ShowPass.Name = "ChkBox_ShowPass";
            this.ChkBox_ShowPass.Size = new System.Drawing.Size(174, 26);
            this.ChkBox_ShowPass.TabIndex = 3;
            this.ChkBox_ShowPass.Text = "Show Password";
            this.ChkBox_ShowPass.UseVisualStyleBackColor = true;
            this.ChkBox_ShowPass.CheckedChanged += new System.EventHandler(this.ChkBox_ShowPass_CheckedChanged);
            // 
            // SignInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(817, 691);
            this.Controls.Add(this.ChkBox_ShowPass);
            this.Controls.Add(this.lbl_special);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_accountN);
            this.Controls.Add(this.lbl_lower);
            this.Controls.Add(this.lbl_Num);
            this.Controls.Add(this.lbl_Up);
            this.Controls.Add(this.lbl_length);
            this.Controls.Add(this.lbl_confirmPssw);
            this.Controls.Add(this.txtbx_confPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_errorAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBx_Pass);
            this.Controls.Add(this.txtbx_AccNum);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignInPage";
            this.Text = "Create a new account";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_errorAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBx_Pass;
        private System.Windows.Forms.TextBox txtbx_AccNum;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_confPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_confirmPssw;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Label lbl_Up;
        private System.Windows.Forms.Label lbl_Num;
        private System.Windows.Forms.Label lbl_lower;
        private System.Windows.Forms.Label lbl_accountN;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_special;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox ChkBox_ShowPass;
    }
}