namespace Chat322_Client
{
    partial class Registration
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
            this.tbox_Password_reg = new System.Windows.Forms.TextBox();
            this.tbox_Nickname_reg = new System.Windows.Forms.TextBox();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbox_Password_reg
            // 
            this.tbox_Password_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_Password_reg.Location = new System.Drawing.Point(82, 113);
            this.tbox_Password_reg.Margin = new System.Windows.Forms.Padding(200, 3, 200, 3);
            this.tbox_Password_reg.Name = "tbox_Password_reg";
            this.tbox_Password_reg.Size = new System.Drawing.Size(200, 26);
            this.tbox_Password_reg.TabIndex = 25;
            // 
            // tbox_Nickname_reg
            // 
            this.tbox_Nickname_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_Nickname_reg.Location = new System.Drawing.Point(82, 41);
            this.tbox_Nickname_reg.Margin = new System.Windows.Forms.Padding(200, 3, 200, 3);
            this.tbox_Nickname_reg.Name = "tbox_Nickname_reg";
            this.tbox_Nickname_reg.Size = new System.Drawing.Size(200, 26);
            this.tbox_Nickname_reg.TabIndex = 24;
            // 
            // btn_Registration
            // 
            this.btn_Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Registration.Location = new System.Drawing.Point(82, 194);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(200, 40);
            this.btn_Registration.TabIndex = 23;
            this.btn_Registration.Text = "Регистрация";
            this.btn_Registration.UseVisualStyleBackColor = true;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nickname";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 292);
            this.Controls.Add(this.tbox_Password_reg);
            this.Controls.Add(this.tbox_Nickname_reg);
            this.Controls.Add(this.btn_Registration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_Password_reg;
        private System.Windows.Forms.TextBox tbox_Nickname_reg;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}