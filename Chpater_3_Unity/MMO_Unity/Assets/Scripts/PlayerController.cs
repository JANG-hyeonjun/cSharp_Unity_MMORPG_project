using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//게임에서는 아래 두가지로 사용되어짐
//1.위치 벡터
//2.방향 벡터
struct MyVector
{
    public float x;
    public float y;
    public float z;
    //              +
    //       +      +
    // +------------+
    public float magnitude { get { return Mathf.Sqrt(x*x + y*y + z*z);}}
    public MyVector normalized { get { return new MyVector(x / magnitude, y / magnitude, z / magnitude); }}

    public MyVector(float x, float y, float z) { this.x = x; this.y = y; this.z = z;}

    public static MyVector operator +(MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    public static MyVector operator -(MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    public static MyVector operator *(MyVector a, float d)
    {
        return new MyVector(a.x * d, a.y * d, a.z * d);
    }
}

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;
    void Start()
    {
        MyVector to = new MyVector(10.0f, 0.0f, 0.0f);
        MyVector from = new MyVector(5.0f, 0.0f, 0.0f);
        MyVector dir = to - from; //(5.0f,0.0f,0.0f)
        //pos += new MyVector(0.0f, 2.0f, 0.0f);

        dir = dir.normalized; //(1.0f,0.0f,0.0f)

        MyVector newPos = from + dir * _speed;

        //방향벡터는 두가지 정보를 얻을 수 있는데
        // 1. 거리(크기) 5 magnitude
        // 2. 실제 방향 ->

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
