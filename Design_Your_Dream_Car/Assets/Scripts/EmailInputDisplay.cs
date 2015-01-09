using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EmailInputDisplay : MonoBehaviour {

	public GameObject mailButton;
	public GameObject doneButton;
	public GameObject restartButton;
	public GameObject previousButton;

	public GameObject mailFieldPrefab;
	private GameObject mailField;

	public GameObject mailFieldParent;

	// Use this for initialization
	void Start () {
		mailButton.GetComponent<Button>().onClick.AddListener( () => { 
			mailField = Instantiate(mailFieldPrefab) as GameObject;
			mailField.transform.parent = mailFieldParent.transform;
			mailField.transform.localPosition = new Vector3(250f, -8f);
		});

		doneButton.GetComponent<Button>().onClick.AddListener( () => {
			Destroy(mailField);
		
		});  
		restartButton.GetComponent<Button>().onClick.AddListener( () => {
			Destroy(mailField);
			
		}); 
		previousButton.GetComponent<Button>().onClick.AddListener( () => {
			Destroy(mailField);
			
		});    
	}
}
