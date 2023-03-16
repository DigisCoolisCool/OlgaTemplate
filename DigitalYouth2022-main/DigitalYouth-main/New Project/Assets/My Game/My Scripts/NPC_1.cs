using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {
		Speech.AddDialogue("0","Hi! Traveller!","1");
		Speech.AddDialogue("1", "Welcome to our planet", "2");
		Speech.AddDialogue("2", "Our planet was destroyed by githotians", "3");
		Speech.AddDialogue("3", "Because of this, drought on our planet", "4");
		Speech.AddDialogue("4", "If you want you can help us", "5");
		Speech.AddDialogue("5", "I will be very grateful to you");
	}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other ){
		Speech.SetDialogue("0");
	}
}