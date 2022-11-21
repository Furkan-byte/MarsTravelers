using Models;



int Mars_X ;
int Mars_Y ;
string FirstTraveler_command;
string SecondTraveler_command;
int FirstTraveler_X;
int FirstTraveler_Y ;
string FirstTraveler_direction;
int SecondTraveler_X;
int SecondTraveler_Y;
string SecondTraveler_direction;


Console.WriteLine("Enter the Mars's X coordinates :  ");
Mars_X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Mars's Y coordinates :  ");
Mars_Y = Convert.ToInt32(Console.ReadLine());


Mars mars = new Mars(Mars_X, Mars_Y);
Travelers FirstTraveler = new FirstTravelerRobot(mars);
Travelers SecondTraveler = new SecondTravelerRobot(mars);


Console.WriteLine("Enter the First Traveler's X coordinates : ");
FirstTraveler_X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the First Traveler's Y coordinates :  ");
FirstTraveler_Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the First Traveler's direction(W,S,N,E) :  ");
FirstTraveler_direction = Console.ReadLine();

FirstTraveler.SetTravelerInfo(FirstTraveler_X,FirstTraveler_Y,FirstTraveler_direction);

Console.WriteLine("Enter the commands(L,R,M) :  ");
FirstTraveler_command = Console.ReadLine();

Console.WriteLine("Enter the Second Traveler's X coordinates : ");
SecondTraveler_X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Second Traveler's Y coordinates :  ");
SecondTraveler_Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Second Traveler's direction(W,S,N,E) :  ");
SecondTraveler_direction = Console.ReadLine();

SecondTraveler.SetTravelerInfo(SecondTraveler_X, SecondTraveler_Y, SecondTraveler_direction);

Console.WriteLine("Enter the commands(L,R,M) :  ");
SecondTraveler_command = Console.ReadLine();
/* For loop for firsTraveler */
for (int i = 0; i < FirstTraveler_command.Length; i++)
{
    string command = Convert.ToString(FirstTraveler_command[i]);
    if (command=="L")
    {
        FirstTraveler.TurnLeft();
    }
    else if (command == "R")
    {
        FirstTraveler.TurnRight();
    }
    else if (command == "M")
    {
        FirstTraveler.MoveForward();
    }
}
/* For loop for SecondTraveler */
for (int j = 0; j < SecondTraveler_command.Length; j++)
{
    string command = Convert.ToString(SecondTraveler_command[j]);
    if (command == "L")
    {
        SecondTraveler.TurnLeft();
    }
    else if (command == "R")
    {
        SecondTraveler.TurnRight();
    }
    else if (command == "M")
    {
        SecondTraveler.MoveForward();
    }
}


Console.WriteLine(FirstTraveler.GetTravelerInfo());
Console.WriteLine(SecondTraveler.GetTravelerInfo());
Console.ReadLine();