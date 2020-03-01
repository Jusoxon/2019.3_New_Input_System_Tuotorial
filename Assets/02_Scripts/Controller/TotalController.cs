using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public enum ControlMode
{
    InGame,
    Option,
    Dialog,

    End
}

public class TotalController : MonoBehaviour
{
    #region SINGLETON
    static TotalController _instance = null;
    public static TotalController Ins
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(TotalController)) as TotalController;
                if (_instance == null)
                {
                    _instance = new GameObject("TotalController", typeof(TotalController)).GetComponent<TotalController>();
                }
            }
            return _instance;
        }
    }
    #endregion

    public ControlMode controlMode;
    public InGameControls inGameControls;
    public OptionControls optionControls;

    private void Awake()
    {
        inGameControls = new InGameControls();
        optionControls = new OptionControls();

        inGameControls.Init();
        optionControls.Init();

        OnInGameControls();
    }

    public void OnInGameControls()
    {
        controlMode = ControlMode.InGame;
        inGameControls.OnEnable();
        optionControls.OnDisable();
    }

    public void OnOptionControls()
    {
        controlMode = ControlMode.Option;
        inGameControls.OnDisable();
        optionControls.OnEnable();
    }
}
