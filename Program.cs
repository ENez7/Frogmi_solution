// .NET 6.0
using Frogmi.dataset;
using Frogmi.models;

// MAIN
Store store = new()
{
    Incidents = ExampleData.Incidents,
};

var startDate = new DateTime(2022, 04, 01);
var endDate = new DateTime(2022, 04, 30);

GetAllIncidents();
Console.WriteLine("==========================");
ShowStatus(store.IncidentStatus(startDate, endDate));

// FUNCTIONS
void GetAllIncidents()
{
    foreach (var incident in store.Incidents)
    {
        Console.WriteLine("==========================");
        Console.WriteLine($"ID: { incident.IdIncident }");
        Console.WriteLine($"Description: { incident.IncidentDescription }");
        Console.WriteLine($"Action: { incident.ActionToPerform }");
        Console.WriteLine($"Reported at: { incident.ReportedAt.Date }");
        Console.WriteLine(
            incident.isSolved 
                ? $"Solved at: { incident.SolvedAt?.Date }" 
                : $"Solved at: N/A");
        Console.WriteLine(
            incident.Status == IncidentStatus.Open 
            ? $"Status: Open" 
            : $"Status: Solved");
    }
}

void ShowStatus(StoreResponse response)
{
    Console.WriteLine("=============STATUS==============");
    Console.WriteLine($"Open incidents: { response.OpenCases }");
    Console.WriteLine($"Solved incidents: { response.SolvedCases }");
    Console.WriteLine($"Average time: { response.AvgSolveTime }");
    Console.WriteLine($"Max solving time: { response.MaximumSolution }");
}