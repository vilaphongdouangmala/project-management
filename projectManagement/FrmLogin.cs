/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 14-Mar-22
 * Time: 1:19 PM
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
	/// Description of FrmLogin.
	/// </summary>
	public partial class FrmLogin : Form
	{
		DataManager dm1 = new DataManager("localhost", "project_management", "root", "");
		public FrmLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmLoginLoad(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = true;
		}//ef
		
		void BtnLoginClick(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string passowrd = txtPassword.Text;
			
			string sql = "SELECT * FROM employee " +
						 "WHERE username = 'd1' AND password = 'd2'";
			
			sql = sql.Replace("d1", username);
			sql = sql.Replace("d2", passowrd);
			
			DataTable resultTable = dm1.GetDataTable(sql); 
			
											//to prevent empty username and password login
			if (resultTable.Rows.Count > 0 && txtUsername.Text != "" && txtPassword.Text != "")
			{
				//get employee's information
				string employeeId 	= resultTable.Rows[0][0].ToString();
				string firstName 	= resultTable.Rows[0][1].ToString();
				string lastName	 	= resultTable.Rows[0][2].ToString();
				string role		 	= resultTable.Rows[0][7].ToString();
				
				//create a user (global vairable)
				//The roles are separated into CEO, Manager, Senior Designer, Junior Designer
				User loggedInUser = new User(employeeId, firstName, lastName, role);
				Global.user = loggedInUser;
				
				MainForm m1 = new MainForm();
				m1.ShowDialog();
			}//end if
			else
            {
				//if username/password is incorrect, then we return
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Invalid username or password");
                return;
            }//endelse
			
		}//ef
		
		void LblCreateUserClick(object sender, EventArgs e)
		{
			FrmRegister registerForm = new FrmRegister();
			registerForm.ShowDialog();                                       
		}//ef
	}//ec
}//en
