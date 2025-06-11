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
            radioButtonScreenSizeFixed = new RadioButton();
            radioButtonScreenSizeFull = new RadioButton();
            radioButtonScreenSizeAdaptive = new RadioButton();
            buttonSettingsSet = new Button();
            groupBoxScreenSize = new GroupBox();
            labelSettingsPageHelp = new Label();
            groupBoxTopPanel = new GroupBox();
            radioButtonTopPanelNo = new RadioButton();
            radioButtonTopPanelYes = new RadioButton();
            labelSettingsPageClose = new Label();
            groupBoxScreenSize.SuspendLayout();
            groupBoxTopPanel.SuspendLayout();
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
            // radioButtonScreenSizeFixed
            // 
            radioButtonScreenSizeFixed.AutoSize = true;
            radioButtonScreenSizeFixed.Location = new Point(6, 43);
            radioButtonScreenSizeFixed.Name = "radioButtonScreenSizeFixed";
            radioButtonScreenSizeFixed.Size = new Size(145, 24);
            radioButtonScreenSizeFixed.TabIndex = 9;
            radioButtonScreenSizeFixed.TabStop = true;
            radioButtonScreenSizeFixed.Text = "Фиксированный";
            radioButtonScreenSizeFixed.UseVisualStyleBackColor = true;
            // 
            // radioButtonScreenSizeFull
            // 
            radioButtonScreenSizeFull.AutoSize = true;
            radioButtonScreenSizeFull.Location = new Point(6, 88);
            radioButtonScreenSizeFull.Name = "radioButtonScreenSizeFull";
            radioButtonScreenSizeFull.Size = new Size(145, 24);
            radioButtonScreenSizeFull.TabIndex = 10;
            radioButtonScreenSizeFull.TabStop = true;
            radioButtonScreenSizeFull.Text = "Полноэкранный";
            radioButtonScreenSizeFull.UseVisualStyleBackColor = true;
            // 
            // radioButtonScreenSizeAdaptive
            // 
            radioButtonScreenSizeAdaptive.AutoSize = true;
            radioButtonScreenSizeAdaptive.Location = new Point(6, 135);
            radioButtonScreenSizeAdaptive.Name = "radioButtonScreenSizeAdaptive";
            radioButtonScreenSizeAdaptive.Size = new Size(117, 24);
            radioButtonScreenSizeAdaptive.TabIndex = 11;
            radioButtonScreenSizeAdaptive.TabStop = true;
            radioButtonScreenSizeAdaptive.Text = "Адаптивный";
            radioButtonScreenSizeAdaptive.UseVisualStyleBackColor = true;
            // 
            // buttonSettingsSet
            // 
            buttonSettingsSet.Location = new Point(77, 504);
            buttonSettingsSet.Name = "buttonSettingsSet";
            buttonSettingsSet.Size = new Size(143, 101);
            buttonSettingsSet.TabIndex = 12;
            buttonSettingsSet.Text = "Применить настройки";
            buttonSettingsSet.UseVisualStyleBackColor = true;
            buttonSettingsSet.Click += buttonSettingsSet_Click;
            // 
            // groupBoxScreenSize
            // 
            groupBoxScreenSize.BackColor = Color.Transparent;
            groupBoxScreenSize.Controls.Add(radioButtonScreenSizeFixed);
            groupBoxScreenSize.Controls.Add(radioButtonScreenSizeFull);
            groupBoxScreenSize.Controls.Add(radioButtonScreenSizeAdaptive);
            groupBoxScreenSize.FlatStyle = FlatStyle.Flat;
            groupBoxScreenSize.Location = new Point(77, 140);
            groupBoxScreenSize.Name = "groupBoxScreenSize";
            groupBoxScreenSize.Size = new Size(241, 184);
            groupBoxScreenSize.TabIndex = 13;
            groupBoxScreenSize.TabStop = false;
            groupBoxScreenSize.Text = "Размер экрана";
            // 
            // labelSettingsPageHelp
            // 
            labelSettingsPageHelp.AutoSize = true;
            labelSettingsPageHelp.Font = new Font("Arial Black", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelSettingsPageHelp.Location = new Point(950, 0);
            labelSettingsPageHelp.Name = "labelSettingsPageHelp";
            labelSettingsPageHelp.Size = new Size(48, 56);
            labelSettingsPageHelp.TabIndex = 14;
            labelSettingsPageHelp.Text = "?";
            labelSettingsPageHelp.Click += labelSettingsPageHelp_Click;
            // 
            // groupBoxTopPanel
            // 
            groupBoxTopPanel.BackColor = Color.Transparent;
            groupBoxTopPanel.Controls.Add(radioButtonTopPanelNo);
            groupBoxTopPanel.Controls.Add(radioButtonTopPanelYes);
            groupBoxTopPanel.Location = new Point(354, 140);
            groupBoxTopPanel.Name = "groupBoxTopPanel";
            groupBoxTopPanel.Size = new Size(240, 166);
            groupBoxTopPanel.TabIndex = 15;
            groupBoxTopPanel.TabStop = false;
            groupBoxTopPanel.Text = "Отображение верхней панели";
            // 
            // radioButtonTopPanelNo
            // 
            radioButtonTopPanelNo.AutoSize = true;
            radioButtonTopPanelNo.Location = new Point(25, 105);
            radioButtonTopPanelNo.Name = "radioButtonTopPanelNo";
            radioButtonTopPanelNo.Size = new Size(151, 24);
            radioButtonTopPanelNo.TabIndex = 1;
            radioButtonTopPanelNo.TabStop = true;
            radioButtonTopPanelNo.Text = "Не отображается";
            radioButtonTopPanelNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonTopPanelYes
            // 
            radioButtonTopPanelYes.AutoSize = true;
            radioButtonTopPanelYes.Location = new Point(25, 50);
            radioButtonTopPanelYes.Name = "radioButtonTopPanelYes";
            radioButtonTopPanelYes.Size = new Size(130, 24);
            radioButtonTopPanelYes.TabIndex = 0;
            radioButtonTopPanelYes.TabStop = true;
            radioButtonTopPanelYes.Text = "Отображается";
            radioButtonTopPanelYes.UseVisualStyleBackColor = true;
            // 
            // labelSettingsPageClose
            // 
            labelSettingsPageClose.AutoSize = true;
            labelSettingsPageClose.Font = new Font("Arial Black", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelSettingsPageClose.Location = new Point(1010, 0);
            labelSettingsPageClose.Name = "labelSettingsPageClose";
            labelSettingsPageClose.Size = new Size(55, 56);
            labelSettingsPageClose.TabIndex = 16;
            labelSettingsPageClose.Text = "X";
            labelSettingsPageClose.Click += labelSettingsPageClose_Click;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(labelSettingsPageClose);
            Controls.Add(groupBoxTopPanel);
            Controls.Add(labelSettingsPageHelp);
            Controls.Add(buttonSettingsSet);
            Controls.Add(buttonSettingsPageToMenu);
            Controls.Add(labelSettingsPageHeading);
            Controls.Add(groupBoxScreenSize);
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
            MouseDown += SettingsPage_MouseDown;
            MouseMove += SettingsPage_MouseMove;
            groupBoxScreenSize.ResumeLayout(false);
            groupBoxScreenSize.PerformLayout();
            groupBoxTopPanel.ResumeLayout(false);
            groupBoxTopPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSettingsPageHeading;
        private Button buttonSettingsPageToMenu;
        private RadioButton radioButtonScreenSizeFixed;
        private RadioButton radioButtonScreenSizeFull;
        private RadioButton radioButtonScreenSizeAdaptive;
        private Button buttonSettingsSet;
        private GroupBox groupBoxScreenSize;
        private Label labelSettingsPageHelp;
        private GroupBox groupBoxTopPanel;
        private RadioButton radioButtonTopPanelNo;
        private RadioButton radioButtonTopPanelYes;
        private Label labelSettingsPageClose;
    }
}