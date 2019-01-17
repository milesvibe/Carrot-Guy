using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Face_Mover : MonoBehaviour {
    public Transform Left_Boundary;     //this is the leftest side that can be done
    public Transform Right_Boundary;    //this sets the rightmost boundary
    public int SpriteWalkSpeed;         //THis 
    public bool bounce = false;
    // Use this for initialization
    void Start () {
		
	}
    void Movement()
    {
        if (bounce == false)
        {
            if (gameObject.activeSelf && transform.position.x > Left_Boundary.position.x)
            {
                transform.Translate(Vector2.up * SpriteWalkSpeed * Time.deltaTime);
                
            }
            if (gameObject.activeSelf && transform.position.x <= Left_Boundary.position.x)
            {
                bounce = true;
            }
        } else {
            if (gameObject.activeSelf && transform.position.x < Right_Boundary.position.x)
            {
                transform.Translate(Vector2.down * SpriteWalkSpeed * Time.deltaTime);
            }
            if (gameObject.activeSelf && transform.position.x >= Right_Boundary.position.x)
            {
                bounce = false;
            }
        }

    }

	// Update is called once per frame
	void Update () {
        Movement();
	}
   
}
