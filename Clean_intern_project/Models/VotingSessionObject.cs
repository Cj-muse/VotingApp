using System;
using System.Collections.Generic;

namespace Clean_intern_project.Models
{
    public class VotingSessionObject
    {
        private Guid _sessionGuid;

        // Constructers
        public VotingSessionObject(Guid initialGuid)
        {
            _sessionGuid = initialGuid;
        }
        public VotingSessionObject(Guid initialGuid, List<VotingObject> list)
        {
            SessionGuid = initialGuid;
            VotingObjectsList = list;
        }

        public VotingSessionObject()
        {        }

        // Properties
        public List<VotingObject> VotingObjectsList { get; set; }

        public Guid SessionGuid
        {
            get { return _sessionGuid; }            
            set { _sessionGuid = value; }
        }

        public string SessionGuidString => _sessionGuid.ToString();

        public string SessionTitle { get; set; }
    }
}