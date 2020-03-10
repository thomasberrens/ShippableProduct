using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
         var mousePos = Input.mousePosition;
         mousePos.z = 2.0f;       // we want 2m away from the camera position
         var objectPos = Camera.current.ScreenToWorldPoint(mousePos);
         Instantiate(cube, objectPos, Quaternion.identity);
        }
    }
}
