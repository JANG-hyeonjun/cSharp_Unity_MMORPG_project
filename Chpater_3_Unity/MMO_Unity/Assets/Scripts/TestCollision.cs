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
        //Local <-> World <-> Viewport <-> Screen(화면)

        //Debug.Log(Input.mousePosition); //Screen
        //Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition)); //ViewPort 스크린과 유사하나 비율로 표현

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);

            LayerMask mask = LayerMask.GetMask("Monster") | LayerMask.GetMask("Wall");
            //int mask = (1 << 8) | (1 << 9);

            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 100.0f, mask))
            {
               
                Debug.Log($"Raycast Camera @{hit.collider.gameObject.tag}");
            }
          
        }

        //원래 과정
        //if (Input.GetMouseButtonDown(0))
        //{ 
        //    Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        //    Vector3 dir = mousePos - Camera.main.transform.position;
        //    dir = dir.normalized;

        //    Debug.DrawRay(Camera.main.transform.position, dir * 100.0f, Color.red, 1.0f);

        //    RaycastHit hit;
        //    if (Physics.Raycast(Camera.main.transform.position, dir, out hit, 100.0f))
        //    {
        //        Debug.Log($"Raycast Camera @{hit.collider.gameObject.name}");
        //    }
        //}
    }
}
