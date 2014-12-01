using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarShift : MonoBehaviour {

	public GameObject carManager;
	public GameObject spoiler;
	public GameObject decal;
	public GameObject wheel;
	public GameObject sc10Prev;
	public GameObject sc11Prev;
	public GameObject sc12Prev;
	// Use this for initialization
	void Start () {
		sc10Prev.GetComponent<Button>().onClick.AddListener( () => { carManager.transform.localPosition = new Vector3(0f,-235f); } );
		sc10Prev.GetComponent<Button>().onClick.AddListener( () => { spoiler.transform.localPosition = new Vector3(0f,-235f); } );
		sc10Prev.GetComponent<Button>().onClick.AddListener( () => { decal.transform.localPosition = new Vector3(0f,-235f); } );
		sc10Prev.GetComponent<Button>().onClick.AddListener( () => { wheel.transform.localPosition = new Vector3(0f,-235f); } );

		sc11Prev.GetComponent<Button>().onClick.AddListener( () => { carManager.transform.localPosition = new Vector3(0f,0f); } );
		sc11Prev.GetComponent<Button>().onClick.AddListener( () => { spoiler.transform.localPosition = new Vector3(0f,0f); } );
		sc11Prev.GetComponent<Button>().onClick.AddListener( () => { decal.transform.localPosition = new Vector3(0f,0f); } );
		sc11Prev.GetComponent<Button>().onClick.AddListener( () => { wheel.transform.localPosition = new Vector3(0f,0f); } );

		sc12Prev.GetComponent<Button>().onClick.AddListener( () => { carManager.transform.localPosition = new Vector3(0f,-600f); } );
		sc12Prev.GetComponent<Button>().onClick.AddListener( () => { spoiler.transform.localPosition = new Vector3(0f,-600f); } );
		sc12Prev.GetComponent<Button>().onClick.AddListener( () => { decal.transform.localPosition = new Vector3(0f,-600f); } );
		sc12Prev.GetComponent<Button>().onClick.AddListener( () => { wheel.transform.localPosition = new Vector3(0f,-600f); } );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
