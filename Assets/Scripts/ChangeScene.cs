using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;

public class ChangeScene : MonoBehaviour
{
    public TMP_InputField inputName;
    public void Menu()
    {
        
        SceneManager.LoadScene(0);
    }

    public void Main()
    {
        Singleton.Instance.nameActual = inputName.text;
        if (Singleton.Instance.nameActual == "") Singleton.Instance.nameActual = "default name";
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }
}
