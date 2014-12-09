using UnityEngine;
using System.Collections;

public class DefaultVelocity : MonoBehaviour {
    // The Velocity (can be set from Inspector)
    public Vector2 velocity;

    void FixedUpdate () {
        rigidbody2D.velocity = velocity;
    }
}
