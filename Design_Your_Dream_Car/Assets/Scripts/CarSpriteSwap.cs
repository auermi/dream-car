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
	public GameObject noDecalButton;

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

	private int sceneIndex;
	public GameObject gasBtn;
	public GameObject elecBtn;
	public GameObject hybBtn;
	public GameObject autBtn;
	public GameObject manBtn;
	public GameObject fwdBtn;
	public GameObject awdBtn;
	
	public Sprite gasBtnDef;
	public Sprite elecBtnDef;
	public Sprite hybBtnDef;
	public Sprite autBtnDef;
	public Sprite manBtnDef;
	public Sprite fwdBtnDef;
	public Sprite awdBtnDef;

	public GameObject prevBtn2;
	public GameObject prevBtn3;
	public GameObject prevBtn4;
	public GameObject prevBtn6;
	public GameObject prevBtn7;
	public GameObject prevBtn8;
	public GameObject prevBtn9;
	public GameObject prevBtn10;

	public GameObject block2;
	public GameObject block3;
	public GameObject block4;
	public GameObject block6;
	public GameObject block7;
	public GameObject block8;
	public GameObject block9;
	public GameObject block10;

	public GameObject makeSelText;
	private GameObject warnTxt;

	public GameObject infoTxtParent;
	public Sprite spoilerSprite;
	public Sprite noSpoilerSprite;
	public Sprite basicWheelSprite;
	public Sprite luxuryWheelSprite;
	public Sprite sportyWheelSprite;
	public Sprite starSprite;
	public Sprite flameSprite;
	public Sprite stripeSprite;
	public Sprite truckSprite;
	public Sprite suvSprite;
	public Sprite vanSprite;
	public Sprite compactSprite;
	public Sprite coupeSprite;

	public GameObject resetBtn;

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

		sceneIndex = 0;

		truckButton.GetComponent<Button>().onClick.AddListener(() => { truckSwap(); sceneIndex = 6; preventAdvance(); remAdvTxt();});
		suvButton.GetComponent<Button>().onClick.AddListener(() => { suvSwap(); sceneIndex = 6; preventAdvance();remAdvTxt(); });
		vanButton.GetComponent<Button>().onClick.AddListener(() => { vanSwap(); sceneIndex = 6; preventAdvance();remAdvTxt(); });
		coupeButton.GetComponent<Button>().onClick.AddListener(() => { coupeSwap(); sceneIndex = 6; preventAdvance(); remAdvTxt();});
		compactButton.GetComponent<Button>().onClick.AddListener(() => { compactSwap(); sceneIndex = 6; preventAdvance(); remAdvTxt();});

		spoilerButton.GetComponent<Button>().onClick.AddListener(() => { addSpoiler(); sceneIndex = 7; preventAdvance();remAdvTxt();});
		noSpoilerButton.GetComponent<Button>().onClick.AddListener(() => { removeSpoiler(); sceneIndex = 7; preventAdvance();remAdvTxt();});

		basicWheelButton.GetComponent<Button>().onClick.AddListener(() => { wheelIndex = 2; wheelSwap(); sceneIndex = 8; preventAdvance();remAdvTxt();});
		luxuryWheelButton.GetComponent<Button>().onClick.AddListener(() => { wheelIndex = 1; wheelSwap(); sceneIndex = 8; preventAdvance();remAdvTxt();});
		sportyWheelButton.GetComponent<Button>().onClick.AddListener(() => { wheelIndex = 0; wheelSwap(); sceneIndex = 8; preventAdvance();remAdvTxt();});

		redButton.GetComponent<Button>().onClick.AddListener(() => { colorIndex = 0; colorChange(); sceneIndex = 9; preventAdvance();remAdvTxt();});
		greenButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 1; colorChange(); sceneIndex = 9; preventAdvance();remAdvTxt();});
		yellowButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 2; colorChange(); sceneIndex = 9; preventAdvance();remAdvTxt();});
		orangeButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 3; colorChange(); sceneIndex = 9; preventAdvance();remAdvTxt();});
		turquoiseButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 4; colorChange(); sceneIndex = 9; preventAdvance();remAdvTxt();});
		carrotButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 5; colorChange(); sceneIndex = 9; preventAdvance();remAdvTxt();});
		pinkButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 6; colorChange(); sceneIndex = 9; preventAdvance();remAdvTxt();});
		greyButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 7; colorChange(); sceneIndex = 9; preventAdvance();remAdvTxt();});
		limeButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 8; colorChange(); sceneIndex = 9; preventAdvance();remAdvTxt();});
		navyButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 9; colorChange(); sceneIndex = 9; preventAdvance();remAdvTxt();});
		glaucousButton.GetComponent<Button>().onClick.AddListener( () => { colorIndex = 10; colorChange(); sceneIndex = 9; preventAdvance();remAdvTxt();});

		starButton.GetComponent<Button>().onClick.AddListener( () => { decalIndex = 0; decalChange(); sceneIndex = 10; preventAdvance();remAdvTxt();});
		flameButton.GetComponent<Button>().onClick.AddListener( () => { decalIndex = 1; decalChange(); sceneIndex = 10; preventAdvance();remAdvTxt();});
		stripeButton.GetComponent<Button>().onClick.AddListener( () => { decalIndex = 2; decalChange(); sceneIndex = 10; preventAdvance();remAdvTxt();});
		noDecalButton.GetComponent<Button>().onClick.AddListener( () => { removeDecal(); });

		prevBtn2.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 2; clearChoices(); });
		prevBtn3.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 3; clearChoices(); });
		prevBtn4.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 4; clearChoices(); });
		prevBtn6.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 6; clearChoices(); });
		prevBtn7.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 7; clearChoices(); });
		prevBtn8.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 8; clearChoices(); });
		prevBtn9.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 9; clearChoices(); });
		prevBtn10.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 10; clearChoices(); });

		gasBtn.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 2; preventAdvance(); remAdvTxt();});
		elecBtn.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 2; preventAdvance(); remAdvTxt();});
		hybBtn.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 2; preventAdvance(); remAdvTxt();});
		autBtn.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 3; preventAdvance(); remAdvTxt();});
		manBtn.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 3; preventAdvance(); remAdvTxt();});
		fwdBtn.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 4; preventAdvance(); remAdvTxt();});
		awdBtn.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 4; preventAdvance(); remAdvTxt();});

		block2.GetComponent<Button>().onClick.AddListener( () => { dispAdvTxt(); } );
		block3.GetComponent<Button>().onClick.AddListener( () => { dispAdvTxt(); } );
		block4.GetComponent<Button>().onClick.AddListener( () => { dispAdvTxt(); } );
		block6.GetComponent<Button>().onClick.AddListener( () => { dispAdvTxt(); } );
		block7.GetComponent<Button>().onClick.AddListener( () => { dispAdvTxt(); } );
		block8.GetComponent<Button>().onClick.AddListener( () => { dispAdvTxt(); } );
		block9.GetComponent<Button>().onClick.AddListener( () => { dispAdvTxt(); } );
		block10.GetComponent<Button>().onClick.AddListener( () => { dispAdvTxt(); } );

		resetBtn.GetComponent<Button>().onClick.AddListener( () => { resetSelections(); });

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
		switch(carIndex)
		{
		case 0:
			switch(decalIndex)
			{
			case 0:
				decal = Instantiate(star) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(-81.5f, -41.8f);
				break;
			case 1:
				decal = Instantiate(flame) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(132.5f, -56.5f);
				decal.transform.localScale = new Vector3(1f, 0.81f);
				break;
			case 2: 
				decal = Instantiate(stripe) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(0f, -58f);
				decal.transform.localScale = new Vector3(2.08f, 0.5f);
				break;
			default:
				break;
			}
			break;
		case 1:
			switch(decalIndex)
			{
			case 0:
				decal = Instantiate(star) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(-86.8f, -78.3f);
				break;
			case 1:
				decal = Instantiate(flame) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(118.73f, -87.3f);
				decal.transform.localScale = new Vector3(1f, 0.81f);
				break;
			case 2: 
				decal = Instantiate(stripe) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(0f, -80.6f);
				decal.transform.localScale = new Vector3(2f, 0.5f);
				break;
			default:
				break;
			}
			break;
		case 2:
			switch(decalIndex)
			{
			case 0:
				decal = Instantiate(star) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(-125.3f, -62.41f);
				break;
			case 1:
				decal = Instantiate(flame) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(105.4f, -72.2f);
				decal.transform.localScale = new Vector3(1f, 0.73f);
				break;
			case 2: 
				decal = Instantiate(stripe) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(0f, -77f);
				decal.transform.localScale = new Vector3(1.92f, 0.5f);
				break;
			default:
				break;
			}
			break;
		case 3:
			switch(decalIndex)
			{
			case 0:
				decal = Instantiate(star) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(-104.5f, -45.6f);
				break;
			case 1:
				decal = Instantiate(flame) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(106.4f, -56.2f);
				decal.transform.localScale = new Vector3(1f, 0.81f);
				break;
			case 2: 
				decal = Instantiate(stripe) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(0f, -61.7f);
				decal.transform.localScale = new Vector3(2.05f, 0.5f);
				break;
			default:
				break;
			}
			break;
		case 4:
			switch(decalIndex)
			{
			case 0:
				decal = Instantiate(star) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(-79.5f, -53.9f);
				break;
			case 1:
				decal = Instantiate(flame) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(52.6f, -52.6f);
				decal.transform.localScale = new Vector3(1f, 0.82f);
				break;
			case 2: 
				decal = Instantiate(stripe) as GameObject;
				decal.transform.parent = decalContainer.transform;
				decal.transform.localPosition = new Vector3(0f, -64.7f);
				decal.transform.localScale = new Vector3(1.53f, 0.5f);
				break;
			default:
				break;
			}
			break;
		default:
			break;
		}

	}
	void removeDecal()
	{
		Destroy(decal);
	}

	void clearChoices()
	{
		switch (sceneIndex)
		{
		case 2:
			gasBtn.GetComponent<Image>().sprite = gasBtnDef;
			elecBtn.GetComponent<Image>().sprite = elecBtnDef;
			hybBtn.GetComponent<Image>().sprite = hybBtnDef;
			break;
		case 3:
			autBtn.GetComponent<Image>().sprite = autBtnDef;
			manBtn.GetComponent<Image>().sprite = manBtnDef;
			break;
		case 4:
			fwdBtn.GetComponent<Image>().sprite = fwdBtnDef;
			awdBtn.GetComponent<Image>().sprite = awdBtnDef;
			break;
		case 6:
			if (car != null)
			{
				Destroy(car);
			}
			break;
		case 7:
			if (spoiler != null)
			{
				Destroy(spoiler);
			}
			break;
		case 8:
			if (leftWheel != null && rightWheel != null)
			{
				Destroy(leftWheel);
				Destroy(rightWheel);
			}
			break;
		case 9:
			car.GetComponent<Image>().color = new Color32(51,51,51,255);
			break;
		case 10:
			if (decal != null)
			{
				Destroy(decal);
			}
			break;
		default:
			break;
		}

	}
	void preventAdvance()
	{
		switch (sceneIndex)
		{
		case 2:
			if (block2 != null)
			{
				Destroy (block2);
			}
			break;
		case 3:
			if (block3 != null)
			{
				Destroy (block3);
			}
			break;
		case 4:
			if (block4 != null)
			{
				Destroy (block4);
			}
			break;
		case 6:
			if (block6 != null)
			{
				Destroy (block6);
			}
			break;
		case 7:
			if (block7 != null)
			{
				Destroy (block7);
			}
			break;
		case 8:
			if (block8 != null)
			{
				Destroy (block8);
			}
			break;
		case 9:
			if (block9 != null)
			{
				Destroy (block9);
			}
			break;
		case 10:
			if (block10 != null)
			{
				Destroy (block10);
			}
			break;
		
		default:
			break;
		}
	}
	void dispAdvTxt ()
	{
		if (warnTxt == null)
		{
			warnTxt = Instantiate (makeSelText) as GameObject;
			warnTxt.transform.parent = infoTxtParent.transform;
			warnTxt.transform.localPosition = new Vector3(355f, -330f);
		}
	}

	void remAdvTxt()
	{
		if (warnTxt != null)
		{
			Destroy(warnTxt);
		}
	}
	void resetSelections()
	{
		gasBtn.GetComponent<Image>().sprite = gasBtnDef;
		elecBtn.GetComponent<Image>().sprite = elecBtnDef;
		hybBtn.GetComponent<Image>().sprite = hybBtnDef;
		autBtn.GetComponent<Image>().sprite = autBtnDef;
		manBtn.GetComponent<Image>().sprite = manBtnDef;
		fwdBtn.GetComponent<Image>().sprite = fwdBtnDef;
		awdBtn.GetComponent<Image>().sprite = awdBtnDef;
		spoilerButton.GetComponent<Image>().sprite = spoilerSprite;
		noSpoilerButton.GetComponent<Image>().sprite = noSpoilerSprite;
		basicWheelButton.GetComponent<Image>().sprite = basicWheelSprite;
		luxuryWheelButton.GetComponent<Image>().sprite = luxuryWheelSprite;
		sportyWheelButton.GetComponent<Image>().sprite = sportyWheelSprite;
		starButton.GetComponent<Image>().sprite = starSprite;
		stripeButton.GetComponent<Image>().sprite = stripeSprite;
		flameButton.GetComponent<Image>().sprite = flameSprite;
		truckButton.GetComponent<Image>().sprite = truckSprite;
		suvButton.GetComponent<Image>().sprite = suvSprite;
		vanButton.GetComponent<Image>().sprite = vanSprite;
		coupeButton.GetComponent<Image>().sprite = coupeSprite;
		compactButton.GetComponent<Image>().sprite = compactSprite;
		truckButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		suvButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		vanButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		coupeButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		compactButton.GetComponent<Image>().color = new Color32(51,51,51,255);


		if (car != null)
		{
			Destroy(car);
		}
		if (spoiler != null)
		{
			Destroy(spoiler);
		}
		if (leftWheel != null)
		{
			Destroy(leftWheel);
			Destroy(rightWheel);
		}
		if (decal != null)
		{
			Destroy(decal);
		}
	}
}
