namespace PalletizingReworked.Models
{
    internal class ScaleSettings
    {
        public int Id { get; set; }
        public string commPort { get; set; }
        public string baudRate { get; set; }
        public string scalePreset { get; set; }
        public string prefix { get; set; }
        public string units { get; set; }
        public string pcName { get; set; }
        public int printCount { get; set; }
        public int palId { get; set; }
        public string printLab { get; set; }
        public int barHeight { get; set; }
        public int barWidth { get; set; }
        public int qrSize { get; set; }
        public int textSize { get; set; }
    }
}
