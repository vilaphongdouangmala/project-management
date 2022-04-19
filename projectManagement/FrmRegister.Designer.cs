/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 18-Mar-22
 * Time: 10:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projectManagement
{
	partial class FrmRegister
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnCreate = new termProject.RoundedButton();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.btnClose = new termProject.RoundedButton();
			this.txtConfirm = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEmployeeId = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtPassword.Location = new System.Drawing.Point(64, 222);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(317, 19);
			this.txtPassword.TabIndex = 22;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnCreate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnCreate.BorderColor = System.Drawing.Color.Tomato;
			this.btnCreate.BorderRadius = 15;
			this.btnCreate.BorderSize = 0;
			this.btnCreate.FlatAppearance.BorderSize = 0;
			this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.ForeColor = System.Drawing.Color.White;
			this.btnCreate.Location = new System.Drawing.Point(310, 377);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(79, 32);
			this.btnCreate.TabIndex = 25;
			this.btnCreate.Text = "Create";
			this.btnCreate.TextColor = System.Drawing.Color.White;
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreateClick);
			// 
			// txtUsername
			// 
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtUsername.Location = new System.Drawing.Point(64, 140);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(317, 19);
			this.txtUsername.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(58, 130);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(331, 41);
			this.label2.TabIndex = 23;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(58, 211);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(331, 41);
			this.label1.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(54, 189);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 35);
			this.label3.TabIndex = 24;
			this.label3.Text = "Password";
			// 
			// lblUsername
			// 
			this.lblUsername.BackColor = System.Drawing.Color.White;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblUsername.Location = new System.Drawing.Point(54, 108);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(124, 35);
			this.lblUsername.TabIndex = 19;
			this.lblUsername.Text = "Username";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnClose.BorderColor = System.Drawing.Color.Tomato;
			this.btnClose.BorderRadius = 15;
			this.btnClose.BorderSize = 0;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(214, 377);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(79, 32);
			this.btnClose.TabIndex = 26;
			this.btnClose.Text = "Close";
			this.btnClose.TextColor = System.Drawing.Color.White;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// txtConfirm
			// 
			this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtConfirm.Location = new System.Drawing.Point(64, 305);
			this.txtConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtConfirm.Name = "txtConfirm";
			this.txtConfirm.Size = new System.Drawing.Size(317, 19);
			this.txtConfirm.TabIndex = 28;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(58, 294);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(331, 41);
			this.label4.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label5.Location = new System.Drawing.Point(54, 272);
			this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(190, 35);
			this.label5.TabIndex = 29;
			this.label5.Text = "Confrim Password";
			// 
			// txtEmployeeId
			// 
			this.txtEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtEmployeeId.Location = new System.Drawing.Point(64, 56);
			this.txtEmployeeId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtEmployeeId.Name = "txtEmployeeId";
			this.txtEmployeeId.Size = new System.Drawing.Size(317, 19);
			this.txtEmployeeId.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(58, 46);
			this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(331, 41);
			this.label6.TabIndex = 32;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label7.Location = new System.Drawing.Point(54, 24);
			this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 35);
			this.label7.TabIndex = 30;
			this.label7.Text = "EmployeeId";
			// 
			// FrmRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(454, 442);
			this.Controls.Add(this.txtEmployeeId);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtConfirm);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblUsername);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmRegister";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmRegister";
			this.Load += new System.EventHandler(this.FrmRegisterLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtEmployeeId;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtConfirm;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private termProject.RoundedButton btnClose;
		private termProject.RoundedButton btnCreate;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
	}
}
