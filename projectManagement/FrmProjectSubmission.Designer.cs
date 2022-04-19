/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 14-Mar-22
 * Time: 1:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projectManagement
{
	partial class FrmProjectSubmission
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectSubmission));
			this.listViewSubmission = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbSubmissionType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProjectID = new System.Windows.Forms.TextBox();
			this.dtpSubmission = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblSubmissionNo = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSubmit = new termProject.RoundedButton();
			this.lblProjectName = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.lblPlaceholder = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listViewSubmission
			// 
			this.listViewSubmission.BackColor = System.Drawing.Color.White;
			this.listViewSubmission.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader6,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader7,
									this.columnHeader4,
									this.columnHeader5});
			this.listViewSubmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.listViewSubmission.FullRowSelect = true;
			this.listViewSubmission.Location = new System.Drawing.Point(24, 54);
			this.listViewSubmission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listViewSubmission.MultiSelect = false;
			this.listViewSubmission.Name = "listViewSubmission";
			this.listViewSubmission.Size = new System.Drawing.Size(770, 267);
			this.listViewSubmission.TabIndex = 0;
			this.listViewSubmission.UseCompatibleStateImageBehavior = false;
			this.listViewSubmission.View = System.Windows.Forms.View.Details;
			this.listViewSubmission.SelectedIndexChanged += new System.EventHandler(this.ListViewSubmissionSelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ProjectID";
			this.columnHeader1.Width = 106;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Project Name";
			this.columnHeader6.Width = 139;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "SubmissionNo";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "EmployeeID";
			this.columnHeader3.Width = 87;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Submitted by";
			this.columnHeader7.Width = 101;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Submission Type";
			this.columnHeader4.Width = 122;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Submission Date";
			this.columnHeader5.Width = 112;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(203, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Project Submissions:";
			// 
			// cmbSubmissionType
			// 
			this.cmbSubmissionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbSubmissionType.FormattingEnabled = true;
			this.cmbSubmissionType.Location = new System.Drawing.Point(140, 82);
			this.cmbSubmissionType.Name = "cmbSubmissionType";
			this.cmbSubmissionType.Size = new System.Drawing.Size(138, 24);
			this.cmbSubmissionType.TabIndex = 111;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(17, 85);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 18);
			this.label1.TabIndex = 110;
			this.label1.Text = "Submission Type:";
			// 
			// txtProjectID
			// 
			this.txtProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProjectID.Location = new System.Drawing.Point(140, 36);
			this.txtProjectID.Margin = new System.Windows.Forms.Padding(2);
			this.txtProjectID.Name = "txtProjectID";
			this.txtProjectID.Size = new System.Drawing.Size(138, 22);
			this.txtProjectID.TabIndex = 109;
			this.txtProjectID.TextChanged += new System.EventHandler(this.TxtProjectIDTextChanged);
			// 
			// dtpSubmission
			// 
			this.dtpSubmission.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.dtpSubmission.CustomFormat = "yyyy-MM-dd";
			this.dtpSubmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpSubmission.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSubmission.Location = new System.Drawing.Point(140, 129);
			this.dtpSubmission.Name = "dtpSubmission";
			this.dtpSubmission.Size = new System.Drawing.Size(138, 22);
			this.dtpSubmission.TabIndex = 108;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(17, 39);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(73, 18);
			this.label10.TabIndex = 106;
			this.label10.Text = "Project ID:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblSubmissionNo);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.btnSubmit);
			this.groupBox1.Controls.Add(this.lblProjectName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cmbSubmissionType);
			this.groupBox1.Controls.Add(this.dtpSubmission);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtProjectID);
			this.groupBox1.Location = new System.Drawing.Point(24, 341);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(770, 166);
			this.groupBox1.TabIndex = 112;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Submission Information";
			// 
			// lblSubmissionNo
			// 
			this.lblSubmissionNo.BackColor = System.Drawing.Color.White;
			this.lblSubmissionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubmissionNo.Location = new System.Drawing.Point(448, 85);
			this.lblSubmissionNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSubmissionNo.Name = "lblSubmissionNo";
			this.lblSubmissionNo.Size = new System.Drawing.Size(127, 18);
			this.lblSubmissionNo.TabIndex = 117;
			this.lblSubmissionNo.Text = "<submission no.>";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(316, 85);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 18);
			this.label6.TabIndex = 116;
			this.label6.Text = "Submission No:";
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnSubmit.BorderColor = System.Drawing.Color.Tomato;
			this.btnSubmit.BorderRadius = 15;
			this.btnSubmit.BorderSize = 0;
			this.btnSubmit.FlatAppearance.BorderSize = 0;
			this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmit.ForeColor = System.Drawing.Color.White;
			this.btnSubmit.Location = new System.Drawing.Point(674, 130);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(87, 30);
			this.btnSubmit.TabIndex = 115;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.TextColor = System.Drawing.Color.White;
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
			// 
			// lblProjectName
			// 
			this.lblProjectName.BackColor = System.Drawing.Color.White;
			this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProjectName.Location = new System.Drawing.Point(448, 40);
			this.lblProjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblProjectName.Name = "lblProjectName";
			this.lblProjectName.Size = new System.Drawing.Size(268, 18);
			this.lblProjectName.TabIndex = 114;
			this.lblProjectName.Text = "<project name>";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(316, 40);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 18);
			this.label4.TabIndex = 113;
			this.label4.Text = "Project Name:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 133);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 18);
			this.label3.TabIndex = 112;
			this.label3.Text = "Submission Date:";
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(460, 27);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(288, 22);
			this.txtSearch.TabIndex = 112;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
			this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
			this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnRefresh.FlatAppearance.BorderSize = 0;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Location = new System.Drawing.Point(763, 25);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(28, 24);
			this.btnRefresh.TabIndex = 113;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// lblPlaceholder
			// 
			this.lblPlaceholder.Enabled = false;
			this.lblPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlaceholder.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.lblPlaceholder.Location = new System.Drawing.Point(465, 31);
			this.lblPlaceholder.Name = "lblPlaceholder";
			this.lblPlaceholder.Size = new System.Drawing.Size(134, 13);
			this.lblPlaceholder.TabIndex = 114;
			this.lblPlaceholder.Text = "Search with ID or Name";
			// 
			// FrmProjectSubmission
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(884, 531);
			this.Controls.Add(this.lblPlaceholder);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listViewSubmission);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmProjectSubmission";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmProjectSubmission";
			this.Load += new System.EventHandler(this.FrmProjectSubmissionLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblPlaceholder;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Label lblSubmissionNo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ListView listViewSubmission;
		private System.Windows.Forms.Label lblProjectName;
		private System.Windows.Forms.DateTimePicker dtpSubmission;
		private System.Windows.Forms.ComboBox cmbSubmissionType;
		private termProject.RoundedButton btnSubmit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtProjectID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
