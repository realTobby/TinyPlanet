using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >= 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector2 TouchDirection = Input.GetTouch(0).deltaPosition;
                this.transform.RotateAround(Vector3.zero, new Vector3(-TouchDirection.y * Time.deltaTime, -TouchDirection.x * Time.deltaTime, 0), 1.5f);
                this.transform.LookAt(Vector3.zero);
                
            }
        }
        
    }
}
