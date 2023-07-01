using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject Panel;
    bool PanelActivo = false;


    public void PanelOptions()
    {
        PanelActivo = !PanelActivo;
        Panel.SetActive(PanelActivo);
    
    }

    //Recuerden tener desactivado el panel desde el inicio
}
