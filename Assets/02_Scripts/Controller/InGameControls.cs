using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InGameControls
{
    PlayerControls controls;
    public Camera cam;

    public Vector2 move;

    public Vector2 camMove;

    public void Init()
    {
        controls = new PlayerControls();

        controls.GamePlay.Check.performed += ctx => Check();
        controls.GamePlay.Cancel.performed += ctx => Cancel();
        controls.GamePlay.Triangle.performed += ctx => Triangle();
        controls.GamePlay.Square.performed += ctx => Square();

        controls.GamePlay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.GamePlay.Move.canceled += ctx => move = Vector2.zero;

        controls.GamePlay.RotateCam.performed += ctx => camMove = ctx.ReadValue<Vector2>();
        controls.GamePlay.RotateCam.canceled += ctx => camMove = Vector2.zero;

        controls.GamePlay.Option.performed += ctx => SwitchAction();
    }

    void Check()
    {
        Debug.Log("GamePlayMode : check");
    }

    void Cancel()
    {
        Debug.Log("GamePlayMode : Run");
    }

    void Triangle()
    {
        Debug.Log("GamePlayMode : Jump");
    }

    void Square()
    {
        Debug.Log("GamePlayMode : Attack");
    }

    void SwitchAction()
    {
        TotalController.Ins.OnOptionControls();
    }

    public void OnEnable()
    {
        controls.GamePlay.Enable();
    }

    public void OnDisable()
    {
        controls.GamePlay.Disable();
    }
}
