using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsOrganization
{
    public class Student
    {
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public string GroupLead { get; private set; } = "None";


        public Student()
        {
            Name = UnivercityLists.GetRandomName();
            SurName = UnivercityLists.GetRandomSurName();
        }
        public Student(string name, string surname)
        {
            Name = name;
            SurName = surname;
        }

        public override string ToString()
        {
            return $"Name: {Name} {SurName}, Group lead: {GroupLead}";
        }

        public void GroupAssignment(SciStaff stuff)
        {
            GroupLead = $"{stuff.GetType().Name} {stuff.Name} {stuff.SurName}";
        }
    }
}
