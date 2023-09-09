using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float SpeedRotation;
    // Start is called before the first frame update
    void Start()
    {
        // transform.Rotate(0, SpeedRotation * 10 * Time.deltaTime, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(SpeedRotation * 10 * Time.deltaTime, 0, 0);
        //transform.Rotate(0,SpeedRotation * 10 * Time.deltaTime, 0);
        transform.Rotate(0, 0, SpeedRotation * 10 * Time.deltaTime);
    }
}
