using Frogmi.models;

namespace Frogmi.dataset
{
    public class ExampleData
    {
        public static List<Incident> Incidents = new ()
        {  
            new Incident 
            {
                IdIncident = 1,
                IncidentDescription = "Test 1",
                ActionToPerform = "Test 1",
                ReportedAt = new DateTime(2022, 03, 18),
                SolvedAt = new DateTime(2022, 04, 20),
                isSolved = true,
                Status = IncidentStatus.Solved
            },
            new Incident 
            {
                IdIncident = 2,
                IncidentDescription = "Test 2",
                ActionToPerform = "Test 2",
                ReportedAt = new DateTime(2022, 03, 18),
                SolvedAt = null,
                isSolved = false,
                Status = IncidentStatus.Open
            },
            new Incident 
            {
                IdIncident = 3,
                IncidentDescription = "Test 3",
                ActionToPerform = "Test 3",
                ReportedAt = new DateTime(2022, 03, 10),
                SolvedAt = new DateTime(2022, 04, 10),
                isSolved = true,
                Status = IncidentStatus.Solved
            },
            new Incident 
            {
                IdIncident = 4,
                IncidentDescription = "Test 4",
                ActionToPerform = "Test 4",
                ReportedAt = new DateTime(2022, 04, 18),
                SolvedAt = new DateTime(2022, 04, 25),
                isSolved = true,
                Status = IncidentStatus.Solved
            },
            new Incident 
            {
                IdIncident = 5,
                IncidentDescription = "Test 5",
                ActionToPerform = "Test 5",
                ReportedAt = new DateTime(2022, 04, 30),
                SolvedAt = null,
                isSolved = false,
                Status = IncidentStatus.Open
            },
            new Incident 
            {
                IdIncident = 6,
                IncidentDescription = "Test 6",
                ActionToPerform = "Test 6",
                ReportedAt = new DateTime(2022, 04, 12),
                SolvedAt = null,
                isSolved = false,
                Status = IncidentStatus.Open
            },
            new Incident 
            {
                IdIncident = 7,
                IncidentDescription = "Test 7",
                ActionToPerform = "Test 7",
                ReportedAt = new DateTime(2022, 04, 18),
                SolvedAt = new DateTime(2022, 04, 20),
                isSolved = true,
                Status = IncidentStatus.Solved
            },
            new Incident
            {
                IdIncident = 8,
                IncidentDescription = "Test 7",
                ActionToPerform = "Test 7",
                ReportedAt = new DateTime(2022, 04, 03),
                SolvedAt = new DateTime(2022, 04, 03),
                isSolved = true,
                Status = IncidentStatus.Solved
            },
        };

        public static List<Incident> TestIncidents = new () 
        {
            new Incident
            {
                IdIncident = 1,
                IncidentDescription = "NoIncidentTest",
                ActionToPerform = "AllFieldsTest",
                ReportedAt = new DateTime(2022, 03, 03),
                SolvedAt = null,
                isSolved = false,
                Status = IncidentStatus.Open
            },
            new Incident
            {
                IdIncident = 2,
                IncidentDescription = "NoIncidentTest",
                ActionToPerform = "AllFieldsTest",
                ReportedAt = new DateTime(2022, 03, 03),
                SolvedAt = new DateTime(2022, 03, 05),
                isSolved = true,
                Status = IncidentStatus.Solved
            },
            new Incident
            {
                IdIncident = 3,
                IncidentDescription = "ThreeIncidentTest",
                ActionToPerform = "AllFieldsTest",
                ReportedAt = new DateTime(2022, 04, 20),
                SolvedAt = null,
                isSolved = false,
                Status = IncidentStatus.Open
            },
            new Incident
            {
                IdIncident = 4,
                IncidentDescription = "ThreeIncidentTest",
                ActionToPerform = "AllFieldsTest",
                ReportedAt = new DateTime(2022, 04, 20),
                SolvedAt = new DateTime(2022, 04, 20),
                isSolved = true,
                Status = IncidentStatus.Solved
            },
            new Incident
            {
                IdIncident = 5,
                IncidentDescription = "ThreeIncidentTest",
                ActionToPerform = "AllFieldsTest",
                ReportedAt = new DateTime(2022, 04, 20),
                SolvedAt = new DateTime(2022, 04, 20),
                isSolved = true,
                Status = IncidentStatus.Solved
            },
            new Incident
            {
                IdIncident = 6,
                IncidentDescription = "AvgIsFive",
                ActionToPerform = "AllFieldsTest",
                ReportedAt = new DateTime(2022, 02, 20),
                SolvedAt = null,
                isSolved = false,
                Status = IncidentStatus.Solved
            },
            new Incident
            {
                IdIncident = 7,
                IncidentDescription = "AvgIsFive",
                ActionToPerform = "AllFieldsTest",
                ReportedAt = new DateTime(2022, 02, 20),
                SolvedAt = new DateTime(2022, 02, 25),
                isSolved = true,
                Status = IncidentStatus.Solved
            },
            new Incident
            {
                IdIncident = 8,
                IncidentDescription = "AvgIsFive",
                ActionToPerform = "AllFieldsTest",
                ReportedAt = new DateTime(2022, 02, 20),
                SolvedAt = new DateTime(2022, 02, 25),
                isSolved = true,
                Status = IncidentStatus.Solved
            },
            new Incident
            {
                IdIncident = 9,
                IncidentDescription = "AvgIsFive",
                ActionToPerform = "AllFieldsTest",
                ReportedAt = new DateTime(2022, 02, 20),
                SolvedAt = new DateTime(2022, 02, 25),
                isSolved = true,
                Status = IncidentStatus.Solved
            },
        };
    }
}
