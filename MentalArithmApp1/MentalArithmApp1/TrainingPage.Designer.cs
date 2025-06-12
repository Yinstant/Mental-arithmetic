using DataClasses;

namespace MentalArithmApp1
{
    partial class TrainingPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingPage));
            buttonTrainingPageToTimeIncrementChoice = new Button();
            buttonTrainingPageEnd = new Button();
            buttonTrainingPageSettings = new Button();
            labelTrainingPageTime = new Label();
            textBoxTrainingPage = new TextBox();
            labelTrainingPageExample = new Label();
            timerTrainingPage = new System.Windows.Forms.Timer(components);
            labelTrainingPageReaction = new Label();
            labelTrainingPageClose = new Label();
            labelTrainingPageHelp = new Label();
            SuspendLayout();
            // 
            // buttonTrainingPageToTimeIncrementChoice
            // 
            buttonTrainingPageToTimeIncrementChoice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonTrainingPageToTimeIncrementChoice.BackColor = Color.Transparent;
            buttonTrainingPageToTimeIncrementChoice.FlatAppearance.BorderSize = 0;
            buttonTrainingPageToTimeIncrementChoice.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonTrainingPageToTimeIncrementChoice.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonTrainingPageToTimeIncrementChoice.FlatStyle = FlatStyle.Flat;
            buttonTrainingPageToTimeIncrementChoice.Font = new Font("Cascadia Code", 22F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonTrainingPageToTimeIncrementChoice.ForeColor = Color.FromArgb(106, 37, 0);
            buttonTrainingPageToTimeIncrementChoice.Image = (Image)resources.GetObject("buttonTrainingPageToTimeIncrementChoice.Image");
            buttonTrainingPageToTimeIncrementChoice.Location = new Point(73, 504);
            buttonTrainingPageToTimeIncrementChoice.Name = "buttonTrainingPageToTimeIncrementChoice";
            buttonTrainingPageToTimeIncrementChoice.Size = new Size(216, 122);
            buttonTrainingPageToTimeIncrementChoice.TabIndex = 0;
            buttonTrainingPageToTimeIncrementChoice.Text = "Вернуться к выбору режима";
            buttonTrainingPageToTimeIncrementChoice.UseVisualStyleBackColor = false;
            buttonTrainingPageToTimeIncrementChoice.Click += buttonTrainingPageToTimeIncrementChoice_Click;
            // 
            // buttonTrainingPageEnd
            // 
            buttonTrainingPageEnd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonTrainingPageEnd.BackColor = Color.Transparent;
            buttonTrainingPageEnd.FlatAppearance.BorderSize = 0;
            buttonTrainingPageEnd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonTrainingPageEnd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonTrainingPageEnd.FlatStyle = FlatStyle.Flat;
            buttonTrainingPageEnd.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            buttonTrainingPageEnd.ForeColor = Color.FromArgb(106, 37, 0);
            buttonTrainingPageEnd.Image = (Image)resources.GetObject("buttonTrainingPageEnd.Image");
            buttonTrainingPageEnd.Location = new Point(803, 508);
            buttonTrainingPageEnd.Name = "buttonTrainingPageEnd";
            buttonTrainingPageEnd.Size = new Size(211, 115);
            buttonTrainingPageEnd.TabIndex = 1;
            buttonTrainingPageEnd.Text = "Закончить досрочно";
            buttonTrainingPageEnd.UseVisualStyleBackColor = false;
            buttonTrainingPageEnd.Click += buttonTrainingPageEnd_Click;
            // 
            // buttonTrainingPageSettings
            // 
            buttonTrainingPageSettings.BackColor = Color.Transparent;
            buttonTrainingPageSettings.FlatAppearance.BorderSize = 0;
            buttonTrainingPageSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonTrainingPageSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonTrainingPageSettings.FlatStyle = FlatStyle.Flat;
            buttonTrainingPageSettings.Image = (Image)resources.GetObject("buttonTrainingPageSettings.Image");
            buttonTrainingPageSettings.Location = new Point(28, 12);
            buttonTrainingPageSettings.Name = "buttonTrainingPageSettings";
            buttonTrainingPageSettings.Size = new Size(89, 90);
            buttonTrainingPageSettings.TabIndex = 2;
            buttonTrainingPageSettings.UseVisualStyleBackColor = false;
            buttonTrainingPageSettings.Click += buttonTrainingPageSettings_Click;
            // 
            // labelTrainingPageTime
            // 
            labelTrainingPageTime.Anchor = AnchorStyles.Top;
            labelTrainingPageTime.AutoSize = true;
            labelTrainingPageTime.BackColor = Color.Transparent;
            labelTrainingPageTime.Font = new Font("Cascadia Code", 64F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelTrainingPageTime.ForeColor = Color.FromArgb(255, 15, 15);
            labelTrainingPageTime.Image = (Image)resources.GetObject("labelTrainingPageTime.Image");
            labelTrainingPageTime.Location = new Point(400, 27);
            labelTrainingPageTime.Name = "labelTrainingPageTime";
            labelTrainingPageTime.Padding = new Padding(50, 15, 50, 15);
            labelTrainingPageTime.RightToLeft = RightToLeft.No;
            labelTrainingPageTime.Size = new Size(327, 115);
            labelTrainingPageTime.TabIndex = 3;
            labelTrainingPageTime.Text = "--:--";
            labelTrainingPageTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxTrainingPage
            // 
            textBoxTrainingPage.Anchor = AnchorStyles.None;
            textBoxTrainingPage.Font = new Font("Cascadia Code", 25F);
            textBoxTrainingPage.ForeColor = Color.FromArgb(106, 37, 0);
            textBoxTrainingPage.Location = new Point(306, 413);
            textBoxTrainingPage.MaxLength = 10;
            textBoxTrainingPage.Name = "textBoxTrainingPage";
            textBoxTrainingPage.Size = new Size(500, 56);
            textBoxTrainingPage.TabIndex = 4;
            textBoxTrainingPage.WordWrap = false;
            textBoxTrainingPage.KeyDown += input_KeyDown;
            // 
            // labelTrainingPageExample
            // 
            labelTrainingPageExample.Anchor = AnchorStyles.None;
            labelTrainingPageExample.BackColor = Color.Transparent;
            labelTrainingPageExample.FlatStyle = FlatStyle.Flat;
            labelTrainingPageExample.Font = new Font("Arial Black", 80F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelTrainingPageExample.ForeColor = Color.Red;
            labelTrainingPageExample.Location = new Point(159, 257);
            labelTrainingPageExample.Name = "labelTrainingPageExample";
            labelTrainingPageExample.Padding = new Padding(50, 10, 50, 10);
            labelTrainingPageExample.Size = new Size(808, 133);
            labelTrainingPageExample.TabIndex = 5;
            labelTrainingPageExample.Text = "Приготовьтесь";
            labelTrainingPageExample.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTrainingPageReaction
            // 
            labelTrainingPageReaction.Anchor = AnchorStyles.None;
            labelTrainingPageReaction.BackColor = Color.Transparent;
            labelTrainingPageReaction.Font = new Font("Arial Black", 45F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelTrainingPageReaction.ForeColor = Color.Orange;
            labelTrainingPageReaction.Location = new Point(231, 168);
            labelTrainingPageReaction.Name = "labelTrainingPageReaction";
            labelTrainingPageReaction.Size = new Size(636, 89);
            labelTrainingPageReaction.TabIndex = 6;
            labelTrainingPageReaction.Text = "Начали!";
            labelTrainingPageReaction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTrainingPageClose
            // 
            labelTrainingPageClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTrainingPageClose.AutoSize = true;
            labelTrainingPageClose.Font = new Font("Arial Black", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelTrainingPageClose.Location = new Point(1010, 0);
            labelTrainingPageClose.Name = "labelTrainingPageClose";
            labelTrainingPageClose.Size = new Size(55, 56);
            labelTrainingPageClose.TabIndex = 20;
            labelTrainingPageClose.Text = "X";
            labelTrainingPageClose.Click += labelTrainingPageClose_Click;
            // 
            // labelTrainingPageHelp
            // 
            labelTrainingPageHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTrainingPageHelp.AutoSize = true;
            labelTrainingPageHelp.Font = new Font("Arial Black", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelTrainingPageHelp.Location = new Point(950, 0);
            labelTrainingPageHelp.Name = "labelTrainingPageHelp";
            labelTrainingPageHelp.Size = new Size(48, 56);
            labelTrainingPageHelp.TabIndex = 19;
            labelTrainingPageHelp.Text = "?";
            // 
            // TrainingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 215, 255);
            ClientSize = new Size(1082, 653);
            Controls.Add(labelTrainingPageClose);
            Controls.Add(labelTrainingPageHelp);
            Controls.Add(labelTrainingPageReaction);
            Controls.Add(labelTrainingPageExample);
            Controls.Add(textBoxTrainingPage);
            Controls.Add(labelTrainingPageTime);
            Controls.Add(buttonTrainingPageSettings);
            Controls.Add(buttonTrainingPageEnd);
            Controls.Add(buttonTrainingPageToTimeIncrementChoice);
            HelpButton = true;
            MaximizeBox = false;
            MaximumSize = new Size(1100, 700);
            MinimizeBox = false;
            MinimumSize = new Size(1100, 700);
            Name = "TrainingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mental arithmetic";
            HelpButtonClicked += TrainingPage_HelpButtonClicked;
            FormClosed += TrainingPage_FormClosed;
            HelpRequested += TrainingPage_HelpRequested;
            KeyDown += input_KeyDown;
            MouseDown += TrainingPage_MouseDown;
            MouseMove += TrainingPage_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTrainingPageToTimeIncrementChoice;
        private Button buttonTrainingPageEnd;
        private Button buttonTrainingPageSettings;
        private Label labelTrainingPageTime;
        private TextBox textBoxTrainingPage;
        private Label labelTrainingPageExample;
        public System.Windows.Forms.Timer timerTrainingPage;
        private Label labelTrainingPageReaction;
        private Label labelTrainingPageClose;
        private Label labelTrainingPageHelp;
    }
}