namespace MentalArithmApp1
{
    partial class ComplexityChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplexityChoice));
            labelComplexityChoiceHeading = new Label();
            buttonComplexityChoiceEasy = new Button();
            buttonComplexityChoiceMedium = new Button();
            buttonComplexityChoiceHard = new Button();
            buttonComplexityChoiceSettings = new Button();
            buttonComplexityChoiceToBack = new Button();
            buttonComplexityChoiceToMenu = new Button();
            SuspendLayout();
            // 
            // labelComplexityChoiceHeading
            // 
            labelComplexityChoiceHeading.AutoSize = true;
            labelComplexityChoiceHeading.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            labelComplexityChoiceHeading.ForeColor = Color.FromArgb(147, 15, 255);
            labelComplexityChoiceHeading.Location = new Point(12, 33);
            labelComplexityChoiceHeading.Name = "labelComplexityChoiceHeading";
            labelComplexityChoiceHeading.Size = new Size(922, 81);
            labelComplexityChoiceHeading.TabIndex = 0;
            labelComplexityChoiceHeading.Text = "Выберите уровень сложности";
            // 
            // buttonComplexityChoiceEasy
            // 
            buttonComplexityChoiceEasy.FlatAppearance.BorderSize = 0;
            buttonComplexityChoiceEasy.FlatStyle = FlatStyle.Flat;
            buttonComplexityChoiceEasy.Image = (Image)resources.GetObject("buttonComplexityChoiceEasy.Image");
            buttonComplexityChoiceEasy.Location = new Point(68, 259);
            buttonComplexityChoiceEasy.Name = "buttonComplexityChoiceEasy";
            buttonComplexityChoiceEasy.Size = new Size(232, 120);
            buttonComplexityChoiceEasy.TabIndex = 1;
            buttonComplexityChoiceEasy.Text = "Начальный";
            buttonComplexityChoiceEasy.UseVisualStyleBackColor = true;
            buttonComplexityChoiceEasy.Click += buttonComplexityChoiceEasy_Click;
            // 
            // buttonComplexityChoiceMedium
            // 
            buttonComplexityChoiceMedium.FlatAppearance.BorderSize = 0;
            buttonComplexityChoiceMedium.FlatStyle = FlatStyle.Flat;
            buttonComplexityChoiceMedium.Image = (Image)resources.GetObject("buttonComplexityChoiceMedium.Image");
            buttonComplexityChoiceMedium.Location = new Point(394, 259);
            buttonComplexityChoiceMedium.Name = "buttonComplexityChoiceMedium";
            buttonComplexityChoiceMedium.Size = new Size(232, 120);
            buttonComplexityChoiceMedium.TabIndex = 2;
            buttonComplexityChoiceMedium.Text = "Средний";
            buttonComplexityChoiceMedium.UseVisualStyleBackColor = true;
            buttonComplexityChoiceMedium.Click += buttonComplexityChoiceMedium_Click;
            // 
            // buttonComplexityChoiceHard
            // 
            buttonComplexityChoiceHard.FlatAppearance.BorderSize = 0;
            buttonComplexityChoiceHard.FlatStyle = FlatStyle.Flat;
            buttonComplexityChoiceHard.Image = (Image)resources.GetObject("buttonComplexityChoiceHard.Image");
            buttonComplexityChoiceHard.Location = new Point(716, 259);
            buttonComplexityChoiceHard.Name = "buttonComplexityChoiceHard";
            buttonComplexityChoiceHard.Size = new Size(232, 120);
            buttonComplexityChoiceHard.TabIndex = 3;
            buttonComplexityChoiceHard.Text = "Продвинутый";
            buttonComplexityChoiceHard.UseVisualStyleBackColor = true;
            buttonComplexityChoiceHard.Click += buttonComplexityChoiceHard_Click;
            // 
            // buttonComplexityChoiceSettings
            // 
            buttonComplexityChoiceSettings.FlatAppearance.BorderSize = 0;
            buttonComplexityChoiceSettings.FlatStyle = FlatStyle.Flat;
            buttonComplexityChoiceSettings.Image = (Image)resources.GetObject("buttonComplexityChoiceSettings.Image");
            buttonComplexityChoiceSettings.Location = new Point(961, 33);
            buttonComplexityChoiceSettings.Name = "buttonComplexityChoiceSettings";
            buttonComplexityChoiceSettings.Size = new Size(90, 77);
            buttonComplexityChoiceSettings.TabIndex = 4;
            buttonComplexityChoiceSettings.UseVisualStyleBackColor = true;
            // 
            // buttonComplexityChoiceToBack
            // 
            buttonComplexityChoiceToBack.FlatAppearance.BorderSize = 0;
            buttonComplexityChoiceToBack.FlatStyle = FlatStyle.Flat;
            buttonComplexityChoiceToBack.Image = (Image)resources.GetObject("buttonComplexityChoiceToBack.Image");
            buttonComplexityChoiceToBack.Location = new Point(68, 477);
            buttonComplexityChoiceToBack.Name = "buttonComplexityChoiceToBack";
            buttonComplexityChoiceToBack.Size = new Size(141, 127);
            buttonComplexityChoiceToBack.TabIndex = 5;
            buttonComplexityChoiceToBack.UseVisualStyleBackColor = true;
            buttonComplexityChoiceToBack.Click += buttonComplexityChoiceToBack_Click;
            // 
            // buttonComplexityChoiceToMenu
            // 
            buttonComplexityChoiceToMenu.FlatAppearance.BorderSize = 0;
            buttonComplexityChoiceToMenu.FlatStyle = FlatStyle.Flat;
            buttonComplexityChoiceToMenu.Image = (Image)resources.GetObject("buttonComplexityChoiceToMenu.Image");
            buttonComplexityChoiceToMenu.Location = new Point(855, 495);
            buttonComplexityChoiceToMenu.Name = "buttonComplexityChoiceToMenu";
            buttonComplexityChoiceToMenu.Size = new Size(163, 119);
            buttonComplexityChoiceToMenu.TabIndex = 6;
            buttonComplexityChoiceToMenu.Text = "Вернуться в меню";
            buttonComplexityChoiceToMenu.UseVisualStyleBackColor = true;
            buttonComplexityChoiceToMenu.Click += buttonComplexityChoiceToMenu_Click;
            // 
            // ComplexityChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(buttonComplexityChoiceToMenu);
            Controls.Add(buttonComplexityChoiceToBack);
            Controls.Add(buttonComplexityChoiceSettings);
            Controls.Add(buttonComplexityChoiceHard);
            Controls.Add(buttonComplexityChoiceMedium);
            Controls.Add(buttonComplexityChoiceEasy);
            Controls.Add(labelComplexityChoiceHeading);
            HelpButton = true;
            MaximizeBox = false;
            MaximumSize = new Size(1100, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1100, 700);
            Name = "ComplexityChoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental arithmetic";
            HelpButtonClicked += ComplexityChoice_HelpButtonClicked;
            FormClosed += ComplexityChoice_FormClosed;
            HelpRequested += ComplexityChoice_HelpRequested;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelComplexityChoiceHeading;
        private Button buttonComplexityChoiceEasy;
        private Button buttonComplexityChoiceMedium;
        private Button buttonComplexityChoiceHard;
        private Button buttonComplexityChoiceSettings;
        private Button buttonComplexityChoiceToBack;
        private Button buttonComplexityChoiceToMenu;
    }
}