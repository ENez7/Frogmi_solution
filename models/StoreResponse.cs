namespace Frogmi.models;

public class StoreResponse
{
    public int OpenCases { get; set; } = 0;
    public int SolvedCases { get; set; } = 0;
    public int AvgSolveTime { get; set; } = 0;
    public int MaximumSolution { get; set; } = 0;

    public override bool Equals(object? obj)
    {
        if(obj is not StoreResponse) return false;

        StoreResponse other = (StoreResponse)obj;
        return OpenCases == other.OpenCases 
            && SolvedCases == other.SolvedCases 
            && AvgSolveTime == other.AvgSolveTime
            && MaximumSolution == other.MaximumSolution;
    }
}