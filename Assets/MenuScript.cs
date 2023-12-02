using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // SceneManager.LoadScene
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Level 1")
        {
            SceneManager.LoadScene("GameScene");
        }
        if (coll.gameObject.name == "Level 2")
        {
            SceneManager.LoadScene("Level2");
        }
        if (coll.gameObject.name == "Level 3")
        {
            SceneManager.LoadScene("Level3");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
