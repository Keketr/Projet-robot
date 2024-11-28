public class FakeConnector : IShiftDataConnector
{
    private List<Robot> _robots = new List<Robot>();

    public void InitializeData(List<Robot> robots)
    {
        _robots = robots;
    }

    public List<Robot> GetRobotsData(DateTime startTime, DateTime endTime)
    {
        // Simulation de données pour les robots
        return _robots;
    }
}