using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementSistem : MonoBehaviour
{
    public static movementSistem instance;
    public int ID;
    public GameObject TempatSpawn;
    public GameObject GUI_Utama;
    public GameObject[] KoleksiModel;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ID = 0;
        GUI_Utama.SetActive(false);
        SpawnObject();
    }

    public void SpawnObject()
    {
        GameObject BendaSebelumnya = GameObject.FindGameObjectWithTag("Model");
        KoleksiModel[ID].SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GantiModel(true);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GantiModel(false);
        }
    }

    public void GantiModel(bool Kanan)
    {
        KoleksiModel[ID].SetActive(false);
        if (Kanan)
        {
            if (ID >= KoleksiModel.Length - 1)
            {
                ID = 0;
            }
            else
            {
                ID += 1;
            }
        }
        else
        {
            if (ID <= 0)
            {
                ID = KoleksiModel.Length - 1;
            }
            else
            {
                ID -= 1;
            }
        }

        SpawnObject();
    }
}
