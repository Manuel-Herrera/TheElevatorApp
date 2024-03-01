// See https://aka.ms/new-console-template for more information
using TheElevatorApp;

var elevator = new Elevator();

while (true)
{
    Console.WriteLine("Enter floor number (1-5) or 'e' to Exit:");
    var input = Console.ReadLine();

    if (input.ToLower() != "e")
    {
        int.TryParse(input, out int floor);

        if (floor == 1 || floor == 5)
            elevator.MoveTo1or5(floor);
        if (floor == 2 || floor == 3 || floor == 4)
            elevator.UpAndDown(floor);
        else
            Console.WriteLine("Invalid input. Please enter a floor number.");
    }
    else
    {
        break;
    }
}
