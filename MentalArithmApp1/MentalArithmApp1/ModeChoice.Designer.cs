namespace MentalArithmApp1
{
    partial class ModeChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeChoice));
            labelModeChoiceHeading = new Label();
            buttonModeChoiceSettings = new Button();
            buttonModeChoiceAddition = new Button();
            buttonModeChoiceSubtraction = new Button();
            buttonModeChoiceMultiplication = new Button();
            buttonModeChoiceDivision = new Button();
            buttonModeChoiceToMenu = new Button();
            SuspendLayout();
            // 
            // labelModeChoiceHeading
            // 
            labelModeChoiceHeading.AutoSize = true;
            labelModeChoiceHeading.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            labelModeChoiceHeading.ForeColor = Color.FromArgb(147, 15, 255);
            labelModeChoiceHeading.Location = new Point(21, 36);
            labelModeChoiceHeading.Name = "labelModeChoiceHeading";
            labelModeChoiceHeading.Size = new Size(915, 81);
            labelModeChoiceHeading.TabIndex = 0;
            labelModeChoiceHeading.Text = "Выберите режим тренировки";
            // 
            // buttonModeChoiceSettings
            // 
            buttonModeChoiceSettings.FlatAppearance.BorderSize = 0;
            buttonModeChoiceSettings.FlatStyle = FlatStyle.Flat;
            buttonModeChoiceSettings.Image = (Image)resources.GetObject("buttonModeChoiceSettings.Image");
            buttonModeChoiceSettings.Location = new Point(964, 22);
            buttonModeChoiceSettings.Name = "buttonModeChoiceSettings";
            buttonModeChoiceSettings.Size = new Size(86, 76);
            buttonModeChoiceSettings.TabIndex = 1;
            buttonModeChoiceSettings.UseVisualStyleBackColor = true;
            // 
            // buttonModeChoiceAddition
            // 
            buttonModeChoiceAddition.FlatAppearance.BorderSize = 0;
            buttonModeChoiceAddition.FlatStyle = FlatStyle.Flat;
            buttonModeChoiceAddition.Image = (Image)resources.GetObject("buttonModeChoiceAddition.Image");
            buttonModeChoiceAddition.Location = new Point(192, 185);
            buttonModeChoiceAddition.Name = "buttonModeChoiceAddition";
            buttonModeChoiceAddition.Size = new Size(228, 119);
            buttonModeChoiceAddition.TabIndex = 2;
            buttonModeChoiceAddition.Text = "Сложение";
            buttonModeChoiceAddition.UseVisualStyleBackColor = true;
            buttonModeChoiceAddition.Click += buttonModeChoiceAddition_Click;
            // 
            // buttonModeChoiceSubtraction
            // 
            buttonModeChoiceSubtraction.FlatAppearance.BorderSize = 0;
            buttonModeChoiceSubtraction.FlatStyle = FlatStyle.Flat;
            buttonModeChoiceSubtraction.Image = (Image)resources.GetObject("buttonModeChoiceSubtraction.Image");
            buttonModeChoiceSubtraction.Location = new Point(522, 185);
            buttonModeChoiceSubtraction.Name = "buttonModeChoiceSubtraction";
            buttonModeChoiceSubtraction.Size = new Size(228, 119);
            buttonModeChoiceSubtraction.TabIndex = 3;
            buttonModeChoiceSubtraction.Text = "Вычитание";
            buttonModeChoiceSubtraction.UseVisualStyleBackColor = true;
            buttonModeChoiceSubtraction.Click += buttonModeChoiceSubtraction_Click;
            // 
            // buttonModeChoiceMultiplication
            // 
            buttonModeChoiceMultiplication.FlatAppearance.BorderSize = 0;
            buttonModeChoiceMultiplication.FlatStyle = FlatStyle.Flat;
            buttonModeChoiceMultiplication.Image = (Image)resources.GetObject("buttonModeChoiceMultiplication.Image");
            buttonModeChoiceMultiplication.Location = new Point(192, 397);
            buttonModeChoiceMultiplication.Name = "buttonModeChoiceMultiplication";
            buttonModeChoiceMultiplication.Size = new Size(228, 119);
            buttonModeChoiceMultiplication.TabIndex = 4;
            buttonModeChoiceMultiplication.Text = "Умножение";
            buttonModeChoiceMultiplication.UseVisualStyleBackColor = true;
            buttonModeChoiceMultiplication.Click += buttonModeChoiceMultiplication_Click;
            // 
            // buttonModeChoiceDivision
            // 
            buttonModeChoiceDivision.FlatAppearance.BorderSize = 0;
            buttonModeChoiceDivision.FlatStyle = FlatStyle.Flat;
            buttonModeChoiceDivision.Image = (Image)resources.GetObject("buttonModeChoiceDivision.Image");
            buttonModeChoiceDivision.Location = new Point(522, 397);
            buttonModeChoiceDivision.Name = "buttonModeChoiceDivision";
            buttonModeChoiceDivision.Size = new Size(228, 119);
            buttonModeChoiceDivision.TabIndex = 5;
            buttonModeChoiceDivision.Text = "Деление";
            buttonModeChoiceDivision.UseVisualStyleBackColor = true;
            buttonModeChoiceDivision.Click += buttonModeChoiceDivision_Click;
            // 
            // buttonModeChoiceToMenu
            // 
            buttonModeChoiceToMenu.FlatAppearance.BorderSize = 0;
            buttonModeChoiceToMenu.FlatStyle = FlatStyle.Flat;
            buttonModeChoiceToMenu.Image = (Image)resources.GetObject("buttonModeChoiceToMenu.Image");
            buttonModeChoiceToMenu.Location = new Point(858, 512);
            buttonModeChoiceToMenu.Name = "buttonModeChoiceToMenu";
            buttonModeChoiceToMenu.Size = new Size(175, 115);
            buttonModeChoiceToMenu.TabIndex = 6;
            buttonModeChoiceToMenu.Text = "Вернуться в меню";
            buttonModeChoiceToMenu.UseVisualStyleBackColor = true;
            buttonModeChoiceToMenu.Click += buttonModeChoiceToMenu_Click;
            // 
            // ModeChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(buttonModeChoiceToMenu);
            Controls.Add(buttonModeChoiceDivision);
            Controls.Add(buttonModeChoiceMultiplication);
            Controls.Add(buttonModeChoiceSubtraction);
            Controls.Add(buttonModeChoiceAddition);
            Controls.Add(buttonModeChoiceSettings);
            Controls.Add(labelModeChoiceHeading);
            HelpButton = true;
            MaximizeBox = false;
            MaximumSize = new Size(1100, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1100, 700);
            Name = "ModeChoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental arithmetic";
            ResumeLayout(false);
            PerformLayout();
            HelpButtonClicked += ModeChoice_HelpButtonClicked;
            HelpRequested += ModeChoice_HelpRequested;
        }

        #endregion

        private Label labelModeChoiceHeading;
        private Button buttonModeChoiceSettings;
        private Button buttonModeChoiceAddition;
        private Button buttonModeChoiceSubtraction;
        private Button buttonModeChoiceMultiplication;
        private Button buttonModeChoiceDivision;
        private Button buttonModeChoiceToMenu;
    }
}