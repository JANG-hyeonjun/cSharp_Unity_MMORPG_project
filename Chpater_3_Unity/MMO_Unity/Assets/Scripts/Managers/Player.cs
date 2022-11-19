using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameObject go = GameObject.Find("@Managers");
        //Managers mg = go.GetComponent<Managers>();
        //이건 썩 좋은 방법이 아니다. 왜냐면 이름으로 오브젝트를 찾는것은 자주 사용하면 안되는 방법

        Managers mg = Managers.Instance;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
