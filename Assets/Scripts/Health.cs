using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    // Current Health
    [SerializeField]
    int cur = 5;

    public void doDamage(int n) {
        // Subtract damage from current health
        cur -= n;

        // Destroy if died
        if (cur <= 0) {
			if(gameObject.tag == "Plant") { 
				Grass.isFilled = false;
				Destroy (gameObject);
			}
			else {
				Destroy (gameObject);
			}
		}
    }
}