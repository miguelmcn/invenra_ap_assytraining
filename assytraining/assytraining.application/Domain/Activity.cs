namespace assytraining.application.Domain
{
    public class Activity : IDomainModel
    {
        public string ActivityID { get; set; }

        public string IvenIRAStudentID { get; set; }

        public Dictionary<string, string> Params { get; set; }
    }
}
