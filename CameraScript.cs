using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float Height;
    public float Width;
    
    // Start is called before the first frame update
    void Start()
    {
        Height = Camera.main.orthographicSize;
        Width = Camera.main.aspect * Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
