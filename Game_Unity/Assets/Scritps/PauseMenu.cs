using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{

    [SerializeField]
    GameObject pauseMenuUI;
    [SerializeField]
    GameObject optionsGameMenuUI;
    [SerializeField]
    GameObject gameOverMenuUI;
    [SerializeField]
    GameObject winMenuUI;
    [SerializeField]
    GameObject blur;

    public static bool gameIsPaused = false;
    // Use this for initialization

    void Start()
    {

    }

    ////CHECK_WHAT_KEY_IS_USING//
    //KeyCode FetchKey()
    //{
    //    int e = System.Enum.GetNames(typeof(KeyCode)).Length;
    //    for (int i = 0; i < e; i++)
    //    {
    //        if (Input.GetKey((KeyCode)i))
    //        {
    //            return (KeyCode)i;
    //        }
    //    }
    //    return KeyCode.None;
    //}
    //print(FetchKey());

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        blur.SetActive(false);
        pauseMenuUI.SetActive(false);
        optionsGameMenuUI.SetActive(false);
        gameOverMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    void Pause()
    {
        blur.SetActive(true);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void GameOver()
    {
        blur.SetActive(true);
        gameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void Win()
    {
        blur.SetActive(true);
        winMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void LoadStartMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Resume();
    }
}
