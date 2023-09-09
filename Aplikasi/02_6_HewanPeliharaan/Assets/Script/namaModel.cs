using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class namaModel : MonoBehaviour
{
    public int ID;
    public static namaModel instance;

    public GameObject kucing;
    public GameObject anjing;
    public GameObject ayam;
    public GameObject burung;
    public GameObject ikan;
    public GameObject ikan2;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ID = 0;
    }

    public void gantiNama(bool kanan)
    {
        if (kanan)
        {
            ID++;
        }
        else
        {
            ID--;
        }

        if (ID == 6)
        {
            ID = 0;
        }
        else if (ID == -1)
        {
            ID = 5;
        }
        switch (ID)
        {
            case 0:
                kucing.SetActive(true);
                anjing.SetActive(false);
                ayam.SetActive(false);
                burung.SetActive(false);
                ikan.SetActive(false);
                ikan2.SetActive(false);
                break;
            case 1:
                kucing.SetActive(false);
                anjing.SetActive(true);
                ayam.SetActive(false);
                burung.SetActive(false);
                ikan.SetActive(false);
                ikan2.SetActive(false);
                break;
            case 2:
                kucing.SetActive(false);
                anjing.SetActive(false);
                ayam.SetActive(true);
                burung.SetActive(false);
                ikan.SetActive(false);
                ikan2.SetActive(false);
                break;
            case 3:
                kucing.SetActive(false);
                anjing.SetActive(false);
                ayam.SetActive(false);
                burung.SetActive(true);
                ikan.SetActive(false);
                ikan2.SetActive(false);
                break;
            case 4:
                kucing.SetActive(false);
                anjing.SetActive(false);
                ayam.SetActive(false);
                burung.SetActive(false);
                ikan.SetActive(true);
                ikan2.SetActive(false);
                break;
            case 5:
                kucing.SetActive(false);
                anjing.SetActive(false);
                ayam.SetActive(false);
                burung.SetActive(false);
                ikan.SetActive(false);
                ikan2.SetActive(true);
                break;
        }
    }
}
