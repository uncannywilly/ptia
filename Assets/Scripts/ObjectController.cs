using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectController : MonoBehaviour
{

    public float scale = 10;
    public float speed = 5;
    private float scaleModifier;
    private float bossEnemyScaleModifier = 5;
    private Vector3 bossEnemyScale;

    public float ScaleModifier
    {
        get
        {
            return scaleModifier;
        }
        set
        {   
            scaleModifier = value;
        }
    }
    public Vector3 BossEnemyScale
    {
        get
        {
            return bossEnemyScale;
             
        }
        set
        { 
            bossEnemyScale = value;
        }
    }


    public GameObject gameManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartMoving();
       
        if (gameObject.transform.position.y <= -30)
        {
            Destroy(gameObject);
        }
    }

    public virtual void StartMoving()
    {
        gameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
   

  

    public void OnTriggerEnter(Collider other)
    {
        
        
        if(gameObject.CompareTag("Enemy") && !other.CompareTag("Wall")){
         Destroy(gameObject);
         Debug.Log("other scale x: " +other.gameObject.transform.localScale.x);
         if(other.gameObject.transform.localScale.x <= 2.0f)
         {
            
             gameManager = GameObject.Find("GameManager");
             gameManager.GetComponent<GameManager>().gameWon = true;
         }
         else
         {
             other.gameObject.transform.localScale = new Vector3(other.gameObject.transform.localScale.x+scaleModifier, 1, 1);
         }
        }
        if(gameObject.CompareTag("Wall") && !other.CompareTag("Enemy") && !other.CompareTag("Wall"))
        {
            //Debug.Log("game over bc of " + gameObject.name + "and" + other.gameObject.name + "collision");
            gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<GameManager>().gameOver = true;
        }
      
      
    }

 
}
