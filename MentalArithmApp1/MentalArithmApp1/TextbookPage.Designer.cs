namespace MentalArithmApp1
{
    partial class TextbookPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextbookPage));
            labelTextbookPageHeading = new Label();
            buttonTextbookPageToBack = new Button();
            buttonTextbookPageToNext = new Button();
            buttonTextbookPageToMenu = new Button();
            pictureBoxTextbookPage = new PictureBox();
            buttonTextbookPageSettings = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTextbookPage).BeginInit();
            SuspendLayout();
            // 
            // labelTextbookPageHeading
            // 
            labelTextbookPageHeading.AutoSize = true;
            labelTextbookPageHeading.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            labelTextbookPageHeading.Location = new Point(46, 9);
            labelTextbookPageHeading.Name = "labelTextbookPageHeading";
            labelTextbookPageHeading.Size = new Size(304, 81);
            labelTextbookPageHeading.TabIndex = 1;
            labelTextbookPageHeading.Text = "Учебник.";
            // 
            // buttonTextbookPageToBack
            // 
            buttonTextbookPageToBack.FlatAppearance.BorderSize = 0;
            buttonTextbookPageToBack.FlatStyle = FlatStyle.Flat;
            buttonTextbookPageToBack.Image = (Image)resources.GetObject("buttonTextbookPageToBack.Image");
            buttonTextbookPageToBack.Location = new Point(32, 504);
            buttonTextbookPageToBack.Name = "buttonTextbookPageToBack";
            buttonTextbookPageToBack.Size = new Size(141, 127);
            buttonTextbookPageToBack.TabIndex = 6;
            buttonTextbookPageToBack.UseVisualStyleBackColor = true;
            buttonTextbookPageToBack.Visible = false;
            buttonTextbookPageToBack.Click += buttonTextbookPageToBack_Click;
            // 
            // buttonTextbookPageToNext
            // 
            buttonTextbookPageToNext.FlatAppearance.BorderSize = 0;
            buttonTextbookPageToNext.FlatStyle = FlatStyle.Flat;
            buttonTextbookPageToNext.Image = (Image)resources.GetObject("buttonTextbookPageToNext.Image");
            buttonTextbookPageToNext.Location = new Point(880, 504);
            buttonTextbookPageToNext.Name = "buttonTextbookPageToNext";
            buttonTextbookPageToNext.Size = new Size(141, 127);
            buttonTextbookPageToNext.TabIndex = 7;
            buttonTextbookPageToNext.UseVisualStyleBackColor = true;
            buttonTextbookPageToNext.Visible = false;
            buttonTextbookPageToNext.Click += buttonTextbookPageToNext_Click;
            // 
            // buttonTextbookPageToMenu
            // 
            buttonTextbookPageToMenu.FlatAppearance.BorderSize = 0;
            buttonTextbookPageToMenu.FlatStyle = FlatStyle.Flat;
            buttonTextbookPageToMenu.Image = (Image)resources.GetObject("buttonTextbookPageToMenu.Image");
            buttonTextbookPageToMenu.Location = new Point(454, 508);
            buttonTextbookPageToMenu.Name = "buttonTextbookPageToMenu";
            buttonTextbookPageToMenu.Size = new Size(163, 119);
            buttonTextbookPageToMenu.TabIndex = 8;
            buttonTextbookPageToMenu.Text = "Вернуться в меню";
            buttonTextbookPageToMenu.UseVisualStyleBackColor = true;
            buttonTextbookPageToMenu.Click += buttonTextbookPageToMenu_Click;
            // 
            // pictureBoxTextbookPage
            // 
            pictureBoxTextbookPage.Location = new Point(100, 112);
            pictureBoxTextbookPage.Name = "pictureBoxTextbookPage";
            pictureBoxTextbookPage.Size = new Size(856, 370);
            pictureBoxTextbookPage.TabIndex = 9;
            pictureBoxTextbookPage.TabStop = false;
            // 
            // buttonTextbookPageSettings
            // 
            buttonTextbookPageSettings.FlatAppearance.BorderSize = 0;
            buttonTextbookPageSettings.FlatStyle = FlatStyle.Flat;
            buttonTextbookPageSettings.Image = (Image)resources.GetObject("buttonTextbookPageSettings.Image");
            buttonTextbookPageSettings.Location = new Point(964, 30);
            buttonTextbookPageSettings.Name = "buttonTextbookPageSettings";
            buttonTextbookPageSettings.Size = new Size(86, 76);
            buttonTextbookPageSettings.TabIndex = 10;
            buttonTextbookPageSettings.UseVisualStyleBackColor = true;
            buttonTextbookPageSettings.Click += buttonTextbookPageSettings_Click;
            // 
            // TextbookPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(buttonTextbookPageSettings);
            Controls.Add(pictureBoxTextbookPage);
            Controls.Add(buttonTextbookPageToMenu);
            Controls.Add(buttonTextbookPageToNext);
            Controls.Add(buttonTextbookPageToBack);
            Controls.Add(labelTextbookPageHeading);
            HelpButton = true;
            MaximizeBox = false;
            MaximumSize = new Size(1100, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1100, 700);
            Name = "TextbookPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental arithmetic";
            FormClosed += TextbookPage_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTextbookPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTextbookPageHeading;
        private Button buttonTextbookPageToBack;
        private Button buttonTextbookPageToNext;
        private Button buttonTextbookPageToMenu;
        private PictureBox pictureBoxTextbookPage;
        private Button buttonTextbookPageSettings;
    }
}