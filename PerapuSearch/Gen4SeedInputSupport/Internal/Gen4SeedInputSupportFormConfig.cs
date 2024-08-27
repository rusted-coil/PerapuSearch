namespace PerapuSearch.Gen4SeedInputSupport.Internal
{
    internal sealed class Gen4SeedInputSupportFormConfig
    {
        public string InitialSeed { get; set; } = string.Empty;
        public bool AccountsSecondsDiff { get; set; } = false;
        public int FrameDiffRange { get; set; } = 10;
        public bool OnlyEvenDiff { get; set; } = true;
    }
}
