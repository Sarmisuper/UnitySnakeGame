using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SnakeHeadBehavior : MonoBehaviour
{
    
    public string direction;
    public bool isQueuedAction;
    public float screenHeight;
    public float screenWidth;
    
    void Start()
    {
        direction = "Right";
        isQueuedAction = false;
        screenHeight = Camera.main.GameObject().GetComponent<CameraScript>().Height;
        screenWidth = Camera.main.GameObject().GetComponent<CameraScript>().Width;
    }

    void Update()
    {
        if (!isQueuedAction)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && direction != "Left" && direction != "Right")
            {
                direction = "Left";
                isQueuedAction = true;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && direction != "Right" && direction != "Left")
            {
                direction = "Right";
                isQueuedAction = true;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow) && direction != "Up" && direction != "Down")
            {
                direction = "Up";
                isQueuedAction = true;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && direction != "Down" && direction != "Up")
            {
                direction = "Down";
                isQueuedAction = true;
            }
        }
        
        if (Time.frameCount % 150 == 0)
        {
            switch (direction)
            {
                case "Right":
                    if (transform.position.x == screenWidth-0.5)
                    {
                        transform.position -= new Vector3(2*screenWidth-1, 0, 0);
                    }
                    else
                    {
                        transform.position += new Vector3(1, 0, 0);
                    }
                    break;
                case "Left":
                    if (transform.position.x == -(screenWidth-0.5))
                    {
                        transform.position += new Vector3(2*screenWidth-1, 0, 0);
                    }
                    else
                    {
                        transform.position += new Vector3(-1, 0, 0);
                    }
                    break;
                case "Up":
                    if (transform.position.y == screenHeight-0.5)
                    {
                        transform.position -= new Vector3(0, 2*screenHeight-1, 0);
                    }
                    else
                    {
                        transform.position += new Vector3(0, 1, 0);
                    }
                    break;
                case "Down":
                    if (transform.position.y == -(screenHeight-0.5))
                    {
                        transform.position += new Vector3(0, 2*screenHeight-1, 0);
                    }
                    else
                    {
                        transform.position += new Vector3(0, -1, 0);
                    }
                    break;
            }

            isQueuedAction = false;
        }
    }
}
