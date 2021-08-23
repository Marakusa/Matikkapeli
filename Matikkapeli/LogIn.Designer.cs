
namespace Matikkapeli
{
    partial class LogIn
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
            this.label2 = new System.Windows.Forms.Label();
            this.tunnus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salasana = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.regSalasana = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.regTunnus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kirjaudu sisään";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(250, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rekisteröidy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tunnus
            // 
            this.tunnus.Location = new System.Drawing.Point(12, 101);
            this.tunnus.Name = "tunnus";
            this.tunnus.Size = new System.Drawing.Size(229, 23);
            this.tunnus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Käyttäjätunnus";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salasana";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // salasana
            // 
            this.salasana.Location = new System.Drawing.Point(12, 159);
            this.salasana.Name = "salasana";
            this.salasana.PasswordChar = '*';
            this.salasana.Size = new System.Drawing.Size(229, 23);
            this.salasana.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kirjaudu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Rekisteröidy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(259, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Salasana";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // regSalasana
            // 
            this.regSalasana.Location = new System.Drawing.Point(259, 159);
            this.regSalasana.MaxLength = 50;
            this.regSalasana.Name = "regSalasana";
            this.regSalasana.PasswordChar = '*';
            this.regSalasana.Size = new System.Drawing.Size(229, 23);
            this.regSalasana.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(259, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Käyttäjätunnus";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // regTunnus
            // 
            this.regTunnus.Location = new System.Drawing.Point(259, 101);
            this.regTunnus.MaxLength = 20;
            this.regTunnus.Name = "regTunnus";
            this.regTunnus.Size = new System.Drawing.Size(229, 23);
            this.regTunnus.TabIndex = 8;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.regSalasana);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.regTunnus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salasana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tunnus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(516, 300);
            this.MinimumSize = new System.Drawing.Size(516, 300);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirjaudu Sisään";
            this.Shown += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tunnus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salasana;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regSalasana;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox regTunnus;
    }
}