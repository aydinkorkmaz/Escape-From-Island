using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameObject : MonoBehaviour
{
    [SerializeField] Text StoryText;
    [SerializeField] Status FirstStatus;
    Status ActiveStatus;
    void Start()
    {   ActiveStatus= FirstStatus;
        StoryText.text=ActiveStatus.GetStatusText();
    }

    
    void Update()
    { 
        var NextStatus=ActiveStatus.GetNextStatus();
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            ActiveStatus=NextStatus[0];

    }   else if(Input.GetKeyDown(KeyCode.Alpha2)){
            ActiveStatus=NextStatus[1];}
            
        else if(Input.GetKeyDown(KeyCode.Alpha3)){
            ActiveStatus=NextStatus[2];
        }
        else if(Input.GetKeyDown(KeyCode.Escape)){
            Debug.Log("Kapandım");
            Application.Quit();
            
        }    
        StoryText.text=ActiveStatus.GetStatusText();    
            }
        
       
            
        
        
    
}
