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
            this.buttonPost = new System.Windows.Forms.Button();
            this.labelTotalText = new System.Windows.Forms.Label();
            this.labelTotaDigit = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.labelStatusValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewChat
            // 
            this.listViewChat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewChat.Location = new System.Drawing.Point(22, 40);
            this.listViewChat.Name = "listViewChat";
            this.listViewChat.Size = new System.Drawing.Size(350, 183);
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
            this.columnHeader3.Width = 210;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(395, 40);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(125, 23);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Location = new System.Drawing.Point(395, 69);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(125, 23);
            this.ButtonLogout.TabIndex = 2;
            this.ButtonLogout.Text = "Logout";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(395, 98);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(125, 23);
            this.buttonPost.TabIndex = 3;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // labelTotalText
            // 
            this.labelTotalText.AutoSize = true;
            this.labelTotalText.Location = new System.Drawing.Point(444, 13);
            this.labelTotalText.Name = "labelTotalText";
            this.labelTotalText.Size = new System.Drawing.Size(34, 13);
            this.labelTotalText.TabIndex = 4;
            this.labelTotalText.Text = "Total:";
            // 
            // labelTotaDigit
            // 
            this.labelTotaDigit.AutoSize = true;
            this.labelTotaDigit.Location = new System.Drawing.Point(485, 13);
            this.labelTotaDigit.Name = "labelTotaDigit";
            this.labelTotaDigit.Size = new System.Drawing.Size(16, 13);
            this.labelTotaDigit.TabIndex = 5;
            this.labelTotaDigit.Text = "   ";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(22, 230);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(350, 65);
            this.textBoxMessage.TabIndex = 6;
            // 
            // labelStatusText
            // 
            this.labelStatusText.AutoSize = true;
            this.labelStatusText.Location = new System.Drawing.Point(44, 13);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(40, 13);
            this.labelStatusText.TabIndex = 7;
            this.labelStatusText.Text = "Status:";
            // 
            // labelStatusValue
            // 
            this.labelStatusValue.AutoSize = true;
            this.labelStatusValue.Location = new System.Drawing.Point(85, 13);
            this.labelStatusValue.Name = "labelStatusValue";
            this.labelStatusValue.Size = new System.Drawing.Size(19, 13);
            this.labelStatusValue.TabIndex = 8;
            this.labelStatusValue.Text = "un";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 319);
            this.Controls.Add(this.labelStatusValue);
            this.Controls.Add(this.labelStatusText);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelTotaDigit);
            this.Controls.Add(this.labelTotalText);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.ButtonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.listViewChat);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label labelTotaDigit;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Label labelStatusValue;
    }
}