using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class touchfield : MonoBehaviour
{
    public Joystick lookJoystick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(lookJoystick.Horizontal*100, lookJoystick.Vertical*100, 0));
    }
}
