namespace EasyNuget
{
    partial class frmAddPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPackage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtInputProjPath = new System.Windows.Forms.TextBox();
            this.BtnBrowseInput = new System.Windows.Forms.Button();
            this.TxtPackageVer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBrowseOutput = new System.Windows.Forms.Button();
            this.TxtOutputPackagePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAddPackage = new System.Windows.Forms.Button();
            this.BtnTestPackage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fbOut = new System.Windows.Forms.FolderBrowserDialog();
            this.ofInput = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 56);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add nuget package";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 2);
            this.label1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input csproj";
            // 
            // TxtInputProjPath
            // 
            this.TxtInputProjPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtInputProjPath.Location = new System.Drawing.Point(111, 81);
            this.TxtInputProjPath.Name = "TxtInputProjPath";
            this.TxtInputProjPath.Size = new System.Drawing.Size(309, 20);
            this.TxtInputProjPath.TabIndex = 3;
            this.TxtInputProjPath.Text = "C:\\Dev\\";
            // 
            // BtnBrowseInput
            // 
            this.BtnBrowseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowseInput.Location = new System.Drawing.Point(426, 79);
            this.BtnBrowseInput.Name = "BtnBrowseInput";
            this.BtnBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowseInput.TabIndex = 4;
            this.BtnBrowseInput.Text = "Browse";
            this.BtnBrowseInput.UseVisualStyleBackColor = true;
            this.BtnBrowseInput.Click += new System.EventHandler(this.BtnBrowseInput_Click);
            // 
            // TxtPackageVer
            // 
            this.TxtPackageVer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPackageVer.Location = new System.Drawing.Point(111, 133);
            this.TxtPackageVer.Name = "TxtPackageVer";
            this.TxtPackageVer.Size = new System.Drawing.Size(309, 20);
            this.TxtPackageVer.TabIndex = 6;
            this.TxtPackageVer.Text = "1.0.0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Package Ver";
            // 
            // BtnBrowseOutput
            // 
            this.BtnBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowseOutput.Location = new System.Drawing.Point(426, 105);
            this.BtnBrowseOutput.Name = "BtnBrowseOutput";
            this.BtnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowseOutput.TabIndex = 9;
            this.BtnBrowseOutput.Text = "Browse";
            this.BtnBrowseOutput.UseVisualStyleBackColor = true;
            this.BtnBrowseOutput.Click += new System.EventHandler(this.BtnBrowseOutput_Click);
            // 
            // TxtOutputPackagePath
            // 
            this.TxtOutputPackagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOutputPackagePath.Location = new System.Drawing.Point(111, 107);
            this.TxtOutputPackagePath.Name = "TxtOutputPackagePath";
            this.TxtOutputPackagePath.Size = new System.Drawing.Size(309, 20);
            this.TxtOutputPackagePath.TabIndex = 8;
            this.TxtOutputPackagePath.Text = "C:\\Dev\\packages";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Destination Folder";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(426, 186);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddPackage
            // 
            this.BtnAddPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddPackage.Location = new System.Drawing.Point(345, 186);
            this.BtnAddPackage.Name = "BtnAddPackage";
            this.BtnAddPackage.Size = new System.Drawing.Size(75, 23);
            this.BtnAddPackage.TabIndex = 11;
            this.BtnAddPackage.Text = "Add";
            this.BtnAddPackage.UseVisualStyleBackColor = true;
            this.BtnAddPackage.Click += new System.EventHandler(this.BtnAddPackage_Click);
            // 
            // BtnTestPackage
            // 
            this.BtnTestPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTestPackage.Location = new System.Drawing.Point(264, 186);
            this.BtnTestPackage.Name = "BtnTestPackage";
            this.BtnTestPackage.Size = new System.Drawing.Size(75, 23);
            this.BtnTestPackage.TabIndex = 12;
            this.BtnTestPackage.Text = "Test";
            this.BtnTestPackage.UseVisualStyleBackColor = true;
            this.BtnTestPackage.Click += new System.EventHandler(this.BtnTestPackage_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(-1, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(514, 2);
            this.label6.TabIndex = 13;
            // 
            // ofInput
            // 
            this.ofInput.FileName = "openFileDialog1";
            // 
            // frmAddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 221);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnTestPackage);
            this.Controls.Add(this.BtnAddPackage);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnBrowseOutput);
            this.Controls.Add(this.TxtOutputPackagePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPackageVer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnBrowseInput);
            this.Controls.Add(this.TxtInputProjPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Nuget Package";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtInputProjPath;
        private System.Windows.Forms.Button BtnBrowseInput;
        private System.Windows.Forms.TextBox TxtPackageVer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBrowseOutput;
        private System.Windows.Forms.TextBox TxtOutputPackagePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAddPackage;
        private System.Windows.Forms.Button BtnTestPackage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog fbOut;
        private System.Windows.Forms.OpenFileDialog ofInput;
    }
}