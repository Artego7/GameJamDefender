using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    bool isFarFromPlayer = true;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        for (int i = 0; i < 5; i++)
        {
            Instantiate(this.gameObject);
        }
        Resolution[] resolutions = Screen.resolutions;
        foreach (Resolution res in resolutions)
        {
            print(res.width + "x" + res.height);
        }
        Screen.SetResolution(resolutions[0].width, resolutions[0].height, true);
    }

    // Update is called once per frame
    void Update()
    {
        if(isFarFromPlayer)
        this.transform.position = new Vector3(transform.position.x + 2.6f, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Van"))
        {
            isFarFromPlayer = false;
            Destroy(this, .5f);
        }
    }
}
