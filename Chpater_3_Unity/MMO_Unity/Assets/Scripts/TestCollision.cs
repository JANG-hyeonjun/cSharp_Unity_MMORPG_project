using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{

    //1) 나 혹은 상대 한테 RigidiBody가 있어야한다. (IsKinematic : Off)
    //2) 나한테 Collider가 있어야한다. (IsTrigger : Off)
    //3) 상대한테 Collider가 있어야한다. (IsTrigger : Off)
    //이 세가지를만족해야 CollisionEnter로 들어옴
    private void OnCollisionEnter(Collision collision) //물리적인 충돌등에 쓰임
    {
        Debug.Log($"Collision @ {collision.gameObject.name} !");
    }

    // 1) 둘다 Collider가 있어야한다.
    // 2) 둘 중 하나는 isTrigger : On
    // 3) 둘 중 하나는 RigidBody가 있어야한다. 

    private void OnTriggerEnter(Collider other) //예를들면 어떤 범위안에 들어갔냐 안들어갔냐
    {
       
        Debug.Log($"Trigger @ { other.gameObject.name} !");
    }


    void Start()
    {
        
    }

    void Update()
    {
        Vector3 look = transform.TransformDirection(Vector3.forward);
        
        Debug.DrawRay(transform.position + Vector3.up, look * 10,Color.red);

        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position + Vector3.up, look, 10);
        
        foreach(RaycastHit hit in hits)
        {
            Debug.Log($"Raycast {hit.collider.gameObject.name}");
        }

        //if (Physics.Raycast(transform.position + Vector3.up, look, out hit, 10))
        //{
        //    Debug.Log($"Raycast {hit.collider.gameObject.name}");
        //}
    }
}
