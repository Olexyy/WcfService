namespace ChatClient
{
    partial class ChatForm
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
            this.listViewChat = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.buttonPostAll = new System.Windows.Forms.Button();
            this.labelTotalText = new System.Windows.Forms.Label();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.labelStatusValue = new System.Windows.Forms.Label();
            this.labelRegistered = new System.Windows.Forms.Label();
            this.labelRegisteredCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelGroupValue = new System.Windows.Forms.Label();
            this.labelGroupText = new System.Windows.Forms.Label();
            this.labelInGroupCount = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonProfie = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCsatAll = new System.Windows.Forms.Button();
            this.groupBoxbuttons = new System.Windows.Forms.GroupBox();
            this.buttonStopCasting = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPostGroup = new System.Windows.Forms.Button();
            this.buttonCastGroup = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxbuttons.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewChat
            // 
            this.listViewChat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewChat.Location = new System.Drawing.Point(6, 19);
            this.listViewChat.Name = "listViewChat";
            this.listViewChat.Size = new System.Drawing.Size(371, 215);
            this.listViewChat.TabIndex = 0;
            this.listViewChat.UseCompatibleStateImageBehavior = false;
            this.listViewChat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 61;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Text";
            this.columnHeader3.Width = 219;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(9, 19);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(107, 23);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Location = new System.Drawing.Point(9, 48);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(107, 23);
            this.ButtonLogout.TabIndex = 2;
            this.ButtonLogout.Text = "Logout";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // buttonPostAll
            // 
            this.buttonPostAll.Location = new System.Drawing.Point(279, 21);
            this.buttonPostAll.Name = "buttonPostAll";
            this.buttonPostAll.Size = new System.Drawing.Size(107, 23);
            this.buttonPostAll.TabIndex = 3;
            this.buttonPostAll.Text = "Post all";
            this.buttonPostAll.UseVisualStyleBackColor = true;
            this.buttonPostAll.Click += new System.EventHandler(this.buttonPostAll_Click);
            // 
            // labelTotalText
            // 
            this.labelTotalText.AutoSize = true;
            this.labelTotalText.Location = new System.Drawing.Point(16, 34);
            this.labelTotalText.Name = "labelTotalText";
            this.labelTotalText.Size = new System.Drawing.Size(61, 13);
            this.labelTotalText.TabIndex = 4;
            this.labelTotalText.Text = "Registered:";
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.AutoSize = true;
            this.labelTotalCount.Location = new System.Drawing.Point(79, 16);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(13, 13);
            this.labelTotalCount.TabIndex = 5;
            this.labelTotalCount.Text = "0";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(6, 19);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(258, 83);
            this.textBoxMessage.TabIndex = 6;
            // 
            // labelStatusText
            // 
            this.labelStatusText.AutoSize = true;
            this.labelStatusText.Location = new System.Drawing.Point(16, 16);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(34, 13);
            this.labelStatusText.TabIndex = 7;
            this.labelStatusText.Text = "Total:";
            // 
            // labelStatusValue
            // 
            this.labelStatusValue.AutoSize = true;
            this.labelStatusValue.Location = new System.Drawing.Point(79, 70);
            this.labelStatusValue.Name = "labelStatusValue";
            this.labelStatusValue.Size = new System.Drawing.Size(21, 13);
            this.labelStatusValue.TabIndex = 8;
            this.labelStatusValue.Text = "No";
            // 
            // labelRegistered
            // 
            this.labelRegistered.AutoSize = true;
            this.labelRegistered.Location = new System.Drawing.Point(16, 70);
            this.labelRegistered.Name = "labelRegistered";
            this.labelRegistered.Size = new System.Drawing.Size(57, 13);
            this.labelRegistered.TabIndex = 9;
            this.labelRegistered.Text = "Logged in:";
            // 
            // labelRegisteredCount
            // 
            this.labelRegisteredCount.AutoSize = true;
            this.labelRegisteredCount.Location = new System.Drawing.Point(79, 34);
            this.labelRegisteredCount.Name = "labelRegisteredCount";
            this.labelRegisteredCount.Size = new System.Drawing.Size(13, 13);
            this.labelRegisteredCount.TabIndex = 10;
            this.labelRegisteredCount.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelGroupValue);
            this.groupBox1.Controls.Add(this.labelGroupText);
            this.groupBox1.Controls.Add(this.labelInGroupCount);
            this.groupBox1.Controls.Add(this.labelGroup);
            this.groupBox1.Controls.Add(this.labelStatusText);
            this.groupBox1.Controls.Add(this.labelTotalCount);
            this.groupBox1.Controls.Add(this.labelRegisteredCount);
            this.groupBox1.Controls.Add(this.labelRegistered);
            this.groupBox1.Controls.Add(this.labelStatusValue);
            this.groupBox1.Controls.Add(this.labelTotalText);
            this.groupBox1.Location = new System.Drawing.Point(383, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 110);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // labelGroupValue
            // 
            this.labelGroupValue.AutoSize = true;
            this.labelGroupValue.Location = new System.Drawing.Point(79, 90);
            this.labelGroupValue.Name = "labelGroupValue";
            this.labelGroupValue.Size = new System.Drawing.Size(33, 13);
            this.labelGroupValue.TabIndex = 14;
            this.labelGroupValue.Text = "None";
            // 
            // labelGroupText
            // 
            this.labelGroupText.AutoSize = true;
            this.labelGroupText.Location = new System.Drawing.Point(16, 90);
            this.labelGroupText.Name = "labelGroupText";
            this.labelGroupText.Size = new System.Drawing.Size(39, 13);
            this.labelGroupText.TabIndex = 13;
            this.labelGroupText.Text = "Group:";
            // 
            // labelInGroupCount
            // 
            this.labelInGroupCount.AutoSize = true;
            this.labelInGroupCount.Location = new System.Drawing.Point(79, 52);
            this.labelInGroupCount.Name = "labelInGroupCount";
            this.labelInGroupCount.Size = new System.Drawing.Size(13, 13);
            this.labelInGroupCount.TabIndex = 12;
            this.labelInGroupCount.Text = "0";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(16, 52);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(49, 13);
            this.labelGroup.TabIndex = 11;
            this.labelGroup.Text = "In group:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonProfie);
            this.groupBox2.Controls.Add(this.buttonLogin);
            this.groupBox2.Controls.Add(this.ButtonLogout);
            this.groupBox2.Location = new System.Drawing.Point(383, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 111);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // buttonProfie
            // 
            this.buttonProfie.Location = new System.Drawing.Point(9, 77);
            this.buttonProfie.Name = "buttonProfie";
            this.buttonProfie.Size = new System.Drawing.Size(107, 23);
            this.buttonProfie.TabIndex = 3;
            this.buttonProfie.Text = "Profile";
            this.buttonProfie.UseVisualStyleBackColor = true;
            this.buttonProfie.Click += new System.EventHandler(this.buttonProfie_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCsatAll);
            this.groupBox3.Controls.Add(this.textBoxMessage);
            this.groupBox3.Controls.Add(this.buttonPostAll);
            this.groupBox3.Controls.Add(this.groupBoxbuttons);
            this.groupBox3.Location = new System.Drawing.Point(12, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 115);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // buttonCsatAll
            // 
            this.buttonCsatAll.Enabled = false;
            this.buttonCsatAll.Location = new System.Drawing.Point(392, 21);
            this.buttonCsatAll.Name = "buttonCsatAll";
            this.buttonCsatAll.Size = new System.Drawing.Size(107, 23);
            this.buttonCsatAll.TabIndex = 14;
            this.buttonCsatAll.Text = "Cast screen all";
            this.buttonCsatAll.UseVisualStyleBackColor = true;
            // 
            // groupBoxbuttons
            // 
            this.groupBoxbuttons.Controls.Add(this.buttonStopCasting);
            this.groupBoxbuttons.Controls.Add(this.buttonClear);
            this.groupBoxbuttons.Controls.Add(this.buttonPostGroup);
            this.groupBoxbuttons.Controls.Add(this.buttonCastGroup);
            this.groupBoxbuttons.Location = new System.Drawing.Point(270, 10);
            this.groupBoxbuttons.Name = "groupBoxbuttons";
            this.groupBoxbuttons.Size = new System.Drawing.Size(238, 99);
            this.groupBoxbuttons.TabIndex = 16;
            this.groupBoxbuttons.TabStop = false;
            // 
            // buttonStopCasting
            // 
            this.buttonStopCasting.Location = new System.Drawing.Point(122, 69);
            this.buttonStopCasting.Name = "buttonStopCasting";
            this.buttonStopCasting.Size = new System.Drawing.Size(107, 23);
            this.buttonStopCasting.TabIndex = 15;
            this.buttonStopCasting.Text = "Stop casting";
            this.buttonStopCasting.UseVisualStyleBackColor = true;
            this.buttonStopCasting.Click += new System.EventHandler(this.buttonStopCasting_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(9, 69);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(107, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPostGroup
            // 
            this.buttonPostGroup.Location = new System.Drawing.Point(9, 40);
            this.buttonPostGroup.Name = "buttonPostGroup";
            this.buttonPostGroup.Size = new System.Drawing.Size(107, 23);
            this.buttonPostGroup.TabIndex = 7;
            this.buttonPostGroup.Text = "Post group";
            this.buttonPostGroup.UseVisualStyleBackColor = true;
            this.buttonPostGroup.Click += new System.EventHandler(this.buttonPostGroup_Click);
            // 
            // buttonCastGroup
            // 
            this.buttonCastGroup.Location = new System.Drawing.Point(122, 40);
            this.buttonCastGroup.Name = "buttonCastGroup";
            this.buttonCastGroup.Size = new System.Drawing.Size(107, 23);
            this.buttonCastGroup.TabIndex = 13;
            this.buttonCastGroup.Text = "Cast screen group";
            this.buttonCastGroup.UseVisualStyleBackColor = true;
            this.buttonCastGroup.Click += new System.EventHandler(this.buttonCastGroup_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.listViewChat);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(12, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(515, 251);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 379);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "ChatForm";
            this.ShowIcon = false;
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxbuttons.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewChat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Button buttonPostAll;
        private System.Windows.Forms.Label labelTotalText;
        private System.Windows.Forms.Label labelTotalCount;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Label labelStatusValue;
        private System.Windows.Forms.Label labelRegistered;
        private System.Windows.Forms.Label labelRegisteredCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonPostGroup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonProfie;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelInGroupCount;
        private System.Windows.Forms.Label labelGroupText;
        private System.Windows.Forms.Label labelGroupValue;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCastGroup;
        private System.Windows.Forms.Button buttonCsatAll;
        private System.Windows.Forms.Button buttonStopCasting;
        private System.Windows.Forms.GroupBox groupBoxbuttons;
    }
}