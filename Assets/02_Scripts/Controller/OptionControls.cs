using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OptionControls
{
    PlayerControls controls;
    public void Init()
    {
        controls = new PlayerControls();

        controls.OptionMode.Circle.performed += ctx => Check();
        controls.OptionMode.Cross.performed += ctx => Cancel();
        controls.OptionMode.Triangle.performed += ctx => Triangle();
        controls.OptionMode.Square.performed += ctx => Square();

        controls.OptionMode.Option.performed += ctx => SwitchAction();
    }

    void Check()
    {
        Debug.Log("OptionMode : check");
    }

    void Cancel()
    {
        Debug.Log("OptionMode : Run");
    }

    void Triangle()
    {
        Debug.Log("OptionMode : Jump");
    }

    void Square()
    {
        Debug.Log("OptionMode : Attack");
    }

    void SwitchAction()
    {
        TotalController.Ins.OnInGameControls();
    }

    public void OnEnable()
    {
        controls.OptionMode.Enable();
    }

    public void OnDisable()
    {
        controls.OptionMode.Disable();
    }
}
