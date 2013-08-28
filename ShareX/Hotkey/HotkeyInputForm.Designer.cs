﻿namespace ShareX
{
    partial class HotkeyInputForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbHotkey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(8, 48);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(104, 48);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbHotkey
            // 
            this.tbHotkey.BackColor = System.Drawing.Color.White;
            this.tbHotkey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHotkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbHotkey.Location = new System.Drawing.Point(8, 16);
            this.tbHotkey.Name = "tbHotkey";
            this.tbHotkey.Size = new System.Drawing.Size(280, 22);
            this.tbHotkey.TabIndex = 3;
            this.tbHotkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHotkey.Enter += new System.EventHandler(this.tbHotkey_Enter);
            this.tbHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbHotkey_KeyDown);
            this.tbHotkey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbHotkey_KeyUp);
            this.tbHotkey.Leave += new System.EventHandler(this.tbHotkey_Leave);
            this.tbHotkey.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbHotkey_PreviewKeyDown);
            // 
            // HotkeyInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 83);
            this.Controls.Add(this.tbHotkey);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HotkeyInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit hotkey";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HotkeyInputForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbHotkey;
    }
}