using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    abstract class Staff : Person
    {
        /// <summary>
        /// Staff's unique identifier
        /// Ex: s00001, s00002
        /// </summary>
        public string Id { get; set; }
    }
}
