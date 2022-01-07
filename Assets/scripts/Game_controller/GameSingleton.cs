using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSingleton : MonoBehaviour{
    public static int Lives;
    public static int Score=3;
    public static GameSingleton estancia;
    
    private void Awake(){
        singleton();
    }
    
    private void singleton(){
        
    if (estancia!=null){
    Destroy(this.gameObject);      
    }else{estancia=this;
    DontDestroyOnLoad(this.gameObject);}
    }
   
}
