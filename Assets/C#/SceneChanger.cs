using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadStage1()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void LoadStage2()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void LoadStage3()
    {
        SceneManager.LoadScene("Stage3");
    }

    public void LoadEnd()
    {
        SceneManager.LoadScene("End");
    }

    public void Exit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}
