public class GradeBookTest
{
    public static void Main(string[] args)
    {
        // one-dimensional array of student grades
        int[] gradesArray = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

        GradeBook myGradeBook = new GradeBook("CS101 Introduction to C# Programming", gradesArray);
        myGradeBook.DisplayMessage();
        myGradeBook.ProcessGrades();
    } // end Main
} // end class GradeBookTest