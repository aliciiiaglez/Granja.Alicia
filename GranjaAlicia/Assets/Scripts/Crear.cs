using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear : MonoBehaviour
{
   public void 
    void Update()
    {
       if(Input.GetMouseButtonUp(0))
       {
        gameObject.SetActive(false);
        controller.SalirModoCreacion();
       }
       else
       {
        Ray rayo = Camera.main.ScreenPointToRay(Input.MousePosition);
        RaycastHit hitInfo;
        if(Physics.Raycast(rayo, out hitInfo) == true)
        {
            if(Input.GetMouseButtonDown(0))
            {
                objetoRecienCreado = Instantiate(objetoACrear);
                objetoRecienCreado.transform.position = hitInfo.point + Vector3.up / 2;
            }
            else if
            {
                objetoRecienCreado.transform.position = hitInfo.point +Vector3.up / 2;
            }   
        }
       }
        
    

    }
}
