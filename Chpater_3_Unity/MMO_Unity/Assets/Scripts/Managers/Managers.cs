using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; //유일성이 보장된다.
    static Managers Instance { get { init(); return s_instance; }} //유일한 매니저를 갖고 온다. 개선
    //public static Managers GetInstance() { init(); return s_instance; } //유일한 매니저를 갖고 온다.
    InputManager _input = new InputManager();
    public static InputManager Input { get { return Instance._input; }}

    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    // Update is called once per frame
    void Update()
    {
        _input.OnUpdate();   
    }
    
    static void init()
    {
        if(s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if(go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }
            //근데 이 object 더이상 삭제 추가 되면 안되니까
            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }
        // 초기화 
        //instance = this; //누군가는 인스턴스를 만들어 주어야 하니 
        //GameObject go = GameObject.Find("@Managers");
        //Managers mg = go.GetComponent<Managers>();
        //하이러라키 뷰에서 @Managers가 없다면 instance가 널이 된다. 그러면 여기서 이걸 사용하면 
        //크래쉬가 일어난다. 
    }

}

