using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarSpriteSwap : MonoBehaviour {

	public GameObject truck;
	public GameObject suv;
	public GameObject van;
	public GameObject coupe;
	public GameObject compact;

	public GameObject canvas;

	public GameObject truckButton;
	public GameObject suvButton;
	public GameObject vanButton;
	public GameObject coupeButton;
	public GameObject compactButton;


	private GameObject car;

	// Use this for initialization
	void Start () {
		truckButton.GetComponent<Button>().onClick.AddListener(() => { truckSwap(); });
		suvButton.GetComponent<Button>().onClick.AddListener(() => { suvSwap(); });
		vanButton.GetComponent<Button>().onClick.AddListener(() => { vanSwap(); });
		coupeButton.GetComponent<Button>().onClick.AddListener(() => { coupeSwap(); });
		compactButton.GetComponent<Button>().onClick.AddListener(() => { compactSwap(); });
	}

	void truckSwap()
	{
		if (car != null)
		{
			Destroy(car);
		}
		car = Instantiate(truck) as GameObject;
		car.transform.parent = canvas.transform;
		car.transform.localPosition = new Vector3(0f,0f);
	}
	void suvSwap()
	{
		if (car != null)
		{
			Destroy(car);
		}
		car = Instantiate(suv) as GameObject;
		car.transform.parent = canvas.transform;
		car.transform.localPosition = new Vector3(0f,0f);
	}
	void vanSwap()
	{
		if (car != null)
		{
			Destroy(car);
		}
		car = Instantiate(van) as GameObject;
		car.transform.parent = canvas.transform;
		car.transform.localPosition = new Vector3(0f,0f);
	}
	void coupeSwap()
	{
		if (car != null)
		{
			Destroy(car);
		}
		car = Instantiate(coupe) as GameObject;
		car.transform.parent = canvas.transform;
		car.transform.localPosition = new Vector3(0f,0f);
	}
	void compactSwap()
	{
		if (car != null)
		{
			Destroy(car);
		}
		car = Instantiate(compact) as GameObject;
		car.transform.parent = canvas.transform;
		car.transform.localPosition = new Vector3(0f,0f);
	}

}
