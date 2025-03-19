/*Console.WriteLine("This is land");
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);
var name = "Bob";
var need = 3;
var value = 3.44;
Console.WriteLine(34.40);
Console.WriteLine("Hello, " + name +"! You have " + need + " messages in your inbox. The temperature is " + value + " celsius.");*/

/*Console.WriteLine(@" c:\source\repo


(this is where the code goes)");*/

/*string name = "Bob";
string message = $"Hello  {name}";
Console.WriteLine(message);

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine(@$"View English output:
                    c:\Exercise\{projectName}\data.txt");

// Console.WriteLine(@$"{russianMessage}:
//                     c:\Exercise\{projectName}\ru-RU\data.txt");*/

// int fahrenheit = 94;
// decimal celsius = (fahrenheit - 32m) * (5m / 9m);
// Console.WriteLine ($"The temperature is {celsius} Celsius");


// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophia = 0;
int nicolas = 0;
int zahirah = 0;
int jeong = 0;

sophia = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
nicolas = nicolas1+ nicolas2 + nicolas3 + nicolas4 +nicolas5;
zahirah = zahirah1 + zahirah2+zahirah3+zahirah4+zahirah5;
jeong = jeong1+jeong2+jeong3+jeong4+jeong5;

decimal sophiaScore = (decimal)sophia / currentAssignments;
decimal nicolasScore = (decimal)nicolas / currentAssignments;
decimal zahirahScore = (decimal)zahirah / currentAssignments;
decimal jeongScore = (decimal)jeong / currentAssignments;

Console.WriteLine("Student\t Score\t");
Console.WriteLine($"The Total score gotten by sophia is:\t {sophiaScore + " \tA"}");
Console.WriteLine($"The Total score gotten by nicolas is:\t {nicolasScore + " \tB"}");
Console.WriteLine($"The Total score gotten by Zahirah is:\t {zahirahScore + " \tB"}");
Console.WriteLine($"The Total score gotten by jeong is:\t {jeongScore + " \tA"}");

