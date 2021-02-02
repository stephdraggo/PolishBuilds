using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EscapeLoop : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#endif
            Application.Quit();
        }
    }
}
