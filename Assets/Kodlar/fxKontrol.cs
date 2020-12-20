using UnityEngine;
using System.Collections;

public class fxKontrol : MonoBehaviour {

    Rigidbody fizik;
    public float fxHiz;
    
	void Start () {

        fizik = GetComponent<Rigidbody>();
        fizik.velocity = transform.forward*fxHiz;
	}
	
	
	
}
