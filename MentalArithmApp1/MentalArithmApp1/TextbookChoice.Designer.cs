namespace MentalArithmApp1
{
    partial class TextbookChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextbookChoice));
            buttonTextbookChoiceToMenu = new Button();
            buttonTextbookChoiceDivision = new Button();
            buttonTextbookChoiceMultiplication = new Button();
            buttonTextbookChoiceSubtraction = new Button();
            buttonTextbookChoiceAddition = new Button();
            buttonTextbookChoiceSettings = new Button();
            labelTextbookChoiceHeading = new Label();
            SuspendLayout();
            // 
            // buttonTextbookChoiceToMenu
            // 
            buttonTextbookChoiceToMenu.FlatAppearance.BorderSize = 0;
            buttonTextbookChoiceToMenu.FlatStyle = FlatStyle.Flat;
            buttonTextbookChoiceToMenu.Image = (Image)resources.GetObject("buttonTextbookChoiceToMenu.Image");
            buttonTextbookChoiceToMenu.Location = new Point(864, 514);
            buttonTextbookChoiceToMenu.Name = "buttonTextbookChoiceToMenu";
            buttonTextbookChoiceToMenu.Size = new Size(175, 115);
            buttonTextbookChoiceToMenu.TabIndex = 13;
            buttonTextbookChoiceToMenu.Text = "Вернуться в меню";
            buttonTextbookChoiceToMenu.UseVisualStyleBackColor = true;
            buttonTextbookChoiceToMenu.Click += buttonTextbookChoiceToMenu_Click;
            // 
            // buttonTextbookChoiceDivision
            // 
            buttonTextbookChoiceDivision.FlatAppearance.BorderSize = 0;
            buttonTextbookChoiceDivision.FlatStyle = FlatStyle.Flat;
            buttonTextbookChoiceDivision.Image = (Image)resources.GetObject("buttonTextbookChoiceDivision.Image");
            buttonTextbookChoiceDivision.Location = new Point(528, 399);
            buttonTextbookChoiceDivision.Name = "buttonTextbookChoiceDivision";
            buttonTextbookChoiceDivision.Size = new Size(228, 119);
            buttonTextbookChoiceDivision.TabIndex = 12;
            buttonTextbookChoiceDivision.Text = "Деление";
            buttonTextbookChoiceDivision.UseVisualStyleBackColor = true;
            buttonTextbookChoiceDivision.Click += buttonTextbookChoiceDivision_Click;
            // 
            // buttonTextbookChoiceMultiplication
            // 
            buttonTextbookChoiceMultiplication.FlatAppearance.BorderSize = 0;
            buttonTextbookChoiceMultiplication.FlatStyle = FlatStyle.Flat;
            buttonTextbookChoiceMultiplication.Image = (Image)resources.GetObject("buttonTextbookChoiceMultiplication.Image");
            buttonTextbookChoiceMultiplication.Location = new Point(198, 399);
            buttonTextbookChoiceMultiplication.Name = "buttonTextbookChoiceMultiplication";
            buttonTextbookChoiceMultiplication.Size = new Size(228, 119);
            buttonTextbookChoiceMultiplication.TabIndex = 11;
            buttonTextbookChoiceMultiplication.Text = "Умножение";
            buttonTextbookChoiceMultiplication.UseVisualStyleBackColor = true;
            buttonTextbookChoiceMultiplication.Click += buttonTextbookChoiceMultiplication_Click;
            // 
            // buttonTextbookChoiceSubtraction
            // 
            buttonTextbookChoiceSubtraction.FlatAppearance.BorderSize = 0;
            buttonTextbookChoiceSubtraction.FlatStyle = FlatStyle.Flat;
            buttonTextbookChoiceSubtraction.Image = (Image)resources.GetObject("buttonTextbookChoiceSubtraction.Image");
            buttonTextbookChoiceSubtraction.Location = new Point(528, 187);
            buttonTextbookChoiceSubtraction.Name = "buttonTextbookChoiceSubtraction";
            buttonTextbookChoiceSubtraction.Size = new Size(228, 119);
            buttonTextbookChoiceSubtraction.TabIndex = 10;
            buttonTextbookChoiceSubtraction.Text = "Вычитание";
            buttonTextbookChoiceSubtraction.UseVisualStyleBackColor = true;
            buttonTextbookChoiceSubtraction.Click += buttonTextbookChoiceSubtraction_Click;
            // 
            // buttonTextbookChoiceAddition
            // 
            buttonTextbookChoiceAddition.FlatAppearance.BorderSize = 0;
            buttonTextbookChoiceAddition.FlatStyle = FlatStyle.Flat;
            buttonTextbookChoiceAddition.Image = (Image)resources.GetObject("buttonTextbookChoiceAddition.Image");
            buttonTextbookChoiceAddition.Location = new Point(198, 187);
            buttonTextbookChoiceAddition.Name = "buttonTextbookChoiceAddition";
            buttonTextbookChoiceAddition.Size = new Size(228, 119);
            buttonTextbookChoiceAddition.TabIndex = 9;
            buttonTextbookChoiceAddition.Text = "Сложение";
            buttonTextbookChoiceAddition.UseVisualStyleBackColor = true;
            buttonTextbookChoiceAddition.Click += buttonTextbookChoiceAddition_Click;
            // 
            // buttonTextbookChoiceSettings
            // 
            buttonTextbookChoiceSettings.FlatAppearance.BorderSize = 0;
            buttonTextbookChoiceSettings.FlatStyle = FlatStyle.Flat;
            buttonTextbookChoiceSettings.Image = (Image)resources.GetObject("buttonTextbookChoiceSettings.Image");
            buttonTextbookChoiceSettings.Location = new Point(970, 24);
            buttonTextbookChoiceSettings.Name = "buttonTextbookChoiceSettings";
            buttonTextbookChoiceSettings.Size = new Size(86, 76);
            buttonTextbookChoiceSettings.TabIndex = 8;
            buttonTextbookChoiceSettings.UseVisualStyleBackColor = true;
            buttonTextbookChoiceSettings.Click += buttonTextbookChoiceSettings_Click;
            // 
            // labelTextbookChoiceHeading
            // 
            labelTextbookChoiceHeading.AutoSize = true;
            labelTextbookChoiceHeading.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            labelTextbookChoiceHeading.ForeColor = Color.FromArgb(147, 15, 255);
            labelTextbookChoiceHeading.Location = new Point(27, 38);
            labelTextbookChoiceHeading.Name = "labelTextbookChoiceHeading";
            labelTextbookChoiceHeading.Size = new Size(832, 81);
            labelTextbookChoiceHeading.TabIndex = 7;
            labelTextbookChoiceHeading.Text = "Учебник. Выберите режим";
            // 
            // TextbookChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(buttonTextbookChoiceToMenu);
            Controls.Add(buttonTextbookChoiceDivision);
            Controls.Add(buttonTextbookChoiceMultiplication);
            Controls.Add(buttonTextbookChoiceSubtraction);
            Controls.Add(buttonTextbookChoiceAddition);
            Controls.Add(buttonTextbookChoiceSettings);
            Controls.Add(labelTextbookChoiceHeading);
            HelpButton = true;
            MaximizeBox = false;
            MaximumSize = new Size(1100, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1100, 700);
            Name = "TextbookChoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental arithmetic";
            FormClosed += TextbookChoice_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTextbookChoiceToMenu;
        private Button buttonTextbookChoiceDivision;
        private Button buttonTextbookChoiceMultiplication;
        private Button buttonTextbookChoiceSubtraction;
        private Button buttonTextbookChoiceAddition;
        private Button buttonTextbookChoiceSettings;
        private Label labelTextbookChoiceHeading;
    }
}