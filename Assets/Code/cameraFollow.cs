using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Vector3 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate ()
    {
        transform.position = target.position + offset;
    }
}
