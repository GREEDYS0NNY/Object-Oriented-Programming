namespace Zadanie3
{
    public static class ListStudentWSIiZExtension
    {
        public static void WypiszPelnaNazweIUczelnie(this List<StudentWSIiZ> studentsWSIiZ)
        {
            foreach (var student in studentsWSIiZ)
            {
                Console.WriteLine(student.WypiszPelnaNazweIUczelnie());
            }
        }
    }
}
