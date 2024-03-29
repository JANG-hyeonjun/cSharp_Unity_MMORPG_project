﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager
{
    public Action KeyAction = null;
    public Action<Define.MouseEvent> MouseAction = null;

    bool _pressed = false;
    
    public void OnUpdate()
    {
        if (EventSystem.current.IsPointerOverGameObject()) // 지금 UI 버튼이 클릭 되었는지 알 수 있다.
            return;

        if (Input.anyKey && KeyAction != null)
            KeyAction.Invoke();
        
        if(Input.GetMouseButton(0))
        {
            MouseAction.Invoke(Define.MouseEvent.Press);
            _pressed = true;
        }
        else
        {
            if (_pressed)
                MouseAction.Invoke(Define.MouseEvent.Click);

            _pressed = false;
        }
    }
}
