using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util
{
    //이걸 왜 만드냐면 GetComponentsInChildren 이나 GetChild를 쓰는데 찾는 T가 Monobehavior나 Componet의 서브클래스여야 하는데 GameObject는 서브 클래스가 아니다.
    
    public static T GetOrAddComponent<T>(GameObject go) where T : UnityEngine.Component
    {
        T component = go.GetComponent<T>();
        if (component == null)
            component = go.AddComponent<T>();

        return component;
    }
    
    public static GameObject FindChild(GameObject go, string name = null, bool recursive = false) 
    {
        Transform transform = FindChild<Transform>(go, name, recursive);
        if (transform == null)
            return null;
        return transform.gameObject;
    }
    public static T FindChild<T>(GameObject go, string name = null, bool recursive = false) where T : UnityEngine.Object
    {
        if (go == null)
            return null;

        if(recursive == false)
        {
            for(int i = 0; i < go.transform.childCount; i++)
            {
                Transform transforms = go.transform.GetChild(i);
                if (string.IsNullOrEmpty(name) || transforms.name == name)
                {
                    T component = transforms.GetComponent<T>();
                    if (component != null)
                        return component;
                }
            }
        }
        else
        {
            foreach(T component in go.GetComponentsInChildren<T>())
            {
                if (string.IsNullOrEmpty(name) || component.name == name)
                    return component;
            }
        }

        return null;
    }
}
