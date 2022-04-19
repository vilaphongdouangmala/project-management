/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 18-Mar-22
 * Time: 8:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projectManagement
{
	/// <summary>
	/// Description of ProjectAssignment.
	/// </summary>
	public class ProjectAssignment
	{
		public string projectId, employeeId, projectRole;
		
		public ProjectAssignment()
		{
		}//econ
		
		public ProjectAssignment(string projectId, string employeeId, string projectRole)
		{
			this.projectId = projectId;
			this.employeeId = employeeId;
			this.projectRole = projectRole;
		}//econ
		
	}//ec
}//en
