﻿namespace VixenModules.Editor.TimedSequenceEditor
{
	partial class BulkEffectMoveForm
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
			this.txtStartTime = new System.Windows.Forms.MaskedTextBox();
			this.txtEndTime = new System.Windows.Forms.MaskedTextBox();
			this.txtOffset = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonBackward = new System.Windows.Forms.RadioButton();
			this.radioButtonForward = new System.Windows.Forms.RadioButton();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtStartTime
			// 
			this.txtStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.txtStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.txtStartTime.Location = new System.Drawing.Point(104, 12);
			this.txtStartTime.Name = "txtStartTime";
			this.txtStartTime.Size = new System.Drawing.Size(100, 20);
			this.txtStartTime.TabIndex = 0;
			this.txtStartTime.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtStartTime_MaskInputRejected);
			this.txtStartTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStartTime_KeyDown);
			this.txtStartTime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtStartTime_KeyUp);
			// 
			// txtEndTime
			// 
			this.txtEndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.txtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.txtEndTime.Location = new System.Drawing.Point(104, 38);
			this.txtEndTime.Name = "txtEndTime";
			this.txtEndTime.Size = new System.Drawing.Size(100, 20);
			this.txtEndTime.TabIndex = 1;
			this.txtEndTime.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtEndTime_MaskInputRejected);
			this.txtEndTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEndTime_KeyDown);
			this.txtEndTime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEndTime_KeyUp);
			// 
			// txtOffset
			// 
			this.txtOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
			this.txtOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtOffset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.txtOffset.Location = new System.Drawing.Point(104, 64);
			this.txtOffset.Name = "txtOffset";
			this.txtOffset.Size = new System.Drawing.Size(100, 20);
			this.txtOffset.TabIndex = 2;
			this.txtOffset.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtOffset_MaskInputRejected);
			this.txtOffset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOffset_KeyDown);
			this.txtOffset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOffset_KeyUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Start Time";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(66, 23);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(0, 13);
			this.linkLabel1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "End Time";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(60, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Offset";
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnOk.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Location = new System.Drawing.Point(95, 185);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 7;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.MouseLeave += new System.EventHandler(this.buttonBackground_MouseLeave);
			this.btnOk.MouseHover += new System.EventHandler(this.buttonBackground_MouseHover);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(176, 185);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.MouseLeave += new System.EventHandler(this.buttonBackground_MouseLeave);
			this.btnCancel.MouseHover += new System.EventHandler(this.buttonBackground_MouseHover);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonBackward);
			this.groupBox1.Controls.Add(this.radioButtonForward);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.groupBox1.Location = new System.Drawing.Point(46, 101);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(158, 73);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Direction";
			this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxes_Paint);
			// 
			// radioButtonBackward
			// 
			this.radioButtonBackward.AutoSize = true;
			this.radioButtonBackward.Location = new System.Drawing.Point(8, 44);
			this.radioButtonBackward.Name = "radioButtonBackward";
			this.radioButtonBackward.Size = new System.Drawing.Size(73, 17);
			this.radioButtonBackward.TabIndex = 1;
			this.radioButtonBackward.Text = "Backward";
			this.radioButtonBackward.UseVisualStyleBackColor = true;
			// 
			// radioButtonForward
			// 
			this.radioButtonForward.AutoSize = true;
			this.radioButtonForward.Checked = true;
			this.radioButtonForward.Location = new System.Drawing.Point(8, 21);
			this.radioButtonForward.Name = "radioButtonForward";
			this.radioButtonForward.Size = new System.Drawing.Size(63, 17);
			this.radioButtonForward.TabIndex = 0;
			this.radioButtonForward.TabStop = true;
			this.radioButtonForward.Text = "Forward";
			this.radioButtonForward.UseVisualStyleBackColor = true;
			// 
			// BulkEffectMoveForm
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(263, 220);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtOffset);
			this.Controls.Add(this.txtEndTime);
			this.Controls.Add(this.txtStartTime);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
			this.MaximumSize = new System.Drawing.Size(279, 259);
			this.MinimumSize = new System.Drawing.Size(279, 259);
			this.Name = "BulkEffectMoveForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Bulk Effect Move";
			this.Load += new System.EventHandler(this.BulkEffectMoveForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox txtStartTime;
		private System.Windows.Forms.MaskedTextBox txtEndTime;
		private System.Windows.Forms.MaskedTextBox txtOffset;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonBackward;
		private System.Windows.Forms.RadioButton radioButtonForward;
		private System.Windows.Forms.ToolTip toolTip;

	}
}