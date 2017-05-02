using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleFollowPlayer : MonoBehaviour {

    public Rigidbody2D rb;
    private Vector3 v3Velocity;
    private ParticleSystem.VelocityOverLifetimeModule particleVelocity;
    //private ParticleSystem.MinMaxCurve rate = new ParticleSystem.MinMaxCurve();

    void Start () {       
        particleVelocity = GetComponent<ParticleSystem>().velocityOverLifetime;          
    }

    void ParticleMovement()
    {        
        particleVelocity.x = v3Velocity.x * 0.3f;
        particleVelocity.y = v3Velocity.y * 0.3f;
    }

    void Update () {
        v3Velocity = rb.velocity;
        ParticleMovement();
    }
}
