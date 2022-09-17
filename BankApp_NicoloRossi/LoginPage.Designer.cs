namespace BankApp_NicoloRossi
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signin = new System.Windows.Forms.Button();
            this.txtbx_AccNum = new System.Windows.Forms.TextBox();
            this.TxtBx_Pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_errorAccount = new System.Windows.Forms.Label();
            this.lbl_errorPass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ChkBox_ShowPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(9, 404);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(203, 112);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Log in";
            this.toolTip1.SetToolTip(this.btn_login, "Click to login");
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_signin
            // 
            this.btn_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.Location = new System.Drawing.Point(551, 433);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(160, 81);
            this.btn_signin.TabIndex = 5;
            this.btn_signin.Text = "Exit";
            this.toolTip1.SetToolTip(this.btn_signin, "Click to close the app");
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txtbx_AccNum
            // 
            this.txtbx_AccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_AccNum.Location = new System.Drawing.Point(20, 112);
            this.txtbx_AccNum.MaxLength = 8;
            this.txtbx_AccNum.Name = "txtbx_AccNum";
            this.txtbx_AccNum.Size = new System.Drawing.Size(311, 49);
            this.txtbx_AccNum.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtbx_AccNum, "Insert Account Number");
            // 
            // TxtBx_Pass
            // 
            this.TxtBx_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Pass.Location = new System.Drawing.Point(20, 241);
            this.TxtBx_Pass.MaxLength = 16;
            this.TxtBx_Pass.Name = "TxtBx_Pass";
            this.TxtBx_Pass.Size = new System.Drawing.Size(308, 49);
            this.TxtBx_Pass.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TxtBx_Pass, "Insert Password");
            this.TxtBx_Pass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(265, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bank App";
            // 
            // lbl_errorAccount
            // 
            this.lbl_errorAccount.AutoSize = true;
            this.lbl_errorAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorAccount.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorAccount.Location = new System.Drawing.Point(23, 164);
            this.lbl_errorAccount.Name = "lbl_errorAccount";
            this.lbl_errorAccount.Size = new System.Drawing.Size(0, 29);
            this.lbl_errorAccount.TabIndex = 7;
            // 
            // lbl_errorPass
            // 
            this.lbl_errorPass.AutoSize = true;
            this.lbl_errorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorPass.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorPass.Location = new System.Drawing.Point(19, 330);
            this.lbl_errorPass.Name = "lbl_errorPass";
            this.lbl_errorPass.Size = new System.Drawing.Size(0, 22);
            this.lbl_errorPass.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(218, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 112);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign in";
            this.toolTip1.SetToolTip(this.button1, "Click to create a new account");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ChkBox_ShowPass
            // 
            this.ChkBox_ShowPass.AutoSize = true;
            this.ChkBox_ShowPass.Location = new System.Drawing.Point(19, 296);
            this.ChkBox_ShowPass.Name = "ChkBox_ShowPass";
            this.ChkBox_ShowPass.Size = new System.Drawing.Size(125, 20);
            this.ChkBox_ShowPass.TabIndex = 2;
            this.ChkBox_ShowPass.Text = "Show Password";
            this.ChkBox_ShowPass.UseVisualStyleBackColor = true;
            this.ChkBox_ShowPass.CheckedChanged += new System.EventHandler(this.ChkBox_ShowPass_CheckedChanged);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(743, 516);
            this.Controls.Add(this.ChkBox_ShowPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_errorPass);
            this.Controls.Add(this.lbl_errorAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBx_Pass);
            this.Controls.Add(this.txtbx_AccNum);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginPage";
            this.Text = "Bank App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.TextBox txtbx_AccNum;
        private System.Windows.Forms.TextBox TxtBx_Pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_errorAccount;
        private System.Windows.Forms.Label lbl_errorPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox ChkBox_ShowPass;
    }
}

