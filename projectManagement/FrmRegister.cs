/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 18-Mar-22
 * Time: 10:24 PM
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
	/// Description of FrmRegister.
	/// </summary>
	public partial class FrmRegister : Form
	{
		DataManager dm1 = new DataManager("localhost", "project_management", "root", "");
		public FrmRegister()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}//econ
		
		void FrmRegisterLoad(object sender, EventArgs e)
		{
			employeeIdAutoComplete();
		}//ef
		
		private bool checkUserNamePassword()
		{
			//check whether the user has existing username
			string sql = "SELECT username, password FROM employee " +
						 "WHERE employeeId = 'd0'";
			sql = sql.Replace("d0", txtEmployeeId.Text);
			
			DataTable result = dm1.GetDataTable(sql);
			
			if (result.Rows[0][0].ToString() != "" && result.Rows[0][1].ToString() != "")
			{
				return true;
			}
			else
			{
				return false;
			}
		}//ef
		
		
		void BtnCreateClick(object sender, EventArgs e)
		{
			if(txtEmployeeId.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
			{
				//check whether the user has existing username
				if (checkUserNamePassword())
				{
					MessageBox.Show("You already have the username and password.");
					return;
				}
				
				//check if password and confirmation are matched
				if (txtConfirm.Text == txtPassword.Text)
				{
					string sql = "UPDATE employee SET username='d1', password='d2' " +
								 "WHERE employeeId = 'd0'";
					
					sql = sql.Replace("d0", txtEmployeeId.Text);
					sql = sql.Replace("d1", txtUsername.Text);
					sql = sql.Replace("d2", txtPassword.Text);
					
					dm1.ExecuteNonQuery(sql);
					
					MessageBox.Show("Create the user successfully.");
				}
				else
				{
					MessageBox.Show("The passwords are not matched.");
				}
			}
			else
			{
				MessageBox.Show("Invalid input.");
			}
		}//ef
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}//ef
		
		private void employeeIdAutoComplete()
		{
			txtEmployeeId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			txtEmployeeId.AutoCompleteSource = AutoCompleteSource.CustomSource;
			
			AutoCompleteStringCollection employeeIds = new AutoCompleteStringCollection();
			
			string sql = "SELECT employeeId FROM employee";
			DataTable resultTable = dm1.GetDataTable(sql);
			
			foreach(DataRow row in resultTable.Rows)
			{
				employeeIds.Add(row[0].ToString());
			}//eloop
			
			txtEmployeeId.AutoCompleteCustomSource = employeeIds;
		}//ef
		
	}//ec
}//en
