using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fungsi_Rotasi : MonoBehaviour
{
    public float Kecepatan;
    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(Kecepatan * 10 * Time.deltaTime, 0, 0);
        //transform.Rotate(0,Kecepatan * 10 * Time.deltaTime, 0);
        //transform.Rotate(0, 0, Kecepatan * 10 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Kecepatan * 10 * Time.deltaTime, 0, 0);
        //transform.Rotate(0,Kecepatan * 10 * Time.deltaTime, 0);
        transform.Rotate(0,0,Kecepatan * 10 * Time.deltaTime);
    }
}
