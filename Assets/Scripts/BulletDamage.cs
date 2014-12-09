using UnityEngine;
using System.Collections;

public class BulletDamage : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D co) {
        // Zombie?
        if (co.tag == "Zombie") {
            // Deal Damage, destroy Bullet
            co.GetComponent<Health>().doDamage(1);
            Destroy(gameObject);
        }
    }
}
