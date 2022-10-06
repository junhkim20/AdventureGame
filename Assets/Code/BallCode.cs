using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCode : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource aud;
    public GameObject key;
    bool respawn = true;
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (respawn == true)
        {
            if (transform.position.y == 2)
            {
                aud.Play();
                respawn = false;
            }
        }
        print(transform.position.y);
        if (transform.position.y < -150)
        {
            transform.position = new Vector3(0, 30, -34);
            respawn = true;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Catcher"))
        {
            Instantiate(key, new Vector3(0, 1, -20), transform.rotation);
            Object.Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
