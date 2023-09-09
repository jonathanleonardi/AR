using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class namaModel : MonoBehaviour
{
    public int ID;
    public static namaModel instance;

    public GameObject jam6;
    public GameObject jam9;
    public GameObject jam0;
    public GameObject jam3;


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
                jam6.SetActive(true);
                jam9.SetActive(false);
                jam0.SetActive(false);
                jam3.SetActive(false);
                break;
            case 1:
                jam6.SetActive(false);
                jam9.SetActive(true);
                jam0.SetActive(false);
                jam3.SetActive(false);
                break;
            case 2:
                jam6.SetActive(false);
                jam9.SetActive(false);
                jam0.SetActive(true);
                jam3.SetActive(false);
                break;
            case 3:
                jam6.SetActive(false);
                jam9.SetActive(false);
                jam0.SetActive(false);
                jam3.SetActive(true);
                break;
        }
    }

}
