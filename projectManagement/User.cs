/*
 * Created by SharpDevelop.
 * User: Predator
 * Date: 17-Mar-22
 * Time: 2:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace projectManagement
{
	/// <summary>
	/// Description of User.
	/// </summary>
	public class User
	{
		public string employeeId, firstName, lastName, role;
		public string fullName;
		
		public User(string employeeId, string firstName, string lastName, string role)
		{
			this.employeeId = employeeId;
			this.firstName = firstName;
			this.lastName = lastName;
			this.role = role;
			this.fullName = firstName + " " + lastName;
		}//econ
		
		public User()
		{
		}//econ
	}//ec
}//en
