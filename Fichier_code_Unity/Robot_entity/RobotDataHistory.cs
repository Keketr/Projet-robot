public class RobotDataHistory
{
    public string RobotId { get; set; }
    public string RobotName { get; set; }

    public List<BatteryDataHistory> BatteryData { get; set; }
    public List<PositionDataHistory> PositionData { get; set; }
    public List<RobotStatusHistory> StatusData { get; set; }
}
//

public class BatteryDataHistory
{
    public int Time { get; set; }
    public int BatteryLevel { get; set; }
    public int BatteryState { get; set; } // Shall be an enum
}

public class PositionDataHistory
{
    public int Time { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public double Orientation { get; set; }
}

public class RobotStatusHistory
{
    public int Time { get; set; }
    public int Status { get; set; } // Shall be an enum
}