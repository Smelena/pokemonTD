using UnityEngine;
using System.Collections;

public class SunSpawn : MonoBehaviour {
    public GameObject prefab;

    // Use this for initialization
    void Start() {
        // Spawn first pokeball in 10 seconds, repeat every 10 seconds
        InvokeRepeating("Spawn", 18, 18);
    }
    
    void Spawn() {
        // Load prefab into the Scene
        // -> transform.position means current position
        // -> Quaternion.identity means default rotation
        Instantiate(prefab,
                    transform.position,
                    Quaternion.identity);
    }
}