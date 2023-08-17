using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{

    //1) 나한테 RigidiBody가 있어야한다. (IsKinematic : Off)
    //2) 나한테 Collider가 있어야한다. (IsTrigger : Off)
    //3) 상대한테 Collider가 있어야한다. (IsTrigger : Off)
    //이 세가지를만족해야 CollisionEnter로 들어옴
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision !");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger !");
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
