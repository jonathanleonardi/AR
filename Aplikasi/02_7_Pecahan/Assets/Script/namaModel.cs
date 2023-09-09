using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class namaModel : MonoBehaviour
{
    public int ID;
    public static namaModel instance;

    public GameObject satu;
    public GameObject satuperdua;
    public GameObject satupertiga;
    public GameObject satuperempat;


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
                satu.SetActive(true);
                satuperdua.SetActive(false);
                satupertiga.SetActive(false);
                satuperempat.SetActive(false);
                break;
            case 1:
                satu.SetActive(false);
                satuperdua.SetActive(true);
                satupertiga.SetActive(false);
                satuperempat.SetActive(false);
                break;
            case 2:
                satu.SetActive(false);
                satuperdua.SetActive(false);
                satupertiga.SetActive(true);
                satuperempat.SetActive(false);
                break;
            case 3:
                satu.SetActive(false);
                satuperdua.SetActive(false);
                satupertiga.SetActive(false);
                satuperempat.SetActive(true);
                break;            
        }
    }

}
