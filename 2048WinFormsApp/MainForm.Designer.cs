namespace _2048WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            scoreLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            рестартToolStripMenuItem = new ToolStripMenuItem();
            рестартToolStripMenuItem1 = new ToolStripMenuItem();
            правилаToolStripMenuItem1 = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            правилаToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            contextMenuStrip3 = new ContextMenuStrip(components);
            filToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip4 = new ContextMenuStrip(components);
            аToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip5 = new ContextMenuStrip(components);
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            contextMenuStrip6 = new ContextMenuStrip(components);
            в32ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            рестартToolStripMenuItem2 = new ToolStripMenuItem();
            правилаToolStripMenuItem2 = new ToolStripMenuItem();
            выходToolStripMenuItem1 = new ToolStripMenuItem();
            результатыToolStripMenuItem = new ToolStripMenuItem();
            интерфейсToolStripMenuItem = new ToolStripMenuItem();
            smallToolStripMenuItem = new ToolStripMenuItem();
            mediumToolStripMenuItem = new ToolStripMenuItem();
            big150ToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            bestScoreLabel = new Label();
            AnimationTimer = new System.Windows.Forms.Timer(components);
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            contextMenuStrip4.SuspendLayout();
            contextMenuStrip5.SuspendLayout();
            contextMenuStrip6.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Счет:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(44, 24);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(13, 15);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { рестартToolStripMenuItem, правилаToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 48);
            // 
            // рестартToolStripMenuItem
            // 
            рестартToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { рестартToolStripMenuItem1, правилаToolStripMenuItem1, выходToolStripMenuItem });
            рестартToolStripMenuItem.Name = "рестартToolStripMenuItem";
            рестартToolStripMenuItem.Size = new Size(122, 22);
            рестартToolStripMenuItem.Text = "File";
            // 
            // рестартToolStripMenuItem1
            // 
            рестартToolStripMenuItem1.Name = "рестартToolStripMenuItem1";
            рестартToolStripMenuItem1.Size = new Size(122, 22);
            рестартToolStripMenuItem1.Text = "Рестарт";
            // 
            // правилаToolStripMenuItem1
            // 
            правилаToolStripMenuItem1.Name = "правилаToolStripMenuItem1";
            правилаToolStripMenuItem1.Size = new Size(122, 22);
            правилаToolStripMenuItem1.Text = "Правила";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(122, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // правилаToolStripMenuItem
            // 
            правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            правилаToolStripMenuItem.Size = new Size(122, 22);
            правилаToolStripMenuItem.Text = "Правила";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(93, 26);
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(92, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(80, 22);
            toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(80, 22);
            toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(80, 22);
            toolStripMenuItem4.Text = "3";
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { filToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(87, 26);
            // 
            // filToolStripMenuItem
            // 
            filToolStripMenuItem.Name = "filToolStripMenuItem";
            filToolStripMenuItem.Size = new Size(86, 22);
            filToolStripMenuItem.Text = "Fil";
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.Items.AddRange(new ToolStripItem[] { аToolStripMenuItem });
            contextMenuStrip4.Name = "contextMenuStrip4";
            contextMenuStrip4.Size = new Size(81, 26);
            // 
            // аToolStripMenuItem
            // 
            аToolStripMenuItem.Name = "аToolStripMenuItem";
            аToolStripMenuItem.Size = new Size(80, 22);
            аToolStripMenuItem.Text = "а";
            // 
            // contextMenuStrip5
            // 
            contextMenuStrip5.Items.AddRange(new ToolStripItem[] { toolStripMenuItem6, toolStripMenuItem7 });
            contextMenuStrip5.Name = "contextMenuStrip5";
            contextMenuStrip5.Size = new Size(81, 48);
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(80, 22);
            toolStripMenuItem6.Text = "2";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(80, 22);
            toolStripMenuItem7.Text = "3";
            // 
            // contextMenuStrip6
            // 
            contextMenuStrip6.Items.AddRange(new ToolStripItem[] { в32ToolStripMenuItem });
            contextMenuStrip6.Name = "contextMenuStrip6";
            contextMenuStrip6.Size = new Size(93, 26);
            // 
            // в32ToolStripMenuItem
            // 
            в32ToolStripMenuItem.Name = "в32ToolStripMenuItem";
            в32ToolStripMenuItem.Size = new Size(92, 22);
            в32ToolStripMenuItem.Text = "в32";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, результатыToolStripMenuItem, интерфейсToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(562, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { рестартToolStripMenuItem2, правилаToolStripMenuItem2, выходToolStripMenuItem1 });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(37, 20);
            fileToolStripMenuItem1.Text = "File";
            // 
            // рестартToolStripMenuItem2
            // 
            рестартToolStripMenuItem2.Name = "рестартToolStripMenuItem2";
            рестартToolStripMenuItem2.Size = new Size(122, 22);
            рестартToolStripMenuItem2.Text = "Рестарт";
            рестартToolStripMenuItem2.Click += рестартToolStripMenuItem2_Click;
            // 
            // правилаToolStripMenuItem2
            // 
            правилаToolStripMenuItem2.Name = "правилаToolStripMenuItem2";
            правилаToolStripMenuItem2.Size = new Size(122, 22);
            правилаToolStripMenuItem2.Text = "Правила";
            правилаToolStripMenuItem2.Click += правилаToolStripMenuItem2_Click;
            // 
            // выходToolStripMenuItem1
            // 
            выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            выходToolStripMenuItem1.Size = new Size(122, 22);
            выходToolStripMenuItem1.Text = "Выход";
            выходToolStripMenuItem1.Click += выходToolStripMenuItem1_Click;
            // 
            // результатыToolStripMenuItem
            // 
            результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            результатыToolStripMenuItem.Size = new Size(81, 20);
            результатыToolStripMenuItem.Text = "Результаты";
            результатыToolStripMenuItem.Click += результатыToolStripMenuItem_Click;
            // 
            // интерфейсToolStripMenuItem
            // 
            интерфейсToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smallToolStripMenuItem, mediumToolStripMenuItem, big150ToolStripMenuItem });
            интерфейсToolStripMenuItem.Name = "интерфейсToolStripMenuItem";
            интерфейсToolStripMenuItem.Size = new Size(81, 20);
            интерфейсToolStripMenuItem.Text = "Интерфейс";
            // 
            // smallToolStripMenuItem
            // 
            smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            smallToolStripMenuItem.Size = new Size(157, 22);
            smallToolStripMenuItem.Text = "Small - 70%";
            smallToolStripMenuItem.Click += smallToolStripMenuItem_Click;
            // 
            // mediumToolStripMenuItem
            // 
            mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            mediumToolStripMenuItem.Size = new Size(157, 22);
            mediumToolStripMenuItem.Text = "Standart - 100%";
            mediumToolStripMenuItem.Click += mediumToolStripMenuItem_Click;
            // 
            // big150ToolStripMenuItem
            // 
            big150ToolStripMenuItem.Name = "big150ToolStripMenuItem";
            big150ToolStripMenuItem.Size = new Size(157, 22);
            big150ToolStripMenuItem.Text = "Big - 130%";
            big150ToolStripMenuItem.Click += big150ToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 7;
            label2.Text = "Лучший результат:";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Location = new Point(121, 39);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(13, 15);
            bestScoreLabel.TabIndex = 8;
            bestScoreLabel.Text = "0";
            // 
            // AnimationTimer
            // 
            AnimationTimer.Interval = 10;
            AnimationTimer.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 408);
            Controls.Add(bestScoreLabel);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Controls.Add(scoreLabel);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048";
            Load += Form1_Load;
            KeyDown += MainForm_KeyDown;
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip3.ResumeLayout(false);
            contextMenuStrip4.ResumeLayout(false);
            contextMenuStrip5.ResumeLayout(false);
            contextMenuStrip6.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label scoreLabel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem рестартToolStripMenuItem;
        private ToolStripMenuItem рестартToolStripMenuItem1;
        private ToolStripMenuItem правилаToolStripMenuItem1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem правилаToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem filToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip4;
        private ToolStripMenuItem аToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ContextMenuStrip contextMenuStrip6;
        private ToolStripMenuItem в32ToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem рестартToolStripMenuItem2;
        private ToolStripMenuItem правилаToolStripMenuItem2;
        private ToolStripMenuItem выходToolStripMenuItem1;
        private Label label2;
        private Label bestScoreLabel;
        private ToolStripMenuItem результатыToolStripMenuItem;
        private ToolStripMenuItem интерфейсToolStripMenuItem;
        private ToolStripMenuItem smallToolStripMenuItem;
        private ToolStripMenuItem mediumToolStripMenuItem;
        private ToolStripMenuItem big150ToolStripMenuItem;
        private System.Windows.Forms.Timer AnimationTimer;
    }
}
