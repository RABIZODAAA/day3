// class Student
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public string? Address { get; set; }
//     public double[] Grades = [];

//     public Student() { }

//     public Student(string f, string l, string a, double[] g)
//     {
//         FirstName = f;
//         LastName = l;
//         Address = a;
//         Grades = g;
//     }

//     public double GetAvg()
//     {
//         double sum = 0;
//         for (int i = 0; i < Grades.Length; i++)
//         {
//             sum += Grades[i];
//         }
//         return sum / Grades.Length;
//     }

//     public void
//      GetInfo()
//     {
//         Console.WriteLine($"FullName: {FirstName} {LastName}");
//         Console.WriteLine($"Address: {Address}");
//         Console.WriteLine($"avereg: {GetAvg()}");
//     }
// }