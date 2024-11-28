
/**public class ShiftManager
{
    private IShiftDataConnector _dataConnector;
    private List<Robot> _shiftRobots = new List<Robot>();

    public ShiftManager(IShiftDataConnector dataConnector)
    {
        _dataConnector = dataConnector;
    }

    public void InitializeShiftData(DateTime startTime, DateTime endTime)
    {
        _shiftRobots = _dataConnector.GetRobotsData(startTime, endTime);
    }

    public List<Robot> GetShiftRobots()
    {
        return _shiftRobots;
    }
}**/

public class ShiftManager //Exemple
{
    public void ExampleUsage()
    {
        // Utilisation du FakeConnector pour récupérer les données des robots
        IShiftDataConnector fakeConnector = new FakeConnector();
        fakeConnector.InitializeData(new List<Robot>
        {
            new Robot { Id = "R1", Name = "Robot1", BatteryLevel = 80, Status = RobotStatus.Free, Position = new Position(0, 0, 0) },
            new Robot { Id = "R2", Name = "Robot2", BatteryLevel = 60, Status = RobotStatus.Busy, Position = new Position(1, 1, 0) },
            new Robot { Id = "R3", Name = "Robot3", BatteryLevel = 50, Status = RobotStatus.Charging, Position = new Position(2, 2, 0) }
        });

        ShiftManager shiftManager = new ShiftManager(fakeConnector);

        DateTime startTime = new DateTime(2024, 11, 27, 8, 0, 0);
        DateTime endTime = new DateTime(2024, 11, 27, 12, 0, 0);

        // Initialiser les données du shift
        shiftManager.InitializeShiftData(startTime, endTime);

        // Créer un RobotManager pour chaque robot
        List<Robot> robots = shiftManager.GetShiftRobots();
        List<RobotManager> robotManagers = new List<RobotManager>();

        foreach (var robot in robots)
        {
            RobotManager robotManager = new RobotManager(robot);
            robotManagers.Add(robotManager);
            robotManager.DisplayRobotStatus();
        }
    }
}
