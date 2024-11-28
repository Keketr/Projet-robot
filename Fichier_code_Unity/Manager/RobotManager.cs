public class RobotManager
{
    public Robot ManagedRobot { get; private set; }

    public RobotManager(Robot robot)
    {
        ManagedRobot = robot;
    }

    public void DisplayRobotStatus()
    {
        Console.WriteLine($"Robot ID: {ManagedRobot.Id}, Name: {ManagedRobot.Name}, Battery Level: {ManagedRobot.BatteryLevel}%, Status: {ManagedRobot.Status}");
    }
}