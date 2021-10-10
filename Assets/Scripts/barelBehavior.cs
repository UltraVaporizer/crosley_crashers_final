using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barelBehavior : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        try
        {
            if ((collision.gameObject.layer == 3 || collision.gameObject.layer >= 6) && !collision.gameObject.GetComponent<Rigidbody>().isKinematic)
            {
                var gamer = Physics.SphereCastAll(transform.position, 5f, Vector3.up, -1);
                foreach (RaycastHit hit in gamer)
                {
                    hit.transform.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                    hit.transform.gameObject.GetComponent<Rigidbody>().AddExplosionForce(250f, transform.position, 5f);
                    Debug.Log("kaboom");
                    Destroy(hit.transform.gameObject);
                }
            }
        }
        catch { }
    }
}
