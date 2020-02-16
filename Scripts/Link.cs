using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Link : MonoBehaviour
{
    public void BTN(string Level)
    {
        SceneManager.LoadScene(Level);
    } 
}
