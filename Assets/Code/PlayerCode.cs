using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerCode : MonoBehaviour
{

    NavMeshAgent _agent; 

    Camera mainCam; 

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        mainCam = Camera.main;
    }

    void Update()
    {
        // left click
        if(Input.GetMouseButton(0)){
             RaycastHit hit; 
  
            if(Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200)){
                _agent.SetDestination(hit.point); 
            }
        }
        
    }
}
