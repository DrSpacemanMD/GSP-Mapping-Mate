namespace GSP_Mapping_Mate
{
    partial class Form2
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
            this.EvidenceGrid = new System.Windows.Forms.DataGridView();
            this.Load = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EvidenceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EvidenceGrid
            // 
            this.EvidenceGrid.AllowUserToAddRows = false;
            this.EvidenceGrid.AllowUserToDeleteRows = false;
            this.EvidenceGrid.AllowUserToOrderColumns = true;
            this.EvidenceGrid.AllowUserToResizeColumns = false;
            this.EvidenceGrid.AllowUserToResizeRows = false;
            this.EvidenceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EvidenceGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.EvidenceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EvidenceGrid.Location = new System.Drawing.Point(12, 12);
            this.EvidenceGrid.MultiSelect = false;
            this.EvidenceGrid.Name = "EvidenceGrid";
            this.EvidenceGrid.ReadOnly = true;
            this.EvidenceGrid.RowHeadersVisible = false;
            this.EvidenceGrid.RowHeadersWidth = 62;
            this.EvidenceGrid.RowTemplate.Height = 33;
            this.EvidenceGrid.Size = new System.Drawing.Size(776, 329);
            this.EvidenceGrid.TabIndex = 0;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(93, 361);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(249, 34);
            this.Load.TabIndex = 1;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(472, 361);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(249, 34);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.EvidenceGrid);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.EvidenceGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView EvidenceGrid;
        private Button Load;
        private Button Cancel;
    }
}