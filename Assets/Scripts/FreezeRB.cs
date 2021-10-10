using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeRB : MonoBehaviour
{
    public LayerMask lm;
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        colliding(collision.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        colliding(collision.gameObject);
    }

    private void OnCollisionExit(Collision collision)
    {
        colliding(collision.gameObject);
    }

    private void colliding(GameObject collision)
    {
        if (collision.gameObject.layer == 3)
        {
            rb.isKinematic = false;
        }
        try
        {
            if (!collision.gameObject.GetComponent<Rigidbody>().isKinematic && (collision.layer <= gameObject.layer))
            {

                //Debug.Log($"My layer: {gameObject.layer} His Layer: {collision.layer}");
                rb.isKinematic = false;

            }
        }
        catch { }
    
    }
}

