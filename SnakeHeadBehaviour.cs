using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SnakeHeadBehaviour : MonoBehaviour
{
    
    public Dir direction;
    public bool isQueuedAction;
    public float screenHeight;
    public float screenWidth;
    public int tickRate;
    
    public enum Dir
    {
        Right, Left, Up, Down
    }
    
    void Start()
    {
        direction = Dir.Right;
        isQueuedAction = false;
        screenHeight = Camera.main.GameObject().GetComponent<CameraScript>().Height;
        screenWidth = Camera.main.GameObject().GetComponent<CameraScript>().Width;
        tickRate = 100;
    }

    void Update()
    {
        if (!isQueuedAction)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && direction != Dir.Left && direction != Dir.Right)
            {
                direction = Dir.Left;
                isQueuedAction = true;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && direction != Dir.Right && direction != Dir.Left)
            {
                direction = Dir.Right;
                isQueuedAction = true;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow) && direction != Dir.Up && direction != Dir.Down)
            {
                direction = Dir.Up;
                isQueuedAction = true;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && direction != Dir.Down && direction != Dir.Up)
            {
                direction = Dir.Down;
                isQueuedAction = true;
            }
        }
        
        if (Time.frameCount % tickRate == 0)
        {
            switch (direction)
            {
                case Dir.Right:
                    if (transform.position.x == screenWidth-0.5)
                    {
                        transform.position -= new Vector3(2*screenWidth-1, 0, 0);
                    }
                    else
                    {
                        transform.position += new Vector3(1, 0, 0);
                    }
                    break;
                case Dir.Left:
                    if (transform.position.x == -(screenWidth-0.5))
                    {
                        transform.position += new Vector3(2*screenWidth-1, 0, 0);
                    }
                    else
                    {
                        transform.position += new Vector3(-1, 0, 0);
                    }
                    break;
                case Dir.Up:
                    if (transform.position.y == screenHeight-0.5)
                    {
                        transform.position -= new Vector3(0, 2*screenHeight-1, 0);
                    }
                    else
                    {
                        transform.position += new Vector3(0, 1, 0);
                    }
                    break;
                case Dir.Down:
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
