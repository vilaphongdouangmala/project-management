/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 17-Mar-22
 * Time: 2:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;

namespace projectManagement
{
	/// <summary>
	/// Description of Global.
	/// </summary>
	public class Global
	{		
		public static User user;
		
		//create an employee list and project assignemnt list for project assignment
		public static List<Employee> employeeList = new List<Employee>();
		public static List<ProjectAssignment> projectAssignmentList = new List<ProjectAssignment>();
	}//ec
}//en
