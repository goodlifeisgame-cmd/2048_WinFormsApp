namespace _2048WinFormsApp
{
    partial class SettingMap
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            onebutton = new Button();
            twobutton = new Button();
            threebutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 43);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Выберите режим";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 103);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Classic";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 103);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Fast game";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(297, 103);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Long game";
            // 
            // onebutton
            // 
            onebutton.Location = new Point(21, 130);
            onebutton.Name = "onebutton";
            onebutton.Size = new Size(75, 23);
            onebutton.TabIndex = 4;
            onebutton.Text = "4x4";
            onebutton.UseVisualStyleBackColor = true;
            onebutton.Click += onebutton_Click;
            // 
            // twobutton
            // 
            twobutton.Location = new Point(156, 130);
            twobutton.Name = "twobutton";
            twobutton.Size = new Size(75, 23);
            twobutton.TabIndex = 5;
            twobutton.Text = "3x3";
            twobutton.UseVisualStyleBackColor = true;
            twobutton.Click += twobutton_Click;
            // 
            // threebutton
            // 
            threebutton.Location = new Point(289, 130);
            threebutton.Name = "threebutton";
            threebutton.Size = new Size(75, 23);
            threebutton.TabIndex = 6;
            threebutton.Text = "6x6";
            threebutton.UseVisualStyleBackColor = true;
            threebutton.Click += threebutton_Click;
            // 
            // SettingMap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(threebutton);
            Controls.Add(twobutton);
            Controls.Add(onebutton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SettingMap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettingMap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button onebutton;
        private Button twobutton;
        private Button threebutton;
    }
}