namespace CesarCipher
{
    partial class Table
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
            this.FrequencyTable = new System.Windows.Forms.DataGridView();
            this.Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // FrequencyTable
            // 
            this.FrequencyTable.AllowUserToOrderColumns = true;
            this.FrequencyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FrequencyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Letter,
            this.Count});
            this.FrequencyTable.Location = new System.Drawing.Point(12, -1);
            this.FrequencyTable.Name = "FrequencyTable";
            this.FrequencyTable.RowHeadersWidth = 51;
            this.FrequencyTable.RowTemplate.Height = 24;
            this.FrequencyTable.Size = new System.Drawing.Size(1000, 1000);
            this.FrequencyTable.TabIndex = 0;
            this.FrequencyTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FrequencyTable_CellContentClick);
            // 
            // Letter
            // 
            this.Letter.HeaderText = "Letter";
            this.Letter.MinimumWidth = 6;
            this.Letter.Name = "Letter";
            this.Letter.Width = 302;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.Width = 302;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.FrequencyTable);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FrequencyTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}