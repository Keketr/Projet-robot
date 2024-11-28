public interface IShiftDataConnector
{
    List<Robot> GetRobotsData(DateTime startTime, DateTime endTime);
    void InitializeData(List<Robot> robots);
}