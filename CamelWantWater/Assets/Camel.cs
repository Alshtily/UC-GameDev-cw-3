using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Camel : MonoBehaviour
{
    private void OnMouseDrag()
    {
        Vector2 mousePostion = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 newPos = Camera.main.ScreenToWorldPoint(mousePostion);
        transform.position = newPos;

        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(1);
    }





}
