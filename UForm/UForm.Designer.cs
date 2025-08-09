namespace UForm
{
    partial class UForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.uc = new UControlLib.UControl();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(636, 348);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(113, 60);
            this.btn.TabIndex = 1;
            this.btn.Text = "East!";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // uc
            // 
            this.uc.LableText = "Area";
            this.uc.Location = new System.Drawing.Point(26, 23);
            this.uc.Name = "uc";
            this.uc.NeedBlankOption = false;
            this.uc.SelectedValue = "01";
            this.uc.Size = new System.Drawing.Size(296, 66);
            this.uc.TabIndex = 0;
            this.uc.SelectedIndexChanged += new System.EventHandler(this.uc_SelectedIndexChanged);
            // 
            // UForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.uc);
            this.Name = "UForm";
            this.Text = "User control test";
            this.ResumeLayout(false);

        }

        #endregion

        private UControlLib.UControl uc;
        private System.Windows.Forms.Button btn;
    }
}

