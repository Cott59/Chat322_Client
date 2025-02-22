namespace Chat322_Client
{
    partial class NetSettings
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
            this.btn_apply = new System.Windows.Forms.Button();
            this.tbox_outport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_inport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_ipaddress = new System.Windows.Forms.TextBox();
            this.tbox_idPerson = new System.Windows.Forms.TextBox();
            this.tbox_NameGroup = new System.Windows.Forms.TextBox();
            this.NameGroup = new System.Windows.Forms.Label();
            this.IDPerson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_apply
            // 
            this.btn_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_apply.Location = new System.Drawing.Point(441, 216);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(118, 39);
            this.btn_apply.TabIndex = 0;
            this.btn_apply.Text = "Применить";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // tbox_outport
            // 
            this.tbox_outport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_outport.Location = new System.Drawing.Point(36, 119);
            this.tbox_outport.Name = "tbox_outport";
            this.tbox_outport.Size = new System.Drawing.Size(191, 26);
            this.tbox_outport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Порт отправки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Порт приёма";
            // 
            // tbox_inport
            // 
            this.tbox_inport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_inport.Location = new System.Drawing.Point(36, 185);
            this.tbox_inport.Name = "tbox_inport";
            this.tbox_inport.Size = new System.Drawing.Size(191, 26);
            this.tbox_inport.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP address";
            // 
            // tbox_ipaddress
            // 
            this.tbox_ipaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_ipaddress.Location = new System.Drawing.Point(36, 48);
            this.tbox_ipaddress.Name = "tbox_ipaddress";
            this.tbox_ipaddress.Size = new System.Drawing.Size(191, 26);
            this.tbox_ipaddress.TabIndex = 5;
            // 
            // tbox_idPerson
            // 
            this.tbox_idPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_idPerson.Location = new System.Drawing.Point(306, 119);
            this.tbox_idPerson.Name = "tbox_idPerson";
            this.tbox_idPerson.Size = new System.Drawing.Size(191, 26);
            this.tbox_idPerson.TabIndex = 7;
            // 
            // tbox_NameGroup
            // 
            this.tbox_NameGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_NameGroup.Location = new System.Drawing.Point(306, 48);
            this.tbox_NameGroup.Name = "tbox_NameGroup";
            this.tbox_NameGroup.Size = new System.Drawing.Size(191, 26);
            this.tbox_NameGroup.TabIndex = 8;
            // 
            // NameGroup
            // 
            this.NameGroup.AutoSize = true;
            this.NameGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameGroup.Location = new System.Drawing.Point(303, 77);
            this.NameGroup.Name = "NameGroup";
            this.NameGroup.Size = new System.Drawing.Size(125, 17);
            this.NameGroup.TabIndex = 9;
            this.NameGroup.Text = "Название Группы";
            // 
            // IDPerson
            // 
            this.IDPerson.AutoSize = true;
            this.IDPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDPerson.Location = new System.Drawing.Point(303, 148);
            this.IDPerson.Name = "IDPerson";
            this.IDPerson.Size = new System.Drawing.Size(79, 17);
            this.IDPerson.TabIndex = 10;
            this.IDPerson.Text = "ID клиента";
            // 
            // NetSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 276);
            this.Controls.Add(this.IDPerson);
            this.Controls.Add(this.NameGroup);
            this.Controls.Add(this.tbox_NameGroup);
            this.Controls.Add(this.tbox_idPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_ipaddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_inport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_outport);
            this.Controls.Add(this.btn_apply);
            this.Name = "NetSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.TextBox tbox_outport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_inport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_ipaddress;
        private System.Windows.Forms.TextBox tbox_idPerson;
        private System.Windows.Forms.TextBox tbox_NameGroup;
        private System.Windows.Forms.Label NameGroup;
        private System.Windows.Forms.Label IDPerson;
    }
}