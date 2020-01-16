namespace WinLess
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.useGloballyInstalledLessCheckbox = new System.Windows.Forms.CheckBox();
            this.startMinimizedCheckBox = new System.Windows.Forms.CheckBox();
            this.startWithWindowsCheckBox = new System.Windows.Forms.CheckBox();
            this.compilingGroupBox = new System.Windows.Forms.GroupBox();
            this.defaultMinifyCheckBox = new System.Windows.Forms.CheckBox();
            this.showSuccessMessagesCheckbox = new System.Windows.Forms.CheckBox();
            this.compileOnSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.saveMinifiedFilesSeparatelyCheckBox = new System.Windows.Forms.CheckBox();
            this.generalGroupBox.SuspendLayout();
            this.compilingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(197, 233);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(116, 233);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.useGloballyInstalledLessCheckbox);
            this.generalGroupBox.Controls.Add(this.startMinimizedCheckBox);
            this.generalGroupBox.Controls.Add(this.startWithWindowsCheckBox);
            this.generalGroupBox.Location = new System.Drawing.Point(13, 9);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(259, 91);
            this.generalGroupBox.TabIndex = 2;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // useGloballyInstalledLessCheckbox
            // 
            this.useGloballyInstalledLessCheckbox.AutoSize = true;
            this.useGloballyInstalledLessCheckbox.Location = new System.Drawing.Point(7, 67);
            this.useGloballyInstalledLessCheckbox.Name = "useGloballyInstalledLessCheckbox";
            this.useGloballyInstalledLessCheckbox.Size = new System.Drawing.Size(145, 17);
            this.useGloballyInstalledLessCheckbox.TabIndex = 2;
            this.useGloballyInstalledLessCheckbox.Text = "Use globally installed less";
            this.useGloballyInstalledLessCheckbox.UseVisualStyleBackColor = true;
            // 
            // startMinimizedCheckBox
            // 
            this.startMinimizedCheckBox.AutoSize = true;
            this.startMinimizedCheckBox.Location = new System.Drawing.Point(7, 44);
            this.startMinimizedCheckBox.Name = "startMinimizedCheckBox";
            this.startMinimizedCheckBox.Size = new System.Drawing.Size(96, 17);
            this.startMinimizedCheckBox.TabIndex = 1;
            this.startMinimizedCheckBox.Text = "Start minimized";
            this.startMinimizedCheckBox.UseVisualStyleBackColor = true;
            // 
            // startWithWindowsCheckBox
            // 
            this.startWithWindowsCheckBox.AutoSize = true;
            this.startWithWindowsCheckBox.Location = new System.Drawing.Point(7, 20);
            this.startWithWindowsCheckBox.Name = "startWithWindowsCheckBox";
            this.startWithWindowsCheckBox.Size = new System.Drawing.Size(117, 17);
            this.startWithWindowsCheckBox.TabIndex = 0;
            this.startWithWindowsCheckBox.Text = "Start with Windows";
            this.startWithWindowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // compilingGroupBox
            // 
            this.compilingGroupBox.Controls.Add(this.defaultMinifyCheckBox);
            this.compilingGroupBox.Controls.Add(this.showSuccessMessagesCheckbox);
            this.compilingGroupBox.Controls.Add(this.compileOnSaveCheckBox);
            this.compilingGroupBox.Controls.Add(this.saveMinifiedFilesSeparatelyCheckBox);
            this.compilingGroupBox.Location = new System.Drawing.Point(13, 106);
            this.compilingGroupBox.Name = "compilingGroupBox";
            this.compilingGroupBox.Size = new System.Drawing.Size(259, 121);
            this.compilingGroupBox.TabIndex = 3;
            this.compilingGroupBox.TabStop = false;
            this.compilingGroupBox.Text = "Compiling";
            // 
            // defaultMinifyCheckBox
            // 
            this.defaultMinifyCheckBox.AutoSize = true;
            this.defaultMinifyCheckBox.Location = new System.Drawing.Point(6, 20);
            this.defaultMinifyCheckBox.Name = "defaultMinifyCheckBox";
            this.defaultMinifyCheckBox.Size = new System.Drawing.Size(102, 17);
            this.defaultMinifyCheckBox.TabIndex = 3;
            this.defaultMinifyCheckBox.Text = "Minify by default";
            this.defaultMinifyCheckBox.UseVisualStyleBackColor = true;
            // 
            // showSuccessMessagesCheckbox
            // 
            this.showSuccessMessagesCheckbox.AutoSize = true;
            this.showSuccessMessagesCheckbox.Location = new System.Drawing.Point(7, 89);
            this.showSuccessMessagesCheckbox.Name = "showSuccessMessagesCheckbox";
            this.showSuccessMessagesCheckbox.Size = new System.Drawing.Size(205, 17);
            this.showSuccessMessagesCheckbox.TabIndex = 2;
            this.showSuccessMessagesCheckbox.Text = "Show message on successful compile";
            this.showSuccessMessagesCheckbox.UseVisualStyleBackColor = true;
            // 
            // compileOnSaveCheckBox
            // 
            this.compileOnSaveCheckBox.AutoSize = true;
            this.compileOnSaveCheckBox.Location = new System.Drawing.Point(7, 66);
            this.compileOnSaveCheckBox.Name = "compileOnSaveCheckBox";
            this.compileOnSaveCheckBox.Size = new System.Drawing.Size(209, 17);
            this.compileOnSaveCheckBox.TabIndex = 1;
            this.compileOnSaveCheckBox.Text = "Automatically compile files when saved";
            this.compileOnSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveMinifiedFilesSeparatelyCheckBox
            // 
            this.saveMinifiedFilesSeparatelyCheckBox.AutoSize = true;
            this.saveMinifiedFilesSeparatelyCheckBox.Location = new System.Drawing.Point(7, 43);
            this.saveMinifiedFilesSeparatelyCheckBox.Name = "saveMinifiedFilesSeparatelyCheckBox";
            this.saveMinifiedFilesSeparatelyCheckBox.Size = new System.Drawing.Size(212, 17);
            this.saveMinifiedFilesSeparatelyCheckBox.TabIndex = 0;
            this.saveMinifiedFilesSeparatelyCheckBox.Text = "Save minified files separately (*.min.css)";
            this.saveMinifiedFilesSeparatelyCheckBox.UseVisualStyleBackColor = true;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 268);
            this.Controls.Add(this.compilingGroupBox);
            this.Controls.Add(this.generalGroupBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.compilingGroupBox.ResumeLayout(false);
            this.compilingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.CheckBox startMinimizedCheckBox;
        private System.Windows.Forms.CheckBox startWithWindowsCheckBox;
        private System.Windows.Forms.GroupBox compilingGroupBox;
        private System.Windows.Forms.CheckBox saveMinifiedFilesSeparatelyCheckBox;
        private System.Windows.Forms.CheckBox compileOnSaveCheckBox;
        private System.Windows.Forms.CheckBox showSuccessMessagesCheckbox;
        private System.Windows.Forms.CheckBox useGloballyInstalledLessCheckbox;
        private System.Windows.Forms.CheckBox defaultMinifyCheckBox;
    }
}