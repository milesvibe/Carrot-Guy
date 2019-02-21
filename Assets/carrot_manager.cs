using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrot_manager : MonoBehaviour
{
  public GameObject tap_area;
  // Start is called before the first frame update
  void Start()
  {
      Physics2D.IgnoreCollision(tap_area.GetComponent<BoxCollider2D>(), this.GetComponent<BoxCollider2D>());
      if (this.name == "Carrot-Sprite") //If this is the real carrot, don't fall.
      {
        this.GetComponent<Rigidbody2D>().isKinematic = true;
      }
      else //Otherwise clone
      {
        //DO YOUR HOMEWORK HERE <----------------------------------------------
        //If clone reaches some y value, destroy itself.
        
        this.GetComponent<Rigidbody2D>().isKinematic = false;
        
        
      }
  }

  // Update is called once per frame
  void Update()
  {
     
        if(this.transform.position.y <= -6.0f)
        {
          Destroy(this.gameObject);
        }
  }
}
