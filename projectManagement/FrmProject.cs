/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 16-Mar-22
 * Time: 12:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace projectManagement
{
	/// <summary>
	/// Description of FrmProject.
	/// </summary>
	public partial class FrmProject : Form
	{
		DataManager dm1 = new DataManager("localhost", "project_management", "root", "");
		public FrmProject()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}//econ
		
		void FrmProjectLoad(object sender, EventArgs e)
		{

			displayAllProjects();
			if(Global.user.role.ToLower() == "junior designer" || Global.user.role.ToLower() == "senior designer")
			{
				designerView();
			}
			
		}//ef
		
		private void designerView()
		{
			btnDelete.Enabled = false;
			btnDelete.BackColor = SystemColors.Control;
		}//ef
		
		private void displayAllProjects()
		{
			projectListView.Items.Clear();
			
			string sql = "SELECT * FROM project " +
						 "ORDER BY acceptedDate";
			
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
		}//ef
		
		private void displaySearchedProjects()
		{
			projectListView.Items.Clear();
			
			string sql = "SELECT * FROM project " +
						 "WHERE (projectId LIKE '%d1%' OR projectName LIKE '%d1%') " +
						 "ORDER BY acceptedDate";
			
			//search by textbox
			sql = sql.Replace("d1", txtSearch.Text);
			
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
		}//ef
		
		void BtnAddClick(object sender, EventArgs e)
		{
			bool completeInfo = fillingComplete();
			
			if (completeInfo)
			{
				string projectId	 = txtProjectID.Text;
				string projectName	 = txtProjectName.Text;
				string projectType	 = cmbProjectType.Text;
				string projectStatus = cmbProjectStatus.Text;
				string acceptedDate	 = dtpAccepted.Text;
				string total	 = txtTotal.Text;
				
				string sql = "INSERT INTO project(projectId, projectName, projectType, projectStatus, acceptedDate, totalAmount) " +
					"VALUES ('d0', 'd1', 'd2', 'd3', 'd4', 'd5')";
				
				sql = sql.Replace("d0", projectId);
				sql = sql.Replace("d1", projectName);
				sql = sql.Replace("d2", projectType);
				sql = sql.Replace("d3", projectStatus);
				sql = sql.Replace("d4", acceptedDate);
				sql = sql.Replace("d5", total);
				
				dm1.ExecuteNonQuery(sql);
				
				MessageBox.Show("The new project has been successfully added.");
				
				//update customer listview
				displayAllProjects();
			}//end if
			else
			{
				MessageBox.Show("Please fill in all information!");
			}//end else
		}//ef
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			string projectId	 = projectListView.SelectedItems[0].SubItems[0].Text;
			
			string sql = "DELETE FROM project " +
						 "WHERE projectId = 'd0'";
			sql = sql.Replace("d0", projectId);
			
			dm1.ExecuteNonQuery(sql);
			
			MessageBox.Show("The project has been deleted.");
			
			displayAllProjects();
		}//ef
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			string projectId	 = projectListView.SelectedItems[0].SubItems[0].Text;
			
			string projectName	 = txtProjectName.Text;
			string projectType	 = cmbProjectType.Text;
			string projectStatus = cmbProjectStatus.Text;
			string acceptedDate	 = dtpAccepted.Text;
			string total	 	 = txtTotal.Text;
			
			string sql = "UPDATE project SET projectName='d1', projectType='d2', projectStatus='d3', acceptedDate='d4', totalAmount='d5' " +
						 "WHERE projectId = 'd0'";
			
			sql = sql.Replace("d0", projectId);
			sql = sql.Replace("d1", projectName);
			sql = sql.Replace("d2", projectType);
			sql = sql.Replace("d3", projectStatus);
			sql = sql.Replace("d4", acceptedDate);
			sql = sql.Replace("d5", total);
			
			dm1.ExecuteNonQuery(sql);
			
			MessageBox.Show("The record has been updated.");
			
			displayAllProjects();
		}//ef
		
		
		private bool fillingComplete()
		{
			if( txtProjectID.Text	 != "" &&
				txtProjectName.Text	 != "" &&
				txtTotal.Text		 != "" &&
				cmbProjectStatus.Text!= "" &&
				cmbProjectType.Text	 != "")
			{
				return true;
			}//end if
			return false;
		}//ef
		
		void ProjectListViewSelectedIndexChanged(object sender, EventArgs e)
		{
			if(projectListView.SelectedItems.Count > 0)
			{
				txtProjectID.Text		 = projectListView.SelectedItems[0].SubItems[0].Text;
				txtProjectName.Text		 = projectListView.SelectedItems[0].SubItems[1].Text;
				cmbProjectType.Text		 = projectListView.SelectedItems[0].SubItems[2].Text;
				cmbProjectStatus.Text	 = projectListView.SelectedItems[0].SubItems[3].Text;
				dtpAccepted.Text		 = projectListView.SelectedItems[0].SubItems[4].Text;
				txtTotal.Text			 = projectListView.SelectedItems[0].SubItems[6].Text;
			}//end if
			else
			{
				txtProjectID.Text		 = "";
				txtProjectName.Text		 = "";
				cmbProjectType.Text		 = "";
				cmbProjectStatus.Text	 = "";
				dtpAccepted.Text		 = "";
				txtTotal.Text			 = "";
			}//end else
			
		}//ef
		
		
		void TxtSearchProjectTextChanged(object sender, EventArgs e)
		{
			displaySearchedProjects();
			
			//if there is a text in search box, then we make in invisible
			if(txtSearch.Text.Length > 0)
			{
				lblPlaceholder.Visible = false;
			}
			else
			{
				lblPlaceholder.Visible = true;
			}
		}//ef
		
		
		void DtpSearchProjectValueChanged(object sender, EventArgs e)
		{
			//search projects by date
			
			projectListView.Items.Clear();
			
			string sql = "SELECT * FROM project " +
						 "WHERE YEAR(acceptedDate) = 'd1' AND MONTH(acceptedDate) = 'd2'" +
						 "ORDER BY acceptedDate";
			
			//search by textbox
			sql = sql.Replace("d1", dtpSearchProject.Value.Year.ToString());
			sql = sql.Replace("d2", dtpSearchProject.Value.Month.ToString());
			
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
		}//ef
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			displayAllProjects();
		}//ef
	}//ec
}//en
