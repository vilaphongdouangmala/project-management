/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 18-Mar-22
 * Time: 8:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projectManagement
{
	partial class FrmAssigned
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
			this.projectListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTotalProject = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(294, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Your Currently Assigned Projects:";
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
			this.projectListView.Location = new System.Drawing.Point(23, 104);
			this.projectListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.projectListView.MultiSelect = false;
			this.projectListView.Name = "projectListView";
			this.projectListView.Size = new System.Drawing.Size(770, 359);
			this.projectListView.TabIndex = 5;
			this.projectListView.UseCompatibleStateImageBehavior = false;
			this.projectListView.View = System.Windows.Forms.View.Details;
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
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(29, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 21);
			this.label2.TabIndex = 6;
			this.label2.Text = "Your Total Projects:";
			// 
			// lblTotalProject
			// 
			this.lblTotalProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalProject.Location = new System.Drawing.Point(196, 65);
			this.lblTotalProject.Name = "lblTotalProject";
			this.lblTotalProject.Size = new System.Drawing.Size(52, 21);
			this.lblTotalProject.TabIndex = 7;
			this.lblTotalProject.Text = "<>";
			// 
			// FrmAssigned
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(884, 531);
			this.Controls.Add(this.lblTotalProject);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.projectListView);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmAssigned";
			this.Text = "FrmAssigned";
			this.Load += new System.EventHandler(this.FrmAssignedLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblTotalProject;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView projectListView;
		private System.Windows.Forms.Label label1;
	}
}
