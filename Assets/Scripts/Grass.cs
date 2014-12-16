using UnityEngine;
using System.Collections;

public class Grass : MonoBehaviour {
	
	public bool isFilled = false;
	
	void OnMouseUpAsButton() {
		// Is there something to build?
		if (BuildMenu.cur != null && !isFilled) {
			// Build it
			Instantiate(BuildMenu.cur.gameObject, transform.position, Quaternion.identity);
			pokeballCollect.score -= BuildMenu.cur.price;
			BuildMenu.cur = null;
			isFilled = true;
		}
	}
}