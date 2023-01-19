using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    /// <summary>
    /// Abstract Class for a person
    /// </summary>
    abstract class Person
    {
        /// <summary>
        /// Person's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Person's address
        /// </summary>
        public string Address { get; set; }
    
        /// <summary>
        /// Person's birth date
        /// </summary>
        public DateOnly BirthDate { get; set; }
        
        /// <summary>
        /// Person's gender 
        /// </summary>
        public Gender Gender { get; set; }

    }
}
