using UnityEngine;
using System.Collections;

public class Firing : MonoBehaviour {
    // The Bullet Prefab

    public GameObject bulletPrefab;

    // Shooting Interval
    public float interval = 1000;

    // Use this for initialization
    void Start () {
        // Try to shoot every few seconds
        InvokeRepeating("Shoot", 1, interval);
    }

    bool enemypokeInFront() {
        // Raycast from the right of the game to the pokeball
        Vector2 origin = new Vector2(9.5f, transform.position.y);
        RaycastHit2D[] hits = Physics2D.RaycastAll(origin, -Vector2.right);

        // Find out if any enemypoke was hit
        foreach (RaycastHit2D hit in hits) {
            if (hit.collider != null &&
                hit.collider.gameObject.tag == "Zombie")
                return true;
        }
        return false;
    }
    
    void Shoot() {
        if (enemypokeInFront()) {
            // Animation
            GetComponent<Animator>().SetTrigger("IsFiring");

            // Instantiate Bullet
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}