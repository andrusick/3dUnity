using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Car;
    
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Car.transform.position + new Vector3(0.5f, 6.76f, -22.2f);
    }
}
