/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 16-Mar-22
 * Time: 12:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projectManagement
{
	partial class FrmProject
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProject));
			this.label2 = new System.Windows.Forms.Label();
			this.projectListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbProjectStatus = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnUpdate = new termProject.RoundedButton();
			this.btnDelete = new termProject.RoundedButton();
			this.btnAdd = new termProject.RoundedButton();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.cmbProjectType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProjectID = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dtpAccepted = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.txtProjectName = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.dtpSearchProject = new System.Windows.Forms.DateTimePicker();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.lblPlaceholder = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Project:";
			// 
			// projectListView
			// 
			this.projectListView.BackColor = System.Drawing.Color.White;
			this.projectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader8,
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader7});
			this.projectListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.projectListView.FullRowSelect = true;
			this.projectListView.Location = new System.Drawing.Point(27, 55);
			this.projectListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.projectListView.MultiSelect = false;
			this.projectListView.Name = "projectListView";
			this.projectListView.Size = new System.Drawing.Size(770, 225);
			this.projectListView.TabIndex = 4;
			this.projectListView.UseCompatibleStateImageBehavior = false;
			this.projectListView.View = System.Windows.Forms.View.Details;
			this.projectListView.SelectedIndexChanged += new System.EventHandler(this.ProjectListViewSelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ProjectID";
			this.columnHeader1.Width = 82;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Project Name";
			this.columnHeader2.Width = 172;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Project Type";
			this.columnHeader3.Width = 99;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Project Status";
			this.columnHeader8.Width = 114;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Accepted Date";
			this.columnHeader5.Width = 101;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Completed Date";
			this.columnHeader6.Width = 108;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Total Value";
			this.columnHeader7.Width = 118;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(403, 23);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(354, 26);
			this.txtSearch.TabIndex = 79;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchProjectTextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbProjectStatus);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.txtTotal);
			this.groupBox1.Controls.Add(this.cmbProjectType);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtProjectID);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.dtpAccepted);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtProjectName);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Location = new System.Drawing.Point(27, 304);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(770, 206);
			this.groupBox1.TabIndex = 80;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Project Information";
			// 
			// cmbProjectStatus
			// 
			this.cmbProjectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProjectStatus.FormattingEnabled = true;
			this.cmbProjectStatus.Location = new System.Drawing.Point(122, 104);
			this.cmbProjectStatus.Name = "cmbProjectStatus";
			this.cmbProjectStatus.Size = new System.Drawing.Size(130, 24);
			this.cmbProjectStatus.TabIndex = 115;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(17, 108);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 18);
			this.label5.TabIndex = 114;
			this.label5.Text = "Project Status:";
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnUpdate.BorderColor = System.Drawing.Color.Tomato;
			this.btnUpdate.BorderRadius = 15;
			this.btnUpdate.BorderSize = 0;
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(679, 164);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(73, 30);
			this.btnUpdate.TabIndex = 113;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.TextColor = System.Drawing.Color.White;
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnDelete.BorderColor = System.Drawing.Color.Tomato;
			this.btnDelete.BorderRadius = 15;
			this.btnDelete.BorderSize = 0;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(584, 164);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(73, 30);
			this.btnDelete.TabIndex = 112;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextColor = System.Drawing.Color.White;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.btnAdd.BorderColor = System.Drawing.Color.Tomato;
			this.btnAdd.BorderRadius = 15;
			this.btnAdd.BorderSize = 0;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(488, 164);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(73, 30);
			this.btnAdd.TabIndex = 111;
			this.btnAdd.Text = "Add";
			this.btnAdd.TextColor = System.Drawing.Color.White;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// txtTotal
			// 
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(21, 168);
			this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(179, 22);
			this.txtTotal.TabIndex = 110;
			// 
			// cmbProjectType
			// 
			this.cmbProjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProjectType.FormattingEnabled = true;
			this.cmbProjectType.Location = new System.Drawing.Point(386, 34);
			this.cmbProjectType.Name = "cmbProjectType";
			this.cmbProjectType.Size = new System.Drawing.Size(138, 24);
			this.cmbProjectType.TabIndex = 105;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(289, 37);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 18);
			this.label1.TabIndex = 104;
			this.label1.Text = "Project Type:";
			// 
			// txtProjectID
			// 
			this.txtProjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProjectID.Location = new System.Drawing.Point(122, 36);
			this.txtProjectID.Margin = new System.Windows.Forms.Padding(2);
			this.txtProjectID.Name = "txtProjectID";
			this.txtProjectID.Size = new System.Drawing.Size(130, 22);
			this.txtProjectID.TabIndex = 103;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 145);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(153, 18);
			this.label8.TabIndex = 101;
			this.label8.Text = "Total Project Value:";
			// 
			// dtpAccepted
			// 
			this.dtpAccepted.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.dtpAccepted.CustomFormat = "yyyy-MM-dd";
			this.dtpAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpAccepted.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpAccepted.Location = new System.Drawing.Point(395, 106);
			this.dtpAccepted.Name = "dtpAccepted";
			this.dtpAccepted.Size = new System.Drawing.Size(129, 22);
			this.dtpAccepted.TabIndex = 100;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(289, 108);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 18);
			this.label6.TabIndex = 98;
			this.label6.Text = "Accepted Date:";
			// 
			// txtProjectName
			// 
			this.txtProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProjectName.Location = new System.Drawing.Point(122, 72);
			this.txtProjectName.Margin = new System.Windows.Forms.Padding(2);
			this.txtProjectName.Name = "txtProjectName";
			this.txtProjectName.Size = new System.Drawing.Size(402, 22);
			this.txtProjectName.TabIndex = 94;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 75);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(94, 18);
			this.label9.TabIndex = 93;
			this.label9.Text = "Project Name:";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(16, 39);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(73, 18);
			this.label10.TabIndex = 92;
			this.label10.Text = "Project ID:";
			// 
			// dtpSearchProject
			// 
			this.dtpSearchProject.CalendarFont = new System.Drawing.Font("Roboto", 7F);
			this.dtpSearchProject.CustomFormat = "MMMM-  yyyy";
			this.dtpSearchProject.Font = new System.Drawing.Font("Roboto", 11F);
			this.dtpSearchProject.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSearchProject.Location = new System.Drawing.Point(222, 24);
			this.dtpSearchProject.Name = "dtpSearchProject";
			this.dtpSearchProject.Size = new System.Drawing.Size(165, 25);
			this.dtpSearchProject.TabIndex = 81;
			this.dtpSearchProject.ValueChanged += new System.EventHandler(this.DtpSearchProjectValueChanged);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
			this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
			this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnRefresh.FlatAppearance.BorderSize = 0;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Location = new System.Drawing.Point(766, 24);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(28, 24);
			this.btnRefresh.TabIndex = 83;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// lblPlaceholder
			// 
			this.lblPlaceholder.Enabled = false;
			this.lblPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlaceholder.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.lblPlaceholder.Location = new System.Drawing.Point(408, 29);
			this.lblPlaceholder.Name = "lblPlaceholder";
			this.lblPlaceholder.Size = new System.Drawing.Size(134, 13);
			this.lblPlaceholder.TabIndex = 115;
			this.lblPlaceholder.Text = "Search with ID or Name";
			// 
			// FrmProject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(884, 531);
			this.Controls.Add(this.lblPlaceholder);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.dtpSearchProject);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.projectListView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmProject";
			this.Text = "FrmProject";
			this.Load += new System.EventHandler(this.FrmProjectLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label lblPlaceholder;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.DateTimePicker dtpAccepted;
		private System.Windows.Forms.ComboBox cmbProjectStatus;
		private System.Windows.Forms.TextBox txtProjectName;
		private System.Windows.Forms.ComboBox cmbProjectType;
		private System.Windows.Forms.TextBox txtProjectID;
		private System.Windows.Forms.DateTimePicker dtpSearchProject;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private termProject.RoundedButton btnAdd;
		private termProject.RoundedButton btnDelete;
		private termProject.RoundedButton btnUpdate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView projectListView;
		private System.Windows.Forms.Label label2;
	}
}
