using UnityEngine;
using System.Collections;

public class temaslaYokOl : MonoBehaviour {


    public GameObject patlama;
    public GameObject playerPatlama;
    AudioSource audio;

    GameObject OyunKontrol;
    oyunKontrol kontrol;
    private void Start()
    {
        OyunKontrol = GameObject.FindGameObjectWithTag("oyunKontrol");
        kontrol = OyunKontrol.GetComponent<oyunKontrol>();
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag != "sinir")
        {
            Destroy(col.gameObject);    //kurşunu yok eder
            Destroy(gameObject);    //asteroidi yok eder
            Instantiate(patlama, transform.position, transform.rotation);
            kontrol.scoreArttir(10);
        }

        if(col.tag == "Player")
        {
            Instantiate(playerPatlama, col.transform.position, col.transform.rotation);
            kontrol.oyunBitti();
        }

        
    }
}
