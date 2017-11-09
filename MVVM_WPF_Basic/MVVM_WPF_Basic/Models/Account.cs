using System;

namespace MVVM_WPF_Basic.Models
{
    class Account
    {
        public uint Id { get; set; }
        public String Name { get { return FirstName + " " + LastName; } }
        public String FirstName { get; set; }
        public String LastName { get; set; }
    }
}
