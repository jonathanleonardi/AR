using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nama : MonoBehaviour
{
    public int ID;
    public static Nama instance;

    public GameObject kursi;
    public GameObject meja;
    public GameObject mobil;
    public GameObject televisi;
    public GameObject vas_bunga;


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
        else {
            ID--;
        }
        
        if (ID == 5) {
            ID = 0;
        }
        else if(ID == -1){
            ID = 4;
        }
        switch (ID){
            case 0:
                kursi.SetActive(true);
                meja.SetActive(false);
                mobil.SetActive(false);
                televisi.SetActive(false);
                vas_bunga.SetActive(false);
                break;
            case 1:
                kursi.SetActive(false);
                meja.SetActive(true);
                mobil.SetActive(false);
                televisi.SetActive(false);
                vas_bunga.SetActive(false);
                break;
            case 2:
                kursi.SetActive(false);
                meja.SetActive(false);
                mobil.SetActive(true);
                televisi.SetActive(false);
                vas_bunga.SetActive(false);
                break;
            case 3:
                kursi.SetActive(false);
                meja.SetActive(false);
                mobil.SetActive(false);
                televisi.SetActive(true);
                vas_bunga.SetActive(false);
                break;
            case 4:
                kursi.SetActive(false);
                meja.SetActive(false);
                mobil.SetActive(false);
                televisi.SetActive(false);
                vas_bunga.SetActive(true);
                break;
        }
    }

}
