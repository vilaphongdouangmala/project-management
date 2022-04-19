/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 14-Mar-22
 * Time: 1:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projectManagement
{
	partial class FrmLogin
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
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.btnLogin = new termProject.RoundedButton();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblCreateUser = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtUsername
			// 
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtUsername.Location = new System.Drawing.Point(60, 83);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(317, 19);
			this.txtUsername.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(54, 73);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(331, 41);
			this.label2.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(54, 154);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(331, 41);
			this.label1.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(50, 132);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 35);
			this.label3.TabIndex = 16;
			this.label3.Text = "Password";
			// 
			// lblUsername
			// 
			this.lblUsername.BackColor = System.Drawing.Color.White;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblUsername.Location = new System.Drawing.Point(50, 51);
			this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(124, 35);
			this.lblUsername.TabIndex = 12;
			this.lblUsername.Text = "Username";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnLogin.BorderColor = System.Drawing.Color.Tomato;
			this.btnLogin.BorderRadius = 15;
			this.btnLogin.BorderSize = 0;
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(175, 221);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(79, 32);
			this.btnLogin.TabIndex = 17;
			this.btnLogin.Text = "Login";
			this.btnLogin.TextColor = System.Drawing.Color.White;
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtPassword.Location = new System.Drawing.Point(60, 165);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(317, 19);
			this.txtPassword.TabIndex = 14;
			// 
			// lblCreateUser
			// 
			this.lblCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCreateUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lblCreateUser.Location = new System.Drawing.Point(283, 201);
			this.lblCreateUser.Name = "lblCreateUser";
			this.lblCreateUser.Size = new System.Drawing.Size(102, 23);
			this.lblCreateUser.TabIndex = 18;
			this.lblCreateUser.Text = "Create new user";
			this.lblCreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblCreateUser.Click += new System.EventHandler(this.LblCreateUserClick);
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(444, 289);
			this.Controls.Add(this.lblCreateUser);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblUsername);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmLogin";
			this.Load += new System.EventHandler(this.FrmLoginLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblCreateUser;
		private System.Windows.Forms.TextBox txtPassword;
		private termProject.RoundedButton btnLogin;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsername;
	}
}
