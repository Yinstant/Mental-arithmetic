﻿namespace MentalArithmApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            buttonMainMenuStart = new Button();
            buttonMainMenuTextbook = new Button();
            buttonMainMenuStatistics = new Button();
            buttonMainMenuManual = new Button();
            buttonMainMenuSettings = new Button();
            labelMainMenuHeading = new Label();
            SuspendLayout();
            // 
            // buttonMainMenuStart
            // 
            buttonMainMenuStart.BackColor = Color.FromArgb(195, 215, 255);
            buttonMainMenuStart.FlatAppearance.BorderSize = 0;
            buttonMainMenuStart.FlatStyle = FlatStyle.Flat;
            buttonMainMenuStart.Image = (Image)resources.GetObject("buttonMainMenuStart.Image");
            buttonMainMenuStart.Location = new Point(388, 215);
            buttonMainMenuStart.Name = "buttonMainMenuStart";
            buttonMainMenuStart.Size = new Size(281, 60);
            buttonMainMenuStart.TabIndex = 0;
            buttonMainMenuStart.Text = "Начать тренировку";
            buttonMainMenuStart.UseVisualStyleBackColor = false;
            buttonMainMenuStart.Click += buttonMainMenuStart_Click;
            // 
            // buttonMainMenuTextbook
            // 
            buttonMainMenuTextbook.BackColor = Color.FromArgb(195, 215, 255);
            buttonMainMenuTextbook.FlatAppearance.BorderSize = 0;
            buttonMainMenuTextbook.FlatStyle = FlatStyle.Flat;
            buttonMainMenuTextbook.Image = (Image)resources.GetObject("buttonMainMenuTextbook.Image");
            buttonMainMenuTextbook.Location = new Point(395, 293);
            buttonMainMenuTextbook.Name = "buttonMainMenuTextbook";
            buttonMainMenuTextbook.Size = new Size(274, 68);
            buttonMainMenuTextbook.TabIndex = 1;
            buttonMainMenuTextbook.Text = "Учебные материалы";
            buttonMainMenuTextbook.UseVisualStyleBackColor = false;
            buttonMainMenuTextbook.Click += buttonMainMenuTextbook_Click;
            // 
            // buttonMainMenuStatistics
            // 
            buttonMainMenuStatistics.BackColor = Color.FromArgb(195, 215, 255);
            buttonMainMenuStatistics.FlatAppearance.BorderSize = 0;
            buttonMainMenuStatistics.FlatStyle = FlatStyle.Flat;
            buttonMainMenuStatistics.Image = (Image)resources.GetObject("buttonMainMenuStatistics.Image");
            buttonMainMenuStatistics.Location = new Point(388, 383);
            buttonMainMenuStatistics.Name = "buttonMainMenuStatistics";
            buttonMainMenuStatistics.Size = new Size(281, 68);
            buttonMainMenuStatistics.TabIndex = 2;
            buttonMainMenuStatistics.Text = "Статистика и достижения";
            buttonMainMenuStatistics.UseVisualStyleBackColor = false;
            buttonMainMenuStatistics.Click += buttonMainMenuStatistics_Click;
            // 
            // buttonMainMenuManual
            // 
            buttonMainMenuManual.BackColor = Color.FromArgb(195, 215, 255);
            buttonMainMenuManual.FlatAppearance.BorderSize = 0;
            buttonMainMenuManual.FlatStyle = FlatStyle.Flat;
            buttonMainMenuManual.Image = (Image)resources.GetObject("buttonMainMenuManual.Image");
            buttonMainMenuManual.Location = new Point(388, 472);
            buttonMainMenuManual.Name = "buttonMainMenuManual";
            buttonMainMenuManual.Size = new Size(281, 68);
            buttonMainMenuManual.TabIndex = 3;
            buttonMainMenuManual.Text = "Инструкция";
            buttonMainMenuManual.UseVisualStyleBackColor = false;
            buttonMainMenuManual.Click += buttonMainMenuManual_Click;
            // 
            // buttonMainMenuSettings
            // 
            buttonMainMenuSettings.FlatAppearance.BorderSize = 0;
            buttonMainMenuSettings.FlatStyle = FlatStyle.Flat;
            buttonMainMenuSettings.Image = (Image)resources.GetObject("buttonMainMenuSettings.Image");
            buttonMainMenuSettings.Location = new Point(937, 529);
            buttonMainMenuSettings.Name = "buttonMainMenuSettings";
            buttonMainMenuSettings.Size = new Size(91, 88);
            buttonMainMenuSettings.TabIndex = 4;
            buttonMainMenuSettings.UseVisualStyleBackColor = true;
            buttonMainMenuSettings.Click += buttonMainMenuSettings_Click;
            // 
            // labelMainMenuHeading
            // 
            labelMainMenuHeading.AutoSize = true;
            labelMainMenuHeading.Font = new Font("Microsoft Sans Serif", 50F, FontStyle.Bold);
            labelMainMenuHeading.ForeColor = Color.FromArgb(255, 15, 159);
            labelMainMenuHeading.Location = new Point(280, 80);
            labelMainMenuHeading.Name = "labelMainMenuHeading";
            labelMainMenuHeading.Size = new Size(533, 95);
            labelMainMenuHeading.TabIndex = 5;
            labelMainMenuHeading.Text = "Устный счёт";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(labelMainMenuHeading);
            Controls.Add(buttonMainMenuSettings);
            Controls.Add(buttonMainMenuManual);
            Controls.Add(buttonMainMenuStatistics);
            Controls.Add(buttonMainMenuTextbook);
            Controls.Add(buttonMainMenuStart);
            Name = "MainMenu";
            Text = "Mental arithmetic";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMainMenuStart;
        private Button buttonMainMenuTextbook;
        private Button buttonMainMenuStatistics;
        private Button buttonMainMenuManual;
        private Button buttonMainMenuSettings;
        private Label labelMainMenuHeading;
    }
}
