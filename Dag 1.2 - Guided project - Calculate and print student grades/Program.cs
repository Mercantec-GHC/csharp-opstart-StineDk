// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;
decimal sophiaAverage = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / 5m;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;
decimal nicolasAverage = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / 5m;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;
decimal zahirahAverage = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / 5m;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;
decimal jeongAverage = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / 5m;

Console.WriteLine($"Sophia: {sophia1}, {sophia2}, {sophia3}, {sophia4}, {sophia5}\n");
Console.WriteLine($"Nicolas: {nicolas1}, {nicolas2}, {nicolas3}, {nicolas4}, {nicolas5}\n");
Console.WriteLine($"Zahirah: {zahirah1}, {zahirah2}, {zahirah3}, {zahirah4}, {zahirah5}\n");
Console.WriteLine($"Jeong: {jeong1}, {jeong2}, {jeong3}, {jeong4}, {jeong5}\n");
Console.WriteLine("Student\t\tGrade");
Console.WriteLine($"Sophia\t\t{sophiaAverage}\tA");
Console.WriteLine($"Nicolas\t\t{nicolasAverage}\tB");
Console.WriteLine($"Zahirah\t\t{zahirahAverage}\tB");
Console.WriteLine($"Jeong\t\t{jeongAverage}\tA");