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
        //Destroy(this.gameObject);
      }
  }

  // Update is called once per frame
  void Update()
  {
    
  }
}
