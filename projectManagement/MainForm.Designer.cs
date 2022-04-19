/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 14-Mar-22
 * Time: 1:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projectManagement
{
	partial class MainForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCustomer = new System.Windows.Forms.Button();
			this.btnAssigned = new System.Windows.Forms.Button();
			this.btnAssign = new System.Windows.Forms.Button();
			this.btnEmployee = new System.Windows.Forms.Button();
			this.lblRole = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSubmission = new System.Windows.Forms.Button();
			this.btnProject = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnlSelectedForm = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.panel1.Controls.Add(this.btnCustomer);
			this.panel1.Controls.Add(this.btnAssigned);
			this.panel1.Controls.Add(this.btnAssign);
			this.panel1.Controls.Add(this.btnEmployee);
			this.panel1.Controls.Add(this.lblRole);
			this.panel1.Controls.Add(this.lblUser);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnSubmission);
			this.panel1.Controls.Add(this.btnProject);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(160, 531);
			this.panel1.TabIndex = 0;
			// 
			// btnCustomer
			// 
			this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
			this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCustomer.FlatAppearance.BorderSize = 0;
			this.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
			this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomer.ForeColor = System.Drawing.Color.White;
			this.btnCustomer.Location = new System.Drawing.Point(0, 422);
			this.btnCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCustomer.Name = "btnCustomer";
			this.btnCustomer.Size = new System.Drawing.Size(160, 66);
			this.btnCustomer.TabIndex = 9;
			this.btnCustomer.Text = "Customer";
			this.btnCustomer.UseVisualStyleBackColor = false;
			this.btnCustomer.Click += new System.EventHandler(this.BtnCustomerClick);
			// 
			// btnAssigned
			// 
			this.btnAssigned.BackColor = System.Drawing.Color.Transparent;
			this.btnAssigned.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnAssigned.FlatAppearance.BorderSize = 0;
			this.btnAssigned.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnAssigned.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
			this.btnAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAssigned.ForeColor = System.Drawing.Color.White;
			this.btnAssigned.Location = new System.Drawing.Point(0, 356);
			this.btnAssigned.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAssigned.Name = "btnAssigned";
			this.btnAssigned.Size = new System.Drawing.Size(160, 66);
			this.btnAssigned.TabIndex = 8;
			this.btnAssigned.Text = "Assigned";
			this.btnAssigned.UseVisualStyleBackColor = false;
			this.btnAssigned.Click += new System.EventHandler(this.BtnAssignedClick);
			// 
			// btnAssign
			// 
			this.btnAssign.BackColor = System.Drawing.Color.Transparent;
			this.btnAssign.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnAssign.FlatAppearance.BorderSize = 0;
			this.btnAssign.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnAssign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
			this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAssign.ForeColor = System.Drawing.Color.White;
			this.btnAssign.Location = new System.Drawing.Point(0, 290);
			this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAssign.Name = "btnAssign";
			this.btnAssign.Size = new System.Drawing.Size(160, 66);
			this.btnAssign.TabIndex = 3;
			this.btnAssign.Text = "Assign";
			this.btnAssign.UseVisualStyleBackColor = false;
			this.btnAssign.Click += new System.EventHandler(this.BtnAssignClick);
			// 
			// btnEmployee
			// 
			this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
			this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnEmployee.FlatAppearance.BorderSize = 0;
			this.btnEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
			this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmployee.ForeColor = System.Drawing.Color.White;
			this.btnEmployee.Location = new System.Drawing.Point(0, 224);
			this.btnEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnEmployee.Name = "btnEmployee";
			this.btnEmployee.Size = new System.Drawing.Size(160, 66);
			this.btnEmployee.TabIndex = 5;
			this.btnEmployee.Text = "Employee";
			this.btnEmployee.UseVisualStyleBackColor = false;
			this.btnEmployee.Click += new System.EventHandler(this.BtnEmployeeClick);
			// 
			// lblRole
			// 
			this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRole.ForeColor = System.Drawing.Color.White;
			this.lblRole.Location = new System.Drawing.Point(12, 64);
			this.lblRole.Name = "lblRole";
			this.lblRole.Size = new System.Drawing.Size(122, 18);
			this.lblRole.TabIndex = 7;
			this.lblRole.Text = "<role>";
			// 
			// lblUser
			// 
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.ForeColor = System.Drawing.Color.White;
			this.lblUser.Location = new System.Drawing.Point(12, 39);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(122, 18);
			this.lblUser.TabIndex = 6;
			this.lblUser.Text = "<name>";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Logged in as:";
			// 
			// btnSubmission
			// 
			this.btnSubmission.BackColor = System.Drawing.Color.Transparent;
			this.btnSubmission.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSubmission.FlatAppearance.BorderSize = 0;
			this.btnSubmission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnSubmission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
			this.btnSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubmission.ForeColor = System.Drawing.Color.White;
			this.btnSubmission.Location = new System.Drawing.Point(0, 158);
			this.btnSubmission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSubmission.Name = "btnSubmission";
			this.btnSubmission.Size = new System.Drawing.Size(160, 66);
			this.btnSubmission.TabIndex = 2;
			this.btnSubmission.Text = "Submission";
			this.btnSubmission.UseVisualStyleBackColor = false;
			this.btnSubmission.Click += new System.EventHandler(this.BtnSubmissionClick);
			// 
			// btnProject
			// 
			this.btnProject.BackColor = System.Drawing.Color.Transparent;
			this.btnProject.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnProject.FlatAppearance.BorderSize = 0;
			this.btnProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
			this.btnProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProject.ForeColor = System.Drawing.Color.White;
			this.btnProject.Location = new System.Drawing.Point(0, 92);
			this.btnProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnProject.Name = "btnProject";
			this.btnProject.Size = new System.Drawing.Size(160, 66);
			this.btnProject.TabIndex = 1;
			this.btnProject.Text = "Project";
			this.btnProject.UseVisualStyleBackColor = false;
			this.btnProject.Click += new System.EventHandler(this.BtnProjectClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 92);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pnlSelectedForm
			// 
			this.pnlSelectedForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSelectedForm.Location = new System.Drawing.Point(160, 0);
			this.pnlSelectedForm.Name = "pnlSelectedForm";
			this.pnlSelectedForm.Size = new System.Drawing.Size(824, 531);
			this.pnlSelectedForm.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(984, 531);
			this.Controls.Add(this.pnlSelectedForm);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "projectManagement";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnCustomer;
		private System.Windows.Forms.Button btnAssigned;
		private System.Windows.Forms.Button btnAssign;
		private System.Windows.Forms.Label lblRole;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnEmployee;
		private System.Windows.Forms.Button btnSubmission;
		private System.Windows.Forms.Panel pnlSelectedForm;
		private System.Windows.Forms.Button btnProject;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;

	}
}
