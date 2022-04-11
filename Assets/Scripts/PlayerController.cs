using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float translation;
    private int playerBounds=35; 
    private float speed = 40;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(0, -20, 0);
    }

    // Update is called once per frame
    void Update()
    {
        translation = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        gameObject.transform.Translate(translation, 0,0);
        if( gameObject.transform.position.x > playerBounds)
        {
            var position = gameObject.transform.position;
            position = new Vector3(playerBounds, position.y, position.z);
            gameObject.transform.position = position;
        }

        if (gameObject.transform.position.x < -playerBounds)
        {
            var position = gameObject.transform.position;
            position = new Vector3(-playerBounds, position.y, position.z);
            gameObject.transform.position = position;
        }
    }
}
