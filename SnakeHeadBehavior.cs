using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHeadBehavior : MonoBehaviour
{
    
    public string direction;
    public bool isQueuedAction;
    void Start()
    {
        direction = "Right";
        isQueuedAction = false;
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

        if (Time.frameCount % 100 == 0)
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

            isQueuedAction = false;
        }
    }
}
