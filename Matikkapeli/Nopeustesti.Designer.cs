
namespace Matikkapeli
{
    partial class Nopeustesti
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
            this.components = new System.ComponentModel.Container();
            this.answer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toCalculate = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.highscores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // answer
            // 
            this.answer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.answer.BackColor = System.Drawing.Color.Black;
            this.answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answer.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answer.ForeColor = System.Drawing.Color.Lime;
            this.answer.Location = new System.Drawing.Point(12, 238);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(1202, 82);
            this.answer.TabIndex = 0;
            this.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.answer.TextChanged += new System.EventHandler(this.answer_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(12, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 5);
            this.panel1.TabIndex = 1;
            // 
            // toCalculate
            // 
            this.toCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toCalculate.BackColor = System.Drawing.Color.Black;
            this.toCalculate.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toCalculate.ForeColor = System.Drawing.Color.Lime;
            this.toCalculate.Location = new System.Drawing.Point(12, 138);
            this.toCalculate.Name = "toCalculate";
            this.toCalculate.Size = new System.Drawing.Size(1202, 97);
            this.toCalculate.TabIndex = 2;
            this.toCalculate.Text = "-";
            this.toCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeText
            // 
            this.timeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeText.BackColor = System.Drawing.Color.Black;
            this.timeText.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeText.ForeColor = System.Drawing.Color.Lime;
            this.timeText.Location = new System.Drawing.Point(12, 348);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(1202, 210);
            this.timeText.TabIndex = 3;
            this.timeText.Text = "0:00 / 1:00";
            this.timeText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(12, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1202, 87);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aloita";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1202, 97);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nopeustesti";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(12, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1202, 87);
            this.button2.TabIndex = 6;
            this.button2.Text = "Lopeta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // highscores
            // 
            this.highscores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.highscores.FormattingEnabled = true;
            this.highscores.ItemHeight = 15;
            this.highscores.Location = new System.Drawing.Point(12, 12);
            this.highscores.Name = "highscores";
            this.highscores.Size = new System.Drawing.Size(215, 214);
            this.highscores.TabIndex = 7;
            // 
            // Nopeustesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1226, 667);
            this.Controls.Add(this.highscores);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.toCalculate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.answer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nopeustesti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nopeustesti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label toCalculate;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox highscores;
    }
}