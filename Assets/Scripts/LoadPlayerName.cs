using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoadPlayerName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(LoadNewScene.Instance!=null){
            GetComponent<TMP_Text>().text = LoadNewScene.Instance.playerName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
