namespace Clean_intern_project.Models
{
    public class VotingObject
    {
        public VotingObject(string str)
        {
            Issue = str;
            YesVotes = 0;
            NoVotes = 0;
            NumberOfVoters = 0;
            IsActive = false;
        }
        
        public int YesVotes { get; set; }

        public int NoVotes { get; set; }

        public int NumberOfVoters { get; set; }

        public bool IsActive { get; set; }

        public string Issue { get; set; }
    }
}