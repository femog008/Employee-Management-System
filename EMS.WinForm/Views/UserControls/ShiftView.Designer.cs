﻿namespace EMS.WinForm.Views.UserControls
{
    partial class ShiftView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.MenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ViewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MessageStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DetailPanel = new System.Windows.Forms.Panel();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ShiftNameTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShiftGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.MenuToolStrip.SuspendLayout();
            this.MessageStatusStrip.SuspendLayout();
            this.DetailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 22);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Shift Configuration";
            // 
            // MenuToolStrip
            // 
            this.MenuToolStrip.AutoSize = false;
            this.MenuToolStrip.BackColor = System.Drawing.Color.White;
            this.MenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.EditToolStripButton,
            this.ViewToolStripButton,
            this.DeleteToolStripButton});
            this.MenuToolStrip.Location = new System.Drawing.Point(0, 22);
            this.MenuToolStrip.Name = "MenuToolStrip";
            this.MenuToolStrip.Size = new System.Drawing.Size(800, 28);
            this.MenuToolStrip.Stretch = true;
            this.MenuToolStrip.TabIndex = 7;
            this.MenuToolStrip.Text = "toolStrip1";
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolStripButton.Image = global::EMS.WinForm.Properties.Resources.Add_16xMD;
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Margin = new System.Windows.Forms.Padding(3);
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewToolStripButton.Text = "New";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditToolStripButton.Image = global::EMS.WinForm.Properties.Resources.Edit_grey_16xMD;
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Margin = new System.Windows.Forms.Padding(3);
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.EditToolStripButton.Text = "Edit";
            this.EditToolStripButton.ToolTipText = "Edit";
            this.EditToolStripButton.Click += new System.EventHandler(this.EditToolStripButton_Click);
            // 
            // ViewToolStripButton
            // 
            this.ViewToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ViewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ViewToolStripButton.Image = global::EMS.WinForm.Properties.Resources.table_16xMD;
            this.ViewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewToolStripButton.Margin = new System.Windows.Forms.Padding(3);
            this.ViewToolStripButton.Name = "ViewToolStripButton";
            this.ViewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ViewToolStripButton.Text = "View";
            this.ViewToolStripButton.Click += new System.EventHandler(this.ViewToolStripButton_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteToolStripButton.Image = global::EMS.WinForm.Properties.Resources.Cancel_16xMD;
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Margin = new System.Windows.Forms.Padding(3);
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteToolStripButton.Text = "Delete";
            this.DeleteToolStripButton.ToolTipText = "Delete";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // MessageStatusStrip
            // 
            this.MessageStatusStrip.AutoSize = false;
            this.MessageStatusStrip.BackColor = System.Drawing.Color.White;
            this.MessageStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.MessageStatusStrip.Location = new System.Drawing.Point(0, 572);
            this.MessageStatusStrip.Name = "MessageStatusStrip";
            this.MessageStatusStrip.Size = new System.Drawing.Size(800, 28);
            this.MessageStatusStrip.TabIndex = 9;
            this.MessageStatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(3);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(38, 22);
            this.StatusLabel.Text = "Saved";
            // 
            // DetailPanel
            // 
            this.DetailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DetailPanel.Controls.Add(this.EndTimePicker);
            this.DetailPanel.Controls.Add(this.StartTimePicker);
            this.DetailPanel.Controls.Add(this.ShiftNameTextBox);
            this.DetailPanel.Controls.Add(this.CancelButton);
            this.DetailPanel.Controls.Add(this.SaveButton);
            this.DetailPanel.Controls.Add(this.label3);
            this.DetailPanel.Controls.Add(this.label2);
            this.DetailPanel.Controls.Add(this.label1);
            this.DetailPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DetailPanel.Enabled = false;
            this.DetailPanel.Location = new System.Drawing.Point(0, 50);
            this.DetailPanel.Name = "DetailPanel";
            this.DetailPanel.Size = new System.Drawing.Size(220, 522);
            this.DetailPanel.TabIndex = 10;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(17, 120);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(184, 20);
            this.EndTimePicker.TabIndex = 13;
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "HH:mm:ss";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(17, 78);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(184, 20);
            this.StartTimePicker.TabIndex = 12;
            // 
            // ShiftNameTextBox
            // 
            this.ShiftNameTextBox.Location = new System.Drawing.Point(17, 36);
            this.ShiftNameTextBox.Name = "ShiftNameTextBox";
            this.ShiftNameTextBox.Size = new System.Drawing.Size(184, 20);
            this.ShiftNameTextBox.TabIndex = 8;
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::EMS.WinForm.Properties.Resources.Cancel_grey_16xMD;
            this.CancelButton.Location = new System.Drawing.Point(89, 157);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(66, 26);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = global::EMS.WinForm.Properties.Resources.save_16xMD;
            this.SaveButton.Location = new System.Drawing.Point(17, 157);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(66, 26);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shift Name:";
            // 
            // ShiftGridView
            // 
            this.ShiftGridView.AllowUserToAddRows = false;
            this.ShiftGridView.AllowUserToDeleteRows = false;
            this.ShiftGridView.AllowUserToResizeRows = false;
            this.ShiftGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShiftGridView.BackgroundColor = System.Drawing.Color.White;
            this.ShiftGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShiftGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShiftGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShiftGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShiftGridView.Location = new System.Drawing.Point(220, 50);
            this.ShiftGridView.Name = "ShiftGridView";
            this.ShiftGridView.RowHeadersVisible = false;
            this.ShiftGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShiftGridView.Size = new System.Drawing.Size(580, 522);
            this.ShiftGridView.TabIndex = 11;
            // 
            // ShiftView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShiftGridView);
            this.Controls.Add(this.DetailPanel);
            this.Controls.Add(this.MessageStatusStrip);
            this.Controls.Add(this.MenuToolStrip);
            this.Controls.Add(this.panel2);
            this.Name = "ShiftView";
            this.Size = new System.Drawing.Size(800, 600);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MenuToolStrip.ResumeLayout(false);
            this.MenuToolStrip.PerformLayout();
            this.MessageStatusStrip.ResumeLayout(false);
            this.MessageStatusStrip.PerformLayout();
            this.DetailPanel.ResumeLayout(false);
            this.DetailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip MenuToolStrip;
        private System.Windows.Forms.ToolStripButton NewToolStripButton;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.ToolStripButton ViewToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.StatusStrip MessageStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Panel DetailPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ShiftGridView;
        private System.Windows.Forms.TextBox ShiftNameTextBox;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
    }
}
