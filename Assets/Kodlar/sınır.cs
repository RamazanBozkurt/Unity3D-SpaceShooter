using UnityEngine;
using System.Collections;

public class sınır : MonoBehaviour {

    int can;
    
    public GameObject player;
    void OnTriggerExit(Collider col)
    {
        Destroy(col.gameObject);
    }

    

}

    
