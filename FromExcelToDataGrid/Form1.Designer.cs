namespace FromExcelToDataGrid
{
    partial class Form1
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
            DataGrid = new DataGridView();
            TextBox_FileSource = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // DataGrid
            // 
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(12, 12);
            DataGrid.Name = "DataGrid";
            DataGrid.Size = new Size(776, 224);
            DataGrid.TabIndex = 0;
            // 
            // TextBox_FileSource
            // 
            TextBox_FileSource.Location = new Point(28, 263);
            TextBox_FileSource.Name = "TextBox_FileSource";
            TextBox_FileSource.Size = new Size(748, 23);
            TextBox_FileSource.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextBox_FileSource);
            Controls.Add(DataGrid);
            Name = "Form1";
            Text = "FromExcelToDataGrid";
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGrid;
        private TextBox TextBox_FileSource;
    }
}
