using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//게임에서는 아래 두가지로 사용되어짐
//1.위치 벡터
//2.방향 벡터

public class PlayerController : MonoBehaviour
{
    //[SerializeField]
    float _speed = 10.0f;
    void Start()
    {

    }

    //GameObject (Player)
    //Transform
    //PlayerController(*)

    //float _yAngle = 0.0f;
    void Update() //한프레임당 호출 됨 -> 60 프레임 이라고 하고 60분의 1초마다 호출되는 것 
    {
        //이전 프레임과 지금 프레임의 시간차를 이용해서 뭔가를 해야하한다.
        //Local -> World
        //TransformDirection

        //World -> Local
        //InverseTransformDirection

        //절대 회전 값 (잘 안쓴다.)
        
        //_yAngle += Time.deltaTime * 100.0f;
        //transform.eulerAngles = new Vector3(0.0f, _yAngle, 0.0f);

        //+ - delta값을 x y z로 회전 한 것 
        //transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100.0f, 0.0f));

        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));

        //transform.position += transform.TransformDirection(Vector3.forward * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.W))
        {
            //특정 방향을 바라보게 끔
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);
            //이렇게 하면 Local Z축이 현재 world기준으로 어떻게 되는가 변환이 있다.
            //그러다 보니 커브를 그리는 것
           
            //근데 그냥 로컬의 방향의 절대적인 이동을 해주는 것이다.
            //transform.position += transform.TransformDirection(Vector3.forward * Time.deltaTime * _speed);
            transform.position += Vector3.forward * Time.deltaTime * _speed;
            //작동 방식이 로컬을 바라보고 있는 기준으로 동작이 되어짐
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            transform.position += Vector3.back * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            transform.position += Vector3.left * Time.deltaTime * _speed;
        }
            
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            transform.position += Vector3.right * Time.deltaTime * _speed;
        }
    }
}
