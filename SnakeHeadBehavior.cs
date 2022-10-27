using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHeadBehavior : MonoBehaviour
{
    
    public string direction;
    void Start()
    {
        direction = "Right";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && direction!="Left")
        {
            transform.position += new Vector3(-1, 0, 0);
            direction = "Left";
            direction = "Left";
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && direction!="Right")
        {
            transform.position += new Vector3(1, 0, 0);
            direction = "Right";
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && direction!="Up")
        {
            transform.position += new Vector3(0, 1, 0);
            direction = "Up";
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && direction!="Down")
        {
            transform.position += new Vector3(0, -1, 0);
            direction = "Down";
        } 
        else if (Time.frameCount % 100 == 0)
        {
            switch (direction)
            {
                case "Right": transform.position += new Vector3(1, 0, 0);
                    break;
                case "Left": transform.position += new Vector3(-1, 0, 0);
                    break;
                case "Up": transform.position += new Vector3(0, 1, 0);
                    break;
                case "Down": transform.position += new Vector3(0, -1, 0);
                    break;
            }
        }
    }
}
