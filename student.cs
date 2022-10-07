using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryPracticeExtended
{
	internal class Student
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Student(string Name, int Age)
		{
			this.Name = Name;
			this.Age = Age;
		}
	}
}
