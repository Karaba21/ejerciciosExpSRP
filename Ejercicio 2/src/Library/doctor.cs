using System;

namespace Doctor
{
    public class Doctor
    {
        public string doctorName {get;}
        public string appoinmentPlace {get;}

        public Doctor (String doctorName, String appoinmentPlace)
        {
            this.doctorName = doctorName;
            this.appoinmentPlace = appoinmentPlace;
        }
        
    }
}