// .NET 6.0
using Frogmi.models;
using Frogmi.utils;

Store store = new Store();
Menu();

void Menu()
{
    int response;
    do
    {
        Console.WriteLine("------------------");
        Console.WriteLine("-------MENU-------");
        Console.WriteLine("------------------");
        Console.WriteLine("1. Report an incident");
        Console.WriteLine("2. Close an incident");
        Console.WriteLine("3. Get all incidents");
        Console.WriteLine("4. Get incidents report");
        Console.WriteLine("5. Close");
        response = int.Parse(Console.ReadLine()!);

        switch (response)
        {
            case 1:
                ReportNewIncident();
                break;
            case 2:
                Console.WriteLine("Enter ID: ");
                int id = Validators.EnterANumber();
                CloseIncident(id);
                break;
            case 3:
                GetAllIncidents();
                break;
            case 4:
                ShowStatus(store.IncidentStatus());
                break;
            case 5:
                break;
            default:
                Console.WriteLine("Invalid option. Please insert the option again.");
                break;
        }
        
    } while (response != 5);
}

void ReportNewIncident()
{
    Console.WriteLine("Identifier: ");
    int id = Validators.EnterANumber();
    Console.WriteLine("Description: ");
    string desc = Console.ReadLine()!;
    Console.WriteLine("Action to perform: ");
    string action = Console.ReadLine()!;

    Incident newIncident = new Incident
    {
        IdIncident = id,
        IncidentDescription = desc,
        ActionToPerform = action,
        ReportedAt = DateTime.Now,
        SolvedAt = null,
        Status = IncidentStatus.Open
    };
    
    store.Incidents.Add(newIncident);
}

void CloseIncident(int id)
{
    foreach (var incident in store.Incidents)
    {
        if (incident.IdIncident == id)
        {
            incident.SolvedAt = DateTime.Now;
            incident.Status = IncidentStatus.Solved;
            incident.isSolved = true;
            return;
        }
    }

    Console.WriteLine("ID not found. Please use another ID");
}

void GetAllIncidents()
{
    if (!store.Incidents.Any())
    {
        Console.WriteLine("---There are no incidents---");
        return;
    }
    foreach (var incident in store.Incidents)
    {
        Console.WriteLine("==========================");
        Console.WriteLine($"ID: { incident.IdIncident }");
        Console.WriteLine($"Description: { incident.IncidentDescription }");
        Console.WriteLine($"Action: { incident.ActionToPerform }");
        Console.WriteLine($"Reported at: { incident.ReportedAt }");
        Console.WriteLine(
            incident.isSolved 
                ? $"Solved at: { incident.SolvedAt }" 
                : $"Solved at: N/A");
        Console.WriteLine(
            incident.Status == IncidentStatus.Open 
            ? $"Status: Open" 
            : $"Status: Solved");
    }
}

void ShowStatus(StoreResponse response)
{
    Console.WriteLine("===========================");
    Console.WriteLine($"Open incidents: {response.OpenCases}");
    Console.WriteLine($"Solved incidents: {response.SolvedCases}");
    Console.WriteLine($"Average time: {response.AvgSolveTime}");
    Console.WriteLine($"Max solving time: {response.MaximunSolution}");
}