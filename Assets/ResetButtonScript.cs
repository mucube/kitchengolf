using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButtonScript : MonoBehaviour
{
    public Rigidbody2D ball;
    public Button resetButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = resetButton.GetComponent<Button>();
		btn.onClick.AddListener(ResetBall);
    }

    void ResetBall(){
		ball.transform.position = new Vector2(0,0);
        ball.velocity = new Vector2(0,0);
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
