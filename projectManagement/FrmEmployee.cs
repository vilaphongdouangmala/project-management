/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 17-Mar-22
 * Time: 11:23 AM
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
	/// Description of FrmEmployee.
	/// </summary>
	public partial class FrmEmployee : Form
	{
		DataManager dm1 = new DataManager("localhost", "project_management", "root", "");
		
		public FrmEmployee()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}//econ
				
		
		void FrmEmployeeLoad(object sender, EventArgs e)
		{
			displayAllEmployees();
			
			addRoleSource();
			addGenderAutoComplete();
		}//ef
		
		
		private void displayAllEmployees()
		{
			listViewEmployee.Items.Clear();
			
			string sql = "SELECT * FROM employee";
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{
				string employeeId	 = row[0].ToString();
				string firstName	 = row[1].ToString();
				string lastName		 = row[2].ToString();
				string DOB			 = row[3].ToString();
				string gender		 = row[4].ToString();
				string email		 = row[5].ToString();
				string phone		 = row[6].ToString();
				string role			 = row[7].ToString();
				
				ListViewItem newRow = new ListViewItem(employeeId);
				newRow.SubItems.Add(firstName);
				newRow.SubItems.Add(lastName);
				newRow.SubItems.Add(DateTime.Parse(DOB).ToString("yyyy-MM-dd"));
				newRow.SubItems.Add(gender);
				newRow.SubItems.Add(email);
				newRow.SubItems.Add(phone);
				newRow.SubItems.Add(role);
				
				listViewEmployee.Items.Add(newRow);
			}//eloop
		}//ef
		
		private void displaySearchedEmployee()
		{
			listViewEmployee.Items.Clear();
			
			string searchedName = txtSearch.Text;
			
			string sql = "SELECT * FROM employee " +
						 "WHERE firstName LIKE '%d1%' OR lastName LIKE '%d1%'";
			
			sql = sql.Replace("d1", searchedName);
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{
				string employeeId	 = row[0].ToString();
				string firstName	 = row[1].ToString();
				string lastName		 = row[2].ToString();
				string DOB			 = row[3].ToString();
				string gender		 = row[4].ToString();
				string email		 = row[5].ToString();
				string phone		 = row[6].ToString();
				string role			 = row[7].ToString();
				
				ListViewItem newRow = new ListViewItem(employeeId);
				newRow.SubItems.Add(firstName);
				newRow.SubItems.Add(lastName);
				newRow.SubItems.Add(DateTime.Parse(DOB).ToString("yyyy-MM-dd"));
				newRow.SubItems.Add(gender);
				newRow.SubItems.Add(email);
				newRow.SubItems.Add(phone);
				newRow.SubItems.Add(role);
				
				listViewEmployee.Items.Add(newRow);
			}//eloop
		}//ef
		
		void BtnAddClick(object sender, EventArgs e)
		{
			string firstName	 = txtFirstName.Text;
			string lastName		 = txtLastName.Text;
			string DOB			 = dtpDOB.Text;
			string gender		 = cmbGender.Text;
			string email		 = txtEmail.Text;
			string phone		 = txtPhone.Text;
			string role			 = cmbRole.Text;
			
			
			string sql = "INSERT INTO employee(employeeId, firstName, lastName, DOB, gender, email, phone, role) " +
						 "VALUES(null, 'd1', 'd2', 'd3', 'd4', 'd5', 'd6', 'd7')";
			
			sql = sql.Replace("d1", firstName);
			sql = sql.Replace("d2", lastName);
			sql = sql.Replace("d3", DOB);
			sql = sql.Replace("d4", gender);
			sql = sql.Replace("d5", email);
			sql = sql.Replace("d6", phone);
			sql = sql.Replace("d7", role);
			
			dm1.ExecuteNonQuery(sql);
			
			MessageBox.Show("The employee has been successfully added.");
			
			//update customer listview
			displayAllEmployees();
			
		}//ef
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			string employeeId = listViewEmployee.SelectedItems[0].SubItems[0].Text;
			
			string sql = "DELETE FROM employee " +
						 "WHERE employeeId = 'd0'";
			
			sql = sql.Replace("d0", employeeId);
			dm1.ExecuteNonQuery(sql);
			
			MessageBox.Show("The employee has been successfully deleted.");
			
			//update customer listview
			displayAllEmployees();
			
		}//ef
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			string employeeId = listViewEmployee.SelectedItems[0].SubItems[0].Text;
			
			//get information
			string firstName	 = txtFirstName.Text;
			string lastName		 = txtLastName.Text;
			string DOB			 = dtpDOB.Text;
			string gender		 = cmbGender.Text;
			string email		 = txtEmail.Text;
			string phone		 = txtPhone.Text;
			string role			 = cmbRole.Text;
			
			string sql = "UPDATE employee SET firstName='d1', lastName='d2', DOB='d3', gender='d4', email='d5', phone='d6', role='d7' " +
						 "WHERE employeeId='d0'";
			
			sql = sql.Replace("d0", employeeId);
			sql = sql.Replace("d1", firstName);
			sql = sql.Replace("d2", lastName);
			sql = sql.Replace("d3", DOB);
			sql = sql.Replace("d4", gender);
			sql = sql.Replace("d5", email);
			sql = sql.Replace("d6", phone);
			sql = sql.Replace("d7", role);
			
			dm1.ExecuteNonQuery(sql);
	
			MessageBox.Show("The record has been updated.");
			
			//update employee listview
			displayAllEmployees();
			
		}//ef
		
		private void addRoleSource()
		{	
			cmbRole.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbRole.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			AutoCompleteStringCollection roles = new AutoCompleteStringCollection();
			
			string sql = "SELECT roleTitle FROM role";
			
			DataTable result = dm1.GetDataTable(sql);

			
			foreach(DataRow row in result.Rows)
			{
				roles.Add(row[0].ToString());
			}//end loop
			
			cmbRole.AutoCompleteCustomSource = roles;
			cmbRole.DataSource = roles;
		}//ef
		
		private void addGenderAutoComplete()
		{
			cmbGender.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cmbGender.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			AutoCompleteStringCollection genders = new AutoCompleteStringCollection();
			
			genders.Add("Male");
			genders.Add("Female");
			genders.Add("LGBT");
			
			cmbGender.AutoCompleteCustomSource = genders;
			cmbGender.DataSource = genders;
		}//ef
		
		
		void ListViewEmployeeSelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewEmployee.SelectedItems.Count > 0)
			{
				//get data from selected row and show them on textboxes
				txtFirstName.Text	 = listViewEmployee.SelectedItems[0].SubItems[1].Text;
				txtLastName.Text	 = listViewEmployee.SelectedItems[0].SubItems[2].Text;
				dtpDOB.Text			 = listViewEmployee.SelectedItems[0].SubItems[3].Text;
				cmbGender.Text		 = listViewEmployee.SelectedItems[0].SubItems[4].Text;
				txtEmail.Text		 = listViewEmployee.SelectedItems[0].SubItems[5].Text;
				txtPhone.Text		 = listViewEmployee.SelectedItems[0].SubItems[6].Text;
				cmbRole.Text		 = listViewEmployee.SelectedItems[0].SubItems[7].Text;
			}
			else
			{
				//if not selecting the row, then empty the textboxes
				txtFirstName.Text = "";
				txtLastName.Text = "";
				dtpDOB.Text = "";
				cmbGender.Text = "";
				txtEmail.Text = "";
				txtPhone.Text = "";
				cmbRole.Text = "";
			}//end
		}//ef
		
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
			displaySearchedEmployee();
			
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
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			displayAllEmployees();
		}//ef
	}//ec
}//en
