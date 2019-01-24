using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_if_collide_with_face : MonoBehaviour
{
    public GameObject face;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x <= face.transform.position.x+5 || this.transform.position.x >= face.transform.position.x+5)
        {
            Destroy(this);
        }
        if (this.transform.position.y <= face.transform.position.y + 5 || this.transform.position.y >= face.transform.position.y + 5)
        {
            Destroy(this);
        }
        //check if carrot's transform.position.x is within 5 units of face.transform.position.x
        //carrot's transform.position.x can be accessed with:
        //  this.transform.position
        //check if carrot's transform.position.y is within 5 units of face.transform.position.y
        if (face.transform.position == this.transform.position)
        {
            Destroy(this);
        }
    }
}
