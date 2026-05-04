namespace _2048WinFormsApp
{
    partial class TableResults
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
            resultsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 19);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Лучшие из лучших";
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            resultsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Location = new Point(30, 46);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.Size = new Size(240, 150);
            resultsDataGridView.TabIndex = 1;
            // 
            // TableResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 233);
            Controls.Add(resultsDataGridView);
            Controls.Add(label1);
            Name = "TableResults";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TableResults";
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView resultsDataGridView;
    }
}