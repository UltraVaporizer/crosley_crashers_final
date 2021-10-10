using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillPlanePointCounter : MonoBehaviour
{
    public int pointCount = 0;
    public int basePoint = 100;
    public Text scoreText;

    private void Start()
    {
        scoreText.text = "0";
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 3) { }//Check if we're deleting a bullet}
        else
        {
            pointCount += (Mathf.Abs(collision.gameObject.layer-14)*basePoint);
            scoreText.text = ""+pointCount;
        }
        Destroy(collision.gameObject);
    }

}
