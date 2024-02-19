string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int course1Grade = 4;
int course2Grade = 3;
int course3Grade = 3;
int course4Grade = 3;
int course5Grade = 4;

decimal engSum = course1Grade * course1Credit;
decimal algSum = course2Grade * course2Credit;
decimal bioSum = course3Grade * course3Credit;
decimal comSum = course4Grade * course4Credit;
decimal psySum = course5Grade * course5Credit;

decimal gpa = (((decimal)course1Grade * course1Credit) + (course2Grade * course2Credit) + (course3Grade * course3Credit) + (course4Grade * course4Credit) + (course5Grade * course5Credit)) / (course1Credit + course2Credit + course3Credit + course4Credit + course5Credit);
decimal rounded = Math.Round(gpa , 2);
Console.WriteLine("Student: Sophia Johnson\n");
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t{course1Grade}\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{course2Grade}\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{course3Grade}\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t{course5Credit}\n");
Console.Write($"Final GPA:\t\t{rounded}");