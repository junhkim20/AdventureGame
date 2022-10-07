using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findSis : MonoBehaviour
{
    AudioSource aud;
    public Vector3 offset;
    private bool found = false;
    GameObject thePlayer;
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(found)
        {
            thePlayer = GameObject.Find("Player");
            transform.position = thePlayer.transform.position + offset;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && found == false)
        {
            aud.Play();
            found = true;
            UpdateScore.score++;
        }
    }
}

