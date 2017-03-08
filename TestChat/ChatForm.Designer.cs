﻿namespace TestChat
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
            this.buttonPost = new System.Windows.Forms.Button();
            this.labelTotalText = new System.Windows.Forms.Label();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.labelStatusValue = new System.Windows.Forms.Label();
            this.labelRegistered = new System.Windows.Forms.Label();
            this.labelRegisteredCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonProfie = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.listViewChat.Size = new System.Drawing.Size(371, 180);
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
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(392, 19);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(107, 23);
            this.buttonPost.TabIndex = 3;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
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
            this.labelTotalCount.Location = new System.Drawing.Point(87, 17);
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
            this.textBoxMessage.Size = new System.Drawing.Size(371, 54);
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
            this.labelStatusValue.Location = new System.Drawing.Point(87, 52);
            this.labelStatusValue.Name = "labelStatusValue";
            this.labelStatusValue.Size = new System.Drawing.Size(21, 13);
            this.labelStatusValue.TabIndex = 8;
            this.labelStatusValue.Text = "No";
            // 
            // labelRegistered
            // 
            this.labelRegistered.AutoSize = true;
            this.labelRegistered.Location = new System.Drawing.Point(16, 52);
            this.labelRegistered.Name = "labelRegistered";
            this.labelRegistered.Size = new System.Drawing.Size(57, 13);
            this.labelRegistered.TabIndex = 9;
            this.labelRegistered.Text = "Logged in:";
            // 
            // labelRegisteredCount
            // 
            this.labelRegisteredCount.AutoSize = true;
            this.labelRegisteredCount.Location = new System.Drawing.Point(87, 34);
            this.labelRegisteredCount.Name = "labelRegisteredCount";
            this.labelRegisteredCount.Size = new System.Drawing.Size(13, 13);
            this.labelRegisteredCount.TabIndex = 10;
            this.labelRegisteredCount.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelStatusText);
            this.groupBox1.Controls.Add(this.labelTotalCount);
            this.groupBox1.Controls.Add(this.labelRegisteredCount);
            this.groupBox1.Controls.Add(this.labelRegistered);
            this.groupBox1.Controls.Add(this.labelStatusValue);
            this.groupBox1.Controls.Add(this.labelTotalText);
            this.groupBox1.Location = new System.Drawing.Point(383, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 79);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonProfie);
            this.groupBox2.Controls.Add(this.buttonLogin);
            this.groupBox2.Controls.Add(this.ButtonLogout);
            this.groupBox2.Location = new System.Drawing.Point(383, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 108);
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
            this.groupBox3.Controls.Add(this.buttonClear);
            this.groupBox3.Controls.Add(this.textBoxMessage);
            this.groupBox3.Controls.Add(this.buttonPost);
            this.groupBox3.Location = new System.Drawing.Point(12, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 87);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(392, 50);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(107, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.listViewChat);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(12, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(515, 211);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 306);
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
        private System.Windows.Forms.Button buttonPost;
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
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonProfie;
    }
}