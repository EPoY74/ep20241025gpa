/*
* Автор: Евгений Петров
* Почта: p174@mail.ru
* Цель: Обечение c#. пишу учебное приложение для подсчета gpa
* https://learn.microsoft.com/ru-ru/training/modules/guided-project-calculate-final-gpa/2-prepare
* Дата проекта: 25.10.2024
*/

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

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

Console.WriteLine($"Student name: {studentName} \n");

Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1Name}\t\t\t{course1Credit}\t\t{course1Grade}");
Console.WriteLine($"{course2Name}\t\t\t{course2Credit}\t\t{course2Grade}");
Console.WriteLine($"{course3Name}\t\t\t{course3Credit}\t\t{course3Grade}");
Console.WriteLine($"{course4Name}\t\t{course4Credit}\t\t{course4Grade}");
Console.WriteLine($"{course5Name}\t\t\t{course5Credit}\t\t{course5Grade}");

int totalCreditHours = 0;

totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;

totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

// Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

decimal gradePointAverage = (decimal)totalGradePoints/totalCreditHours;

// Console.WriteLine($"Final GPA: {gradePointAverage}");

int leadingDigit = (int) gradePointAverage;
int firstDigit = (int)(gradePointAverage * 10) % 10;
int secondDigit = (int) (gradePointAverage * 100 ) % 10;

Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");