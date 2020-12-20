using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunKontrol : MonoBehaviour {

    public GameObject asteroid;
    public Vector3 pos;
    Vector3 vec;
    public float baslangicBekleme;
    public float olusturmaBekleme;
    public float donguBekleme;
    int score;
    public Text text;
    public Text oyunBittiText;
    public Text yenidenBaslama;
    bool oyunBittiKontrol = false;
    bool oyunYenidenBasladiKontrol = false;
    
	void Start () {

        score = 0;
        text.text = "skor = " + score;


        StartCoroutine(olustur());
        
	}

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && oyunYenidenBasladiKontrol == true)    
        {
            
            SceneManager.LoadScene("a");    //R ye basıldığında oyun yeniden başlar
        }
    }
    IEnumerator olustur()
    {
        yield return new WaitForSeconds(baslangicBekleme);
        while (true)
        {
            for(int i = 0; i < 10; i++)
            {
                vec = new Vector3(Random.Range(-pos.x, pos.x), 0, pos.z);
                Instantiate(asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(olusturmaBekleme);

            }

            if (oyunBittiKontrol)
            {
                yenidenBaslama.text = "yeniden başlamak için R tuşuna basın";
                oyunYenidenBasladiKontrol = true;
                break;

            }

            yield return new WaitForSeconds(donguBekleme);

            
        }
        
    }

    public void scoreArttir(int gelenScore)
    {
        score += gelenScore;
        text.text = "skor = " + score;
    }

    public void oyunBitti()
    {
        oyunBittiText.text = "OYUN BİTTİ";
        oyunBittiKontrol = true;
    }
}
