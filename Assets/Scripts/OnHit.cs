using UnityEngine;
using System.Collections;

public class OnHit : MonoBehaviour {
   // public int idx;
    
    public GameObject Camera;
    public GameScript Script;

    void Awake()
    {
        
        //camera = GameObject.FindGameObjectWithTag("MainCamera");
        Script = Camera.GetComponent<GameScript>();
    }

    void OnMouseDown()
    {
        Debug.Log("shit");
        Script.SpawnNew(this.gameObject);
        
    }
    
}
