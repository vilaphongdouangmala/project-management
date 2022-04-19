/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 18-Mar-22
 * Time: 8:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace projectManagement
{
	/// <summary>
	/// Description of FrmAssigned.
	/// </summary>
	public partial class FrmAssigned : Form
	{
		DataManager dm1 = new DataManager("localhost", "project_management", "root", "");
		public FrmAssigned()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}//econ
		
		void FrmAssignedLoad(object sender, EventArgs e)
		{
			displayAllAssignedProject();
		}//ef
		
		private void displayAllAssignedProject()
		{
			projectListView.Items.Clear();
			
			//query for the projects that user has been assigned
			string sql = "SELECT * FROM project p, project_assignment pa " +
						 "WHERE p.projectId = pa.projectId && p.projectStatus = 'In progress' && pa.employeeId = 'd0'";
			
			sql = sql.Replace("d0", Global.user.employeeId);
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{
				string projectId	 = row[0].ToString();
				string projectName	 = row[2].ToString();
				string projectType	 = row[3].ToString();
				string projectStatus = row[4].ToString();
				string acceptedDate	 = row[5].ToString();
				string completedDate = row[6].ToString();
				string totalAmount	 = row[7].ToString();
				
				ListViewItem newRow = new ListViewItem(projectId);
				newRow.SubItems.Add(projectName);
				newRow.SubItems.Add(projectType);
				newRow.SubItems.Add(projectStatus);
				newRow.SubItems.Add(DateTime.Parse(acceptedDate).ToString("yyyy-MM-dd"));
				
				//in case project is not completed yet, then we do not convert format
				if (completedDate == "")
				{
					newRow.SubItems.Add(completedDate);
				}
				else
				{
					newRow.SubItems.Add(DateTime.Parse(completedDate).ToString("yyyy-MM-dd"));
				}
				
				newRow.SubItems.Add(totalAmount);
				
				projectListView.Items.Add(newRow);
			}//eloop
			
			//show total current assigned project
			sql = "SELECT COUNT(*) FROM project p, project_assignment pa " +
				  "WHERE p.projectId = pa.projectId && p.projectStatus = 'In progress' && pa.employeeId = 'd0'";
			
			sql = sql.Replace("d0", Global.user.employeeId);
			
			DataTable result = dm1.GetDataTable(sql);
			
			lblTotalProject.Text = result.Rows[0][0].ToString();
		}//ef
		
	}//ec
}//en
