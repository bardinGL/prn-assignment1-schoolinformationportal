using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolinformationportal
{
    public class Validation

    {
        public String createRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1).ToString();
            
        }
        public String getFirstLetter(string Description) {
            string[] words = Description.Split(' ');
            StringBuilder ID = new StringBuilder(); 
            foreach (string word in words)
            {
                if(!string.IsNullOrEmpty(word))
                {
                    ID.Append(word[0]);
                }
            }
            return ID.ToString();
    }
    public string createStudentID(String majorID, String studentName) { 
            Validation validation = new Validation();

            String studentID = "";
            studentID = majorID + validation.getFirstLetter(studentName) ;
            return studentID;
        }
        //public string createEmail(string ID)
        //{ Validation validation = new Validation();
        //String Email;
        //Email = ID + validation.createRandomNumber(1,1000000).PadLeft(6) + "@gmail.com" ;
        //    return Email;
        //}

        public string getFirstName(string fullName)
        {
            string[] names = fullName.Split(' ');
            string firstName = names[0];
            return firstName;
        }

        public string createEmail(string ID)
        {
            Validation validation = new Validation();
            String Email;
            Email = ID + validation.createRandomNumber(1, 1000000).PadLeft(6) + "@gmail.com";
            return Email;
        }
        public string createPassword(String fullName)
        {
            Validation validation = new Validation();

            String Password = validation.getFirstName(fullName);
            return Password;
        }

            public string createclassID(String majorID) {
            Validation validation = new Validation();
            String classID = majorID + validation.createRandomNumber(1,10000).PadLeft(4) ;
            return classID;
        }

        public string createMajorID(String majorDescription)
        {
            Validation validation = new Validation();
            String majorID = validation.getFirstLetter(majorDescription) ;
            return majorID;
        }
        public String createSubjectID(String SubjectDescrpition) {
            Validation validation = new Validation();
            String subjectID = validation.getFirstLetter(SubjectDescrpition) ;
            return subjectID;
        }
        public String createAdminID(String Name) {
        Validation validation = new Validation();
            String adminID = "ad" + Name ;
            return adminID;
        }
        public String createApplicationID()
        {
            Validation validation = new Validation();
                return validation.createRandomNumber(1, 10000).PadLeft(4);
            
        }


    }
}
