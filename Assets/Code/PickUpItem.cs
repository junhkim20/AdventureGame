using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public AudioSource pickupSound;

    void OnTriggerEnter(Collider other)
    {
        //pickupSound.Play();
        //UpdateScore.score ++;
        Destroy(gameObject);
    }
}
