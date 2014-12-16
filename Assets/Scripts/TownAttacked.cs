using UnityEngine;
using System.Collections;

public class TownAttacked : MonoBehaviour {

	bool showGameOver = false;

	void OnCollisionStay2D(Collision2D coll) {
		// Collided with a enemypoke?
		if (coll.gameObject.tag == "Zombie") {
			showGameOver = true;
		}
	}

	void OnGUI(){
		if (showGameOver){
			Time.timeScale = 0;
			GUI.Window(0, new Rect((Screen.width/2)-150, (Screen.height/2)-100
			                       , 300, 250), ShowGUI, "GAME OVER");		
		}
	}
	
	void ShowGUI(int windowID){
		// You may put a label to show a message to the player
		
		GUI.Label(new Rect(65, 40, 200, 80), "OH NO! The evil Pokemon have taken over!");
		
		// You may put a button to close the pop up too
		
		if (GUI.Button(new Rect(50, 150, 75, 30), "Quit")){
			showGameOver = false;
			Application.Quit();
			// you may put other code to run according to your game too
		}
		
	}
}
