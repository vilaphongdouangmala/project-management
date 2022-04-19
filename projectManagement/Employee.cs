/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 18-Mar-22
 * Time: 8:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projectManagement
{
	/// <summary>
	/// Description of Employee.
	/// </summary>
	public class Employee
	{
		public string employeeId, firstName, lastName, role;
		
		public Employee()
		{
		}//econ
		
		public Employee(string employeeId, string firstName, string lastName, string role)
		{
			this.employeeId = employeeId;
			this.firstName = firstName;
			this.lastName = lastName;
			this.role = role;
		}//econ
		
	}//ec
}//en
