using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Present { get; set; }
    }
}
