using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckFinishedScript : MonoBehaviour
{
    public TMP_Text gameText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "FinishLine")
        {
            gameText.text = "Finished!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
