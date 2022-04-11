using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyType4 : ObjectController
{
    private float timeElapsed;

    private float roundedTime;
    // EnemyType4 is a boss enemy and will modify scale tremendously
    void Start()
    {
        ScaleModifier = 2.25f;  
        speed = 20f;
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        roundedTime = Mathf.Round(timeElapsed);
       
        StartMoving();

    }
    
    public override void StartMoving() // can override virtual methods from parent class
    {
        var bossEnemyScale = BossEnemyScale;
        bossEnemyScale.x =  Mathf.PingPong(Time.time*10, 45);
        gameObject.transform.localScale = new Vector3(bossEnemyScale.x, 1, 1);
        gameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    

    // Update is called once per frame
    
}
