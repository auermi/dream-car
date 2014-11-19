using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarButtonStateChange : MonoBehaviour {

	void BtnColorActive()
	{
		this.GetComponent<Image> ().color = new Color32(0,118,192, 255);
		
	}


	void BtnColorInactive()
	{
		GameObject.FindGameObjectWithTag("truck").GetComponent<Image> ().color = new Color32(51,51,51, 255);
		GameObject.FindGameObjectWithTag("suv").GetComponent<Image> ().color = new Color32(51,51,51, 255);
		GameObject.FindGameObjectWithTag("van").GetComponent<Image> ().color = new Color32(51,51,51, 255);
		GameObject.FindGameObjectWithTag("coupe").GetComponent<Image> ().color = new Color32(51,51,51, 255);
		GameObject.FindGameObjectWithTag("compact").GetComponent<Image> ().color = new Color32(51,51,51, 255);
	}




}
