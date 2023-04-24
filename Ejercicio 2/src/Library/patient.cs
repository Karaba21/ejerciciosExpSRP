using System;

namespace Program
{
    public class Patient
    {
        public string name {get;}
        public string id {get;}
        public string phoneNumber {get; }

        public Patient (String name, String id, String phoneNumber)
        {
            this.name = name;
            this.id = id;
            this.phoneNumber = phoneNumber;
        }
        
    }
}