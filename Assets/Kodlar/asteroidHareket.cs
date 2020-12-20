using UnityEngine;
using System.Collections;

public class asteroidHareket : MonoBehaviour {

    Rigidbody fizik;
    public float hiz;

    void Start () {

        fizik = GetComponent<Rigidbody>();
        
	}
	
	
	void Update () {

        fizik.velocity = transform.forward*-hiz;
	}
}
