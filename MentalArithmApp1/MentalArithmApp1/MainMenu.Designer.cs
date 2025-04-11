namespace MentalArithmApp1
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
            buttonMainMenuStart = new Button();
            buttonMainMenuTextbook = new Button();
            buttonMainMenuStatistics = new Button();
            buttonMainMenuManual = new Button();
            SuspendLayout();
            // 
            // buttonMainMenuStart
            // 
            buttonMainMenuStart.BackColor = Color.FromArgb(255, 224, 192);
            buttonMainMenuStart.FlatStyle = FlatStyle.Flat;
            buttonMainMenuStart.Location = new Point(425, 214);
            buttonMainMenuStart.Name = "buttonMainMenuStart";
            buttonMainMenuStart.Size = new Size(216, 68);
            buttonMainMenuStart.TabIndex = 0;
            buttonMainMenuStart.Text = "Начать тренировку";
            buttonMainMenuStart.UseVisualStyleBackColor = false;
            buttonMainMenuStart.Click += button1_Click;
            // 
            // buttonMainMenuTextbook
            // 
            buttonMainMenuTextbook.BackColor = Color.FromArgb(255, 224, 192);
            buttonMainMenuTextbook.FlatStyle = FlatStyle.Flat;
            buttonMainMenuTextbook.Location = new Point(425, 302);
            buttonMainMenuTextbook.Name = "buttonMainMenuTextbook";
            buttonMainMenuTextbook.Size = new Size(216, 68);
            buttonMainMenuTextbook.TabIndex = 1;
            buttonMainMenuTextbook.Text = "Учебные материалы";
            buttonMainMenuTextbook.UseVisualStyleBackColor = false;
            buttonMainMenuTextbook.Click += button2_Click;
            // 
            // buttonMainMenuStatistics
            // 
            buttonMainMenuStatistics.BackColor = Color.FromArgb(255, 224, 192);
            buttonMainMenuStatistics.FlatStyle = FlatStyle.Flat;
            buttonMainMenuStatistics.Location = new Point(425, 399);
            buttonMainMenuStatistics.Name = "buttonMainMenuStatistics";
            buttonMainMenuStatistics.Size = new Size(216, 68);
            buttonMainMenuStatistics.TabIndex = 2;
            buttonMainMenuStatistics.Text = "Статистика и достижения";
            buttonMainMenuStatistics.UseVisualStyleBackColor = false;
            // 
            // buttonMainMenuManual
            // 
            buttonMainMenuManual.BackColor = Color.FromArgb(255, 224, 192);
            buttonMainMenuManual.FlatStyle = FlatStyle.Flat;
            buttonMainMenuManual.Location = new Point(425, 500);
            buttonMainMenuManual.Name = "buttonMainMenuManual";
            buttonMainMenuManual.Size = new Size(216, 68);
            buttonMainMenuManual.TabIndex = 3;
            buttonMainMenuManual.Text = "Инструкция";
            buttonMainMenuManual.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1060, 643);
            Controls.Add(buttonMainMenuManual);
            Controls.Add(buttonMainMenuStatistics);
            Controls.Add(buttonMainMenuTextbook);
            Controls.Add(buttonMainMenuStart);
            Name = "MainMenu";
            Text = "Mental arithmetic";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonMainMenuStart;
        private Button buttonMainMenuTextbook;
        private Button buttonMainMenuStatistics;
        private Button buttonMainMenuManual;
    }
}
