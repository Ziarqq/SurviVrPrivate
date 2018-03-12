using UnityEngine;
using System.Collections;

public class ObjToggler : MonoBehaviour
{
    void Start()
    {
        
    }
    public void DisableObject(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
    public void EnableObject(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }
}