using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class squareMovement : MonoBehaviour
{

    public float velocity;
    public Rigidbody2D myRB;



    private float horizontal;
    private float vertical;

    // Start is called before the first frame update
    void Start()
    {
        velocity = 3.5f;
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        horizontal = 0;
        vertical = 0;

        if(UnityEngine.Input.GetKey(KeyCode.UpArrow) == true || UnityEngine.Input.GetKey(KeyCode.W) == true){vertical += velocity;}

        if(UnityEngine.Input.GetKey(KeyCode.DownArrow) == true || UnityEngine.Input.GetKey(KeyCode.S) == true){vertical -= velocity;}

        if(UnityEngine.Input.GetKey(KeyCode.RightArrow) == true || UnityEngine.Input.GetKey(KeyCode.D) == true){horizontal += velocity;}
        
        if(UnityEngine.Input.GetKey(KeyCode.LeftArrow) == true || UnityEngine.Input.GetKey(KeyCode.A) == true){horizontal -= velocity;}
        
        Vector2 vector = new Vector2(horizontal, vertical);
        myRB.velocity = vector;
        
        
    }

    
}
