using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public static LoadNewScene Instance;
    public string playerName;
    public TMP_InputField playerNameInputField;
  
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        

    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void StartGame()
    {
        playerName = playerNameInputField.GetComponent<TMP_InputField>().text;
        SceneManager.LoadScene(1);
       
        
    }

  

  
}
