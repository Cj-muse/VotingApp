using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clean_intern_project.Models
{
    public class VotingSessionManager
    {
        public VotingSessionObject CreateSession(string sessionTitle, string issues, Dictionary<string, VotingSessionObject> votingSessionDictionary)
        {
            string[] parsedIssues = issues.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            List<VotingObject> votingObjects = new List<VotingObject>();
            CreateVotingObjects(parsedIssues, votingObjects);
            VotingSessionObject newVotingSession = CreateSessionObject(votingObjects);
            newVotingSession.SessionTitle = sessionTitle;
            votingSessionDictionary.Add(newVotingSession.SessionGuidString, newVotingSession);
            return newVotingSession;
        }

        private VotingSessionObject CreateSessionObject(List<VotingObject> votingObjects)
        {
            VotingSessionObject newVotingSession = new VotingSessionObject();
            Guid guid = Guid.NewGuid();
            newVotingSession.VotingObjectsList = votingObjects;
            newVotingSession.SessionGuid = guid;
            return newVotingSession;
        }

        private int CreateVotingObjects(string[] parsedIssues, List<VotingObject> votingObjects)
        {
            int i;

            for (i = 0; i < parsedIssues.Length; i++)
            {
                if (string.Empty == parsedIssues[i])
                { continue; }

                VotingObject newVotingObject = new VotingObject(parsedIssues[i]);
                if (0 == i)
                {
                    newVotingObject.IsActive = true;
                }
                votingObjects.Add(newVotingObject);
            }
            return i;
        }
    }
}