namespace CodeStepByStep_CSharp.Collections.Dictionary
{
    //Write a method named Teacher that produces a mapping of students' grades. Your method accepts two parameters: a class roster telling you each student's name and percentage earned in the course, and a grade mapping telling you the minimum percentage needed to earn each unique grade mark. The class roster is a dictionary from students' names (strings) to the percentage of points they earned in the course (integers). The grade mapping is a dictionary from percentages (integers) to grades (strings) and indicates the minimum percentage needed to earn each kind of grade. The task of your method is to look at the student roster and grade mapping and use them to build and return a new Dictionary from students' names to the letter grades they have earned in the class, based on their percentage and the grade mapping. Each student should be given the grade that corresponds to the highest value from the grade mapping that is less than or equal to the percentage that the student earned.
    //
    //Suppose that the class roster is stored in a dictionary variable named roster that contains the following key/value pairs, and that the grade mapping is stored in a dictionary variable named gradeMap that contains the key/value pairs below it:
    //
    //roster:
    //  {{"Mort", 77}, {"Dan", 81}, {"Alyssa", 98}, {"Kim", 52}, {"Lisa", 87}, {"Bob", 43}, {"Jeff", 70}, {"Sylvia", 92}, {"Vikram", 90}}
    //gradeMap:
    //  {{52, "D"}, {70, "C-"}, {73, "C"}, {76, "C+"}, {80, "B-"}, {84, "B"}, {87, "B+"}, {89, "A-"}, {91, "A"}, {98, "A+"}}
    //The idea is that Mort earned a C+ because his grade is at least 76%; Dan earned a B- because he earned at least 80%; and so on. If a given student's percentage is not as large as any of the percentages in the dictionary, give them a default grade of "F". So your method should build and return the following dictionary from students' names to their letter grades when passed the above data:
    //
    //return value:
    //  {{"Mort", "C+"}, {"Dan", "B-"}, {"Alyssa", "A+"}, {"Kim", "D"}, {"Lisa", "B+"}, {"Bob", "F"}, {"Jeff", "C-"}, {"Sylvia", "A"}, {"Vikram", "A-"}}
    //Though dictionaries often store their elements in unpredictable order, for this problem you may assume that the grade mapping's key/value pairs are stored in ascending order by keys (percentages).
    //
    //If either dictionary passed to your method is empty, your method should return an empty dictionary. You should not make any assumptions about the number of key/value pairs in the dictionary or the range of possible percentages that could be in the dictionary.
    //
    //Constraints: You may create one new dictionary as storage to solve this problem. (This is the dictionary you will return.) You may not declare any other data structures. You can have as many simple variables as you like, such as integers or strings. Do not modify the dictionaries that are passed in to your method as a parameter.
    //
    using Dumpify;

    public class Teachers
    {
        public static void RunTeachers()
        {

            Dictionary<string, int> roster2 = new();
            Dictionary<string, int> roster = new()
            {
                { "Mort", 77 }, { "Dan", 81 }, { "Alyssa", 98 }, { "Kim", 52 }, { "Lisa", 87 },
                { "Bob", 43 }, { "Jeff", 70 }, { "Sylvia", 92 }, { "Vikram", 90 }
            };
            Dictionary<int, string> gradeMap = new()
            {
                { 52, "D" }, { 70, "C-" }, { 73, "C" },
                { 76, "C+" }, { 80, "B-" }, { 84, "B" }, { 87, "B+" }, { 89, "A-" }, { 91, "A" }, { 98, "A+" }
            };
            Dictionary<string, string> finalGrades = new();


            if (roster.Count() == 0 || gradeMap.Count() == 0)
            {
                Console.WriteLine("A dictionary was empty.");
                return;
            }

            foreach (KeyValuePair<string, int> student in roster)
            {
                string prevGradeValue = string.Empty;

                foreach (KeyValuePair<int, string> perc in gradeMap)
                {
                    if (student.Value < 52)
                    {
                        finalGrades.Add(student.Key, "F");
                        break;
                    }
                    else if (perc.Key > student.Value && perc.Key != student.Value)
                    {
                        finalGrades.Add(student.Key, prevGradeValue);
                        //finalGrades.DumpConsole();
                        break;
                    }
                    else if (perc.Key == student.Value)
                    {
                        finalGrades.Add(student.Key, perc.Value);
                        //finalGrades.DumpConsole();
                        break;
                    }

                    prevGradeValue = perc.Value;
                }
            }

            finalGrades.DumpConsole();

        }

    }
}
