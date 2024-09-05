using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDemo
{
    public class Login
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; } = string.Empty;

        public DateTime Time = DateTime.UtcNow;
    }
}
