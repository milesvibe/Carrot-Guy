using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_manager : MonoBehaviour {
    public UnityEngine.UI.Text totalCarrotsDisplay; //variable for text object
    public int totalCarrots = 0; //variable for score
    public int carrotsPerTap = 5; //variable for tap quantity

	// Use this for initialization
	void Start () {
        Debug.Log(totalCarrots); //how we'llprint to the console to check values
	}
	
	// Update is called once per frame
	void Update () {
        if (totalCarrots == 100) //reward for completing 100
        {
            totalCarrots = 120; // reward :)

        }
        totalCarrotsDisplay.text = totalCarrots.ToString(); //where we set the text
	}
    public void onClick()
    {
        totalCarrots = totalCarrots + carrotsPerTap; //Increase totalCarrot variable by 1
        Debug.Log(totalCarrots); // Debug totalCarrots to console
    }

    public void upgrade() //increse carrots per tap by cost of 2 for price of 1 
    {
        carrotsPerTap = carrotsPerTap + 2; //upgrade time
    }
}


    //public int upgradeCarrots = totalCarrot






