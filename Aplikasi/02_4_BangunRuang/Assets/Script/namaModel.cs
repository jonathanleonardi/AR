using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class namaModel : MonoBehaviour
{
    public int ID;
    public static namaModel instance;

    public GameObject kubus;
    public GameObject pspj;
    public GameObject prismasegi3;
    public GameObject tabung;
    public GameObject trapesium;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ID = 0;
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
        switch (ID)
        {
            case 0:
                kubus.SetActive(true);
                pspj.SetActive(false);
                prismasegi3.SetActive(false);
                tabung.SetActive(false);
                trapesium.SetActive(false);
                break;
            case 1:
                kubus.SetActive(false);
                pspj.SetActive(true);
                prismasegi3.SetActive(false);
                tabung.SetActive(false);
                trapesium.SetActive(false);
                break;
            case 2:
                kubus.SetActive(false);
                pspj.SetActive(false);
                prismasegi3.SetActive(true);
                tabung.SetActive(false);
                trapesium.SetActive(false);
                break;
            case 3:
                kubus.SetActive(false);
                pspj.SetActive(false);
                prismasegi3.SetActive(false);
                tabung.SetActive(true);
                trapesium.SetActive(false);
                break;
            case 4:
                kubus.SetActive(false);
                pspj.SetActive(false);
                prismasegi3.SetActive(false);
                tabung.SetActive(false);
                trapesium.SetActive(true);
                break;
        }
    }

}
