using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Door : MonoBehaviour
{
    public bool locked = false; 
    public string nextScene;
    public float scoreNeeded = 0f;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            if(!locked){
                SceneManager.LoadScene(nextScene); 
            } else {
                if(UpdateScore.score >= scoreNeeded) {
                    SceneManager.LoadScene(nextScene); 
                }
            }
        }
    }
}
