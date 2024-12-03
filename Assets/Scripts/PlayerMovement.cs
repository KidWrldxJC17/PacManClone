using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        //This line moves character to position 0,0 at the start of the game
        transform.position = new Vector2(0,0);
        Debug.Log("New Position!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)(direction * speed * Time.deltaTime);

        direction = new Vector2(0, 0);
        switch(true) 
        {
            case bool _ when Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow):
                direction = Vector2.right;
                //Debug.Log("Its allll RIGHT!");
                break;
            case bool _ when Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow):
                direction = Vector2.left;
                //Debug.Log("Its allll LEFT!");
                break;
            case bool _ when Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow):
                direction = Vector2.down;
                //Debug.Log("Its allll DOWN from here!");
                break;
            case bool _ when Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow):
                direction = Vector2.up;
                //Debug.Log("Its allll UP from here!");
                break;

        }
    }
}
