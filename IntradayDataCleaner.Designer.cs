namespace MarketAnalyser
{
    partial class IntradayDataCleaner
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
            this.ultraDateTimeEditor2 = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraDateTimeEditor1 = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraDateTimeEditor2
            // 
            this.ultraDateTimeEditor2.DateTime = new System.DateTime(2014, 11, 23, 8, 35, 0, 0);
            this.ultraDateTimeEditor2.Location = new System.Drawing.Point(318, 61);
            this.ultraDateTimeEditor2.MaskInput = "{time}";
            this.ultraDateTimeEditor2.Name = "ultraDateTimeEditor2";
            this.ultraDateTimeEditor2.Size = new System.Drawing.Size(144, 21);
            this.ultraDateTimeEditor2.TabIndex = 6;
            this.ultraDateTimeEditor2.Value = new System.DateTime(2014, 11, 23, 8, 35, 0, 0);
            // 
            // ultraDateTimeEditor1
            // 
            this.ultraDateTimeEditor1.DateTime = new System.DateTime(2014, 11, 23, 4, 25, 0, 0);
            this.ultraDateTimeEditor1.Location = new System.Drawing.Point(137, 61);
            this.ultraDateTimeEditor1.MaskInput = "{time}";
            this.ultraDateTimeEditor1.Name = "ultraDateTimeEditor1";
            this.ultraDateTimeEditor1.Size = new System.Drawing.Size(144, 21);
            this.ultraDateTimeEditor1.TabIndex = 5;
            this.ultraDateTimeEditor1.Value = new System.DateTime(2014, 11, 23, 4, 25, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clean";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IntradayDataCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ultraDateTimeEditor2);
            this.Controls.Add(this.ultraDateTimeEditor1);
            this.Name = "IntradayDataCleaner";
            this.Text = "IntradayDataCleaner";
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditor2;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditor1;
        private System.Windows.Forms.Button button1;
    }
}