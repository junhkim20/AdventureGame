using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    AudioSource aud;

    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        aud.transform.parent = null;
        aud.Play();
        Destroy(gameObject, aud.clip.length);
        UpdateScore.score ++;
    }
}
