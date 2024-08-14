using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationPanel : MonoBehaviour
{
    public GameObject infor;
    public GameObject infor1;
    public GameObject infor2;
    public GameObject infor3;
    public GameObject infor4;
    public GameObject infor5;
    public GameObject infor6;
    public GameObject infor7;
    public GameObject infor8;
    public GameObject removebutton;
    public GameObject removebutton1;
    public GameObject removebutton2;
    public GameObject removebutton3;
    public GameObject removebutton4;
    public GameObject removebutton5;
    public GameObject removebutton6;
    public GameObject removebutton7;
    public GameObject removebutton8;







    void DisablePanels()
    {
        infor.SetActive(false);
        infor1.SetActive(false);
        infor2.SetActive(false);
        infor3.SetActive(false);
        infor4.SetActive(false);
        infor5.SetActive(false);
        infor6.SetActive(false);
        infor7.SetActive(false);
        infor8.SetActive(false);
        removebutton.SetActive(false);
        removebutton1.SetActive(false);
        removebutton2.SetActive(false);
        removebutton3.SetActive(false);
        removebutton4.SetActive(false);
        removebutton5.SetActive(false);
        removebutton6.SetActive(false);
        removebutton7.SetActive(false);
        removebutton8.SetActive(false);

    }

    public void information()
    {
        DisablePanels();
        infor.SetActive(true);
        removebutton.SetActive(true);
    }

    public void information1()
    {
        DisablePanels();
        infor1.SetActive(true);
        removebutton1.SetActive(true);
    }

    public void information2()
    {
        DisablePanels();
        infor2.SetActive(true);
        removebutton2.SetActive(true);
    }

    public void information3()
    {
        DisablePanels();
        infor3.SetActive(true);
        removebutton3.SetActive(true);
    }

    public void information4()
    {
        DisablePanels();
        infor4.SetActive(true);
        removebutton4.SetActive(true);
    }

    public void information5()
    {
        DisablePanels();
        infor5.SetActive(true); 
        removebutton5.SetActive(true);
    }

    public void information6()
    {
        DisablePanels();
        infor6.SetActive(true);
        removebutton6.SetActive(true);
    }

    public void information7()
    {
        DisablePanels();
        infor7.SetActive(true);
        removebutton7.SetActive(true);
    }

    public void information8()
    {
        DisablePanels();
        infor8.SetActive(true);
        removebutton8.SetActive(true);
    }



}
