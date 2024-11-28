public class FakeConnector : IShiftDataConnector
{
    public List<Robot> GetRobotsData(DateTime startTime, DateTime endTime)
    {
        // Simulation de données pour les robots
        return new List<Robot>
        {
            new Robot { Id = "R1", Name = "Robot1", BatteryLevel = 80, Status = RobotStatus.Free, Position = new Position(0, 0, 0) },
            new Robot { Id = "R2", Name = "Robot2", BatteryLevel = 60, Status = RobotStatus.Busy, Position = new Position(1, 1, 0) },
            new Robot { Id = "R3", Name = "Robot3", BatteryLevel = 50, Status = RobotStatus.Charging, Position = new Position(2, 2, 0) }
        };
    }
}