using UnityEngine;
using System.Collections;

public class Firing : MonoBehaviour {
    // The Bullet Prefab
    public GameObject bulletPrefab;

    // Shooting Interval
    public float interval = 0.5f;

    // Use this for initialization
    void Start () {
        // Try to shoot every few seconds
        InvokeRepeating("Shoot", 0, interval);
    }

    bool zombieInFront() {
        // Raycast from the right of the game to the plant
        Vector2 origin = new Vector2(9.5f, transform.position.y);
        RaycastHit2D[] hits = Physics2D.RaycastAll(origin, -Vector2.right);

        // Find out if any Zombie was hit
        foreach (RaycastHit2D hit in hits) {
            if (hit.collider != null &&
                hit.collider.gameObject.tag == "Zombie")
                return true;
        }
        return false;
    }
    
    void Shoot() {
        if (zombieInFront()) {
            // Animation
            GetComponent<Animator>().SetTrigger("IsFiring");

            // Instantiate Bullet
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}