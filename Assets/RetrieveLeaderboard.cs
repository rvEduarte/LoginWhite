using LootLocker.Requests;
using UnityEngine;

public class RetrieveLeaderboard : MonoBehaviour
{
    /*public int leaderboardID = 23413;

    public void GetLeaderboard()
    {
        LootLockerSDKManager.GetScoreList(leaderboardID, 10, (response) =>
        {
            if (response.success)
            {
                foreach (var entry in response.items)
                {
                    string playerName = entry.member_id;
                    int score = entry.score;
                    string metadata = entry.metadata;

                    // Parse the metadata
                    LeaderboardMetadata leaderboardData = JsonUtility.FromJson<LeaderboardMetadata>(metadata);
                    int timeTaken = leaderboardData.timeTaken;
                    float accuracy = leaderboardData.accuracy;

                    // Display the data (customize this according to your UI)
                    Debug.Log($"Player: {playerName}, Score: {score}, Time Taken: {timeTaken} seconds, Accuracy: {accuracy}%");
                }
            }
            else
            {
                Debug.Log("Failed to retrieve leaderboard: " + response.Error);
            }
        });
    }

    [System.Serializable]
    private class LeaderboardMetadata
    {
        public int timeTaken;
        public float accuracy;
    }

    public void GetLeaderboardData()
    {
        // Assume leaderboard ID is 1
        int leaderboardID = 23413;
        int count = 10; // Number of top scores to fetch

        LootLockerSDKManager.GetScoreList(leaderboardID, count, (response) =>
        {
            if (response.success)
            {
                Debug.Log("Leaderboard data fetched successfully");

                foreach (var score in response.items)
                {
                    string playerName = score.member_id;
                    int playerScore = score.score;
                    string metadata = score.metadata;

                    // Parse metadata
                    var metadataObject = JsonUtility.FromJson<Metadata>(metadata);
                    int timeTaken = metadataObject.timeTaken;
                    float accuracy = metadataObject.accuracy;

                    Debug.Log($"Player: {playerName}, Score: {playerScore}, Time Taken: {timeTaken}s, Accuracy: {accuracy * 100}%");
                }
            }
            else
            {
                Debug.Log("Failed to fetch leaderboard data: " + response.Error);
            }
        });
    }

    [System.Serializable]
    public class Metadata
    {
        public int timeTaken;
        public float accuracy;
    }*/
}