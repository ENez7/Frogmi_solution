namespace Frogmi.models;

public class Incident
{
    public int IdIncident { get; set; }
    public string IncidentDescription { get; set; }
    public string ActionToPerform { get; set; }
    public DateTime ReportedAt { get; set; }
    public DateTime? SolvedAt { get; set; }
    public bool isSolved { get; set; } = false;
    public IncidentStatus Status { get; set; }

}
public enum IncidentStatus
{
    Open,
    Solved
}
