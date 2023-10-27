using UnityEngine;

public class OOPS : MonoBehaviour
{
    public AudioSource audioSource; 

    void Start()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
