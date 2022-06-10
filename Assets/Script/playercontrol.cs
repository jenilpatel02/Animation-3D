using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class playercontrol : MonoBehaviour
{
    public Animator animator;
    private float speed;
    private float turningspeed;
    private Rigidbody rb;   
    public VariableJoystick joystick;
    public Joystick camerajoystick;
    public CinemachineFreeLook freecamera;
   
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>(); 
    }
    public void jump()
    {
        animator.SetTrigger("jump");
    }
       public void kick()
    {
        animator.SetTrigger("kick");
    }
     // Update is called once per frame
    void Update()
    {
        freecamera.m_XAxis.Value += camerajoystick.Direction.x*10;
        freecamera.m_XAxis.Value -= camerajoystick.Direction.y/100;
        var h = joystick.Horizontal;
        var v = joystick.Vertical   ;
        animator.SetFloat("speed", v);
        animator.SetFloat("turningspeed", h);
     }
}
