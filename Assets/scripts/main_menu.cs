using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("cutscene");// в кавычках название сцены на которую осуществляется переход
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
