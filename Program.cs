using System.Net.Cache;

namespace QueryPracticeExtended
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// for nums
			//
			int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

			int min = nums.Min();
			Console.WriteLine(min + "\n");

			int max = nums.Max();
			Console.WriteLine(max + "\n");

			int maxunder10k = nums.Where(num => num <= 10000).Max();
			Console.WriteLine(maxunder10k + "\n");

			List<int> twofigure = nums.Where(num => num >= 10 && num <= 100).ToList();
			PrintList(twofigure);

			List<int> sixfigure = nums.Where(num => num > 100000 && num <= 999999).ToList();
			PrintList(sixfigure);

			int evencount = nums.Count(num => num % 2 == 0);
			Console.WriteLine(evencount + "\n");

			List<int> descending = nums.OrderByDescending(num => num).ToList();
			PrintList(descending);
			
			// for students
			//
			List<Student> students = new List<Student>();
			students.Add(new Student("Jimmy", 13));
			students.Add(new Student("Hannah Banana", 21));
			students.Add(new Student("Justin", 30));
			students.Add(new Student("Sarah", 53));
			students.Add(new Student("Hannibal", 15));
			students.Add(new Student("Phillip", 16));
			students.Add(new Student("Maria", 63));
			students.Add(new Student("Abe", 33));
			students.Add(new Student("Curtis", 10));

			Console.WriteLine("Our Students");

			List<Student> over21 = students.Where(s => s.Age >= 21).ToList();
			PrintList(over21);

			int oldest = students.Max(s => s.Age);
			List<Student> oldestStudent = students.Where(s => s.Age == oldest).ToList();
			PrintList(oldestStudent);

			int young = students.Min(s => s.Age);
			List<Student> youngStudent = students.Where(s => s.Age == young).ToList();
			PrintList(youngStudent);

			List<Student> oldUnder25 = students.Where(s => s.Age < 25).ToList();
			int oldestUnder25 = oldUnder25.Max(s => s.Age);
			List<Student> oldUnder25L = students.Where(s => s.Age == oldestUnder25).ToList();
			PrintList(oldUnder25L);

			List<Student> even21L = students.Where(s => s.Age > 21 && s.Age % 2 == 0).ToList();
			PrintList(even21L);

			List<Student> teen = students.Where(s => s.Age < 20 && s.Age > 12).ToList();
			PrintList(teen);

			char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
			List<Student> vowel = students.Where(s => vowels.Contains(s.Name.First())).ToList();
			PrintList(vowel);

			List<Student> mad = students.OrderBy(s => s.Age).ToList();
			PrintList(mad);

		}

		public static void PrintList(List<int> input)
		{
			for (int i = 0; i < input.Count; i++)
			{
				int num = input[i];
				Console.WriteLine($"{i}: {num} \n");
			}
		}
		public static void PrintList(List<Student> students)
		{
			for (int i = 0; i < students.Count; i++)
			{
				Student s = students[i];
				Console.WriteLine($"{i}: {s.Name} is {s.Age} \n");
			}
		}
	}
}