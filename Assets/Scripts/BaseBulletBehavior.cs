using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBulletBehavior : MonoBehaviour
{
    private void OnCollisionExit(Collision collision)
    {
        Destroy(gameObject);
    }
}
