namespace assytraining.application.Domain
{
    public class Analytics : IDomainModel
    {
        public string InvenIRAStudentID { get; set; }

        public IEnumerable<AnalyticsConfigurationItem>? Qualitative { get; set; }

        public IEnumerable<AnalyticsConfigurationItem>? Quantitative { get; set; }
    }
}
