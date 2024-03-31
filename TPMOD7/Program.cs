using System.Text.Json;

namespace TPMOD7
{
    class course
    {
        public String kode { get; set; }
        public String nama { get; set; }
    }

    internal class KuliahMahasiswa1302220080
    {
        class CourseData
        {
            public List<Course> courses { get; set; }
        }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Docs\\Konstruksi Perangkat Lunak\\TPMOD7\\tp7_1_1302220080 (1)");
            CourseData dataJson = JsonSerializer.Deserialize<CourseData>(jsonString);

            int i = 1;
            foreach (var course in dataJson.courses)
            {
                Console.WriteLine($"MK {i} {course.kode} - {course.nama}");
                i++;
            }
        }
    }
}
