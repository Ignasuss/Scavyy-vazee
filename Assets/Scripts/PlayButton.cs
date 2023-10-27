using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public string nextScene;

    public void OnMouseDown()
    {
        SceneManager.LoadScene(nextScene);
    }
}