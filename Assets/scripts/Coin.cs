using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int Points=10;

    void OnTriggerEnter(Collider other){
		if (other.tag == "Player"){
    Destroy (this.gameObject);
        GameSingleton.Score+=Points;
        Debug.Log(GameSingleton.Score);
        }
      }  

}
