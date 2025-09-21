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
            SelectExcelDownloadDataGrid = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // DataGrid
            // 
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(14, 14);
            DataGrid.Name = "DataGrid";
            DataGrid.Size = new Size(887, 254);
            DataGrid.TabIndex = 0;
            // 
            // SelectExcelDownloadDataGrid
            // 
            SelectExcelDownloadDataGrid.Location = new Point(310, 341);
            SelectExcelDownloadDataGrid.Name = "SelectExcelDownloadDataGrid";
            SelectExcelDownloadDataGrid.Size = new Size(295, 68);
            SelectExcelDownloadDataGrid.TabIndex = 1;
            SelectExcelDownloadDataGrid.Text = "Select Excel Download DataGrid";
            SelectExcelDownloadDataGrid.UseVisualStyleBackColor = true;
            SelectExcelDownloadDataGrid.Click += SelectExcelDownloadDataGrid_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(SelectExcelDownloadDataGrid);
            Controls.Add(DataGrid);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "FromExcelToDataGrid";
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGrid;
        private Button SelectExcelDownloadDataGrid;
    }
}
