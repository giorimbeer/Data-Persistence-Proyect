using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System.IO;
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
        Singleton.Instance.name = inputName.text;
        print(inputName.text);
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
