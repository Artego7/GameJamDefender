using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    [SerializeField]
    Text pointsText;
    PauseMenu pauseMenu;

    int actualPoints = 0;
    int maxPoints = 5;
    string pointsString;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointsString = actualPoints.ToString();

        pointsText.text = pointsString;

        if (actualPoints >= maxPoints)
            pauseMenu.Win();
    }
    public void incressPoints()
    {
        actualPoints++;
    }
}
