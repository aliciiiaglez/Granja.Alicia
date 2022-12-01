using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCam : MonoBehaviour
{
    Vector3 oldMousePosition;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            FuncionMoverCamara();
        }
        oldMousePosition = Input.mousePosition;

        void FuncionMoverCamara()
        {
            Vector3 deltaPos = oldMousePosition - Input.mousePosition;
            Camera.main.transform.position += new Vector3(deltaPos.x, 0.0f, deltaPos.y)
        }

    }
}
