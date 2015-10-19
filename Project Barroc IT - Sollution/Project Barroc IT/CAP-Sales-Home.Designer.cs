namespace Project_Barroc_IT
{
    partial class MainScreen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttn_SearchContact = new System.Windows.Forms.Button();
            this.bttn_SearchProject = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblLogOut = new System.Windows.Forms.Label();
            this.bttn_AddContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Search Contact";
            // 
            // bttn_SearchContact
            // 
            this.bttn_SearchContact.Location = new System.Drawing.Point(180, 41);
            this.bttn_SearchContact.Name = "bttn_SearchContact";
            this.bttn_SearchContact.Size = new System.Drawing.Size(75, 23);
            this.bttn_SearchContact.TabIndex = 1;
            this.bttn_SearchContact.Text = "Search";
            this.bttn_SearchContact.UseVisualStyleBackColor = true;
            this.bttn_SearchContact.Click += new System.EventHandler(this.bttn_SearchContact_Click);
            // 
            // bttn_SearchProject
            // 
            this.bttn_SearchProject.Location = new System.Drawing.Point(180, 68);
            this.bttn_SearchProject.Name = "bttn_SearchProject";
            this.bttn_SearchProject.Size = new System.Drawing.Size(75, 23);
            this.bttn_SearchProject.TabIndex = 3;
            this.bttn_SearchProject.Text = "Search";
            this.bttn_SearchProject.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Search Project";
            // 
            // LblLogOut
            // 
            this.LblLogOut.AutoSize = true;
            this.LblLogOut.Location = new System.Drawing.Point(210, 105);
            this.LblLogOut.Name = "LblLogOut";
            this.LblLogOut.Size = new System.Drawing.Size(45, 13);
            this.LblLogOut.TabIndex = 4;
            this.LblLogOut.Text = "Log Out";
            this.LblLogOut.Click += new System.EventHandler(this.label1_Click);
            // 
            // bttn_AddContact
            // 
            this.bttn_AddContact.Location = new System.Drawing.Point(13, 13);
            this.bttn_AddContact.Name = "bttn_AddContact";
            this.bttn_AddContact.Size = new System.Drawing.Size(160, 23);
            this.bttn_AddContact.TabIndex = 5;
            this.bttn_AddContact.Text = "Add Contact";
            this.bttn_AddContact.UseVisualStyleBackColor = true;
            this.bttn_AddContact.Click += new System.EventHandler(this.bttn_AddContact_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 127);
            this.Controls.Add(this.bttn_AddContact);
            this.Controls.Add(this.LblLogOut);
            this.Controls.Add(this.bttn_SearchProject);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bttn_SearchContact);
            this.Controls.Add(this.textBox1);
            this.Name = "MainScreen";
            this.Text = "CAP-Sales-Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttn_SearchContact;
        private System.Windows.Forms.Button bttn_SearchProject;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblLogOut;
        private System.Windows.Forms.Button bttn_AddContact;
    }
}