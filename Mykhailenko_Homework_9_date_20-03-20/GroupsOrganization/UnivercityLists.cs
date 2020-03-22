using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsOrganization
{
    public static class UnivercityLists
    {
        public enum Names { Alex, Bob, Tom, Joan, Charlie, Marta, Jack, Alice, Marco, George }
        public enum Surnames { Johnson, Smith, Black, Brown, McConnel, Garrison, Wolf, Studebecker }
        public enum SciGrades { Professor = 1, Lector, Assistant }

        private static List<SciStaff> SciStaffList { get; set; } = new List<SciStaff>();
        private static List<Student> StudentsList { get; set; } = new List<Student>();

        static Random Random { get; } = new Random(); // Randomizer for an autonames.

        public static void AddProfessor()
        {
            SciStaffList.Add(new Professor());
        }
        public static void AddProfessor(string name, string surname)
        {
            SciStaffList.Add(new Professor(name, surname));
        }

        public static void AddLector()
        {
            SciStaffList.Add(new Lector());
        }
        public static void AddLector(string name, string surname)
        {
            SciStaffList.Add(new Lector(name, surname));
        }

        public static void AddAssistant()
        {
            SciStaffList.Add(new Assistant());
        }
        public static void AddAssistant(string name, string surname)
        {
            SciStaffList.Add(new Assistant(name, surname));
        }

        public static void AddStudent()
        {
            StudentsList.Add(new Student());
        }
        public static void AddStudent(string name, string surname)
        {
            StudentsList.Add(new Student(name, surname));
        }


        public static int GetSciListCount()
        {
            return SciStaffList.Count;
        }
        public static int GetStudentsListCount()
        {
            return StudentsList.Count;
        }

        public static SciStaff GetSciWorker(int index)
        {
            return SciStaffList[index];
        }
        public static Student GetStudent(int index)
        {
            return StudentsList[index];
        }

        public static string GetRandomName()
        {
            return Enum.GetName(typeof(Names), Random.Next(Enum.GetValues(typeof(Names)).Length));
        }
        public static string GetRandomSurName()
        {
            return Enum.GetName(typeof(Surnames), Random.Next(Enum.GetValues(typeof(Surnames)).Length));
        }

        public static string DefaultStudyGroupsFilling()
        {
            int currentGroup = 0;
            int currentStudent = 0;
            string result = string.Empty;

            while ((currentStudent < StudentsList.Count) && (currentGroup < SciStaffList.Count))
            {
                SciStaffList[currentGroup].AddStudentToGroup(StudentsList[currentStudent++]);

                if (SciStaffList[currentGroup].SupervizedGroup.Count >= SciStaffList[currentGroup].GetMaxGroupCapacity())
                {
                    result += $"{SciStaffList[currentGroup].GetType().Name} {SciStaffList[currentGroup].Name} {SciStaffList[currentGroup].SurName}'s group was filled.\n";
                    currentGroup++;
                }
            }

            return result;
        }

        public static string SciStaffGroupsInfoPrint()
        {
            string result = string.Empty;

            int groupCounter = 1;

            foreach (SciStaff item in SciStaffList)
            {
                result +=
                    $"Group #{groupCounter++}\n" +
                    item.ToString() + "\n";
            }

            return result;
        }
        public static string StudentsBindingInfoPrint()
        {
            string result = string.Empty;

            foreach (Student item in StudentsList)
            {
                result += item.ToString() + "\n";
            }

            return result;
        }

        public static string GetNonEmptyGroupsInfo()
        {
            string result = string.Empty;
            int groupCounter = 1;

            foreach (SciStaff item in SciStaffList.Where(teacher => teacher.SupervizedGroup.Count != 0).ToList())
            {
                result +=
                    $"Group #{groupCounter++}\n" +
                    $"Group lead: {item.GetType().Name.ToLower()} {item.Name} {item.SurName} " +
                    $"Group fullness: {item.SupervizedGroup.Count}/{item.GetMaxGroupCapacity()}\n";
            }

            return result;
        }

        public static int GetNonEmptyGroupsCount()
        {
            return SciStaffList.Where(teacher => teacher.SupervizedGroup.Count != 0).ToList().Count;
        }
        public static string GetDetailedGroupInfo(int index)
        {

            string result = string.Empty;
            int studentCounter = 1;

            if (SciStaffList[index].SupervizedGroup.Count == 0)
            {
                result += "No students in the group.";
            }
            else
            {
                result += $"Group #{index + 1}\n\n";

                result += $"Group lead: \n{SciStaffList[index].GetType().Name} {SciStaffList[index].Name} {SciStaffList[index].SurName}\n\n";

                result += "Students in group:\n";

                foreach (Student student in SciStaffList[index].SupervizedGroup)
                {
                    result += $"Student #{studentCounter++}: {student.Name} {student.SurName}" + "\n";
                }
            }


            return result;
        }


        public static string GetGroupFiliingMessage(SciStaff sciStuff)
        {
            return $"Group leaded by {sciStuff.GetType().Name.ToLower()} {sciStuff.Name} {sciStuff.SurName} was staffed.";
        }





    }
}
