namespace PerapuSearch.Config
{
    public sealed class ConfigData
    {
        public int Generation { get; set; } = 0;
        public int Gen4MinCount { get; set; } = 0;
        public int Gen4MaxCount { get; set; } = 0;
        public int Gen5MinCount { get; set; } = 40;
        public int Gen5MaxCount { get; set; } = 60;
    }
}
