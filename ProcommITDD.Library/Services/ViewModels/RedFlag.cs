namespace ProcommITDD.Library.Services.ViewModels
{
    public class RedFlag
    {
        /// <summary>
        /// Topic name - needs to be named Label for easier chart display.
        /// </summary>
        public string Label { get; set; }

        public int OrderNum { get; set; }

        public int OperationalRiskRedFlags { get; set; }

        public int MonetaryRiskRedFlags { get; set; }

        public int DependencyRiskRedFlags { get; set; }

        /// <summary>
        /// Total red flags - needs to be named Value for easier chart display.
        /// </summary>
        public int Value
        {
            get
            {
                return OperationalRiskRedFlags + MonetaryRiskRedFlags + DependencyRiskRedFlags;
            }
        }
    }
}