using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava4
{
    public class Classroom
    {
        public List<Student> Students { get; set; }
        public List<Computer> Computers { get; set; }
        public Teacher CurrentTeacher { get; set; }
        public string RoomNumber { get; set; }
    }
}
