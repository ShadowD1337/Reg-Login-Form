namespace name_pass
{
    partial class Form1
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
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.tbox_user = new System.Windows.Forms.TextBox();
            this.tbox_pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_sqside = new System.Windows.Forms.Label();
            this.tbox_sqside = new System.Windows.Forms.TextBox();
            this.lbl_sqface = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(162, 71);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(116, 25);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "Username:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(162, 160);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(112, 25);
            this.lbl_pass.TabIndex = 1;
            this.lbl_pass.Text = "Password:";
            // 
            // tbox_user
            // 
            this.tbox_user.Location = new System.Drawing.Point(449, 68);
            this.tbox_user.Name = "tbox_user";
            this.tbox_user.Size = new System.Drawing.Size(279, 31);
            this.tbox_user.TabIndex = 2;
            // 
            // tbox_pass
            // 
            this.tbox_pass.Location = new System.Drawing.Point(449, 154);
            this.tbox_pass.Name = "tbox_pass";
            this.tbox_pass.Size = new System.Drawing.Size(279, 31);
            this.tbox_pass.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(521, 228);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(135, 69);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_sqside
            // 
            this.lbl_sqside.AutoSize = true;
            this.lbl_sqside.Location = new System.Drawing.Point(162, 349);
            this.lbl_sqside.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_sqside.Name = "lbl_sqside";
            this.lbl_sqside.Size = new System.Drawing.Size(207, 25);
            this.lbl_sqside.TabIndex = 5;
            this.lbl_sqside.Text = "Страна на квадрат:";
            // 
            // tbox_sqside
            // 
            this.tbox_sqside.Location = new System.Drawing.Point(449, 349);
            this.tbox_sqside.Name = "tbox_sqside";
            this.tbox_sqside.Size = new System.Drawing.Size(279, 31);
            this.tbox_sqside.TabIndex = 6;
            // 
            // lbl_sqface
            // 
            this.lbl_sqface.AutoSize = true;
            this.lbl_sqface.Location = new System.Drawing.Point(162, 437);
            this.lbl_sqface.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_sqface.Name = "lbl_sqface";
            this.lbl_sqface.Size = new System.Drawing.Size(18, 25);
            this.lbl_sqface.TabIndex = 7;
            this.lbl_sqface.Text = " ";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(573, 415);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(135, 69);
            this.btn_calc.TabIndex = 8;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(281, 228);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(135, 69);
            this.btn_register.TabIndex = 9;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 572);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.lbl_sqface);
            this.Controls.Add(this.tbox_sqside);
            this.Controls.Add(this.lbl_sqside);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbox_pass);
            this.Controls.Add(this.tbox_user);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox tbox_user;
        private System.Windows.Forms.TextBox tbox_pass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_sqside;
        private System.Windows.Forms.TextBox tbox_sqside;
        private System.Windows.Forms.Label lbl_sqface;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_register;
    }
}

