using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class namaModel : MonoBehaviour
{
    public int ID;
    public static namaModel instance;

    public GameObject seratus;
    public GameObject duaratus;
    public GameObject limarauts;
    public GameObject seribu;
    public GameObject duaribu;
    public GameObject limaribu;
    public GameObject sepuluhribu;
    public GameObject duapuluhribu;
    public GameObject limapuluhribu;
    public GameObject seratusribu;


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

        if (ID == 10)
        {
            ID = 0;
        }
        else if (ID == -1)
        {
            ID = 9;
        }
        switch (ID)
        {
            case 0:
                seratus.SetActive(true);
                duaratus.SetActive(false);
                limarauts.SetActive(false);
                seribu.SetActive(false);
                duaribu.SetActive(false);
                limaribu.SetActive(false);
                sepuluhribu.SetActive(false);
                duapuluhribu.SetActive(false);
                limapuluhribu.SetActive(false);
                seratusribu.SetActive(false);
                break;
            case 1:
                seratus.SetActive(false);
                duaratus.SetActive(true);
                limarauts.SetActive(false);
                seribu.SetActive(false);
                duaribu.SetActive(false);
                limaribu.SetActive(false);
                sepuluhribu.SetActive(false);
                duapuluhribu.SetActive(false);
                limapuluhribu.SetActive(false);
                seratusribu.SetActive(false);
                break;
            case 2:
                seratus.SetActive(false);
                duaratus.SetActive(false);
                limarauts.SetActive(true);
                seribu.SetActive(false);
                duaribu.SetActive(false);
                limaribu.SetActive(false);
                sepuluhribu.SetActive(false);
                duapuluhribu.SetActive(false);
                limapuluhribu.SetActive(false);
                seratusribu.SetActive(false);
                break;
            case 3:
                seratus.SetActive(false);
                duaratus.SetActive(false);
                limarauts.SetActive(false);
                seribu.SetActive(true);
                duaribu.SetActive(false);
                limaribu.SetActive(false);
                sepuluhribu.SetActive(false);
                duapuluhribu.SetActive(false);
                limapuluhribu.SetActive(false);
                seratusribu.SetActive(false);
                break;
            case 4:
                seratus.SetActive(false);
                duaratus.SetActive(false);
                limarauts.SetActive(false);
                seribu.SetActive(false);
                duaribu.SetActive(true);
                limaribu.SetActive(false);
                sepuluhribu.SetActive(false);
                duapuluhribu.SetActive(false);
                limapuluhribu.SetActive(false);
                seratusribu.SetActive(false);
                break;
            case 5:
                seratus.SetActive(false);
                duaratus.SetActive(false);
                limarauts.SetActive(false);
                seribu.SetActive(false);
                duaribu.SetActive(false);
                limaribu.SetActive(true);
                sepuluhribu.SetActive(false);
                duapuluhribu.SetActive(false);
                limapuluhribu.SetActive(false);
                seratusribu.SetActive(false);
                break;
            case 6:
                seratus.SetActive(false);
                duaratus.SetActive(false);
                limarauts.SetActive(false);
                seribu.SetActive(false);
                duaribu.SetActive(false);
                limaribu.SetActive(false);
                sepuluhribu.SetActive(true);
                duapuluhribu.SetActive(false);
                limapuluhribu.SetActive(false);
                seratusribu.SetActive(false);
                break;
            case 7:
                seratus.SetActive(false);
                duaratus.SetActive(false);
                limarauts.SetActive(false);
                seribu.SetActive(false);
                duaribu.SetActive(false);
                limaribu.SetActive(false);
                sepuluhribu.SetActive(false);
                duapuluhribu.SetActive(true);
                limapuluhribu.SetActive(false);
                seratusribu.SetActive(false);
                break;
            case 8:
                seratus.SetActive(false);
                duaratus.SetActive(false);
                limarauts.SetActive(false);
                seribu.SetActive(false);
                duaribu.SetActive(false);
                limaribu.SetActive(false);
                sepuluhribu.SetActive(false);
                duapuluhribu.SetActive(false);
                limapuluhribu.SetActive(true);
                seratusribu.SetActive(false);
                break;
            case 9:
                seratus.SetActive(false);
                duaratus.SetActive(false);
                limarauts.SetActive(false);
                seribu.SetActive(false);
                duaribu.SetActive(false);
                limaribu.SetActive(false);
                sepuluhribu.SetActive(false);
                duapuluhribu.SetActive(false);
                limapuluhribu.SetActive(false);
                seratusribu.SetActive(true);
                break;
        }
    }

}
