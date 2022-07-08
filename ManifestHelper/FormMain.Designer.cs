namespace ManifestHelper
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dgFilePath = new System.Windows.Forms.OpenFileDialog();
            this.txtExePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLangCode = new System.Windows.Forms.ComboBox();
            this.txtManifestPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnManifestPath = new System.Windows.Forms.Button();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dgFilePath
            // 
            this.dgFilePath.Filter = "EXE 文件|*.exe|所有文件|*.*";
            this.dgFilePath.InitialDirectory = "C:\\";
            this.dgFilePath.Title = "请选择EXE文件";
            // 
            // txtExePath
            // 
            this.txtExePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExePath.Location = new System.Drawing.Point(143, 12);
            this.txtExePath.Name = "txtExePath";
            this.txtExePath.Size = new System.Drawing.Size(456, 21);
            this.txtExePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "可执行文件路径(&P):";
            // 
            // btnExePath
            // 
            this.btnExePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExePath.Location = new System.Drawing.Point(605, 12);
            this.btnExePath.Name = "btnExePath";
            this.btnExePath.Size = new System.Drawing.Size(43, 21);
            this.btnExePath.TabIndex = 2;
            this.btnExePath.Text = "…";
            this.btnExePath.UseVisualStyleBackColor = true;
            this.btnExePath.Click += new System.EventHandler(this.btnExePath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "语言代码(&L):";
            // 
            // cbLangCode
            // 
            this.cbLangCode.DisplayMember = "UTF-8";
            this.cbLangCode.FormattingEnabled = true;
            this.cbLangCode.Items.AddRange(new object[] {
            "utf-8",
            "af",
            "af-ZA",
            "ar",
            "ar-AE",
            "ar-BH",
            "ar-DZ",
            "ar-EG",
            "ar-IQ",
            "ar-JO",
            "ar-KW",
            "ar-LB",
            "ar-LY",
            "ar-MA",
            "ar-OM",
            "ar-QA",
            "ar-SA",
            "ar-SY",
            "ar-TN",
            "ar-YE",
            "az",
            "az-AZ",
            "az-AZ",
            "be",
            "be-BY",
            "bg",
            "bg-BG",
            "bs-BA",
            "ca",
            "ca-ES",
            "cs",
            "cs-CZ",
            "cy",
            "cy-GB",
            "da",
            "da-DK",
            "de",
            "de-AT",
            "de-CH",
            "de-DE",
            "de-LI",
            "de-LU",
            "dv",
            "dv-MV",
            "el",
            "el-GR",
            "en",
            "en-AU",
            "en-BZ",
            "en-CA",
            "en-CB",
            "en-GB",
            "en-IE",
            "en-JM",
            "en-NZ",
            "en-PH",
            "en-TT",
            "en-US",
            "en-ZA",
            "en-ZW",
            "eo",
            "es",
            "es-AR",
            "es-BO",
            "es-CL",
            "es-CO",
            "es-CR",
            "es-DO",
            "es-EC",
            "es-ES",
            "es-ES",
            "es-GT",
            "es-HN",
            "es-MX",
            "es-NI",
            "es-PA",
            "es-PE",
            "es-PR",
            "es-PY",
            "es-SV",
            "es-UY",
            "es-VE",
            "et",
            "et-EE",
            "eu",
            "eu-ES",
            "fa",
            "fa-IR",
            "fi",
            "fi-FI",
            "fo",
            "fo-FO",
            "fr",
            "fr-BE",
            "fr-CA",
            "fr-CH",
            "fr-FR",
            "fr-LU",
            "fr-MC",
            "gl",
            "gl-ES",
            "gu",
            "gu-IN",
            "he",
            "he-IL",
            "hi",
            "hi-IN",
            "hr",
            "hr-BA",
            "hr-HR",
            "hu",
            "hu-HU",
            "hy",
            "hy-AM",
            "id",
            "id-ID",
            "is",
            "is-IS",
            "it",
            "it-CH",
            "it-IT",
            "ja",
            "ja-JP",
            "ka",
            "ka-GE",
            "kk",
            "kk-KZ",
            "kn",
            "kn-IN",
            "ko",
            "ko-KR",
            "kok",
            "kok-IN",
            "ky",
            "ky-KG",
            "lt",
            "lt-LT",
            "lv",
            "lv-LV",
            "mi",
            "mi-NZ",
            "mk",
            "mk-MK",
            "mn",
            "mn-MN",
            "mr",
            "mr-IN",
            "ms",
            "ms-BN",
            "ms-MY",
            "mt",
            "mt-MT",
            "nb",
            "nb-NO",
            "nl",
            "nl-BE",
            "nl-NL",
            "nn-NO",
            "ns",
            "ns-ZA",
            "pa",
            "pa-IN",
            "pl",
            "pl-PL",
            "pt",
            "pt-BR",
            "pt-PT",
            "qu",
            "qu-BO",
            "qu-EC",
            "qu-PE",
            "ro",
            "ro-RO",
            "ru",
            "ru-RU",
            "sa",
            "sa-IN",
            "se",
            "se-FI",
            "se-FI",
            "se-FI",
            "se-NO",
            "se-NO",
            "se-NO",
            "se-SE",
            "se-SE",
            "se-SE",
            "sk",
            "sk-SK",
            "sl",
            "sl-SI",
            "sq",
            "sq-AL",
            "sr-BA",
            "sr-BA",
            "sr-SP",
            "sr-SP",
            "sv",
            "sv-FI",
            "sv-SE",
            "sw",
            "sw-KE",
            "syr",
            "syr-SY",
            "ta",
            "ta-IN",
            "te",
            "te-IN",
            "th",
            "th-TH",
            "tl",
            "tl-PH",
            "tn",
            "tn-ZA",
            "tr",
            "tr-TR",
            "ts",
            "tt",
            "tt-RU",
            "uk",
            "uk-UA",
            "ur",
            "ur-PK",
            "uz",
            "uz-UZ",
            "uz-UZ",
            "vi",
            "vi-VN",
            "xh",
            "xh-ZA",
            "zh",
            "zh-CN",
            "zh-Hans",
            "zh-HK",
            "zh-MO",
            "zh-SG",
            "zh-TW",
            "zu",
            "zu-ZA"});
            this.cbLangCode.Location = new System.Drawing.Point(144, 66);
            this.cbLangCode.Name = "cbLangCode";
            this.cbLangCode.Size = new System.Drawing.Size(173, 20);
            this.cbLangCode.TabIndex = 4;
            this.cbLangCode.Text = "utf-8";
            this.cbLangCode.TextChanged += new System.EventHandler(this.cbLangCode_TextChanged);
            // 
            // txtManifestPath
            // 
            this.txtManifestPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManifestPath.Location = new System.Drawing.Point(144, 39);
            this.txtManifestPath.Name = "txtManifestPath";
            this.txtManifestPath.Size = new System.Drawing.Size(456, 21);
            this.txtManifestPath.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Manifest输出路径(&O):";
            // 
            // btnManifestPath
            // 
            this.btnManifestPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManifestPath.Location = new System.Drawing.Point(605, 39);
            this.btnManifestPath.Name = "btnManifestPath";
            this.btnManifestPath.Size = new System.Drawing.Size(43, 21);
            this.btnManifestPath.TabIndex = 2;
            this.btnManifestPath.Text = "…";
            this.btnManifestPath.UseVisualStyleBackColor = true;
            this.btnManifestPath.Click += new System.EventHandler(this.btnManifestPath_Click);
            // 
            // txtPreview
            // 
            this.txtPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreview.Location = new System.Drawing.Point(144, 92);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.Size = new System.Drawing.Size(456, 125);
            this.txtPreview.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Manifest预览(&V):";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerate.Location = new System.Drawing.Point(143, 223);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(174, 30);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "保存 Manifest (&S)";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnGenerate;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 260);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cbLangCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnManifestPath);
            this.Controls.Add(this.btnExePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtManifestPath);
            this.Controls.Add(this.txtExePath);
            this.Controls.Add(this.txtPreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(999999, 300);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manifest 生成工具 By chr_ (支持拖拽)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dgFilePath;
        private System.Windows.Forms.TextBox txtExePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLangCode;
        private System.Windows.Forms.TextBox txtManifestPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnManifestPath;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerate;
    }
}

