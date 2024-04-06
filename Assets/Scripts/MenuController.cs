using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public void ApplicationQuit()
    {
        print("Hola");
        Application.Quit();
    }
    public void GoToScena()
    {
        SceneManager.LoadScene(1);
    }
}
