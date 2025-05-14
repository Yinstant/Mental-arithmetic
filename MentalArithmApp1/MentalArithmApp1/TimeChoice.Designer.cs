namespace MentalArithmApp1
{
    partial class TimeChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeChoice));
            labelTimeChoiceHeading = new Label();
            buttonTimeChoiceSettings = new Button();
            buttonTimeChoiceNoTime = new Button();
            buttonTimeChoiceOneMinute = new Button();
            buttonTimeChoiceThreeMinute = new Button();
            buttonTimeChoiceFiveMinute = new Button();
            buttonTimeChoice15Minute = new Button();
            buttonTimeChoiceToBack = new Button();
            buttonTimeChoiceToMenu = new Button();
            SuspendLayout();
            // 
            // labelTimeChoiceHeading
            // 
            labelTimeChoiceHeading.AutoSize = true;
            labelTimeChoiceHeading.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            labelTimeChoiceHeading.ForeColor = Color.FromArgb(147, 15, 255);
            labelTimeChoiceHeading.Location = new Point(12, 34);
            labelTimeChoiceHeading.Name = "labelTimeChoiceHeading";
            labelTimeChoiceHeading.Size = new Size(895, 81);
            labelTimeChoiceHeading.TabIndex = 0;
            labelTimeChoiceHeading.Text = "Выберите время тренировки";
            // 
            // buttonTimeChoiceSettings
            // 
            buttonTimeChoiceSettings.FlatAppearance.BorderSize = 0;
            buttonTimeChoiceSettings.FlatStyle = FlatStyle.Flat;
            buttonTimeChoiceSettings.Image = (Image)resources.GetObject("buttonTimeChoiceSettings.Image");
            buttonTimeChoiceSettings.Location = new Point(944, 47);
            buttonTimeChoiceSettings.Name = "buttonTimeChoiceSettings";
            buttonTimeChoiceSettings.Size = new Size(94, 68);
            buttonTimeChoiceSettings.TabIndex = 1;
            buttonTimeChoiceSettings.UseVisualStyleBackColor = true;
            // 
            // buttonTimeChoiceNoTime
            // 
            buttonTimeChoiceNoTime.FlatAppearance.BorderSize = 0;
            buttonTimeChoiceNoTime.FlatStyle = FlatStyle.Flat;
            buttonTimeChoiceNoTime.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonTimeChoiceNoTime.Image = (Image)resources.GetObject("buttonTimeChoiceNoTime.Image");
            buttonTimeChoiceNoTime.Location = new Point(72, 221);
            buttonTimeChoiceNoTime.Name = "buttonTimeChoiceNoTime";
            buttonTimeChoiceNoTime.Size = new Size(234, 119);
            buttonTimeChoiceNoTime.TabIndex = 2;
            buttonTimeChoiceNoTime.Text = "Без ограничений";
            buttonTimeChoiceNoTime.UseVisualStyleBackColor = true;
            buttonTimeChoiceNoTime.Click += buttonTimeChoiceNoTime_Click;
            // 
            // buttonTimeChoiceOneMinute
            // 
            buttonTimeChoiceOneMinute.FlatAppearance.BorderSize = 0;
            buttonTimeChoiceOneMinute.FlatStyle = FlatStyle.Flat;
            buttonTimeChoiceOneMinute.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonTimeChoiceOneMinute.Image = (Image)resources.GetObject("buttonTimeChoiceOneMinute.Image");
            buttonTimeChoiceOneMinute.Location = new Point(424, 221);
            buttonTimeChoiceOneMinute.Name = "buttonTimeChoiceOneMinute";
            buttonTimeChoiceOneMinute.Size = new Size(234, 119);
            buttonTimeChoiceOneMinute.TabIndex = 3;
            buttonTimeChoiceOneMinute.Text = "1 минута";
            buttonTimeChoiceOneMinute.UseVisualStyleBackColor = true;
            buttonTimeChoiceOneMinute.Click += buttonTimeChoiceOneMinute_Click;
            // 
            // buttonTimeChoiceThreeMinute
            // 
            buttonTimeChoiceThreeMinute.FlatAppearance.BorderSize = 0;
            buttonTimeChoiceThreeMinute.FlatStyle = FlatStyle.Flat;
            buttonTimeChoiceThreeMinute.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonTimeChoiceThreeMinute.Image = (Image)resources.GetObject("buttonTimeChoiceThreeMinute.Image");
            buttonTimeChoiceThreeMinute.Location = new Point(748, 221);
            buttonTimeChoiceThreeMinute.Name = "buttonTimeChoiceThreeMinute";
            buttonTimeChoiceThreeMinute.Size = new Size(234, 119);
            buttonTimeChoiceThreeMinute.TabIndex = 4;
            buttonTimeChoiceThreeMinute.Text = "3 минуты";
            buttonTimeChoiceThreeMinute.UseVisualStyleBackColor = true;
            buttonTimeChoiceThreeMinute.Click += buttonTimeChoiceThreeMinute_Click;
            // 
            // buttonTimeChoiceFiveMinute
            // 
            buttonTimeChoiceFiveMinute.FlatAppearance.BorderSize = 0;
            buttonTimeChoiceFiveMinute.FlatStyle = FlatStyle.Flat;
            buttonTimeChoiceFiveMinute.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonTimeChoiceFiveMinute.Image = (Image)resources.GetObject("buttonTimeChoiceFiveMinute.Image");
            buttonTimeChoiceFiveMinute.Location = new Point(230, 400);
            buttonTimeChoiceFiveMinute.Name = "buttonTimeChoiceFiveMinute";
            buttonTimeChoiceFiveMinute.Size = new Size(234, 119);
            buttonTimeChoiceFiveMinute.TabIndex = 5;
            buttonTimeChoiceFiveMinute.Text = "5 минут";
            buttonTimeChoiceFiveMinute.UseVisualStyleBackColor = true;
            buttonTimeChoiceFiveMinute.Click += buttonTimeChoiceFiveMinute_Click;
            // 
            // buttonTimeChoice15Minute
            // 
            buttonTimeChoice15Minute.FlatAppearance.BorderSize = 0;
            buttonTimeChoice15Minute.FlatStyle = FlatStyle.Flat;
            buttonTimeChoice15Minute.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonTimeChoice15Minute.Image = (Image)resources.GetObject("buttonTimeChoice15Minute.Image");
            buttonTimeChoice15Minute.Location = new Point(605, 400);
            buttonTimeChoice15Minute.Name = "buttonTimeChoice15Minute";
            buttonTimeChoice15Minute.Size = new Size(234, 119);
            buttonTimeChoice15Minute.TabIndex = 6;
            buttonTimeChoice15Minute.Text = "15 минут";
            buttonTimeChoice15Minute.UseVisualStyleBackColor = true;
            buttonTimeChoice15Minute.Click += buttonTimeChoice15Minute_Click;
            // 
            // buttonTimeChoiceToBack
            // 
            buttonTimeChoiceToBack.FlatAppearance.BorderSize = 0;
            buttonTimeChoiceToBack.FlatStyle = FlatStyle.Flat;
            buttonTimeChoiceToBack.Image = (Image)resources.GetObject("buttonTimeChoiceToBack.Image");
            buttonTimeChoiceToBack.Location = new Point(37, 522);
            buttonTimeChoiceToBack.Name = "buttonTimeChoiceToBack";
            buttonTimeChoiceToBack.Size = new Size(151, 103);
            buttonTimeChoiceToBack.TabIndex = 7;
            buttonTimeChoiceToBack.UseVisualStyleBackColor = true;
            buttonTimeChoiceToBack.Click += buttonTimeChoiceToBack_Click;
            // 
            // buttonTimeChoiceToMenu
            // 
            buttonTimeChoiceToMenu.FlatAppearance.BorderSize = 0;
            buttonTimeChoiceToMenu.FlatStyle = FlatStyle.Flat;
            buttonTimeChoiceToMenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonTimeChoiceToMenu.Image = (Image)resources.GetObject("buttonTimeChoiceToMenu.Image");
            buttonTimeChoiceToMenu.Location = new Point(860, 498);
            buttonTimeChoiceToMenu.Name = "buttonTimeChoiceToMenu";
            buttonTimeChoiceToMenu.Size = new Size(178, 127);
            buttonTimeChoiceToMenu.TabIndex = 8;
            buttonTimeChoiceToMenu.Text = "Вернуться в меню";
            buttonTimeChoiceToMenu.UseVisualStyleBackColor = true;
            buttonTimeChoiceToMenu.Click += buttonTimeChoiceToMenu_Click;
            // 
            // TimeChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(buttonTimeChoiceToMenu);
            Controls.Add(buttonTimeChoiceToBack);
            Controls.Add(buttonTimeChoice15Minute);
            Controls.Add(buttonTimeChoiceFiveMinute);
            Controls.Add(buttonTimeChoiceThreeMinute);
            Controls.Add(buttonTimeChoiceOneMinute);
            Controls.Add(buttonTimeChoiceNoTime);
            Controls.Add(buttonTimeChoiceSettings);
            Controls.Add(labelTimeChoiceHeading);
            HelpButton = true;
            MaximizeBox = false;
            MaximumSize = new Size(1100, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1100, 700);
            Name = "TimeChoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental arithmetic";
            Load += TimeChoice_Load;
            ResumeLayout(false);
            PerformLayout();
            HelpButtonClicked += TimeChoice_HelpButtonClicked;
            HelpRequested += TimeChoice_HelpRequested;
        }

        #endregion

        private Label labelTimeChoiceHeading;
        private Button buttonTimeChoiceSettings;
        private Button buttonTimeChoiceNoTime;
        private Button buttonTimeChoiceOneMinute;
        private Button buttonTimeChoiceThreeMinute;
        private Button buttonTimeChoiceFiveMinute;
        private Button buttonTimeChoice15Minute;
        private Button buttonTimeChoiceToBack;
        private Button buttonTimeChoiceToMenu;
    }
}