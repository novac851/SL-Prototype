using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EscPanel : MonoBehaviour
{
    
    public GameObject panelinventory;
    public GameObject panelsetting;
    public GameObject panelquit;

    
    public GameObject lineinventory;
    public GameObject linesetting;
    public GameObject linequit;


    void DisablePanels()
    {
        
        panelinventory.SetActive(false);
        panelsetting.SetActive(false);
        panelquit.SetActive(false);
        
        lineinventory.SetActive(false);
        linesetting.SetActive(false);
        linequit.SetActive(false);

    }



    public void OpenPanelInventory()
    {
        DisablePanels();
        panelinventory.SetActive(true);
        lineinventory.SetActive(true);

    }

    public void OpenPanelSetting()
    {
        DisablePanels();
        panelsetting.SetActive(true);
        linesetting.SetActive(true);
    }

    public void OpenPanelQuit()
    {
        DisablePanels();
        panelquit.SetActive(true);
        linequit.SetActive(true);
    }

}
