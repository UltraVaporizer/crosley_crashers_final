using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UpgradeHandler : MonoBehaviour
{

    public GameObject barrelParent;

    private void Awake()
    {
        if (StaticVars.barrel)
        {

        }
    }






    public void speedButton()
    {
        StaticVars.speed = true;
        resetScene();
    }

    public void warHeadButton() 
    {
        StaticVars.warhead = true;
        resetScene();
    }

    public void enedButton()
    {
        StaticVars.ened = true;
        resetScene();
    }

    public void barrelButton()
    {
        StaticVars.barrel = true;
        resetScene();
    }

    public void resetScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

}
