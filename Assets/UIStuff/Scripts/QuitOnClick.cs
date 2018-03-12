using System.Collections;
using UnityEngine;

public class QuitOnClick : MonoBehaviour
{

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
