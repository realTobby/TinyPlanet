using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public float rotationalSpeed = 5f;

    // Update is called once per frame
    void Update()
    {

        this.transform.RotateAround(Vector3.zero, Vector3.down, rotationalSpeed * Time.deltaTime);


    }
}
