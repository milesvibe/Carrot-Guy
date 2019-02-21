using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap_manager : MonoBehaviour {

  public score_manager score_manager_object;          //reference to score manager class
  public UnityEngine.GameObject carrot_sprite, clone; // calls upon the gods to set up an empty variable
  public Transform Left_Boundary;                     //this is the leftest side that can be done
  public Transform Right_Boundary;                    //this sets the rightmost boundary	
  public float y_spawn;
  public int cost_to_upgrade = 1;                     //TODO: Implement exponential cost to upgrade
  void Start () {
    y_spawn = carrot_sprite.transform.position.y;
   }
	
	// Update is called once per frame
	void Update () {
		
	}
    
  public void upgrade()                                         //increse carrots per tap by cost of 2 for price of 1 
  {
      if (score_manager_object.totalCarrots >= cost_to_upgrade)
      { 
          score_manager_object.carrotsPerTap += 2;              //upgrades carrotsPerTap by 2 by accesing score manager object
          score_manager_object.totalCarrots -= cost_to_upgrade; //removing 1
      }
  }
    
    
  private void OnMouseDown() //when you click it do
  {
    Clone_Carrot();
  }
  void Clone_Carrot()
  {
    Debug.Log("YEET");
    clone = Instantiate(carrot_sprite); //creates another carrot yeet
    float x_spawn = Random.Range(Left_Boundary.transform.position.x, Right_Boundary.transform.position.x);
    clone.transform.position = new Vector3(x_spawn, y_spawn, 0);
  }
}
