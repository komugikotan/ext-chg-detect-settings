namespace ext_change_detect_settings
{
    partial class ecd_settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.path_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.update_path = new System.Windows.Forms.Button();
            this.update_startup_true = new System.Windows.Forms.Button();
            this.update_startup_false = new System.Windows.Forms.Button();
            this.exe_start = new System.Windows.Forms.Button();
            this.show_licence_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "フォルダ設定";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 1;
            // 
            // path_textbox
            // 
            this.path_textbox.Location = new System.Drawing.Point(14, 33);
            this.path_textbox.Name = "path_textbox";
            this.path_textbox.Size = new System.Drawing.Size(378, 19);
            this.path_textbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "スタートアップ設定";
            // 
            // update_path
            // 
            this.update_path.Location = new System.Drawing.Point(14, 58);
            this.update_path.Name = "update_path";
            this.update_path.Size = new System.Drawing.Size(378, 23);
            this.update_path.TabIndex = 4;
            this.update_path.Text = "更新";
            this.update_path.UseVisualStyleBackColor = true;
            this.update_path.Click += new System.EventHandler(this.update_path_Click);
            // 
            // update_startup_true
            // 
            this.update_startup_true.Location = new System.Drawing.Point(14, 122);
            this.update_startup_true.Name = "update_startup_true";
            this.update_startup_true.Size = new System.Drawing.Size(186, 23);
            this.update_startup_true.TabIndex = 5;
            this.update_startup_true.Text = "有効化";
            this.update_startup_true.UseVisualStyleBackColor = true;
            this.update_startup_true.Click += new System.EventHandler(this.update_startup_true_Click);
            // 
            // update_startup_false
            // 
            this.update_startup_false.Location = new System.Drawing.Point(206, 122);
            this.update_startup_false.Name = "update_startup_false";
            this.update_startup_false.Size = new System.Drawing.Size(186, 23);
            this.update_startup_false.TabIndex = 6;
            this.update_startup_false.Text = "無効化";
            this.update_startup_false.UseVisualStyleBackColor = true;
            this.update_startup_false.Click += new System.EventHandler(this.update_startup_false_Click);
            // 
            // exe_start
            // 
            this.exe_start.Location = new System.Drawing.Point(14, 152);
            this.exe_start.Name = "exe_start";
            this.exe_start.Size = new System.Drawing.Size(378, 38);
            this.exe_start.TabIndex = 7;
            this.exe_start.Text = "アプリを起動する（バックグラウンドで動作します）";
            this.exe_start.UseVisualStyleBackColor = true;
            this.exe_start.Click += new System.EventHandler(this.exe_start_Click);
            // 
            // show_licence_button
            // 
            this.show_licence_button.Location = new System.Drawing.Point(14, 196);
            this.show_licence_button.Name = "show_licence_button";
            this.show_licence_button.Size = new System.Drawing.Size(378, 38);
            this.show_licence_button.TabIndex = 8;
            this.show_licence_button.Text = "Show LICENCES";
            this.show_licence_button.UseVisualStyleBackColor = true;
            this.show_licence_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // ecd_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 239);
            this.Controls.Add(this.show_licence_button);
            this.Controls.Add(this.exe_start);
            this.Controls.Add(this.update_startup_false);
            this.Controls.Add(this.update_startup_true);
            this.Controls.Add(this.update_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.path_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ecd_settings";
            this.Text = "設定変更";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox path_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button update_path;
        private System.Windows.Forms.Button update_startup_true;
        private System.Windows.Forms.Button update_startup_false;
        private System.Windows.Forms.Button exe_start;
        private System.Windows.Forms.Button show_licence_button;
    }
}

