namespace assytraining.application.Domain
{
    public class AnalyticsConfiguration: IDomainModel
    {
        public IEnumerable<AnalyticsConfigurationItem>? Qualitative { get; set; }

        public IEnumerable<AnalyticsConfigurationItem>? Quantitative { get; set; }
    }
}
