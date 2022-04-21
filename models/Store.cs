namespace Frogmi.models;

public class Store
{
    public List<Incident> Incidents { get; set; } = new List<Incident>();

    public StoreResponse IncidentStatus(DateTime startDate, DateTime endDate)
    {
        StoreResponse response = new StoreResponse();
        response.MaximunSolution = Int32.MinValue;
        foreach (var incident in Incidents)
        {
            if (!incident.isSolved)
                response.OpenCases++;
            else
            {
                response.SolvedCases++;
                var solutionTime = Convert.ToInt32((incident.SolvedAt! - incident.ReportedAt).Value.TotalDays);
                response.AvgSolveTime += solutionTime;
                if (solutionTime < response.MaximunSolution)
                    response.MaximunSolution = solutionTime;
            }
        }

        response.AvgSolveTime /= response.SolvedCases;
        return response;
    }
}