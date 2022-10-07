using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sisterFound : MonoBehaviour
{
    AudioSource aud;
    private bool found = false;
    GameObject thePlayer;
    public Vector3 offset;

    void Start()
    {
        aud = GetComponent<AudioSource>();
        thePlayer = GameObject.Find("Player");
    }

    void Update()
    {
        if (found)
        {
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