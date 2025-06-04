namespace MentalArithmApp1
{
    partial class SettingsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            labelSettingsPageHeading = new Label();
            buttonSettingsPageToMenu = new Button();
            SuspendLayout();
            // 
            // labelSettingsPageHeading
            // 
            labelSettingsPageHeading.AutoSize = true;
            labelSettingsPageHeading.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            labelSettingsPageHeading.Location = new Point(339, 18);
            labelSettingsPageHeading.Name = "labelSettingsPageHeading";
            labelSettingsPageHeading.Size = new Size(391, 89);
            labelSettingsPageHeading.TabIndex = 0;
            labelSettingsPageHeading.Text = "Настройки";
            // 
            // buttonSettingsPageToMenu
            // 
            buttonSettingsPageToMenu.FlatAppearance.BorderSize = 0;
            buttonSettingsPageToMenu.FlatStyle = FlatStyle.Flat;
            buttonSettingsPageToMenu.Image = (Image)resources.GetObject("buttonSettingsPageToMenu.Image");
            buttonSettingsPageToMenu.Location = new Point(859, 504);
            buttonSettingsPageToMenu.Name = "buttonSettingsPageToMenu";
            buttonSettingsPageToMenu.Size = new Size(175, 115);
            buttonSettingsPageToMenu.TabIndex = 7;
            buttonSettingsPageToMenu.Text = "Вернуться в меню";
            buttonSettingsPageToMenu.UseVisualStyleBackColor = true;
            buttonSettingsPageToMenu.Click += buttonSettingsPageToMenu_Click;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(buttonSettingsPageToMenu);
            Controls.Add(labelSettingsPageHeading);
            HelpButton = true;
            MaximizeBox = false;
            MaximumSize = new Size(1100, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1100, 700);
            Name = "SettingsPage";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental arithmetic";
            FormClosed += SettingsPage_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSettingsPageHeading;
        private Button buttonSettingsPageToMenu;
    }
}