using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BallCode : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource aud;
    AudioSource keySpawnAud;
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
            keySpawnAud = collision.gameObject.GetComponent<AudioSource>();
            keySpawnAud.Play();
            Object.Destroy(collision.gameObject, 3);
            Instantiate(key, new Vector3(0, 1, -20), transform.rotation);
            Destroy(gameObject, 3);
        }

        else if (collision.collider.gameObject.CompareTag("DeathPlane"))
        {
            SceneManager.LoadScene("YouLose");
        }
    }
}
