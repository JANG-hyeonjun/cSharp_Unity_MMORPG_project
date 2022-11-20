using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;
    void Start()
    {
        
    }

    //GameObject (Player)
        //Transform
        //PlayerController(*)
    void Update() //한프레임당 호출 됨 -> 60 프레임 이라고 하고 60분의 1초마다 호출되는 것 
    {
        //이전 프레임과 지금 프레임의 시간차를 이용해서 뭔가를 해야하한다.
        //Local -> World
        //TransformDirection

        //World -> Local
        //InverseTransformDirection

        if (Input.GetKey(KeyCode.W))
            //근데이건 로컬을 월드로 바꿔서 한거고 난 그게 싫어 그냥 로컬에 맞추고 싶다면
            //transform.position += transform.TransformDirection(Vector3.forward * Time.deltaTime * _speed);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            //작동 방식이 로컬을 바라보고 있는 기준으로 동작이 되어짐
        if (Input.GetKey(KeyCode.S))
            //transform.position += transform.TransformDirection(Vector3.back * Time.deltaTime * _speed);
            transform.Translate(Vector3.back * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.A))
            //transform.position += transform.TransformDirection(Vector3.left * Time.deltaTime * _speed); 
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.D))
            //transform.position += transform.TransformDirection(Vector3.right * Time.deltaTime * _speed); 
            transform.Translate(Vector3.right * Time.deltaTime * _speed);
    }
}
