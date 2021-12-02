using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngineCaseStudy
{
    class FileNotFoundException : Exception
    {
        public FileNotFoundException(string msg) : base(msg)
        {

        }
    }
}