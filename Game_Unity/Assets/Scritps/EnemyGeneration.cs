using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneration : MonoBehaviour
{

    [SerializeField]
    GameObject enemyPrefab;

    float delay = 0;
    float maxTime = 1;
    List<float> changeSpawnSide = new List<float>();

    // Start is called before the first frame update
    void Start()
    {
        changeSpawnSide.Add(53f);
        changeSpawnSide.Add(0f);
        changeSpawnSide.Add(-53f);
        for (int i = 0; i < 1; i++)
        {
            Instantiate(enemyPrefab.gameObject, new Vector3(-240, 8, transform.position.z + changeSpawnSide[Random.RandomRange(0, 3)]), Quaternion.identity);
        }
        //Resolution[] resolutions = Screen.resolutions;
        //foreach (Resolution res in resolutions)
        //{
        //    print(res.width + "x" + res.height);
        //}
        //Screen.SetResolution(resolutions[0].width, resolutions[0].height, true);
    }

    // Update is called once per frame
    void Update()
    {
        delay += Time.deltaTime;
        if(delay >= maxTime)
        {
            Instantiate(enemyPrefab.gameObject, new Vector3(-240, 8, transform.position.z + changeSpawnSide[Random.RandomRange(0, 3)]), Quaternion.identity);
            delay = 0;
        }
    }   
}
