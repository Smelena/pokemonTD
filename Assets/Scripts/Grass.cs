using UnityEngine;
using System.Collections;

public class Grass : MonoBehaviour {
	
	public bool isFilled = false;
	
	void OnMouseUpAsButton() {
		// Is there something to build?
		if (BuildMenu.cur != null) {
			// Build it
			Vector3 pos = transform.position;
			//don't do anything if already filled
			if(GrassCellFill.getPostionList().Contains(pos)) {	
				return;
			}
			Instantiate(BuildMenu.cur.gameObject, pos, Quaternion.identity);
			GrassCellFill.addPosition(pos);
			SunCollect.score -= BuildMenu.cur.price;
			BuildMenu.cur = null;
		}

	}
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "Trainer") {
			Destroy (coll.gameObject, 2f);
		}
	}
}