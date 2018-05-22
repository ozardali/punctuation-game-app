using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class alistirma7 : MonoBehaviour {

	public int yanlis = 0;
	public GameObject DogruPanel;
	public GameObject YanlisPanel;
	public GameObject AciklamaPanel;
	public GameObject AlistirmaPanel;

	// Noktalama İşaretleri
	public GameObject duzcizgi;
	public GameObject nokta;
	public GameObject ikinokta;
	public GameObject kesmeisareti;
	public GameObject noktalivirgul;
	public GameObject soruisareti;
	public GameObject tirnak;
	public GameObject ucnokta;
	public GameObject unlem;
	public GameObject virgul;
	public GameObject DevamButon;
	public Text DogruText;


	public bool hatagerisay = false;
	public float timeLeft = 1.0f;

	void Aciklama(){
		AlistirmaPanel.gameObject.SetActive (false);
		AciklamaPanel.gameObject.SetActive(true);
		DevamButon.gameObject.SetActive(true);
	}
	void Start () {
		DogruText.text = "Tebrikler " + PlayerPrefs.GetString ("username") + " Doğru Cevap!";
	}

	void Update(){

		if (hatagerisay) {
			timeLeft -= Time.deltaTime;
			if (timeLeft < 0) {
				yanlis = yanlis + 1;
				if (yanlis == 3) {
					Aciklama();
				} 
				YanlisPanel.gameObject.SetActive(false);
				hatagerisay = false;
				timeLeft = 1.0f;

			}

		}
	}

	void OnTriggerEnter2D(Collider2D temasEdilen)
	{
		if (yanlis != 3) {
			if (temasEdilen.gameObject.tag == "nokta") {

				YanlisPanel.gameObject.SetActive (true);
				Destroy (temasEdilen.gameObject);
				hatagerisay = true;

			} else if (temasEdilen.gameObject.tag == "kesmeisareti") {

				YanlisPanel.gameObject.SetActive (true);
				Destroy (temasEdilen.gameObject);
				hatagerisay = true;

			} else if (temasEdilen.gameObject.tag == "noktalivirgul") {

				YanlisPanel.gameObject.SetActive (true);
				Destroy (temasEdilen.gameObject);
				hatagerisay = true;
			} else if (temasEdilen.gameObject.tag == "ikinokta") {

				YanlisPanel.gameObject.SetActive (true);
				Destroy (temasEdilen.gameObject);
				hatagerisay = true;
			} else if (temasEdilen.gameObject.tag == "ucnokta") {

				YanlisPanel.gameObject.SetActive (true);
				Destroy (temasEdilen.gameObject);
				hatagerisay = true;
			} else if (temasEdilen.gameObject.tag == "virgul") {


				YanlisPanel.gameObject.SetActive (true);
				Destroy (temasEdilen.gameObject);
				hatagerisay = true;
			} else if (temasEdilen.gameObject.tag == "tirnak") {
				YanlisPanel.gameObject.SetActive (true);
				Destroy (temasEdilen.gameObject);
				hatagerisay = true;
			} else if (temasEdilen.gameObject.tag == "duzcizgi") {


				YanlisPanel.gameObject.SetActive (true);
				Destroy (temasEdilen.gameObject);
				hatagerisay = true;
			} else if (temasEdilen.gameObject.tag == "soruisareti") {


				YanlisPanel.gameObject.SetActive (true);
				Destroy (temasEdilen.gameObject);
				hatagerisay = true;

			} else if (temasEdilen.gameObject.tag == "unlem") {

				DogruPanel.gameObject.SetActive (true);
				DevamButon.gameObject.SetActive (true);
			}
		}

}
}