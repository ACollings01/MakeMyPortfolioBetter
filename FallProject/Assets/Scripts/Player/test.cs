using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    protected Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector2(joystick.Horizontal * 10.0f, rigidbody.velocity.y);
    }
}
