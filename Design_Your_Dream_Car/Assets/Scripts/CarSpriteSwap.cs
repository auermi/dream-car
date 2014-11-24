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
	public GameObject spoilerContainer;
	public GameObject decalContainer;
	public GameObject bodyContainer;
	public GameObject wheelContainer;

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
	
	public GameObject redButton;
	public GameObject greenButton;
	public GameObject yellowButton;
	public GameObject orangeButton;
	public GameObject turquoiseButton;
	public GameObject carrotButton;
	public GameObject pinkButton;
	public GameObject greyButton;
	public GameObject limeButton;
	public GameObject navyButton;
	public GameObject glaucousButton;

	public GameObject vanSpoiler;
	public GameObject truckSpoiler;
	public GameObject coupeSpoiler;
	public GameObject compactSpoiler;
	public GameObject suvSpoiler;

	public GameObject starButton;
	public GameObject flameButton;
	public GameObject stripeButton;

	public GameObject stripe;
	public GameObject flame;
	public GameObject star;

	public GameObject basicWheel;
	public GameObject luxuryWheel;
	public GameObject sportWheel;

	private GameObject leftWheel;
	private GameObject rightWheel;

	private GameObject car;
	private GameObject spoiler;
	private GameObject wheels;
	private GameObject decal;
	
	private int carIndex;
	private int wheelIndex;
	private int colorIndex;
	private int decalIndex;

	private Color32 redColor = new Color32(238, 52, 36, 255);
	private Color32 greenColor = new Color32(0, 169, 79, 255);
	private Color32 yellowColor = new Color32(235, 231, 41, 255);
	private Color32 orangeColor = new Color32(243, 116, 33, 255);
	private Color32 turquoiseColor = new Color32(0, 177, 176, 255);
	private Color32 carrotColor = new Color32(231, 166, 20, 255);
	private Color32 pinkColor = new Color32(248, 179, 186, 255);
	private Color32 greyColor = new Color32(186, 186, 186, 255);
	private Color32 limeColor = new Color32(123, 193, 67, 255);
	private Color32 navyColor = new Color32(0, 75, 135, 255);
	private Color32 glaucousColor = new Color32(65, 89, 96, 255);

	/// <summary>
	/// carIndex= 
	/// 0:Truck 
	/// 1:SUV
	/// 2:Van
	/// 3:Coupe
	/// 4:Compact
	/// 
	/// wheelIndex=
	/// 0:Sport
	/// 1:Luxury
	/// 2:Basic
	/// 
	/// colorIndex=
	/// 0:Red
	/// 1:Green
	/// 2:Yellow
	/// 3:Orange
	/// 4:Turquoise
	/// 5:Carrot
	/// 6:Pink
	/// 7:Grey
	/// 8:Lime
	/// 9:Navy
	/// 10:Glaucous
	/// 
	/// decalIndex=
	/// 0:star
	/// 1:flame
	/// 2:stripe
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

		basicWheelButton.GetComponent<Button>().onClick.AddListener(() => { wheelIndex = 2; wheelSwap(); });
		luxuryWheelButton.GetComponent<Button>().onClick.AddListener(() => { wheelIndex = 1; wheelSwap(); });
		sportyWheelButton.GetComponent<Button>().onClick.AddListener(() => { wheelIndex = 0; wheelSwap(); });

		redButton.GetComponent<Button>().onClick.AddListener(() => { colorIndex = 0; colorChange(); });
		greenButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 1; colorChange(); });
		yellowButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 2; colorChange(); });
		orangeButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 3; colorChange(); });
		turquoiseButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 4; colorChange(); });
		carrotButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 5; colorChange(); });
		pinkButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 6; colorChange(); });
		greyButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 7; colorChange(); });
		limeButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 8; colorChange(); });
		navyButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 9; colorChange(); });
		glaucousButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 10; colorChange(); });

		starButton.GetComponent<Button>().onClick.AddListener( () => { decalIndex = 0; decalChange(); });
		flameButton.GetComponent<Button>().onClick.AddListener( () => { decalIndex = 1; decalChange(); });
		stripeButton.GetComponent<Button>().onClick.AddListener( () => { decalIndex = 2; decalChange(); });

	}

	void truckSwap()
	{
		if (car != null)
		{
			Destroy(car);
		}
		carIndex = 0;
		car = Instantiate(truck) as GameObject;
		car.transform.parent = bodyContainer.transform;
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
		car.transform.parent = bodyContainer.transform;
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
		car.transform.parent = bodyContainer.transform;
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
		car.transform.parent = bodyContainer.transform;
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
		car.transform.parent = bodyContainer.transform;
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
				spoiler.transform.parent = spoilerContainer.transform;
				spoiler.transform.localPosition = new Vector3(-353.27f, 37.1f);
				break;

			case 1:
				if (spoiler != null){
					Destroy(spoiler);
				}
				spoiler = Instantiate(suvSpoiler) as GameObject;
				spoiler.transform.parent = spoilerContainer.transform;
				spoiler.transform.localPosition = new Vector3(-358.4f, 37.1f);
				break;

			case 2:
				if (spoiler != null){
					Destroy(spoiler);
				}
				spoiler = Instantiate(vanSpoiler) as GameObject;
				spoiler.transform.parent = spoilerContainer.transform;
				spoiler.transform.localPosition = new Vector3(-364.8f, 67f);
				break;

			case 3:
				if (spoiler != null){
					Destroy(spoiler);
				}
				spoiler = Instantiate(coupeSpoiler) as GameObject;
				spoiler.transform.parent = spoilerContainer.transform;
				spoiler.transform.localPosition = new Vector3(-352.2f, 52.03f);
				break;

			case 4:
				if (spoiler != null){
					Destroy(spoiler);
				}
				spoiler = Instantiate(compactSpoiler) as GameObject;
				spoiler.transform.parent = spoilerContainer.transform;
				spoiler.transform.localPosition = new Vector3(-278.4f, 70.8f);
				break;

			default:
				break;
		}

	}
	void removeSpoiler()
	{
		Destroy(spoiler);
	}

	void wheelSwap()
	{
		if (leftWheel != null)
		{
			Destroy(leftWheel);
		}
		if (rightWheel != null)
		{
			Destroy(rightWheel);
		}

		switch (carIndex)
		{
		case 0:
			switch (wheelIndex)
			{
			case 0:
				leftWheel = Instantiate(sportWheel) as GameObject;
				rightWheel = Instantiate (sportWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-212.8f, -86.1f);
				rightWheel.transform.localPosition = new Vector3(267.35f, -86.1f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.55f, 0.55f);
				break;
			case 1:
				leftWheel = Instantiate(luxuryWheel) as GameObject;
				rightWheel = Instantiate (luxuryWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-212.8f, -86.1f);
				rightWheel.transform.localPosition = new Vector3(267.35f, -86.1f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.55f, 0.55f);
				break;
			case 2:
				leftWheel = Instantiate(basicWheel) as GameObject;
				rightWheel = Instantiate (basicWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-212.8f, -86.1f);
				rightWheel.transform.localPosition = new Vector3(267.35f, -86.1f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.55f, 0.55f);
				break;
			default:
				break;
			}
			break;
		case 1:
			switch (wheelIndex)
			{
			case 0:
				leftWheel = Instantiate(sportWheel) as GameObject;
				rightWheel = Instantiate (sportWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-215.1f, -106f);
				rightWheel.transform.localPosition = new Vector3(264.3f, -106f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.6f, 0.6f);
				break;
			case 1:
				leftWheel = Instantiate(luxuryWheel) as GameObject;
				rightWheel = Instantiate (luxuryWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-215.1f, -106f);
				rightWheel.transform.localPosition = new Vector3(264.3f, -106f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.6f, 0.6f);
				break;
			case 2:
				leftWheel = Instantiate(basicWheel) as GameObject;
				rightWheel = Instantiate (basicWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-215.1f, -106f);
				rightWheel.transform.localPosition = new Vector3(264.3f, -106f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.6f, 0.6f);
				break;
			default:
				break;
			}
			break;
		case 2:
			switch (wheelIndex)
			{
			case 0:
				leftWheel = Instantiate(sportWheel) as GameObject;
				rightWheel = Instantiate (sportWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-233.9f, -97.2f);
				rightWheel.transform.localPosition = new Vector3(245.6f, -97.2f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.55f, 0.55f);
				break;
			case 1:
				leftWheel = Instantiate(luxuryWheel) as GameObject;
				rightWheel = Instantiate (luxuryWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-233.9f, -97.2f);
				rightWheel.transform.localPosition = new Vector3(245.6f, -97.2f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.55f, 0.55f);
				break;
			case 2:
				leftWheel = Instantiate(basicWheel) as GameObject;
				rightWheel = Instantiate (basicWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-233.9f, -97.2f);
				rightWheel.transform.localPosition = new Vector3(245.6f, -97.2f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.55f, 0.55f);
				break;
			default:
				break;
			}
			break;
		case 3:
			switch (wheelIndex)
			{
			case 0:
				leftWheel = Instantiate(sportWheel) as GameObject;
				rightWheel = Instantiate (sportWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-226.1f, -78.3f);
				rightWheel.transform.localPosition = new Vector3(257.6f, -78.3f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.6f, 0.6f);
				break;
			case 1:
				leftWheel = Instantiate(luxuryWheel) as GameObject;
				rightWheel = Instantiate (luxuryWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-226.1f, -78.3f);
				rightWheel.transform.localPosition = new Vector3(257.6f, -78.3f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.6f, 0.6f);
				break;
			case 2:
				leftWheel = Instantiate(basicWheel) as GameObject;
				rightWheel = Instantiate (basicWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-226.1f, -78.3f);
				rightWheel.transform.localPosition = new Vector3(257.6f, -78.3f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.6f, 0.6f);
				break;
			default:
				break;
			}
			break;
		case 4:
			switch (wheelIndex)
			{
			case 0:
				leftWheel = Instantiate(sportWheel) as GameObject;
				rightWheel = Instantiate (sportWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-207.7f, -81.37f);
				rightWheel.transform.localPosition = new Vector3(187f, -81.37f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.63f, 0.63f);
				break;
			case 1:
				leftWheel = Instantiate(luxuryWheel) as GameObject;
				rightWheel = Instantiate (luxuryWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-207.7f, -81.37f);
				rightWheel.transform.localPosition = new Vector3(187f, -81.37f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.63f, 0.63f);
				break;
			case 2:
				leftWheel = Instantiate(basicWheel) as GameObject;
				rightWheel = Instantiate (basicWheel) as GameObject;
				leftWheel.transform.parent = rightWheel.transform.parent = wheelContainer.transform;
				leftWheel.transform.localPosition = new Vector3(-207.7f, -81.37f);
				rightWheel.transform.localPosition = new Vector3(187f, -81.37f);
				leftWheel.transform.localScale = rightWheel.transform.localScale = new Vector3(0.63f, 0.63f);
				break;
			default:
				break;
			}
			break;
		default:
			break;
		}

	}

	void colorChange()
	{
		switch(colorIndex)
		{
		case 0:
			car.GetComponent<Image>().color = redColor;
			break;
		case 1:
			car.GetComponent<Image>().color = greenColor;
			break;
		case 2:
			car.GetComponent<Image>().color = yellowColor;
			break;
		case 3:
			car.GetComponent<Image>().color = orangeColor;
			break;
		case 4:
			car.GetComponent<Image>().color = turquoiseColor;
			break;
		case 5:
			car.GetComponent<Image>().color = carrotColor;
			break;
		case 6:
			car.GetComponent<Image>().color = pinkColor;
			break;
		case 7:
			car.GetComponent<Image>().color = greyColor;
			break;
		case 8:
			car.GetComponent<Image>().color = limeColor;
			break;
		case 9:
			car.GetComponent<Image>().color = navyColor;
			break;
		case 10:
			car.GetComponent<Image>().color = glaucousColor;
			break;
		default:
			break;
		}
	}

	void decalChange()
	{
		if (decal != null)
		{
			Destroy(decal);
		}
		switch(decalIndex)
		{
			case 0:
				decal = Instantiate(star) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(11.6f, -62.41f);
				break;
			case 1:
				decal = Instantiate(flame) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(42.2f, -62.41f);
				break;
			case 2: 
				decal = Instantiate(stripe) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(0f, -50.1f);
				break;
			default:
				break;
		}
	}
}
