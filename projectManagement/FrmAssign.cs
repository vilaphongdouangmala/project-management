/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 18-Mar-22
 * Time: 8:18 PM
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
	/// Description of FrmAssign.
	/// </summary>
	public partial class FrmAssign : Form
	{
		DataManager dm1 = new DataManager("localhost", "project_management", "root", "");
		public FrmAssign()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}//econ
		
		
		void FrmAssignLoad(object sender, EventArgs e)
		{
			loadEmployeeList();
			displayEmployeeList();
			
			//implement autocompletes
			projectInfoAutoComplete();
		}//ef
		
		private void loadEmployeeList()
		{
			//get employees list from database
			string sql = "SELECT employeeId, firstName, lastName, role FROM employee";
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{
				string employeeId	 = row[0].ToString();
				string firstName	 = row[1].ToString();
				string lastName		 = row[2].ToString();
				string role			 = row[3].ToString();
				
				Global.employeeList.Add(new Employee(employeeId, firstName, lastName, role));
			}//eloop
		}//ef
		
		
		private void displayEmployeeList()
		{
			listViewEmployee.Items.Clear();
			
			foreach(Employee e in Global.employeeList)
			{
				ListViewItem newRow = new ListViewItem(e.employeeId);
				newRow.SubItems.Add(e.firstName + " " + e.lastName);
				newRow.SubItems.Add(e.role);
				
				listViewEmployee.Items.Add(newRow);
			}//eloop
		}//ef
		
		
		private void displaySearchedEmployeeList()
		{
			listViewEmployee.Items.Clear();
			
			foreach(Employee e in Global.employeeList)
			{
				//if statement for filitering
				if (e.firstName.ToLower().Contains(txtSearch.Text.ToLower()) || e.lastName.ToLower().Contains(txtSearch.Text.ToLower()))
				{
					ListViewItem newRow = new ListViewItem(e.employeeId);
					newRow.SubItems.Add(e.firstName + " " + e.lastName);
					newRow.SubItems.Add(e.role);
				
					listViewEmployee.Items.Add(newRow);
				}
			}//eloop
		}//ef
		
		private void displayProjectAssignmentList()
		{
			listViewProjectAssignment.Items.Clear();
			
			foreach(ProjectAssignment pa in Global.projectAssignmentList)
			{
				//get the employee name
				string employeeName = getEmployeeNameById(pa.employeeId);
				
				ListViewItem newRow = new ListViewItem(pa.employeeId);
				newRow.SubItems.Add(employeeName);
				newRow.SubItems.Add(pa.projectRole);
				
				listViewProjectAssignment.Items.Add(newRow);
			}//eloop
		}//ef

		
		private void projectInfoAutoComplete()
		{
			cmbProjectId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbProjectId.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			cmbProjectName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbProjectName.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			AutoCompleteStringCollection projectIds = new AutoCompleteStringCollection();
			AutoCompleteStringCollection projectNames = new AutoCompleteStringCollection();
			
			//query for in-progress project
			string sql = "SELECT projectId, projectName FROM project WHERE projectStatus = 'In progress'";
			
			DataTable resultTable = dm1.GetDataTable(sql);
			foreach (DataRow row in resultTable.Rows)
			{
				projectIds.Add(row[0].ToString());
				projectNames.Add(row[1].ToString());
			}//eloop
			
			cmbProjectId.AutoCompleteCustomSource = projectIds;
			cmbProjectId.DataSource = projectIds;
			
			cmbProjectName.AutoCompleteCustomSource = projectNames;
			cmbProjectName.DataSource = projectNames;
		}//ef
		
		void CmbProjectIdTextChanged(object sender, EventArgs e)
		{
			//this function is for changing the project name when there is a change in project ID
			
			//get project name with projectId
			string sql = "SELECT projectName, projectType FROM project WHERE projectId = 'd0'";
			sql = sql.Replace("d0", cmbProjectId.Text);
			
			DataTable result = dm1.GetDataTable(sql);
				
			if(result.Rows.Count > 0)
			{
				cmbProjectName.Text = result.Rows[0][0].ToString();
				lblProjectType.Text = result.Rows[0][1].ToString();
				
				//if there is changes in selecting project, clear all the info
				refreshInformation();
			}
			
		}//ef
		
		void CmbProjectNameTextChanged(object sender, EventArgs e)
		{
			//this function is for changing the project id when there is a change in project name
			
			//get project id with projectname
			string sql = "SELECT projectId, projectType FROM project WHERE projectName = 'd0'";
			sql = sql.Replace("d0", cmbProjectName.Text);
			
			DataTable result = dm1.GetDataTable(sql);
				
			if(result.Rows.Count > 0)
			{
				cmbProjectId.Text = result.Rows[0][0].ToString();
				lblProjectType.Text = result.Rows[0][1].ToString();
				
				//if there is changes in selecting project, clear all the info
				refreshInformation();
			}
		}//ef
		
		private Employee getEmployeeById(string employeeId)
		{
			foreach(Employee e in Global.employeeList)
			{
				if(employeeId == e.employeeId)
				{
					return e;
				}
			}//eloop
			return null;
		}//ef
		
		private string getEmployeeNameById(string employeeId)
		{
			string sql = "SELECT firstName, lastName FROM employee " +
						 "WHERE employeeId = 'd0'";
			sql = sql.Replace("d0", employeeId);
			
			DataTable result = dm1.GetDataTable(sql);
			
			return result.Rows[0][0].ToString() + " " + result.Rows[0][1].ToString();
		}//ef
		
		
		private void refreshInformation()
		{
			//clear the old list
			Global.employeeList.Clear();
			Global.projectAssignmentList.Clear();
			//load the employee list again
			loadEmployeeList();
			
			//update listview
			displayEmployeeList();
			displayProjectAssignmentList();
		}//ef
		
		void BtnAssignClick(object sender, EventArgs e)
		{
			string employeeId = listViewEmployee.SelectedItems[0].SubItems[0].Text;
			
			Employee assignedEmployee = getEmployeeById(employeeId);
			
			if(assignedEmployee != null)
			{
				//add employee to the project team member
				Global.projectAssignmentList.Add(new ProjectAssignment(cmbProjectId.Text, assignedEmployee.employeeId, assignedEmployee.role));
				
				//remove the assigned employee from the existing list
				Global.employeeList.Remove(assignedEmployee);
			}
			
			//refresh listviews
			displayEmployeeList();
			displayProjectAssignmentList();
		}//ef
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			string sql = "INSERT INTO project_assignment(projectId, employeeId, projectRole) " +
						 "VALUES ";
			
			foreach(ProjectAssignment pa in Global.projectAssignmentList)
			{
				sql += string.Format("('{0}', '{1}', '{2}'),", pa.projectId, pa.employeeId, pa.projectRole); 
			}
			
			//get rid of comma
			sql = sql.Substring(0, sql.Length-1);
			
			dm1.ExecuteNonQuery(sql);
			
			MessageBox.Show("Submitted successfully.");
			
			//clear the information
			refreshInformation();
			
		}//ef
		
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
			displaySearchedEmployeeList();
			
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
	}//ec
}//en
