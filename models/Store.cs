namespace Frogmi.models;

public class Store
{
    public List<Incident> Incidents { get; set; } = new List<Incident>();

    public StoreResponse IncidentStatus(DateTime startDate, DateTime endDate)
    {
        IEnumerable<Incident> incidentsToReport = Incidents.Where(i => i.ReportedAt >= startDate && i.ReportedAt <= endDate);
        if(!incidentsToReport.Any())
        {
            Console.WriteLine("There is no incidents to report");
            return new StoreResponse
            {
                OpenCases = 0,
                SolvedCases = 0,
                AvgSolveTime = 0,
                MaximumSolution = 0,
            };
        }
        StoreResponse response = new StoreResponse();
        response.MaximumSolution = Int32.MinValue;

        foreach (var incident in incidentsToReport)
        {
            if (!incident.isSolved)
                response.OpenCases++;
            else
            {
                response.SolvedCases++;
                var solutionTime = Convert.ToInt32((incident.SolvedAt! - incident.ReportedAt).Value.TotalDays);
                response.AvgSolveTime += solutionTime;
                if (solutionTime > response.MaximumSolution)
                    response.MaximumSolution = solutionTime;
            }
        }

        response.AvgSolveTime /= response.SolvedCases;
        return response;
    }
}