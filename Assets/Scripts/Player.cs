using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float maxSpeed = 200;
    
    private void Update()
    {
        

        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        var finalPosition = Vector3.MoveTowards(transform.position, mousePos, maxSpeed * Time.deltaTime);
        GetComponent<Rigidbody2D>().MovePosition(finalPosition);

    }
}
