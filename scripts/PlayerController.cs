using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 10.5f );
        if ( Input.GetKey( KeyCode.A ))
            {
                transform.Translate(-0.1f, 0, 0);
                transform.Rotate(0, -0.75f, 0);
            }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0, 0);
            transform.Rotate(0, 0.75f, 0, 0);
        }
    }
}
