namespace Chat322_Client
{
    partial class Authorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Entrance = new System.Windows.Forms.Button();
            this.RegNewPerson = new System.Windows.Forms.LinkLabel();
            this.tbox_Nickname = new System.Windows.Forms.TextBox();
            this.tbox_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Пароль";
            // 
            // btn_Entrance
            // 
            this.btn_Entrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Entrance.Location = new System.Drawing.Point(85, 215);
            this.btn_Entrance.Name = "btn_Entrance";
            this.btn_Entrance.Size = new System.Drawing.Size(116, 40);
            this.btn_Entrance.TabIndex = 17;
            this.btn_Entrance.Text = "Вход";
            this.btn_Entrance.UseVisualStyleBackColor = true;
            this.btn_Entrance.Click += new System.EventHandler(this.btn_Entrance_Click);
            // 
            // RegNewPerson
            // 
            this.RegNewPerson.AutoSize = true;
            this.RegNewPerson.Location = new System.Drawing.Point(100, 285);
            this.RegNewPerson.Name = "RegNewPerson";
            this.RegNewPerson.Size = new System.Drawing.Size(87, 13);
            this.RegNewPerson.TabIndex = 18;
            this.RegNewPerson.TabStop = true;
            this.RegNewPerson.Text = "РЕГИСТРАЦИЯ";
            this.RegNewPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegNewPerson_LinkClicked);
            // 
            // tbox_Nickname
            // 
            this.tbox_Nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_Nickname.Location = new System.Drawing.Point(45, 41);
            this.tbox_Nickname.Margin = new System.Windows.Forms.Padding(200, 3, 200, 3);
            this.tbox_Nickname.Name = "tbox_Nickname";
            this.tbox_Nickname.Size = new System.Drawing.Size(200, 26);
            this.tbox_Nickname.TabIndex = 19;
            // 
            // tbox_Password
            // 
            this.tbox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_Password.Location = new System.Drawing.Point(45, 114);
            this.tbox_Password.Margin = new System.Windows.Forms.Padding(200, 3, 200, 3);
            this.tbox_Password.Name = "tbox_Password";
            this.tbox_Password.Size = new System.Drawing.Size(200, 26);
            this.tbox_Password.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nickname";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_Password);
            this.Controls.Add(this.tbox_Nickname);
            this.Controls.Add(this.RegNewPerson);
            this.Controls.Add(this.btn_Entrance);
            this.Controls.Add(this.label1);
            this.Name = "Authorization";
            this.Text = "Авторизацая";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Entrance;
        private System.Windows.Forms.LinkLabel RegNewPerson;
        private System.Windows.Forms.TextBox tbox_Nickname;
        private System.Windows.Forms.TextBox tbox_Password;
        private System.Windows.Forms.Label label2;
    }
}