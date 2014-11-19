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

	public GameObject spoilerButton;
	public GameObject noSpoilerButton;

	public GameObject vanSpoiler;
	public GameObject truckSpoiler;
	public GameObject coupeSpoiler;
	public GameObject compactSpoiler;
	public GameObject suvSpoiler;

	private GameObject car;
	private GameObject spoiler;
	
	private int carIndex;


	

	// Use this for initialization
	void Start () {
		truckButton.GetComponent<Button>().onClick.AddListener(() => { truckSwap(); });
		suvButton.GetComponent<Button>().onClick.AddListener(() => { suvSwap(); });
		vanButton.GetComponent<Button>().onClick.AddListener(() => { vanSwap(); });
		coupeButton.GetComponent<Button>().onClick.AddListener(() => { coupeSwap(); });
		compactButton.GetComponent<Button>().onClick.AddListener(() => { compactSwap(); });

		spoilerButton.GetComponent<Button>().onClick.AddListener(() => { addSpoiler(); });
		noSpoilerButton.GetComponent<Button>().onClick.AddListener(() => { removeSpoiler(); });


	}

	void truckSwap()
	{
		if (car != null)
		{
			Destroy(car);
		}
		carIndex = 0;
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
		carIndex = 1;
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
		carIndex = 2;
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
		carIndex = 3;
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
		carIndex = 4;
		car = Instantiate(compact) as GameObject;
		car.transform.parent = canvas.transform;
		car.transform.localPosition = new Vector3(0f,0f);
	}

	void addSpoiler ()
	{
		switch(carIndex)
		{
			case 0:
				if (spoiler != null){
					Destroy(spoiler);
				}
			spoiler = Instantiate(truckSpoiler) as GameObject;
			spoiler.transform.parent = canvas.transform;
			spoiler.transform.localPosition = new Vector3(-353.27f, 37.1f);
			break;

			case 1:
				if (spoiler != null){
					Destroy(spoiler);
				}
				spoiler = Instantiate(suvSpoiler) as GameObject;
				spoiler.transform.parent = canvas.transform;
				spoiler.transform.localPosition = new Vector3(-358.4f, 37.1f);
			break;

			case 2:
				if (spoiler != null){
					Destroy(spoiler);
				}
				spoiler = Instantiate(vanSpoiler) as GameObject;
				spoiler.transform.parent = canvas.transform;
				spoiler.transform.localPosition = new Vector3(-364.8f, 83.6f);
				break;

			case 3:
				if (spoiler != null){
					Destroy(spoiler);
				}
				spoiler = Instantiate(coupeSpoiler) as GameObject;
				spoiler.transform.parent = canvas.transform;
				spoiler.transform.localPosition = new Vector3(-352.2f, 52.03f);
				break;

			case 4:
				if (spoiler != null){
					Destroy(spoiler);
				}
				spoiler = Instantiate(compactSpoiler) as GameObject;
				spoiler.transform.parent = canvas.transform;
				spoiler.transform.localPosition = new Vector3(-344.1f, 78.8f);
				break;

			default:
				break;
		}

	}
	void removeSpoiler()
	{
		Destroy(spoiler);
	}
}
