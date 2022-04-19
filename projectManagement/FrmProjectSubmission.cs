/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 14-Mar-22
 * Time: 1:17 PM
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
	/// Description of FrmProjectSubmission.
	/// </summary>
	public partial class FrmProjectSubmission : Form
	{
		DataManager dm1 = new DataManager("localhost", "project_management", "root", "");
		
		public FrmProjectSubmission()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}//econ
		
		void FrmProjectSubmissionLoad(object sender, EventArgs e)
		{
			displayAllSubmissions();
			submissionTypeAutoComplete();
			projectIdAutoComplete();
			
			//if the logged in user is manager, he/she is not allow to submit the work
			if(Global.user.role.ToLower() == "manager")
			{
				managerView();
			}
			
		}//ef
		
		private void managerView()
		{
			btnSubmit.Enabled = false;
			btnSubmit.BackColor = SystemColors.Control;
		}//ef
		
		private void displayAllSubmissions()
		{
			listViewSubmission.Items.Clear();
			
			string sql = "SELECT * FROM project_submission";
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{
				string projectId		 = row[0].ToString();
				string projectName		 = getProjectNameById(projectId);
				string submissionNo		 = row[1].ToString();
				string employeeId		 = row[2].ToString();
				string employeeName		 = getEmployeeNameById(employeeId);
				string submissionType	 = row[3].ToString();
				string submissionDate	 = row[4].ToString();
				
				ListViewItem newRow = new ListViewItem(projectId);
				newRow.SubItems.Add(projectName);
				newRow.SubItems.Add(submissionNo);
				newRow.SubItems.Add(employeeId);
				newRow.SubItems.Add(employeeName);
				newRow.SubItems.Add(submissionType);
				newRow.SubItems.Add(DateTime.Parse(submissionDate).ToString("yyyy-MM-dd"));
					
				listViewSubmission.Items.Add(newRow);
			}//eloop
			
		}//ef
		
		private void displaySearchedSubmission()
		{
			listViewSubmission.Items.Clear();
			
			//make a query where the user can search for submission by either project ID or name
			string sql = "SELECT * FROM project_submission AS ps, project AS p " +
						 "WHERE p.projectId = ps.projectId " +
						 "AND (ps.projectId LIKE '%d1%' OR p.projectName LIKE '%d1%')";
				
			sql = sql.Replace("d1", txtSearch.Text);

			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{

				string projectId		 = row[0].ToString();
				string projectName		 = getProjectNameById(projectId);
				string submissionNo		 = row[1].ToString();
				string employeeId		 = row[2].ToString();
				string employeeName		 = getEmployeeNameById(employeeId);
				string submissionType	 = row[3].ToString();
				string submissionDate	 = row[4].ToString();
				
				ListViewItem newRow = new ListViewItem(projectId);
				newRow.SubItems.Add(projectName);
				newRow.SubItems.Add(submissionNo);
				newRow.SubItems.Add(employeeId);
				newRow.SubItems.Add(employeeName);
				newRow.SubItems.Add(submissionType);
				newRow.SubItems.Add(DateTime.Parse(submissionDate).ToString("yyyy-MM-dd"));
					
				listViewSubmission.Items.Add(newRow);
			}//eloop
		}//ef
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			//if project is complete, we cannot have any further submission
			if (getProjectStatus().ToLower() == "complete")
			{
				MessageBox.Show("The project is already completed!\nYou cannot have any further submission.");
				return;
			}
			
			string projectId		 = txtProjectID.Text;
			string projectName		 = getProjectNameById(projectId);
			string submissionNo		 = lblSubmissionNo.Text;
			
			//get employeeId and fullName from the user logged in
			string employeeId		 = Global.user.employeeId;
			string fullName			 = Global.user.fullName;
			
			string submissionType	 = cmbSubmissionType.Text;
			string submissionDate	 = dtpSubmission.Text;				
			
			//insert into table
			string sql = "INSERT INTO project_submission(projectId, submissionNo, employeeId, submissionType, submissionDate) " +
				  		 "VALUES ('d0', 'd1', 'd2', 'd3', 'd4')";
			
			sql = sql.Replace("d0", projectId);
			sql = sql.Replace("d1", submissionNo);
			sql = sql.Replace("d2", employeeId);
			sql = sql.Replace("d3", submissionType);
			sql = sql.Replace("d4", submissionDate);
			
			dm1.ExecuteNonQuery(sql);
			
						
			//if final submission is submitted, then make the project as complete
			if(submissionType == "Final Submission")
			{
				updateProjectAsComplete(projectId);
			}//end if 
			
			MessageBox.Show("Submitted successfully!");
			
			displayAllSubmissions();
		}//ef
		
		private string getProjectNameById(string projectId)
		{
			string sql = "SELECT projectName FROM project " +
						 "WHERE projectId = 'd0'";
			sql = sql.Replace("d0", projectId);
			DataTable resultTable = dm1.GetDataTable(sql);
			
			if(resultTable.Rows.Count > 0)
			{
				//if there is a result from query, then we return it
				return resultTable.Rows[0][0].ToString();
			}//end if
			else
			{
				//else null is returned
				return null;
			}//end else
		}//ef
		
		private string getEmployeeNameById(string employeeId)
		{
			string sql = "SELECT firstName, lastName FROM employee " +
						 "WHERE employeeId = 'd0'";
			sql = sql.Replace("d0", employeeId);
			DataTable resultTable = dm1.GetDataTable(sql);
			
			string fullName = resultTable.Rows[0][0].ToString() + " " + resultTable.Rows[0][1].ToString();
			
			return fullName;
		}//ef
		
		private string getProjectStatus()
		{
			string sql = "SELECT projectStatus FROM project " +
						 "WHERE projectId = 'd0'";
			sql = sql.Replace("d0", txtProjectID.Text);
			DataTable result = dm1.GetDataTable(sql);
			
			return result.Rows[0][0].ToString();
		}//ef
		
		private int getSubmissionNo()
		{
			//get submission no.
			string sql = "SELECT COUNT(*) FROM project_submission " +
						 "WHERE projectId = 'd0'";
			sql = sql.Replace("d0", txtProjectID.Text);
			DataTable result = dm1.GetDataTable(sql);
			int submissionNo = int.Parse(result.Rows[0][0].ToString()) + 1;
			return submissionNo;
		}//ef
		
		
		private void updateProjectAsComplete(string projectId)
		{
			string sql = "UPDATE project SET projectStatus='Complete', completedDate='d1' " +
						 "WHERE projectId = 'd0'";
			sql = sql.Replace("d0", projectId);
			//update project completion date as today
			sql = sql.Replace("d1", DateTime.Now.Date.ToString("yyyy-MM-dd"));
			
			dm1.ExecuteNonQuery(sql);
		}//ef
		
		private void submissionTypeAutoComplete()
		{
			cmbSubmissionType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbSubmissionType.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			AutoCompleteStringCollection submissionTypes = new AutoCompleteStringCollection();
			
			//add types of submission, there are 2, design and final
			submissionTypes.Add("Design Submission");
			submissionTypes.Add("Final Submission");
			
			cmbSubmissionType.AutoCompleteCustomSource = submissionTypes;
			cmbSubmissionType.DataSource = submissionTypes;
		}//ef
		
		private void projectIdAutoComplete()
		{
			txtProjectID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			txtProjectID.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			AutoCompleteStringCollection projectIds = new AutoCompleteStringCollection();
			
			string sql = "SELECT projectId FROM project";
			DataTable resultTable = dm1.GetDataTable(sql);
			foreach (DataRow row in resultTable.Rows)
			{
				projectIds.Add(row[0].ToString());
			}//eloop
			
			txtProjectID.AutoCompleteCustomSource = projectIds;
		}//ef
		
		
		void TxtProjectIDTextChanged(object sender, EventArgs e)
		{
			string projectId   = txtProjectID.Text;
			string projectName = getProjectNameById(projectId);
			//if there is project found
			if(projectName != null)
			{
				lblProjectName.Text	 = projectName;
				lblSubmissionNo.Text = getSubmissionNo().ToString();
			}//end if
		}//ef
		
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
			displaySearchedSubmission();
			
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
		
		void ListViewSubmissionSelectedIndexChanged(object sender, EventArgs e)
		{
			if(listViewSubmission.SelectedItems.Count > 0)
			{
				//we fill in only projectId and allow user to choose submission type by themselves
				txtProjectID.Text = listViewSubmission.SelectedItems[0].SubItems[0].Text;
			}
		}//ef
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			displayAllSubmissions();
		}//ef
	}//ec
}//en
