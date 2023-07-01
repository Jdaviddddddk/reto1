using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config : MonoBehaviour
{
    public GameObject Panel;
    bool PanelActivo = false;


    public void PanelConfig()
    {
        PanelActivo = !PanelActivo;
        Panel.SetActive(PanelActivo);
    
    }

    //Recuerden tener desactivado el panel desde el inicio
}
