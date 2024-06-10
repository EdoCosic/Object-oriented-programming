using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB210181
{
    public class PrisustvoIB210181
    {
        public int Id { get; set; }
        public int NastavaId { get; set; }
        public NastavaIB210181 Nastava { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
