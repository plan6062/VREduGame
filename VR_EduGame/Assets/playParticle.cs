using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playParticle : MonoBehaviour
{
    public new ParticleSystem particleSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trash")
        {
            Debug.Log("Trigger entered");
            particleSystem.Play();
            Destroy(other.gameObject);
        }
    }
}