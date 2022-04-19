/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 14-Mar-22
 * Time: 1:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace projectManagement
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		private void openForm(Form selectedForm, object btnSender)
		{
			selectedForm.TopLevel = false;
			selectedForm.FormBorderStyle = FormBorderStyle.None;
			selectedForm.Dock = DockStyle.Fill;
			this.pnlSelectedForm.Controls.Add(selectedForm);
			this.pnlSelectedForm.Tag = selectedForm;
			selectedForm.BringToFront();
			selectedForm.Show();
		}//ef
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//open Project form as default
			openForm(new FrmProject(), sender);
			lblUser.Text = Global.user.fullName;
			lblRole.Text = Global.user.role;
			
			if(Global.user.role.ToLower() == "manager")
			{
				//if logged in as manager, we make it as manager's view
				managerView();
			}
			else if(Global.user.role.ToLower() == "junior designer" || Global.user.role.ToLower() == "senior designer")
			{
				designerView();
			}
			
		}//ef
			
		private void managerView()
		{
			btnAssigned.Visible = false;
		}//ef
		
		private void designerView()
		{
			btnAssign.Visible = false;
			btnCustomer.Visible = false;
			btnEmployee.Visible = false;
		}//ef
		
		void BtnProjectClick(object sender, EventArgs e)
		{
			openForm(new FrmProject(), sender);
		}//ef
		
		void BtnSubmissionClick(object sender, EventArgs e)
		{
			openForm(new FrmProjectSubmission(), sender);
		}//ef
		
		void BtnEmployeeClick(object sender, EventArgs e)
		{
			openForm(new FrmEmployee(), sender);
		}//ef
		
		void BtnAssignClick(object sender, EventArgs e)
		{
			openForm(new FrmAssign(), sender);
		}//ef
		
		void BtnCustomerClick(object sender, EventArgs e)
		{
			openForm(new FrmCustomer(), sender);
		}//ef
		
		void BtnAssignedClick(object sender, EventArgs e)
		{
			openForm(new FrmAssigned(), sender);
		}//ef
	}//ec
}//en
