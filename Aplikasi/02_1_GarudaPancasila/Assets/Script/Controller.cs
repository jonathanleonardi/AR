using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject InfoPanel1;
    public GameObject InfoPanel2;
    public GameObject InfoPanel3;
    public GameObject InfoPanel4;
    public GameObject InfoPanel5;

    private bool show = false;

    public void ShowHideInfo1()
    {
        if (!show)
        {
            InfoPanel1.SetActive(true);
            show = true;
        }
        else
        {
            InfoPanel1.SetActive(false);
            show = false;
        }
    }

    public void ShowHideInfo2()
    {
        if (!show)
        {
            InfoPanel2.SetActive(true);
            show = true;
        }
        else
        {
            InfoPanel2.SetActive(false);
            show = false;
        }
    }

    public void ShowHideInfo3()
    {
        if (!show)
        {
            InfoPanel3.SetActive(true);
            show = true;
        }
        else
        {
            InfoPanel3.SetActive(false);
            show = false;
        }
    }

    public void ShowHideInfo4()
    {
        if (!show)
        {
            InfoPanel4.SetActive(true);
            show = true;
        }
        else
        {
            InfoPanel4.SetActive(false);
            show = false;
        }
    }

    public void ShowHideInfo5()
    {
        if (!show)
        {
            InfoPanel5.SetActive(true);
            show = true;
        }
        else
        {
            InfoPanel5.SetActive(false);
            show = false;
        }
    }
}
