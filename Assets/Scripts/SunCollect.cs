using UnityEngine;
using System.Collections;

public class SunCollect : MonoBehaviour {
    // Global score
    public static int score = 5;

    void OnMouseDown() {
        // Increase Score
        score += 1;

        // Destroy Sun
        Destroy(gameObject);
    }
	void OnBecameInvisible() {
		Destroy( gameObject ); 
	}
}