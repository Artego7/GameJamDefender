using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    bool ismovingUp = false;
    bool ismovingDown = false;
    float moveUp;
    float moveDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ismovingUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            
        }
    }

}
