using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    public GameObject Panel;
    bool PanelActivo = false;


    public void PanelNiveles()
    {
        PanelActivo = !PanelActivo;
        Panel.SetActive(PanelActivo);
    
    }

    //Recuerden tener desactivado el panel desde el inicio
}
