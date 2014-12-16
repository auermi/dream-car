using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarSpriteSwap : MonoBehaviour {

	public GoogleAnalyticsV3 googleAnalytics;

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
	public GameObject gasButton;
	public GameObject electricButton;
	public GameObject hybridButton;
	public GameObject automaticButton;
	public GameObject manualButton;
	public GameObject twoWheelDriveButton;
	public GameObject allWheelDriveButton;
	
	public Sprite gasButtonSprite;
	public Sprite electricButtonSprite;
	public Sprite hybridButtonSprite;
	public Sprite automaticButtonSprite;
	public Sprite manualButtonSprite;
	public Sprite twoWheelDriveButtonSprite;
	public Sprite allWheelDriveButtonSprite;

	public GameObject prevButton1;
	public GameObject prevButton2;
	public GameObject prevButton3;
	public GameObject prevButton4;
	public GameObject prevButton5;
	public GameObject prevButton6;
	public GameObject prevButton7;
	public GameObject prevButton8;
	public GameObject prevButton9;
	public GameObject prevButton10;
	public GameObject prevButton11;

	public GameObject makeSelText;
	private GameObject warnTxt;

	private bool isChosen;

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

	public GameObject resetButton;

	public GameObject nextButton0;
	public GameObject nextButton1;
	public GameObject nextButton2;
	public GameObject nextButton3;
	public GameObject nextButton4;
	public GameObject nextButton5;
	public GameObject nextButton6;
	public GameObject nextButton7;
	public GameObject nextButton8;
	public GameObject nextButton9;
	public GameObject nextButton10;
	public GameObject nextButton11;

	public Sprite nextButtonInactive;
	public Sprite nextButtonActive;

	public GameObject infoButton2;
	public GameObject infoButton3;
	public GameObject infoButton4;
	public GameObject infoButton6;
	public GameObject infoButton7;
	public GameObject infoButton8;
	public GameObject infoButton9;
	public GameObject infoButton10;

	public GameObject textButton2;
	public GameObject textButton3;
	public GameObject textButton4;
	public GameObject textButton6;
	public GameObject textButton7;
	public GameObject textButton8;
	public GameObject textButton9;
	public GameObject textButton10;

	public Sprite basicWheelButtonSprite;
	public Sprite luxuryWheelButtonSprite;
	public Sprite sportyWheelButtonSprite;
	public Sprite noSpoilerButtonSprite;
	public Sprite spoilerButtonSprite;
	public Sprite stripeButtonSprite;
	public Sprite starsButtonSprite;
	public Sprite flamesButtonSprite;
	public Sprite noDecalButtonSprite;
	public Sprite noDecalButtonActiveSprite;
	public Sprite noSpoilerActivebuttonSprite;
	public Sprite spoilerActiveButtonSprite;
	public Sprite whiteSpoiler;

	public GameObject doneButton;

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

		//Setting next buttons inactive to prevent moving on without choice
		nextButton2.GetComponent<Button>().interactable = false;
		nextButton3.GetComponent<Button>().interactable = false;
		nextButton4.GetComponent<Button>().interactable = false;
		nextButton6.GetComponent<Button>().interactable = false;
		nextButton7.GetComponent<Button>().interactable = false;
		nextButton8.GetComponent<Button>().interactable = false;
		nextButton9.GetComponent<Button>().interactable = false;
		nextButton10.GetComponent<Button>().interactable = false;

		//Setting Next Buttons' sprite to the inactive sprite
		nextButton2.GetComponent<Image>().sprite = nextButtonInactive;
		nextButton3.GetComponent<Image>().sprite = nextButtonInactive;
		nextButton4.GetComponent<Image>().sprite = nextButtonInactive;
		nextButton6.GetComponent<Image>().sprite = nextButtonInactive;
		nextButton7.GetComponent<Image>().sprite = nextButtonInactive;
		nextButton8.GetComponent<Image>().sprite = nextButtonInactive;
		nextButton9.GetComponent<Image>().sprite = nextButtonInactive;
		nextButton10.GetComponent<Image>().sprite = nextButtonInactive;

		//Setting Info Button/Text Button Event Listeners to diable next button again if info displayed AND removes existing choices on design portion of app
		/*
		infoButton2.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(2); });
		infoButton3.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(3); });
		infoButton4.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(4); });
		infoButton6.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(6); removeCar(); });
		infoButton7.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(7); removeSpoiler(); });
		infoButton8.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(8); removeWheels(); });
		infoButton9.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(9); removeColor(); });
		infoButton10.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(10); removeDecal(); });

		textButton2.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(2); });
		textButton3.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(3); });
		textButton4.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(4); });
		textButton6.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(6); removeCar(); });
		textButton7.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(7); removeSpoiler(); });
		textButton8.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(8); removeWheels(); });
		textButton9.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(9); removeColor(); });
		textButton10.GetComponent<Button>().onClick.AddListener ( () => { changeNextButtonStateToFalse(10); removeDecal(); });

*/

		//Prepare Button Event Listeners

		//Fuel-Type Event Listeners
		gasButton.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 2;  remAdvTxt(); changeNextButtonStateToTrue(2); });
		electricButton.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 2;  remAdvTxt(); changeNextButtonStateToTrue(2); });
		hybridButton.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 2;  remAdvTxt(); changeNextButtonStateToTrue(2); });

		//Transmission Event Listeners
		automaticButton.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 3;  remAdvTxt(); changeNextButtonStateToTrue(3); });
		manualButton.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 3;  remAdvTxt(); changeNextButtonStateToTrue(3); });

		//Drivetrain Event Listeners
		twoWheelDriveButton.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 4;  remAdvTxt(); changeNextButtonStateToTrue(4); });
		allWheelDriveButton.GetComponent<Button>().onClick.AddListener( () => { sceneIndex = 4;  remAdvTxt(); changeNextButtonStateToTrue(4); });

		//Car Body Event Listeners
		truckButton.GetComponent<Button>().onClick.AddListener(() => { 
			truckSwap();
			nextButton6.GetComponent<Button>().interactable = true;
			sceneIndex = 6; 
			changeNextButtonStateToTrue(6);
			remAdvTxt();  
		});
		suvButton.GetComponent<Button>().onClick.AddListener(() => { 
			suvSwap();
			nextButton6.GetComponent<Button>().interactable = true;
			changeNextButtonStateToTrue(6);
			sceneIndex = 6; 
			remAdvTxt();  
		});
		vanButton.GetComponent<Button>().onClick.AddListener(() => { 
			vanSwap();
			nextButton6.GetComponent<Button>().interactable = true;
			sceneIndex = 6; 
			changeNextButtonStateToTrue(6);
			remAdvTxt();  
		});
		coupeButton.GetComponent<Button>().onClick.AddListener(() => { 
			coupeSwap(); 
			nextButton6.GetComponent<Button>().interactable = true;
			sceneIndex = 6; 
			changeNextButtonStateToTrue(6);
			remAdvTxt(); 
		});
		compactButton.GetComponent<Button>().onClick.AddListener(() => { 
			compactSwap(); 
			nextButton6.GetComponent<Button>().interactable = true;
			sceneIndex = 6; 
			changeNextButtonStateToTrue(6);
			remAdvTxt(); 
		});

		//Spoiler Event Listeners
		spoilerButton.GetComponent<Button>().onClick.AddListener(() => {
			spoilerButton.GetComponent<Image>().sprite = spoilerActiveButtonSprite;
			noSpoilerButton.GetComponent<Image>().sprite = noSpoilerButtonSprite;
			nextButton7.GetComponent<Button>().interactable = true;
			addSpoiler(); 
			sceneIndex = 7; 
			changeNextButtonStateToTrue(7);
			remAdvTxt(); ;
		});
		noSpoilerButton.GetComponent<Button>().onClick.AddListener(() => { 
			nextButton7.GetComponent<Button>().interactable = true;
			spoilerButton.GetComponent<Image>().sprite = spoilerButtonSprite;
			noSpoilerButton.GetComponent<Image>().sprite = noSpoilerActivebuttonSprite;
			removeSpoiler(); 
			sceneIndex = 7; 
			changeNextButtonStateToTrue(7);
			remAdvTxt(); 
			Debug.Log ("heooo");
		});

		//Wheel Event Listeners
		basicWheelButton.GetComponent<Button>().onClick.AddListener(() => { 
			nextButton8.GetComponent<Button>().interactable = true;
			wheelIndex = 2; 
			wheelSwap(); 
			sceneIndex = 8; 
			changeNextButtonStateToTrue(8);
			remAdvTxt(); 
		});
		luxuryWheelButton.GetComponent<Button>().onClick.AddListener(() => { 
			nextButton8.GetComponent<Button>().interactable = true;
			wheelIndex = 1; 
			wheelSwap(); 
			sceneIndex = 8; 
			changeNextButtonStateToTrue(8);
			remAdvTxt(); 
		});
		sportyWheelButton.GetComponent<Button>().onClick.AddListener(() => { 
			nextButton8.GetComponent<Button>().interactable = true;
			wheelIndex = 0; 
			wheelSwap(); 
			sceneIndex = 8; 
			changeNextButtonStateToTrue(8);
			remAdvTxt();
		});

		//Color Event Listeners
		redButton.GetComponent<Button>().onClick.AddListener(() => { 
			nextButton9.GetComponent<Button>().interactable = true;
			colorIndex = 0; 
			colorChange(); 
			sceneIndex = 9; 
			changeNextButtonStateToTrue(9);
			remAdvTxt(); 
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = redColor;
			}
		});
		greenButton.GetComponent<Button>().onClick.AddListener( () => { 

			nextButton9.GetComponent<Button>().interactable = true;
			colorIndex = 1; 
			colorChange(); 
			sceneIndex = 9; 
			changeNextButtonStateToTrue(9);
			remAdvTxt(); 
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = greenColor;
			}
		});
		yellowButton.GetComponent<Button>().onClick.AddListener( () => { 
			nextButton9.GetComponent<Button>().interactable = true;
			colorIndex = 2; 
			colorChange(); 
			sceneIndex = 9; 
			changeNextButtonStateToTrue(9);
			remAdvTxt();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = yellowColor;
			}
		});
		orangeButton.GetComponent<Button>().onClick.AddListener( () => { 
			nextButton9.GetComponent<Button>().interactable = true;
			colorIndex = 3; 
			colorChange(); 
			sceneIndex = 9; 
			changeNextButtonStateToTrue(9);
			remAdvTxt();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = orangeColor;
			}
		});
		turquoiseButton.GetComponent<Button>().onClick.AddListener( () => { 
			nextButton9.GetComponent<Button>().interactable = true;
			colorIndex = 4; 
			colorChange(); 
			sceneIndex = 9; 
			changeNextButtonStateToTrue(9);
			remAdvTxt(); 
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = turquoiseColor;
			}
		});
		carrotButton.GetComponent<Button>().onClick.AddListener( () => {
			nextButton9.GetComponent<Button>().interactable = true;
			colorIndex = 5; 
			colorChange(); 
			sceneIndex = 9; 
			changeNextButtonStateToTrue(9);
			remAdvTxt();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = carrotColor;
			}
		});
		pinkButton.GetComponent<Button>().onClick.AddListener( () => { 
			nextButton9.GetComponent<Button>().interactable = true;
			colorIndex = 6; 
			colorChange(); 
			sceneIndex = 9; 
			changeNextButtonStateToTrue(9);
			remAdvTxt();
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = pinkColor;
			}
		});
		greyButton.GetComponent<Button>().onClick.AddListener( () => { 
			nextButton9.GetComponent<Button>().interactable = true;
			colorIndex = 7; 
			colorChange(); 
			sceneIndex = 9; 
			changeNextButtonStateToTrue(9);
			remAdvTxt(); 
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = greyColor;
			}
		});
		limeButton.GetComponent<Button>().onClick.AddListener( () => { 
			nextButton9.GetComponent<Button>().interactable = true;
			colorIndex = 8; 
			colorChange(); 
			sceneIndex = 9; 
			changeNextButtonStateToTrue(9);
			remAdvTxt(); 
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = limeColor;
			}
		});
		navyButton.GetComponent<Button>().onClick.AddListener( () => { 
			nextButton9.GetComponent<Button>().interactable = true;
			colorIndex = 9; 
			colorChange(); 
			sceneIndex = 9; 
			changeNextButtonStateToTrue(9);
			remAdvTxt(); 
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = navyColor;
			}
		});
		glaucousButton.GetComponent<Button>().onClick.AddListener( () => { 
			nextButton9.GetComponent<Button>().interactable = true;
			colorIndex = 10; 
			colorChange(); 
			sceneIndex = 9; 
			changeNextButtonStateToTrue(9);
			remAdvTxt(); 
			if (spoiler != null)
			{
				spoiler.GetComponent<Image>().color = glaucousColor;
			}
		});

		//Decal Event Listeners
		starButton.GetComponent<Button>().onClick.AddListener( () => { 
			nextButton10.GetComponent<Button>().interactable = true;
			decalIndex = 0; 
			decalChange(); 
			sceneIndex = 10; 
			changeNextButtonStateToTrue(10);
			remAdvTxt();
		});
		flameButton.GetComponent<Button>().onClick.AddListener( () => { 
			nextButton10.GetComponent<Button>().interactable = true;
			decalIndex = 1; 
			decalChange(); 
			sceneIndex = 10; 
			changeNextButtonStateToTrue(10);
			remAdvTxt(); 
		});
		stripeButton.GetComponent<Button>().onClick.AddListener( () => {
			nextButton10.GetComponent<Button>().interactable = true;
			decalIndex = 2; 
			decalChange(); 
			sceneIndex = 10; 
			changeNextButtonStateToTrue(10);
			remAdvTxt(); 
		});
		noDecalButton.GetComponent<Button>().onClick.AddListener( () => { 
			nextButton10.GetComponent<Button>().interactable = true;
			noDecalButton.GetComponent<Image>().sprite = noDecalButtonActiveSprite; 
			changeNextButtonStateToTrue(10);
			removeDecal();
		});







		//Clearing the previous screen's customization option
		prevButton2.GetComponent<Button>().onClick.AddListener( () => {  
			clearChoices();  
		});
		prevButton3.GetComponent<Button>().onClick.AddListener( () => {  
			nextButton2.GetComponent<Button>().interactable = false;
			nextButton2.GetComponent<Image>().sprite = nextButtonInactive;
			clearChoices(); 
		});
		prevButton4.GetComponent<Button>().onClick.AddListener( () => { 
			nextButton3.GetComponent<Image>().sprite = nextButtonInactive;
			nextButton3.GetComponent<Button>().interactable = false; 
			clearChoices();  
		});
		prevButton5.GetComponent<Button>().onClick.AddListener( () => {
			nextButton4.GetComponent<Image>().sprite = nextButtonInactive;
			nextButton4.GetComponent<Button>().interactable = false; 
		});
		prevButton6.GetComponent<Button>().onClick.AddListener( () => {  
			clearChoices(); 
			removeCar(); 
		});
		prevButton7.GetComponent<Button>().onClick.AddListener( () => {  
			clearChoices();
			nextButton6.GetComponent<Image>().sprite = nextButtonInactive;
			nextButton6.GetComponent<Button>().interactable = false; 
			noSpoilerButton.GetComponent<Image>().sprite = noSpoilerButtonSprite; 
			removeSpoiler();
		});
		prevButton8.GetComponent<Button>().onClick.AddListener( () => {  
			clearChoices();
			nextButton7.GetComponent<Image>().sprite = nextButtonInactive;
			nextButton7.GetComponent<Button>().interactable = false; 
			removeWheels();  
		});
		prevButton9.GetComponent<Button>().onClick.AddListener( () => {  
			clearChoices(); 
			nextButton8.GetComponent<Button>().interactable = false; 
			nextButton8.GetComponent<Image>().sprite = nextButtonInactive;
			removeColor(); 
		});
		prevButton10.GetComponent<Button>().onClick.AddListener( () => {  
			clearChoices(); 
			nextButton9.GetComponent<Button>().interactable = false; 
			nextButton9.GetComponent<Image>().sprite = nextButtonInactive;
			removeDecal(); noDecalButton.GetComponent<Image>().sprite = noDecalButtonSprite; 
		});

		//Reset Button resets selections
		resetButton.GetComponent<Button>().onClick.AddListener( () => { resetSelections(); });
		doneButton.GetComponent<Button>().onClick.AddListener( () => { resetSelections(); });

		nextButton1.GetComponent<Image>().enabled = true;
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


	void clearChoices()
	{
		switch (sceneIndex)
		{
		case 2:
			gasButton.GetComponent<Image>().sprite = gasButtonSprite;
			electricButton.GetComponent<Image>().sprite = electricButtonSprite;
			hybridButton.GetComponent<Image>().sprite = hybridButtonSprite;
			break;
		case 3:
			automaticButton.GetComponent<Image>().sprite = automaticButtonSprite;
			manualButton.GetComponent<Image>().sprite = manualButtonSprite;
			break;
		case 4:
			twoWheelDriveButton.GetComponent<Image>().sprite = twoWheelDriveButtonSprite;
			allWheelDriveButton.GetComponent<Image>().sprite = allWheelDriveButtonSprite;
			break;
		case 6:
			removeCar();
			break;
		case 7:
			removeSpoiler();
			break;
		case 8:
			removeWheels();
			break;
		case 9:
			removeColor();
			break;
		case 10:
			removeDecal();
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
		gasButton.GetComponent<Image>().sprite = gasButtonSprite;
		electricButton.GetComponent<Image>().sprite = electricButtonSprite;
		hybridButton.GetComponent<Image>().sprite = hybridButtonSprite;
		automaticButton.GetComponent<Image>().sprite = automaticButtonSprite;
		manualButton.GetComponent<Image>().sprite = manualButtonSprite;
		twoWheelDriveButton.GetComponent<Image>().sprite = twoWheelDriveButtonSprite;
		allWheelDriveButton.GetComponent<Image>().sprite = allWheelDriveButtonSprite;
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
	void changeNextButtonStateToFalse(int scene)
	{
		//Setting next buttons inactive to prevent moving on without choice
		//Setting Next Buttons' sprite to the inactive sprite

		switch (scene)
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
			nextButton2.GetComponent<Button>().interactable = false;
			nextButton2.GetComponent<Image>().sprite = nextButtonInactive;
			break;
		case 3:
			nextButton3.GetComponent<Button>().interactable = false;
			nextButton3.GetComponent<Image>().sprite = nextButtonInactive;
			break;
		case 4:
			nextButton4.GetComponent<Button>().interactable = false;
			nextButton4.GetComponent<Image>().sprite = nextButtonInactive;
			break;
		case 5:
			break;
		case 6:
			nextButton6.GetComponent<Button>().interactable = false;
			nextButton6.GetComponent<Image>().sprite = nextButtonInactive;
			break;
		case 7:
			nextButton7.GetComponent<Button>().interactable = false;
			nextButton7.GetComponent<Image>().sprite = nextButtonInactive;
			break;
		case 8:
			nextButton8.GetComponent<Button>().interactable = false;
			nextButton8.GetComponent<Image>().sprite = nextButtonInactive;
			break;
		case 9:
			nextButton9.GetComponent<Button>().interactable = false;
			nextButton9.GetComponent<Image>().sprite = nextButtonInactive;
			break;
		case 10:
			nextButton10.GetComponent<Button>().interactable = false;
			nextButton10.GetComponent<Image>().sprite = nextButtonInactive;
			break;
		case 11:
			break;
		default:
			break;
		}
	}
	void changeNextButtonStateToTrue(int scene)
	{
		//Setting next buttons to active to allow moving to next option
		//Setting Next Buttons' sprite to the active sprite
		switch (scene)
		{
		case 0:
			break;
		case 1:
			break;
		case 2:
			nextButton2.GetComponent<Button>().interactable = true;
			nextButton2.GetComponent<Image>().sprite = nextButtonActive;
			break;
		case 3:
			nextButton3.GetComponent<Button>().interactable = true;
			nextButton3.GetComponent<Image>().sprite = nextButtonActive;
			break;
		case 4:
			nextButton4.GetComponent<Button>().interactable = true;
			nextButton4.GetComponent<Image>().sprite = nextButtonActive;
			break;
		case 5:
			break;
		case 6:
			nextButton6.GetComponent<Button>().interactable = true;
			nextButton6.GetComponent<Image>().sprite = nextButtonActive;
			break;
		case 7:
			nextButton7.GetComponent<Button>().interactable = true;
			nextButton7.GetComponent<Image>().sprite = nextButtonActive;
			break;
		case 8:
			nextButton8.GetComponent<Button>().interactable = true;
			nextButton8.GetComponent<Image>().sprite = nextButtonActive;
			break;
		case 9:
			nextButton9.GetComponent<Button>().interactable = true;
			nextButton9.GetComponent<Image>().sprite = nextButtonActive;
			break;
		case 10:
			nextButton10.GetComponent<Button>().interactable = true;
			nextButton10.GetComponent<Image>().sprite = nextButtonActive;
			break;
		case 11:
			break;
		default:
			break;
		}
	}
	void removeCar()
	{
		if (car != null)
		{
			Destroy(car);
		}
		truckButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		suvButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		vanButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		coupeButton.GetComponent<Image>().color = new Color32(51,51,51,255);
		compactButton.GetComponent<Image>().color = new Color32(51,51,51,255);
	}
	void removeColor()
	{
		car.GetComponent<Image>().color = new Color32(51,51,51,255);
	}
	void removeWheels()
	{
		if (leftWheel != null)
		{
			Destroy(leftWheel);
			Destroy(rightWheel);
		}
		basicWheelButton.GetComponent<Image>().sprite = basicWheelButtonSprite;
		luxuryWheelButton.GetComponent<Image>().sprite = luxuryWheelButtonSprite;
		sportyWheelButton.GetComponent<Image>().sprite = sportyWheelButtonSprite;

	}
	void removeDecal()
	{
		if (decal != null)
		{
			Destroy(decal);
		}
		flameButton.GetComponent<Image>().sprite = flamesButtonSprite;
		starButton.GetComponent<Image>().sprite = starsButtonSprite;
		stripeButton.GetComponent<Image>().sprite = stripeButtonSprite;

	}

	void removeSpoiler()
	{
		if (spoiler != null)
		{
			Destroy(spoiler);
		}
		spoilerButton.GetComponent<Image>().sprite = spoilerButtonSprite;
	}
}
