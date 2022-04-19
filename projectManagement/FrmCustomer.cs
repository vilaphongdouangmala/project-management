/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 17-Mar-22
 * Time: 2:02 PM
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
	/// Description of FrmCustomer.
	/// </summary>
	public partial class FrmCustomer : Form
	{
		DataManager dm1 = new DataManager("localhost", "project_management", "root", "");
		public FrmCustomer()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}//econ
		
		void FrmCustomerLoad(object sender, EventArgs e)
		{
			displayAllCustomers();
		}//ef
		
		private void displayAllCustomers()
		{
			listViewCustomer.Items.Clear();
			
			string sql = "SELECT * FROM customer";
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{
				string customerId	 = row[0].ToString();
				string firstName	 = row[1].ToString();
				string lastName		 = row[2].ToString();
				string DOB			 = row[3].ToString();
				string gender		 = row[4].ToString();
				string email		 = row[5].ToString();
				string phone		 = row[6].ToString();
				
				ListViewItem newRow = new ListViewItem(customerId);
				newRow.SubItems.Add(firstName);
				newRow.SubItems.Add(lastName);
				newRow.SubItems.Add(DateTime.Parse(DOB).ToString("yyyy-MM-dd"));
				newRow.SubItems.Add(gender);
				newRow.SubItems.Add(email);
				newRow.SubItems.Add(phone);
				
				listViewCustomer.Items.Add(newRow);
			}//eloop
		}//ef
		
		private void displaySearchedCustomer()
		{
			listViewCustomer.Items.Clear();
			
			string searchedName = txtSearch.Text;
			
			string sql = "SELECT * FROM customer " +
						 "WHERE firstName LIKE '%d1%' OR lastName LIKE '%d1%'";
			
			sql = sql.Replace("d1", searchedName);
			
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{
				string customerId	 = row[0].ToString();
				string firstName	 = row[1].ToString();
				string lastName		 = row[2].ToString();
				string DOB			 = row[3].ToString();
				string gender		 = row[4].ToString();
				string email		 = row[5].ToString();
				string phone		 = row[6].ToString();
				
				ListViewItem newRow = new ListViewItem(customerId);
				newRow.SubItems.Add(firstName);
				newRow.SubItems.Add(lastName);
				newRow.SubItems.Add(DateTime.Parse(DOB).ToString("yyyy-MM-dd"));
				newRow.SubItems.Add(gender);
				newRow.SubItems.Add(email);
				newRow.SubItems.Add(phone);
				
				listViewCustomer.Items.Add(newRow);
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
			
			
			string sql = "INSERT INTO customer(customerId, firstName, lastName, DOB, gender, email, phone) " +
						 "VALUES(null, 'd1', 'd2', 'd3', 'd4', 'd5', 'd6')";
			
			sql = sql.Replace("d1", firstName);
			sql = sql.Replace("d2", lastName);
			sql = sql.Replace("d3", DOB);
			sql = sql.Replace("d4", gender);
			sql = sql.Replace("d5", email);
			sql = sql.Replace("d6", phone);
			
			dm1.ExecuteNonQuery(sql);
			
			MessageBox.Show("The customer has been successfully added.");
			
			displayAllCustomers();
		}//ef
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			string customerId = listViewCustomer.SelectedItems[0].SubItems[0].Text;
			
			string sql = "DELETE FROM customer " +
						 "WHERE customerId = 'd0'";
			sql = sql.Replace("d0", customerId);
			
			dm1.ExecuteNonQuery(sql);
			
			MessageBox.Show("The customer has been successfully deleted.");
			
			displayAllCustomers();
		}//ef
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			string customerId = listViewCustomer.SelectedItems[0].SubItems[0].Text;
			
			//get information
			string firstName	 = txtFirstName.Text;
			string lastName		 = txtLastName.Text;
			string DOB			 = dtpDOB.Text;
			string gender		 = cmbGender.Text;
			string email		 = txtEmail.Text;
			string phone		 = txtPhone.Text;
			
			string sql = "UPDATE customer SET firstName='d1', lastName='d2', DOB='d3', gender='d4', email='d5', phone='d6' " +
						 "WHERE customerId = 'd0'";
			
			sql = sql.Replace("d0", customerId);
			sql = sql.Replace("d1", firstName);
			sql = sql.Replace("d2", lastName);
			sql = sql.Replace("d3", DOB);
			sql = sql.Replace("d4", gender);
			sql = sql.Replace("d5", email);
			sql = sql.Replace("d6", phone);

			dm1.ExecuteNonQuery(sql);
			
			MessageBox.Show("The record has been updated.");
			
			//update customer listview
			displayAllCustomers();
		}//ef
		
		void ListViewCustomerSelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewCustomer.SelectedItems.Count > 0)
			{
				//get data from selected row and show them on textboxes
				txtFirstName.Text	 = listViewCustomer.SelectedItems[0].SubItems[1].Text;
				txtLastName.Text	 = listViewCustomer.SelectedItems[0].SubItems[2].Text;
				dtpDOB.Text			 = listViewCustomer.SelectedItems[0].SubItems[3].Text;
				cmbGender.Text		 = listViewCustomer.SelectedItems[0].SubItems[4].Text;
				txtEmail.Text		 = listViewCustomer.SelectedItems[0].SubItems[5].Text;
				txtPhone.Text		 = listViewCustomer.SelectedItems[0].SubItems[6].Text;
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
			}//end
		}//ef
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			displayAllCustomers();
		}//ef
		
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
			displaySearchedCustomer();
			
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
