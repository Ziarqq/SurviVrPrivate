using System.Collections;
using UnityEngine;
using UnityEditor;

public class QuitOnClick : MonoBehaviour
{

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
