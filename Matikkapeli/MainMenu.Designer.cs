
namespace Matikkapeli
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcome = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.achievements = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome.Location = new System.Drawing.Point(12, 20);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(660, 56);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Tervetuloa Matikkapeliin\r\nOlet kirjautuneena käyttäjälle {0}";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(243, 162);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(200, 51);
            this.start.TabIndex = 1;
            this.start.Text = "Aloita";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // achievements
            // 
            this.achievements.Location = new System.Drawing.Point(243, 219);
            this.achievements.Name = "achievements";
            this.achievements.Size = new System.Drawing.Size(200, 51);
            this.achievements.TabIndex = 2;
            this.achievements.Text = "Palkinnot";
            this.achievements.UseVisualStyleBackColor = true;
            this.achievements.Click += new System.EventHandler(this.achievements_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(243, 276);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(200, 51);
            this.logout.TabIndex = 3;
            this.logout.Text = "Kirjaudu ulos";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(660, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "(c) 2021 Markus Kannisto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Lopeta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.achievements);
            this.Controls.Add(this.start);
            this.Controls.Add(this.welcome);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matikkapeli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button achievements;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

