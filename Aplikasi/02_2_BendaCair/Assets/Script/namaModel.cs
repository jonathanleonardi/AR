using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class namaModel : MonoBehaviour
{
    public int ID;
    public static namaModel instance;

    public GameObject teh;
    public GameObject air_putih;
    public GameObject susu;
    public GameObject santan;


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

        if (ID == 4)
        {
            ID = 0;
        }
        else if (ID == -1)
        {
            ID = 3;
        }
        switch (ID)
        {
            case 0:
                teh.SetActive(true);
                air_putih.SetActive(false);
                susu.SetActive(false);
                santan.SetActive(false);
                break;
            case 1:
                teh.SetActive(false);
                air_putih.SetActive(true);
                susu.SetActive(false);
                santan.SetActive(false);
                break;
            case 2:
                teh.SetActive(false);
                air_putih.SetActive(false);
                susu.SetActive(true);
                santan.SetActive(false);
                break;
            case 3:
                teh.SetActive(false);
                air_putih.SetActive(false);
                susu.SetActive(false);
                santan.SetActive(true);
                break;
        }
    }

}
