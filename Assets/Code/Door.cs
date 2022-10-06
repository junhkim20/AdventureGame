using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Door : MonoBehaviour
{
    public bool locked = false; 

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            if(!locked){
                SceneManager.LoadScene("ballLevel"); 
            } else {
                if(UpdateScore.score >= 4) {
                    SceneManager.LoadScene("ballLevel"); 
                }
            }
        }
    }
}
