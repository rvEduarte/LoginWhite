using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titescriptSCENE : MonoBehaviour
{
    private string MainTite = "ExampleMainMenu";
    public void goBackToLogin()
    {
        SceneManager.LoadScene(MainTite);
    }
}
