﻿namespace VaultExplorer
{
    partial class SecretDialog
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label uxLabelValue;
            this.uxTextBoxName = new System.Windows.Forms.TextBox();
            this.uxButtonOK = new System.Windows.Forms.Button();
            this.uxButtonCancel = new System.Windows.Forms.Button();
            this.uxErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.uxSplitContainer = new System.Windows.Forms.SplitContainer();
            this.uxTextBoxValue = new System.Windows.Forms.TextBox();
            this.uxPropertyGridSecret = new System.Windows.Forms.PropertyGrid();
            this.uxLabelBytesLeft = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            uxLabelValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSplitContainer)).BeginInit();
            this.uxSplitContainer.Panel1.SuspendLayout();
            this.uxSplitContainer.Panel2.SuspendLayout();
            this.uxSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 11);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 17);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // uxLabelValue
            // 
            uxLabelValue.AutoSize = true;
            uxLabelValue.Location = new System.Drawing.Point(16, 72);
            uxLabelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            uxLabelValue.Name = "uxLabelValue";
            uxLabelValue.Size = new System.Drawing.Size(48, 17);
            uxLabelValue.TabIndex = 3;
            uxLabelValue.Text = "Value:";
            // 
            // uxTextBoxName
            // 
            this.uxTextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBoxName.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.uxTextBoxName.Location = new System.Drawing.Point(20, 31);
            this.uxTextBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.uxTextBoxName.MaxLength = 256;
            this.uxTextBoxName.Name = "uxTextBoxName";
            this.uxTextBoxName.Size = new System.Drawing.Size(639, 26);
            this.uxTextBoxName.TabIndex = 2;
            this.uxTextBoxName.TextChanged += new System.EventHandler(this.uxTextBoxName_TextChanged);
            // 
            // uxButtonOK
            // 
            this.uxButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxButtonOK.Enabled = false;
            this.uxButtonOK.Location = new System.Drawing.Point(452, 570);
            this.uxButtonOK.Margin = new System.Windows.Forms.Padding(4);
            this.uxButtonOK.Name = "uxButtonOK";
            this.uxButtonOK.Size = new System.Drawing.Size(100, 28);
            this.uxButtonOK.TabIndex = 5;
            this.uxButtonOK.Text = "OK";
            this.uxButtonOK.UseVisualStyleBackColor = true;
            this.uxButtonOK.Click += new System.EventHandler(this.uxButtonOK_Click);
            // 
            // uxButtonCancel
            // 
            this.uxButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxButtonCancel.Location = new System.Drawing.Point(560, 570);
            this.uxButtonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.uxButtonCancel.Name = "uxButtonCancel";
            this.uxButtonCancel.Size = new System.Drawing.Size(100, 28);
            this.uxButtonCancel.TabIndex = 6;
            this.uxButtonCancel.Text = "Cancel";
            this.uxButtonCancel.UseVisualStyleBackColor = true;
            // 
            // uxErrorProvider
            // 
            this.uxErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.uxErrorProvider.ContainerControl = this;
            // 
            // uxSplitContainer
            // 
            this.uxSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSplitContainer.Location = new System.Drawing.Point(20, 92);
            this.uxSplitContainer.Name = "uxSplitContainer";
            this.uxSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // uxSplitContainer.Panel1
            // 
            this.uxSplitContainer.Panel1.Controls.Add(this.uxTextBoxValue);
            // 
            // uxSplitContainer.Panel2
            // 
            this.uxSplitContainer.Panel2.Controls.Add(this.uxPropertyGridSecret);
            this.uxSplitContainer.Size = new System.Drawing.Size(639, 471);
            this.uxSplitContainer.SplitterDistance = 357;
            this.uxSplitContainer.SplitterWidth = 6;
            this.uxSplitContainer.TabIndex = 8;
            // 
            // uxTextBoxValue
            // 
            this.uxTextBoxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxTextBoxValue.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBoxValue.Location = new System.Drawing.Point(0, 0);
            this.uxTextBoxValue.Margin = new System.Windows.Forms.Padding(4);
            this.uxTextBoxValue.MaxLength = 25600;
            this.uxTextBoxValue.Multiline = true;
            this.uxTextBoxValue.Name = "uxTextBoxValue";
            this.uxTextBoxValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxTextBoxValue.Size = new System.Drawing.Size(639, 357);
            this.uxTextBoxValue.TabIndex = 5;
            this.uxTextBoxValue.TextChanged += new System.EventHandler(this.uxTextBoxValue_TextChanged);
            // 
            // uxPropertyGridSecret
            // 
            this.uxPropertyGridSecret.DisabledItemForeColor = System.Drawing.SystemColors.WindowText;
            this.uxPropertyGridSecret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxPropertyGridSecret.HelpVisible = false;
            this.uxPropertyGridSecret.Location = new System.Drawing.Point(0, 0);
            this.uxPropertyGridSecret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPropertyGridSecret.Name = "uxPropertyGridSecret";
            this.uxPropertyGridSecret.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.uxPropertyGridSecret.Size = new System.Drawing.Size(639, 108);
            this.uxPropertyGridSecret.TabIndex = 8;
            this.uxPropertyGridSecret.ToolbarVisible = false;
            // 
            // uxLabelBytesLeft
            // 
            this.uxLabelBytesLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxLabelBytesLeft.Location = new System.Drawing.Point(405, 72);
            this.uxLabelBytesLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxLabelBytesLeft.Name = "uxLabelBytesLeft";
            this.uxLabelBytesLeft.Size = new System.Drawing.Size(254, 17);
            this.uxLabelBytesLeft.TabIndex = 3;
            this.uxLabelBytesLeft.Text = "xxx bytes left";
            this.uxLabelBytesLeft.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SecretDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uxButtonCancel;
            this.ClientSize = new System.Drawing.Size(676, 611);
            this.Controls.Add(this.uxSplitContainer);
            this.Controls.Add(this.uxButtonCancel);
            this.Controls.Add(this.uxButtonOK);
            this.Controls.Add(this.uxLabelBytesLeft);
            this.Controls.Add(uxLabelValue);
            this.Controls.Add(this.uxTextBoxName);
            this.Controls.Add(label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "SecretDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Secret";
            ((System.ComponentModel.ISupportInitialize)(this.uxErrorProvider)).EndInit();
            this.uxSplitContainer.Panel1.ResumeLayout(false);
            this.uxSplitContainer.Panel1.PerformLayout();
            this.uxSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxSplitContainer)).EndInit();
            this.uxSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTextBoxName;
        private System.Windows.Forms.Button uxButtonOK;
        private System.Windows.Forms.Button uxButtonCancel;
        private System.Windows.Forms.ErrorProvider uxErrorProvider;
        private System.Windows.Forms.TextBox uxTextBoxValue;
        private System.Windows.Forms.PropertyGrid uxPropertyGridSecret;
        private System.Windows.Forms.SplitContainer uxSplitContainer;
        private System.Windows.Forms.Label uxLabelBytesLeft;
    }
}