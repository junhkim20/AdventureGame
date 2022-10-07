using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class EndGame : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None; 
    }

    public void BackToTitle()
    {
        SceneManager.LoadScene("Title Screen");
    }

    public void RetryLevel()
    {
        SceneManager.LoadScene("ballLevel");
    }
}
