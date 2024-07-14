using UnityEngine;
using LootLocker.Requests;
using System.ComponentModel;
using TMPro;

public class SubmitLeaderboardScore : MonoBehaviour
{
  public static string leaderboardKey = "titehenlo";
    public TMP_InputField inputscore;
  public void titeSubmit()
    {

        int scoreToSubmit = 2000;
        PlayerPrefs.SetFloat("tite1", 15.0f);
        PlayerPrefs.SetFloat("tite", 0.50f);
        PlayerPrefs.Save();
        Submit(scoreToSubmit);
    }
  public static void Submit(int scoreToSubmit)
  {
    //the member id is set when the user logs in or uses guest login, if they have not done either of those then this will be empty and the request will fail.
    // we set it throughout WhiteLabelManager.cs, you can cmd/ctrl + f and look for PlayerPrefs.SetString("LLplayerId"
    string playerId = PlayerPrefs.GetString("LLplayerId");
        //string metadata = "timeTaken: " + PlayerPrefs.GetFloat("tite1") +" Accuracy: "+ PlayerPrefs.GetFloat("tite");

        // Create metadata object
        PlayerMetadata1 metadataObject = new PlayerMetadata1
        {
            timeTaken = PlayerPrefs.GetFloat("tite1"),
            accuracy = PlayerPrefs.GetFloat("tite")
        };
        // Serialize metadata to JSON
        string metadata = JsonUtility.ToJson(metadataObject);

        LootLockerSDKManager.SubmitScore(playerId, scoreToSubmit, leaderboardKey, metadata, (response) =>
    {
      if (response.success)
      {
        Debug.Log("SubmitLeaderboardScore successful" + metadata);
      }
      else
      {
        Debug.LogError("SubmitLeaderboardScore failed");
        Debug.LogError("Error: " + response.Error);
      }
    });
  }


    public static void GetPlayerHighScore()
  {
        string playerIdString = PlayerPrefs.GetString("LLplayerId");

        // Convert the playerId string to an integer
        int playerId;
        if (!int.TryParse(playerIdString, out playerId))
        {
            Debug.LogError("Failed to parse playerId from PlayerPrefs.");
            return;
        }
        LootLockerSDKManager.GetMemberRank(leaderboardKey, playerId, (response) =>
      {
        if (response.statusCode == 200)
        {
          Debug.Log("Successful");
          Debug.Log("Player Score: " + response.score);
          PlayerPrefs.SetInt("highScore", response.score);
        }
        else
        {
          Debug.Log("failed to get highscore: " + response.Error);
        }
      });
  }
}
