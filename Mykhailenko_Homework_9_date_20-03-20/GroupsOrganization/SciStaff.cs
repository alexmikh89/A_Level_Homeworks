using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsOrganization
{
    public abstract class SciStaff
    {
        public abstract List<Student> SupervizedGroup { get; set; }
        public abstract string Name { get; set; }
        public abstract string SurName { get; set; }
        protected abstract int MaxGroupCapacity { get; set; }

        public abstract void AddStudentToGroup(Student student);
        public abstract int GetMaxGroupCapacity();
    }

    public class Professor : SciStaff
    {
        public override List<Student> SupervizedGroup { get; set; }
        public override string Name { get; set; }
        public override string SurName { get; set; }
        protected override int MaxGroupCapacity { get; set; }

        public Professor(int groupCapacity = 10)
        {
            Name = UnivercityLists.GetRandomName();
            SurName = UnivercityLists.GetRandomSurName();
            MaxGroupCapacity = groupCapacity;
            SupervizedGroup = new List<Student>();
        }

        public Professor(string name, string surname)
        {
            Name = name;
            SurName = surname;
            MaxGroupCapacity = 10;
            SupervizedGroup = new List<Student>();
        }

        public override void AddStudentToGroup(Student student)
        {
            SupervizedGroup.Add(student);
            student.GroupAssignment(this);
        }

        public override int GetMaxGroupCapacity()
        {
            return MaxGroupCapacity;
        }

        public override string ToString()
        {
            return $"Name: {Name} {SurName}, Professor; Group fullness (max/current): {SupervizedGroup.Count}/{MaxGroupCapacity}.";
        }


    }

    public class Lector : SciStaff
    {
        public override List<Student> SupervizedGroup { get; set; }
        public override string Name { get; set; }
        public override string SurName { get; set; }
        protected override int MaxGroupCapacity { get; set; } = 7;

        public Lector()
        {
            Name = UnivercityLists.GetRandomName();
            SurName = UnivercityLists.GetRandomSurName();
            SupervizedGroup = new List<Student>();
        }

        public Lector(string name, string surname)
        {
            Name = name;
            SurName = surname;
            SupervizedGroup = new List<Student>();
        }

        public override void AddStudentToGroup(Student student)
        {
            SupervizedGroup.Add(student);
            student.GroupAssignment(this);
        }

        public override int GetMaxGroupCapacity()
        {
            return MaxGroupCapacity;
        }

        public override string ToString()
        {
            return $"Name: {Name} {SurName}, Lector; Group fullness (max/current): {SupervizedGroup.Count}/{MaxGroupCapacity}.";
        }
    }

    public class Assistant : SciStaff
    {
        public override List<Student> SupervizedGroup { get; set; }
        public override string Name { get; set; }
        public override string SurName { get; set; }
        protected override int MaxGroupCapacity { get; set; } = 3;

        public Assistant()
        {
            Name = UnivercityLists.GetRandomName();
            SurName = UnivercityLists.GetRandomSurName();
            SupervizedGroup = new List<Student>();
        }
        public Assistant(string name, string surname)
        {
            Name = name;
            SurName = surname;
            SupervizedGroup = new List<Student>();
        }


        public override void AddStudentToGroup(Student student)
        {
            SupervizedGroup.Add(student);
            student.GroupAssignment(this);
        }

        public override int GetMaxGroupCapacity()
        {
            return MaxGroupCapacity;
        }

        public override string ToString()
        {
            return $"Name: {Name} {SurName}, Assistant; Group fullness (max/current): {SupervizedGroup.Count}/{MaxGroupCapacity}.";
        }
    }
}
