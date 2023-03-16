using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public int coin;
	

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start() 
	{
	 
	}

	// OnTriggerEnter is called when the Collider "collided" enters the trigger.
	protected void OnTriggerEnter(Collider collided) {

		// Check for collision with coins
		if (collided.gameObject.tag == "Coin") {  
			
			Destroy(collided.gameObject);
			coin++;
			HUD.UpdateCoinCount(coin);
			HUD.Message("You got coin!");
		}


		if (collided.gameObject.name == "Powerup1")
		{
			Destroy(collided.gameObject);
			Abilities.doubleJumpEnabled = true;
			HUD.Message("You got powerup! You can jump higher!");
		}


		if (collided.gameObject.name == "Powerup2")
        {
			Destroy(collided.gameObject);
			Abilities.spinAttackEnabled = true;
			HUD.Message("You got SPINATTACK! You can use new attack!");


        }



        }
			
	}