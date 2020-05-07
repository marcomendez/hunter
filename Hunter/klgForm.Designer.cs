using n7aKeylogger;
namespace WindowsFormsApplication1
{
    partial class klgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(klgForm));
            this.cbKeyloggerEnabled = new System.Windows.Forms.CheckBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtElements = new System.Windows.Forms.TextBox();
            this.txtResources = new System.Windows.Forms.TextBox();
            this.keylogger1 = new n7aKeylogger.Keylogger();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKeyloggerEnabled
            // 
            this.cbKeyloggerEnabled.AutoSize = true;
            this.cbKeyloggerEnabled.Location = new System.Drawing.Point(15, 12);
            this.cbKeyloggerEnabled.Name = "cbKeyloggerEnabled";
            this.cbKeyloggerEnabled.Size = new System.Drawing.Size(115, 17);
            this.cbKeyloggerEnabled.TabIndex = 9;
            this.cbKeyloggerEnabled.Text = "Keylogger Enabled";
            this.cbKeyloggerEnabled.UseVisualStyleBackColor = true;
            this.cbKeyloggerEnabled.CheckedChanged += new System.EventHandler(this.cbKeyloggerEnabled_CheckedChanged);
            // 
            // btnClean
            // 
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.Location = new System.Drawing.Point(12, 35);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(118, 23);
            this.btnClean.TabIndex = 16;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(12, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.close_Click);
            // 
            // btnXml
            // 
            this.btnXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXml.Location = new System.Drawing.Point(12, 143);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(118, 23);
            this.btnXml.TabIndex = 19;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(12, 117);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(118, 20);
            this.txtAppName.TabIndex = 20;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(169, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtElements);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtResources);
            this.splitContainer1.Size = new System.Drawing.Size(678, 415);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.TabIndex = 21;
            // 
            // txtElements
            // 
            this.txtElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtElements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtElements.Location = new System.Drawing.Point(3, 3);
            this.txtElements.Multiline = true;
            this.txtElements.Name = "txtElements";
            this.txtElements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtElements.Size = new System.Drawing.Size(219, 393);
            this.txtElements.TabIndex = 22;
            // 
            // txtResources
            // 
            this.txtResources.AllowDrop = true;
            this.txtResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResources.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResources.Location = new System.Drawing.Point(17, 3);
            this.txtResources.Multiline = true;
            this.txtResources.Name = "txtResources";
            this.txtResources.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResources.Size = new System.Drawing.Size(412, 397);
            this.txtResources.TabIndex = 14;
            // 
            // keylogger1
            // 
            this.keylogger1.Enabled = false;
            this.keylogger1.Keylogger_Mode = n7aKeylogger.Keylogger.Keylogger_Modes.Hooks;
            this.keylogger1.VKCodeAsStringDown += new n7aKeylogger.Keylogger.ValueChangedEventHandler(this.keylogger1_VKCodeAsStringDown);
            // 
            // klgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 439);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.cbKeyloggerEnabled);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "klgForm";
            this.Text = "Hunter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.klgForm_FormClosing);
            this.Load += new System.EventHandler(this.klgForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Keylogger keylogger1;
        private System.Windows.Forms.CheckBox cbKeyloggerEnabled;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtElements;
        private System.Windows.Forms.TextBox txtResources;
    }
}

