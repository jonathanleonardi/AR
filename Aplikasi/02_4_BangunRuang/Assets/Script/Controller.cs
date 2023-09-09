using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject[] InfoPanel;
    public GameObject[] showHideName;

    private bool show = false;
    public int ID;

    public void ShowHideInfo()
    {
        if (!show)
        {
            InfoPanel[ID].SetActive(true);
            showHideName[ID].SetActive(false);
            show = true;
        }
        else
        {
            InfoPanel[ID].SetActive(false);
            showHideName[ID].SetActive(true);
            show = false;
        }
    }

    public void ganti(bool kanan)
    {
        if (kanan)
        {
            ID++;
        }
        else
        {
            ID--;
        }

        if (ID == 5)
        {
            ID = 0;
        }
        else if (ID == -1)
        {
            ID = 4;
        }
    }
}