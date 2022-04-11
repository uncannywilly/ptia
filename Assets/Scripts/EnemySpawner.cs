using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{   
    private int  rangeX = 30;
    public int numberOfEnemies = 10;

    [SerializeField] private GameObject[] enemy;

    [SerializeField] private GameObject wall;

    
    [SerializeField] private GameObject bossEnemy;

    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("InstantiateEnemy",0.5f,3);
       InvokeRepeating("InstantiateWall",1f,6);
       InvokeRepeating("InstantiateBossEnemy",10f,10);
    }

    private void InstantiateWall()
    {
        
        for(int i=0; i<=1; i++)
        {
            wall.transform.localScale = new Vector3(Random.Range(25,35), 1, 1);
            
            if(i % 2 ==0){
                Instantiate(wall, new Vector3(27, 35, 0), transform.rotation);
            }
            else{
                Instantiate(wall, new Vector3(-27, 35, 0), transform.rotation);
            }
          
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InstantiateEnemy()
    {
        for(int i=0; i<=Random.Range(4, 7); i++){
            Instantiate(enemy[RandomNumber(enemy.Length,true)], new Vector3(RandomNumber(rangeX, false), 32, 0), transform.rotation); 
        }
    }
    
    private void InstantiateBossEnemy()
    {
        
            Instantiate(bossEnemy, new Vector3(0, 32, 0), transform.rotation); 
        
    }
  
    private int RandomNumber(int range, bool absolute) // ABSTRACTION
    {
        if(absolute){
            return Random.Range(0, range);
        }
        else
        {
            return Random.Range(-range, range);
        }
        
    }
}
