using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventary : MonoBehaviour
{
    public GameObject Panel;
    bool PanelActivo = true;


    public void PanelInventary()
    {
        PanelActivo = !PanelActivo;
        Panel.SetActive(PanelActivo);
    
    }

    //Recuerden tener desactivado el panel desde el inicio
}
