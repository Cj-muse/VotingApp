namespace Clean_intern_project.Models
{
    public class VotingObject
    {
        public VotingObject(string str)
        {
            Issue = str;
            VotesFor = 0;
            VotesAgainst = 0;
            NumberOfVoters = 0;
            IsActive = false;
        }
        
        public int VotesFor { get; set; }

        public int VotesAgainst { get; set; }

        public int NumberOfVoters { get; set; }

        public bool IsActive { get; set; }

        public string Issue { get; set; }
    }
}