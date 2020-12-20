using UnityEngine;
using System.Collections;

public class playerKontrol : MonoBehaviour {

    Rigidbody fizik;
    float horizontal = 0;
    float vertical = 0;
    Vector3 vec;
    public float playerSpeed;
    public float minX;
    public float maksX;
    public float minZ;
    public float maksZ;
    public float egimhizi;
    float atesSuresi=0;
    public float gecenSure;
    public GameObject kursun;
    public Transform kursunCikisYeri;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButton("Jump") && Time.time>atesSuresi)
        {
            atesSuresi = Time.time + gecenSure;
            Instantiate(kursun, kursunCikisYeri.position, Quaternion.identity);      //nesne pozisyon rotasyon
        }
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        vec = new Vector3(horizontal, 0, vertical);

        fizik.velocity = vec*playerSpeed;

        fizik.position = new Vector3(Mathf.Clamp(fizik.position.x, minX, maksX), 0, Mathf.Clamp(fizik.position.z, minZ, maksZ));    //uçağın sınır hareketleri

        fizik.rotation = Quaternion.Euler(0, 0, fizik.velocity.x*egimhizi);     //ucağın sağ sol hareketleri

    }
}
