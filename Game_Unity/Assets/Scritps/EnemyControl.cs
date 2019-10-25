using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    PauseMenu pauseMenu;

    bool isFarFromPlayer = true;
    bool isReferenced = false;

    // Start is called before the first frame update
    void Start()
    {
        if ((pauseMenu == null) && (GetComponent<PauseMenu>() != null))
        {
            pauseMenu = GetComponent<PauseMenu>();
        }
        else
        {
            Debug.LogWarning("Missing player_gun_manager_script component. Please add one");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ((pauseMenu == null) && (GetComponent<PauseMenu>() != null) && !isReferenced)
        {
            pauseMenu = GetComponent<PauseMenu>();
            isReferenced = true;
        }
        else
        {
            Debug.LogWarning("Missing player_gun_manager_script component. Please add one");
        }
        if (isFarFromPlayer)
            this.transform.position = new Vector3(transform.position.x + 1.6f, transform.position.y, transform.position.z);
    }
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Van"))
        {
            isFarFromPlayer = false;
            Destroy(this.gameObject, .5f);
            pauseMenu.GameOver();
        }
    }

}
