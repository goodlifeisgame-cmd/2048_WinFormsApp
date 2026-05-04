namespace _2048WinFormsApp
{
    partial class WelcomeMenu
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
            label1 = new Label();
            userNametextBox = new TextBox();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 22);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите ваше имя";
            // 
            // userNametextBox
            // 
            userNametextBox.Location = new Point(30, 54);
            userNametextBox.Name = "userNametextBox";
            userNametextBox.Size = new Size(107, 23);
            userNametextBox.TabIndex = 1;
            // 
            // WelcomeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(177, 124);
            Controls.Add(userNametextBox);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "WelcomeMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048";
            KeyDown += WelcomeMenu_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userNametextBox;
        private ColorDialog colorDialog1;
    }
}