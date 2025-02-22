namespace Chat322_Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbox_outMessege = new System.Windows.Forms.TextBox();
            this.tbox_groupMessages = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_GetMessage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_TextSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.NetSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tbIniFile = new System.Windows.Forms.TextBox();
            this.lb_activeGroup = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbox_outMessege
            // 
            this.tbox_outMessege.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_outMessege.Location = new System.Drawing.Point(27, 550);
            this.tbox_outMessege.Multiline = true;
            this.tbox_outMessege.Name = "tbox_outMessege";
            this.tbox_outMessege.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_outMessege.Size = new System.Drawing.Size(386, 96);
            this.tbox_outMessege.TabIndex = 0;
            // 
            // tbox_groupMessages
            // 
            this.tbox_groupMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_groupMessages.Location = new System.Drawing.Point(27, 69);
            this.tbox_groupMessages.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tbox_groupMessages.Multiline = true;
            this.tbox_groupMessages.Name = "tbox_groupMessages";
            this.tbox_groupMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_groupMessages.Size = new System.Drawing.Size(386, 454);
            this.tbox_groupMessages.TabIndex = 1;
            this.tbox_groupMessages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(439, 69);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(202, 249);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(444, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Участники чата:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(441, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список чатов:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить участника";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(650, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "Создать";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_GetMessage
            // 
            this.btn_GetMessage.Location = new System.Drawing.Point(439, 573);
            this.btn_GetMessage.Name = "btn_GetMessage";
            this.btn_GetMessage.Size = new System.Drawing.Size(75, 56);
            this.btn_GetMessage.TabIndex = 12;
            this.btn_GetMessage.Text = "Отправить";
            this.btn_GetMessage.UseVisualStyleBackColor = true;
            this.btn_GetMessage.Click += new System.EventHandler(this.btn_GetMessage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Сообщение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Чат:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(439, 341);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(650, 376);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 16;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_TextSetting,
            this.NetSettings});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.ToolStripMenuItem.Text = "Настройки";
            // 
            // btn_TextSetting
            // 
            this.btn_TextSetting.Name = "btn_TextSetting";
            this.btn_TextSetting.Size = new System.Drawing.Size(187, 22);
            this.btn_TextSetting.Text = "Текст";
            this.btn_TextSetting.Click += new System.EventHandler(this.btn_TextSetting_Click);
            // 
            // NetSettings
            // 
            this.NetSettings.Name = "NetSettings";
            this.NetSettings.Size = new System.Drawing.Size(187, 22);
            this.NetSettings.Text = "сетевые настройки";
            this.NetSettings.Click += new System.EventHandler(this.NetSettings_Click);
            // 
            // tbIniFile
            // 
            this.tbIniFile.Location = new System.Drawing.Point(444, 422);
            this.tbIniFile.Multiline = true;
            this.tbIniFile.Name = "tbIniFile";
            this.tbIniFile.Size = new System.Drawing.Size(197, 101);
            this.tbIniFile.TabIndex = 20;
            // 
            // lb_activeGroup
            // 
            this.lb_activeGroup.AutoSize = true;
            this.lb_activeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_activeGroup.Location = new System.Drawing.Point(74, 43);
            this.lb_activeGroup.Name = "lb_activeGroup";
            this.lb_activeGroup.Size = new System.Drawing.Size(0, 17);
            this.lb_activeGroup.TabIndex = 21;
            this.lb_activeGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 669);
            this.Controls.Add(this.lb_activeGroup);
            this.Controls.Add(this.tbIniFile);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_GetMessage);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbox_groupMessages);
            this.Controls.Add(this.tbox_outMessege);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "CHAT-322";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_outMessege;
        private System.Windows.Forms.TextBox tbox_groupMessages;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_GetMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_TextSetting;
        private System.Windows.Forms.TextBox tbIniFile;
        private System.Windows.Forms.ToolStripMenuItem NetSettings;
        private System.Windows.Forms.Label lb_activeGroup;
    }
}

