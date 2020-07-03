namespace SatisFactory_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.OreList = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mined = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.used = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTN_Extraction = new System.Windows.Forms.Button();
            this.BTN_Delete_E = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OreList
            // 
            this.OreList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.mined,
            this.used});
            this.OreList.GridLines = true;
            this.OreList.HideSelection = false;
            this.OreList.Location = new System.Drawing.Point(12, 12);
            this.OreList.Name = "OreList";
            this.OreList.Size = new System.Drawing.Size(1110, 220);
            this.OreList.TabIndex = 0;
            this.OreList.UseCompatibleStateImageBehavior = false;
            this.OreList.View = System.Windows.Forms.View.List;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 100;
            // 
            // mined
            // 
            this.mined.Text = "Mined";
            this.mined.Width = 100;
            // 
            // used
            // 
            this.used.Text = "used";
            this.used.Width = 100;
            // 
            // BTN_Extraction
            // 
            this.BTN_Extraction.Location = new System.Drawing.Point(12, 238);
            this.BTN_Extraction.Name = "BTN_Extraction";
            this.BTN_Extraction.Size = new System.Drawing.Size(100, 25);
            this.BTN_Extraction.TabIndex = 1;
            this.BTN_Extraction.Text = "Add Extraction ";
            this.BTN_Extraction.UseVisualStyleBackColor = true;
            this.BTN_Extraction.Click += new System.EventHandler(this.BTN_Extraction_Click);
            // 
            // BTN_Delete_E
            // 
            this.BTN_Delete_E.Location = new System.Drawing.Point(118, 238);
            this.BTN_Delete_E.Name = "BTN_Delete_E";
            this.BTN_Delete_E.Size = new System.Drawing.Size(100, 25);
            this.BTN_Delete_E.TabIndex = 2;
            this.BTN_Delete_E.Text = " Delete Extraction ";
            this.BTN_Delete_E.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 659);
            this.Controls.Add(this.BTN_Delete_E);
            this.Controls.Add(this.BTN_Extraction);
            this.Controls.Add(this.OreList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView OreList;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader mined;
        private System.Windows.Forms.ColumnHeader used;
        private System.Windows.Forms.Button BTN_Extraction;
        private System.Windows.Forms.Button BTN_Delete_E;
    }
}

