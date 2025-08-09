namespace UControlLib
{
    partial class UControl
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblChiku = new System.Windows.Forms.Label();
            this.cboChiku = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblChiku
            // 
            this.lblChiku.AutoSize = true;
            this.lblChiku.Location = new System.Drawing.Point(13, 16);
            this.lblChiku.Name = "lblChiku";
            this.lblChiku.Size = new System.Drawing.Size(71, 30);
            this.lblChiku.TabIndex = 0;
            this.lblChiku.Text = "Area";
            this.lblChiku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboChiku
            // 
            this.cboChiku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChiku.FormattingEnabled = true;
            this.cboChiku.Location = new System.Drawing.Point(102, 11);
            this.cboChiku.Name = "cboChiku";
            this.cboChiku.Size = new System.Drawing.Size(183, 38);
            this.cboChiku.TabIndex = 1;
            // 
            // UControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboChiku);
            this.Controls.Add(this.lblChiku);
            this.Name = "UControl";
            this.Size = new System.Drawing.Size(296, 61);
            this.Load += new System.EventHandler(this.UControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChiku;
        private System.Windows.Forms.ComboBox cboChiku;
    }
}
