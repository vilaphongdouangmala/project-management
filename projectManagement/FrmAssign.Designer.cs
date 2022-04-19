/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 18-Mar-22
 * Time: 8:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projectManagement
{
	partial class FrmAssign
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
			this.label1 = new System.Windows.Forms.Label();
			this.listViewEmployee = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbProjectName = new System.Windows.Forms.ComboBox();
			this.cmbProjectId = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblProjectType = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAssign = new termProject.RoundedButton();
			this.listViewProjectAssignment = new System.Windows.Forms.ListView();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSubmit = new termProject.RoundedButton();
			this.lblPlaceholder = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Assign Project Members:";
			// 
			// listViewEmployee
			// 
			this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3});
			this.listViewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.listViewEmployee.FullRowSelect = true;
			this.listViewEmployee.Location = new System.Drawing.Point(26, 187);
			this.listViewEmployee.MultiSelect = false;
			this.listViewEmployee.Name = "listViewEmployee";
			this.listViewEmployee.Size = new System.Drawing.Size(325, 277);
			this.listViewEmployee.TabIndex = 1;
			this.listViewEmployee.UseCompatibleStateImageBehavior = false;
			this.listViewEmployee.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Employee ID";
			this.columnHeader1.Width = 93;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Role";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbProjectName);
			this.groupBox1.Controls.Add(this.cmbProjectId);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.lblProjectType);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(26, 44);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(770, 100);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Project:";
			// 
			// cmbProjectName
			// 
			this.cmbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProjectName.FormattingEnabled = true;
			this.cmbProjectName.Location = new System.Drawing.Point(389, 29);
			this.cmbProjectName.Name = "cmbProjectName";
			this.cmbProjectName.Size = new System.Drawing.Size(271, 24);
			this.cmbProjectName.TabIndex = 117;
			this.cmbProjectName.TextChanged += new System.EventHandler(this.CmbProjectNameTextChanged);
			// 
			// cmbProjectId
			// 
			this.cmbProjectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProjectId.FormattingEnabled = true;
			this.cmbProjectId.Location = new System.Drawing.Point(114, 29);
			this.cmbProjectId.Name = "cmbProjectId";
			this.cmbProjectId.Size = new System.Drawing.Size(130, 24);
			this.cmbProjectId.TabIndex = 116;
			this.cmbProjectId.TextChanged += new System.EventHandler(this.CmbProjectIdTextChanged);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 71);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 18);
			this.label4.TabIndex = 40;
			this.label4.Text = "Project Type:";
			// 
			// lblProjectType
			// 
			this.lblProjectType.BackColor = System.Drawing.Color.White;
			this.lblProjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProjectType.Location = new System.Drawing.Point(114, 71);
			this.lblProjectType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblProjectType.Name = "lblProjectType";
			this.lblProjectType.Size = new System.Drawing.Size(211, 18);
			this.lblProjectType.TabIndex = 32;
			this.lblProjectType.Text = "<project type>";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(290, 32);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 18);
			this.label3.TabIndex = 23;
			this.label3.Text = "Project Name:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 32);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 18);
			this.label2.TabIndex = 22;
			this.label2.Text = "Project ID:";
			// 
			// btnAssign
			// 
			this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnAssign.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnAssign.BorderColor = System.Drawing.Color.Tomato;
			this.btnAssign.BorderRadius = 15;
			this.btnAssign.BorderSize = 0;
			this.btnAssign.FlatAppearance.BorderSize = 0;
			this.btnAssign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
			this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAssign.ForeColor = System.Drawing.Color.White;
			this.btnAssign.Location = new System.Drawing.Point(372, 303);
			this.btnAssign.Name = "btnAssign";
			this.btnAssign.Size = new System.Drawing.Size(79, 32);
			this.btnAssign.TabIndex = 18;
			this.btnAssign.Text = "=>";
			this.btnAssign.TextColor = System.Drawing.Color.White;
			this.btnAssign.UseVisualStyleBackColor = false;
			this.btnAssign.Click += new System.EventHandler(this.BtnAssignClick);
			// 
			// listViewProjectAssignment
			// 
			this.listViewProjectAssignment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6});
			this.listViewProjectAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.listViewProjectAssignment.FullRowSelect = true;
			this.listViewProjectAssignment.Location = new System.Drawing.Point(471, 187);
			this.listViewProjectAssignment.MultiSelect = false;
			this.listViewProjectAssignment.Name = "listViewProjectAssignment";
			this.listViewProjectAssignment.Size = new System.Drawing.Size(325, 277);
			this.listViewProjectAssignment.TabIndex = 19;
			this.listViewProjectAssignment.UseCompatibleStateImageBehavior = false;
			this.listViewProjectAssignment.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Employee ID";
			this.columnHeader4.Width = 83;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Name";
			this.columnHeader5.Width = 150;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Role";
			this.columnHeader6.Width = 85;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(379, 282);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 18);
			this.label5.TabIndex = 118;
			this.label5.Text = "Assign";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnSubmit.BorderColor = System.Drawing.Color.Tomato;
			this.btnSubmit.BorderRadius = 15;
			this.btnSubmit.BorderSize = 0;
			this.btnSubmit.FlatAppearance.BorderSize = 0;
			this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
			this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubmit.ForeColor = System.Drawing.Color.White;
			this.btnSubmit.Location = new System.Drawing.Point(699, 483);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(97, 32);
			this.btnSubmit.TabIndex = 119;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.TextColor = System.Drawing.Color.White;
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// lblPlaceholder
			// 
			this.lblPlaceholder.Enabled = false;
			this.lblPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlaceholder.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.lblPlaceholder.Location = new System.Drawing.Point(30, 160);
			this.lblPlaceholder.Name = "lblPlaceholder";
			this.lblPlaceholder.Size = new System.Drawing.Size(185, 13);
			this.lblPlaceholder.TabIndex = 121;
			this.lblPlaceholder.Text = "Search with first name or last name";
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(26, 156);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(325, 22);
			this.txtSearch.TabIndex = 120;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
			// 
			// FrmAssign
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(884, 531);
			this.Controls.Add(this.lblPlaceholder);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listViewProjectAssignment);
			this.Controls.Add(this.btnAssign);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listViewEmployee);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmAssign";
			this.Text = "FrmAssign";
			this.Load += new System.EventHandler(this.FrmAssignLoad);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblPlaceholder;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Label lblProjectType;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private termProject.RoundedButton btnSubmit;
		private System.Windows.Forms.ListView listViewProjectAssignment;
		private System.Windows.Forms.ListView listViewEmployee;
		private termProject.RoundedButton btnAssign;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbProjectName;
		private System.Windows.Forms.ComboBox cmbProjectId;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
	}
}
