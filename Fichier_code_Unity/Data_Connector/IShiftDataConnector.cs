public interface IShiftDataConnector
{
    List<Robot> GetRobotsData(DateTime startTime, DateTime endTime);
}