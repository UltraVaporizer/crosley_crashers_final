using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private GameObject killPlane;
    public GameObject menu;
    public GameObject winScreen;
    private bool temp = false;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
        winScreen.SetActive(false);
        killPlane = GameObject.Find("KillPlane");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            temp = !temp;
            menu.SetActive(temp);
            if (temp)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        if(killPlane.GetComponent<KillPlanePointCounter>().pointCount >= 74000)
        {
            Cursor.lockState = CursorLockMode.None;
            winScreen.SetActive(true);
        }

    }
}
