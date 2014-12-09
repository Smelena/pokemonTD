using UnityEngine;
using System.Collections;

public class Grass : MonoBehaviour {

    void OnMouseUpAsButton() {
        // Is there something to build?
        if (BuildMenu.cur != null) {
            // Build it
            Instantiate(BuildMenu.cur.gameObject, transform.position, Quaternion.identity);
            SunCollect.score -= BuildMenu.cur.price;
            BuildMenu.cur = null;
        }
    }
}