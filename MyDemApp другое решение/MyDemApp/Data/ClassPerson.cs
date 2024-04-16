using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemApp.Data
{
    public class ClassPerson
    {
        private string id;
        private string date;
        private string equipment;
        private string malfunction_type;
        private string problem_desc;
        private string client;
        private string status;

        public ClassPerson()
        {
        }

        public ClassPerson(string Id, string Date, string Equipment, string Malfunction_type, string Problem_desc, string Client, string Status, string Executor)
        {
            id = Id;
            date = Date;
            equipment = Equipment;
            malfunction_type = Malfunction_type;
            problem_desc = Problem_desc;
            client = Client;
            status = Status;
        }

        public static List<ClassPerson> list = new List<ClassPerson>();
         public string Id
        {
            get { return id; }
            set { id = value; }
        }
         public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Equipment
        {
            get { return equipment; }
            set { equipment = value; }
        }

        public string Malfunction_type
        {
            get { return malfunction_type; }
            set { malfunction_type = value; }
        }

        public string Problem_desc
        {
            get { return problem_desc; }
            set { problem_desc = value; }
        }

        public string Client
        {
            get { return client; }
            set { client = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
