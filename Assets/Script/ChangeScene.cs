using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void changeToMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void changeToCarpentryTrain()
    {
        SceneManager.LoadScene(2);
    }

    public void changeToCarpentryCut()
    {
        SceneManager.LoadScene(3);
    }
}
