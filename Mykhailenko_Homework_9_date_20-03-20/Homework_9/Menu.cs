using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupsOrganization;

namespace Homework_9
{
    class Menu
    {
        public static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("Main menu:\n");
            Console.WriteLine("Autofill groups and students (recomended).");
            Console.WriteLine("Students' bindings to groups.");
            Console.WriteLine("Info about non-empty groups.");
            Console.WriteLine("Detailed info about group.");
            Console.WriteLine("Teachers' loads' info.");
            Console.WriteLine("Custom adding.");
            Console.WriteLine("Quit.");

            Console.Write("\nYour option (A/S/I/D/C/Q):");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case (ConsoleKey.A):
                    Console.Clear();
                    AutoFilling();
                    break;

                case (ConsoleKey.S):
                    Console.Clear();
                    Console.WriteLine("Students' bindings to groups: \n");
                    Console.WriteLine(UnivercityLists.StudentsBindingInfoPrint());
                    break;

                case (ConsoleKey.I):
                    Console.Clear();
                    Console.WriteLine("Info about groups: \n");
                    Console.WriteLine(UnivercityLists.GetNonEmptyGroupsInfo());
                    break;

                case (ConsoleKey.D):

                    Console.Clear();
                    Console.WriteLine("Detailed info about group: \n");
                    Console.WriteLine(UnivercityLists.GetNonEmptyGroupsInfo());

                    Console.Write("Choose a group number: ");
                    int groupNumber = ListBoundsValidation(UnivercityLists.GetNonEmptyGroupsCount());

                    Console.Clear();
                    Console.WriteLine($"Detailed info about group #{groupNumber}: \n");
                    Console.WriteLine(UnivercityLists.GetDetailedGroupInfo(groupNumber));
                    Console.WriteLine();
                    break;

                case (ConsoleKey.T):
                    Console.Clear();
                    Console.WriteLine("Teachers' loads' info: ");
                    Console.WriteLine(UnivercityLists.SciStaffGroupsInfoPrint());
                    break;

                case (ConsoleKey.C):
                    CustomAddMenu();
                    break;

                case (ConsoleKey.Q):
                    return;

                default:
                    MainMenu();
                    break;
            }

            Console.Write("Press any key to return to main menu.");
            Console.ReadKey();

            MainMenu();
        }

        public static void CustomAddMenu()
        {
            Console.Clear();

            Console.WriteLine("Custom add menu.\n");
            Console.WriteLine("Professor adding.");
            Console.WriteLine("Lector adding.");
            Console.WriteLine("Assistant adding.");
            Console.WriteLine("Student adding.");
            //Console.WriteLine("Group assigning for a groupless student.");
            Console.WriteLine("Quit to main menu.");

            Console.Write("\nYour option (P/L/A/S/Q):");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case (ConsoleKey.P):
                    CustomProfessorInput();
                    Console.WriteLine();
                    break;
                case (ConsoleKey.L):
                    CustomLectorInput();
                    Console.WriteLine();
                    break;
                case (ConsoleKey.A):
                    CustomAssistantInput();
                    Console.WriteLine();
                    break;
                case (ConsoleKey.S):
                    CustomStudentInput();
                    Console.WriteLine();
                    break;

                case (ConsoleKey.Q):
                    MainMenu();
                    return;

                default:
                    CustomAddMenu();
                    break;
            }

            Console.Write("Press any key to return to the custom add menu.");
            Console.ReadKey();

            CustomAddMenu();
        }

        public static void AutoFilling()
        {
            Console.WriteLine("Autofilling operations.\n");

            Console.Write("Enter the number of students to add: ");
            int studentsCount = PositiveIntValidation();

            for (int i = 0; i < studentsCount; i++)
            {
                UnivercityLists.AddStudent();
            }


            Console.Write("Enter the number of professors: ");
            int professorsCount = PositiveIntValidation();

            for (int i = 0; i < professorsCount; i++)
            {
                UnivercityLists.AddProfessor();
            }

            Console.Write("Enter the number of lectors: ");
            int lectorCount = PositiveIntValidation();

            for (int i = 0; i < lectorCount; i++)
            {
                UnivercityLists.AddLector();
            }


            Console.Write("Enter the number of assistants: ");
            int assistantCount = PositiveIntValidation();

            for (int i = 0; i < assistantCount; i++)
            {
                UnivercityLists.AddAssistant();
            }

            Console.Clear();

            // Filled groups.
            Console.WriteLine("Autofill complete!\n");
            Console.WriteLine("Filled groups:\n");
            Console.WriteLine(UnivercityLists.DefaultStudyGroupsFilling());
        }

        public static void CustomProfessorInput()
        {
            Console.Clear();
            Console.WriteLine("Adding new professor:\n");

            Console.Write("Name: ");
            string name = StringValidation();

            Console.Write("Surname: ");
            string surName = StringValidation();

            UnivercityLists.AddProfessor(name, surName);
        }

        public static void CustomLectorInput()
        {
            Console.Clear();
            Console.WriteLine("Adding new lector:\n");

            Console.Write("Name: ");
            string name = StringValidation();

            Console.Write("Surname: ");
            string surName = StringValidation();

            UnivercityLists.AddLector(name, surName);
        }

        public static void CustomAssistantInput()
        {
            Console.Clear();
            Console.WriteLine("Adding new assistant:\n");

            Console.Write("Name: ");
            string name = StringValidation();

            Console.Write("Surname: ");
            string surName = StringValidation();

            UnivercityLists.AddAssistant(name, surName);
        }

        public static void CustomStudentInput()
        {
            Console.Clear();
            Console.WriteLine("Adding new student:\n");

            Console.Write("Name: ");
            string name = StringValidation();

            Console.Write("Surname: ");
            string surName = StringValidation();

            UnivercityLists.AddStudent(name, surName);

            Student currStudent = UnivercityLists.GetStudent(UnivercityLists.GetStudentsListCount() - 1);

            Console.WriteLine();

            StudentGroupAssignment(currStudent);
        }

        private static void StudentGroupAssignment(Student student)
        {
            Console.WriteLine("Student group assignment.\n");

            Console.WriteLine("Existing groups: \n");
            Console.WriteLine(UnivercityLists.SciStaffGroupsInfoPrint());

            Console.Write("Choose a non-fulled group for a student:");

            int index = ListBoundsValidation(UnivercityLists.GetSciListCount());

            UnivercityLists.GetSciWorker(index - 1).SupervizedGroup.Add(student);
        }

        public static string StringValidation()
        {
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                Console.Write("String cant be empty. Any key to try again. ");
                Console.ReadKey();
                return StringValidation();
            }
        }

        public static int PositiveIntValidation()
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result) && result >= 0) { return result; }
            else
            {
                Console.Write("Error! Input a non-negative number: ");
                return PositiveIntValidation();
            }
        }

        public static int ListBoundsValidation(int listCount)
        {
            string input = Console.ReadLine();

            if ((int.TryParse(input, out int result)) && (result <= listCount) && (result >= 1)) { return result; }
            else
            {
                Console.Write($"Error! Input a non-negative number 1...{listCount}: ");
                return PositiveIntValidation();
            }
        }
    }
}
