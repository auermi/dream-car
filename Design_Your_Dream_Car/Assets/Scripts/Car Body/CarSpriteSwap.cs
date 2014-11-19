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

	public GameObject basicWheelButton;
	public GameObject luxuryWheelButton;
	public GameObject sportyWheelButton;

	public GameObject vanSpoiler;
	public GameObject truckSpoiler;
	public GameObject coupeSpoiler;
	public GameObject compactSpoiler;
	public GameObject suvSpoiler;

	public GameObject basicWheelSuv;
	public GameObject luxuryWheelSuv;
	public GameObject sportyWheelSuv;
	public GameObject basicWheelTruck;
	public GameObject luxuryWheelTruck;
	public GameObject sportyWheelTruck;
	public GameObject basicWheelCoupe;
	public GameObject luxuryWheelCoupe;
	public GameObject sportyWheelCoupe;
	public GameObject basicWheelCompact;
	public GameObject luxuryWheelCompact;
	public GameObject sportyWheelCompact;
	public GameObject basicWheelVan;
	public GameObject luxuryWheelVan;
	public GameObject sportyWheelVan;


	private GameObject car;
	private GameObject spoiler;
	private GameObject wheels;
	
	private int carIndex;
	private int wheelIndex;


	/// <summary>
	/// carIndex= 
	/// 0:Truck 
	/// 1:SUV
	/// 2:Van
	/// 3:Coupe
	/// 4:Compact
	/// 
	/// wheelIndex=
	/// 0:Basic
	/// 1:Luxury
	/// 2:Sporty
	/// </summary>

	// Use this for initialization
	void Start () {
		truckButton.GetComponent<Button>().onClick.AddListener(() => { truckSwap(); });
		suvButton.GetComponent<Button>().onClick.AddListener(() => { suvSwap(); });
		vanButton.GetComponent<Button>().onClick.AddListener(() => { vanSwap(); });
		coupeButton.GetComponent<Button>().onClick.AddListener(() => { coupeSwap(); });
		compactButton.GetComponent<Button>().onClick.AddListener(() => { compactSwap(); });

		spoilerButton.GetComponent<Button>().onClick.AddListener(() => { addSpoiler(); });
		noSpoilerButton.GetComponent<Button>().onClick.AddListener(() => { removeSpoiler();});

		basicWheelButton.GetComponent<Button>().onClick.AddListener(() => { wheelIndex = 0; addWheels(); });
		luxuryWheelButton.GetComponent<Button>().onClick.AddListener(() => { wheelIndex = 1; addWheels(); });
		sportyWheelButton.GetComponent<Button>().onClick.AddListener(() => { wheelIndex = 2; addWheels(); });

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
	void addWheels()
	{
		switch(carIndex)
		{
		case 0:
			if (wheels != null)
			{
				Destroy(wheels);
			}
			switch(wheelIndex)
			{
			case 0:
				wheels = Instantiate(basicWheelTruck) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-503.7f, -385.8f);
				break;
			case 1:
				wheels = Instantiate(luxuryWheelTruck) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-503.7f, -385.8f);
				break;
			case 2:
				wheels = Instantiate(sportyWheelTruck) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-503.7f, -385.8f);
				break;
			default:
				break;
			}
			break;
		case 1:
			if (wheels != null)
			{
				Destroy(wheels);
			}
			switch(wheelIndex)
			{
			case 0:
				wheels = Instantiate(basicWheelSuv) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-503.7f, -385.8f);
				break;
			case 1:
				wheels = Instantiate(luxuryWheelSuv) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-503.7f, -385.8f);
				break;
			case 2:
				wheels = Instantiate(sportyWheelSuv) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-503.7f, -385.8f);
				break;
			default:
				break;
			}
			break;
		case 2:
			if (wheels != null)
			{
				Destroy(wheels);
			}
			switch(wheelIndex)
			{
			case 0:
				wheels = Instantiate(basicWheelVan) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-524.1f, -376.1f);
				break;
			case 1:
				wheels = Instantiate(luxuryWheelVan) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-524.1f, -376.1f);
				break;
			case 2:
				wheels = Instantiate(sportyWheelVan) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-524.1f, -376.1f);
				break;
			default:
				break;
			}
			break;
		case 3:
			if (wheels != null)
			{
				Destroy(wheels);
			}
			switch(wheelIndex)
			{
			case 0:
				wheels = Instantiate(basicWheelCoupe) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-524f, -361.7f);
				break;
			case 1:
				wheels = Instantiate(luxuryWheelCoupe) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-524f, -361.7f);
				break;
			case 2:
				wheels = Instantiate(sportyWheelCoupe) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-524f, -361.7f);
				break;
			default:
				break;
			}
			break;
		case 4:
			if (wheels != null)
			{
				Destroy(wheels);
			}
			switch(wheelIndex)
			{
			case 0:
				wheels = Instantiate(basicWheelCompact) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-555.7f, -385.8f);
				break;
			case 1:
				wheels = Instantiate(luxuryWheelCompact) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-555.7f, -385.8f);
				break;
			case 2:
				wheels = Instantiate(sportyWheelCompact) as GameObject;
				wheels.transform.parent = canvas.transform;
				wheels.transform.localPosition = new Vector3(-555.7f, -385.8f);
				break;
			default:
				break;
			}
			break;
		default:
			break;
		}
	}
}
