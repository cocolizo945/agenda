/*
 * Created by SharpDevelop.
 * User: coquito
 * Date: 31/10/2022
 * Time: 12:17 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace agenda_c_
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtname;
		private System.Windows.Forms.TextBox txtap;
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Button btnsave;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtname = new System.Windows.Forms.TextBox();
			this.txtap = new System.Windows.Forms.TextBox();
			this.btncancel = new System.Windows.Forms.Button();
			this.btnsave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(42, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(42, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apellidos";
			// 
			// txtname
			// 
			this.txtname.Location = new System.Drawing.Point(169, 42);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(100, 20);
			this.txtname.TabIndex = 2;
			// 
			// txtap
			// 
			this.txtap.Location = new System.Drawing.Point(169, 110);
			this.txtap.Name = "txtap";
			this.txtap.Size = new System.Drawing.Size(100, 20);
			this.txtap.TabIndex = 3;
			// 
			// btncancel
			// 
			this.btncancel.Location = new System.Drawing.Point(183, 216);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(75, 23);
			this.btncancel.TabIndex = 4;
			this.btncancel.Text = "cancelar";
			this.btncancel.UseVisualStyleBackColor = true;
			// 
			// btnsave
			// 
			this.btnsave.Location = new System.Drawing.Point(289, 216);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(75, 23);
			this.btnsave.TabIndex = 5;
			this.btnsave.Text = "guardar";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new System.EventHandler(this.BtnsaveClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 296);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.txtap);
			this.Controls.Add(this.txtname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "agenda_c#";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
