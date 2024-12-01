using UnityEngine;
using UnityEngine.UI;

public class Robot : IPositionable, ICopyable<Robot>
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? ExternalId { get; set; }
    public string? Error { get; set; }
    public virtual short? BatteryLevel { get; set; }
    public BatteryLevelState BatteryLevelState { get; set; }
    public RobotStatus Status { get; set; }
    public Position? Position { get; set; }
    public bool HasTaskAllocated { get; set; }

    public virtual bool IsAvailable
    {
        get
        {
            return Status == RobotStatus.Free
                || Status == RobotStatus.Charging && BatteryLevelState == BatteryLevelState.Normal;
        }
    }

    public Robot Copy()
    {
        return (Robot)this.MemberwiseClone();
    }

    public enum BatteryLevelState
    {
        Low, 
        Normal,
        High
    }

    public enum RobotStatus
    {
        Free,
        Busy,
        Charging,
        Error,

    }

    public intface IPositionable
    {
        Position? Position {get; set;}
    }

    public interface ICopyable<T>
    {
        T Copy();
    }
}