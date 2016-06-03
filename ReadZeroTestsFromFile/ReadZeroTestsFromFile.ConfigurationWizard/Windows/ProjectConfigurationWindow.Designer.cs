namespace ReadZeroTestsFromFile.ConfigurationWizard.Windows
{
    partial class ProjectConfigurationWindow
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
            this.lblInputConfigure = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelInputFileConfiguration = new System.Windows.Forms.Panel();
            this.btnBrowseInputFile = new System.Windows.Forms.Button();
            this.lblInputFileName = new System.Windows.Forms.Label();
            this.cmbInputSource = new System.Windows.Forms.ComboBox();
            this.lblReadInputFrom = new System.Windows.Forms.Label();
            this.lblConfigureOutputTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fdlgInputFile = new System.Windows.Forms.OpenFileDialog();
            this.lblproblemSolverName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelInput.SuspendLayout();
            this.panelInputFileConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInputConfigure
            // 
            this.lblInputConfigure.AutoSize = true;
            this.lblInputConfigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputConfigure.Location = new System.Drawing.Point(21, 55);
            this.lblInputConfigure.Name = "lblInputConfigure";
            this.lblInputConfigure.Size = new System.Drawing.Size(348, 29);
            this.lblInputConfigure.TabIndex = 0;
            this.lblInputConfigure.Text = "Configure Input Parameters";
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.panelInputFileConfiguration);
            this.panelInput.Controls.Add(this.cmbInputSource);
            this.panelInput.Controls.Add(this.lblReadInputFrom);
            this.panelInput.Location = new System.Drawing.Point(18, 87);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(822, 173);
            this.panelInput.TabIndex = 1;
            // 
            // panelInputFileConfiguration
            // 
            this.panelInputFileConfiguration.Controls.Add(this.btnBrowseInputFile);
            this.panelInputFileConfiguration.Controls.Add(this.lblInputFileName);
            this.panelInputFileConfiguration.Location = new System.Drawing.Point(0, 48);
            this.panelInputFileConfiguration.Name = "panelInputFileConfiguration";
            this.panelInputFileConfiguration.Size = new System.Drawing.Size(809, 100);
            this.panelInputFileConfiguration.TabIndex = 4;
            // 
            // btnBrowseInputFile
            // 
            this.btnBrowseInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseInputFile.Location = new System.Drawing.Point(224, 12);
            this.btnBrowseInputFile.Name = "btnBrowseInputFile";
            this.btnBrowseInputFile.Size = new System.Drawing.Size(123, 34);
            this.btnBrowseInputFile.TabIndex = 3;
            this.btnBrowseInputFile.Text = "Browse...";
            this.btnBrowseInputFile.UseVisualStyleBackColor = true;
            this.btnBrowseInputFile.Click += new System.EventHandler(this.btnBrowseInputFile_Click);
            // 
            // lblInputFileName
            // 
            this.lblInputFileName.AutoSize = true;
            this.lblInputFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputFileName.Location = new System.Drawing.Point(5, 21);
            this.lblInputFileName.Name = "lblInputFileName";
            this.lblInputFileName.Size = new System.Drawing.Size(148, 25);
            this.lblInputFileName.TabIndex = 1;
            this.lblInputFileName.Text = "Input Data File: ";
            // 
            // cmbInputSource
            // 
            this.cmbInputSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInputSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInputSource.FormattingEnabled = true;
            this.cmbInputSource.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbInputSource.Items.AddRange(new object[] {
            "-- Select --",
            "Console",
            "Text File"});
            this.cmbInputSource.Location = new System.Drawing.Point(224, 14);
            this.cmbInputSource.Name = "cmbInputSource";
            this.cmbInputSource.Size = new System.Drawing.Size(121, 33);
            this.cmbInputSource.TabIndex = 2;
            this.cmbInputSource.SelectedIndexChanged += new System.EventHandler(this.cmbInputSource_SelectedIndexChanged);
            // 
            // lblReadInputFrom
            // 
            this.lblReadInputFrom.AutoSize = true;
            this.lblReadInputFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadInputFrom.Location = new System.Drawing.Point(3, 17);
            this.lblReadInputFrom.Name = "lblReadInputFrom";
            this.lblReadInputFrom.Size = new System.Drawing.Size(213, 25);
            this.lblReadInputFrom.TabIndex = 0;
            this.lblReadInputFrom.Text = "Read Input Data From: ";
            // 
            // lblConfigureOutputTitle
            // 
            this.lblConfigureOutputTitle.AutoSize = true;
            this.lblConfigureOutputTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigureOutputTitle.Location = new System.Drawing.Point(13, 263);
            this.lblConfigureOutputTitle.Name = "lblConfigureOutputTitle";
            this.lblConfigureOutputTitle.Size = new System.Drawing.Size(369, 29);
            this.lblConfigureOutputTitle.TabIndex = 2;
            this.lblConfigureOutputTitle.Text = "Configure Output Parameters";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(18, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 173);
            this.panel2.TabIndex = 2;
            // 
            // fdlgInputFile
            // 
            this.fdlgInputFile.FileName = "openFileDialog1";
            // 
            // lblproblemSolverName
            // 
            this.lblproblemSolverName.AutoSize = true;
            this.lblproblemSolverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproblemSolverName.Location = new System.Drawing.Point(23, 22);
            this.lblproblemSolverName.Name = "lblproblemSolverName";
            this.lblproblemSolverName.Size = new System.Drawing.Size(213, 25);
            this.lblproblemSolverName.TabIndex = 3;
            this.lblproblemSolverName.Text = "Problem Solver Name: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(242, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 30);
            this.textBox1.TabIndex = 4;
            // 
            // ProjectConfigurationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 545);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblproblemSolverName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblConfigureOutputTitle);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.lblInputConfigure);
            this.Name = "ProjectConfigurationWindow";
            this.Text = "ProjectConfigurationWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectConfigurationWindow_FormClosing);
            this.Load += new System.EventHandler(this.ProjectConfigurationWindow_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelInputFileConfiguration.ResumeLayout(false);
            this.panelInputFileConfiguration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputConfigure;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.ComboBox cmbInputSource;
        private System.Windows.Forms.Label lblInputFileName;
        private System.Windows.Forms.Label lblReadInputFrom;
        private System.Windows.Forms.Label lblConfigureOutputTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBrowseInputFile;
        private System.Windows.Forms.OpenFileDialog fdlgInputFile;
        private System.Windows.Forms.Label lblproblemSolverName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelInputFileConfiguration;
    }
}