using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    /// <summary>
    /// 
    /// </summary>
    class Medic : Staff
    {
        
        /// <summary>
        /// Medic's Department
        /// </summary>
        public string Department { get; set; }
        
        /// <summary>
        /// Medic's Field
        /// </summary>
        public string Field { get; set; } 
    }
}
