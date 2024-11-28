public class MaeveConnector : IShiftDataConnector
{
    public void InitializeData(List<Robot> robots)
    {
        throw new NotImplementedException("MaeveConnector does not support data initialization.");
    }

    public List<Robot> GetRobotsData(DateTime startTime, DateTime endTime)
    {
        // Implémentation pour se connecter à une vraie base de données et récupérer les données des robots
        throw new NotImplementedException("MaeveConnector needs to be implemented to fetch real data.");
    }
}