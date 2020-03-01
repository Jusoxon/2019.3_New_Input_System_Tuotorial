using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamRotater : MonoBehaviour
{
    public CinemachineFreeLook freeLookCam;


    void Update()
    {
        Vector2 camRotate = new Vector2(TotalController.Ins.inGameControls.camMove.x, TotalController.Ins.inGameControls.camMove.y);
        freeLookCam.m_XAxis.m_InputAxisValue = -camRotate.x;
        freeLookCam.m_YAxis.m_InputAxisValue = camRotate.y;
    }
}
