//Written by Michael Andrew Auer for the Indianapolis Museum of Art Dream Car iPad Application
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonStateChange : MonoBehaviour {

	//Gather all the selection Buttons
	public GameObject gas_Button;
	public GameObject electric_Button;
	public GameObject hybrid_Button;
	public GameObject automatic_Button;
	public GameObject manual_Button;
	public GameObject twoWheelDrive_Button;
	public GameObject allWheelDrive_Button;
	public GameObject truck_Button;
	public GameObject suv_Button;
	public GameObject van_Button;
	public GameObject coupe_Button;
	public GameObject compact_Button;
	public GameObject spoiler_Button;
	public GameObject noSpoiler_Button;
	public GameObject basicWheel_Button;
	public GameObject sportyWheel_Button;
	public GameObject luxuryWheel_Button;
	public GameObject flame_Button;
	public GameObject stripe_Button;
	public GameObject star_Button;
	public GameObject noDecal_Button;

	//Active State Sprites
	public Sprite gas_Button_Sprite_Active;
	public Sprite electric_Button_Sprite_Active;
	public Sprite hybrid_Button_Sprite_Active;
	public Sprite automatic_Button_Sprite_Active;
	public Sprite manual_Button_Sprite_Active;
	public Sprite twoWheelDrive_Button_Sprite_Active;
	public Sprite allWheelDrive_Button_Sprite_Active;
	public Sprite noSpoiler_Button_Sprite_Active;
	public Sprite basicWheel_Button_Sprite_Active;
	public Sprite sportyWheel_Button_Sprite_Active;
	public Sprite luxuryWheel_Button_Sprite_Active;
	public Sprite flame_Button_Sprite_Active;
	public Sprite stripe_Button_Sprite_Active;
	public Sprite star_Button_Sprite_Active;
	public Sprite noDecal_Button_Sprite_Active;

	//Inactive State Sprites
	public Sprite gas_Button_Sprite_Inactive;
	public Sprite electric_Button_Sprite_Inactive;
	public Sprite hybrid_Button_Sprite_Inactive;
	public Sprite automatic_Button_Sprite_Inactive;
	public Sprite manual_Button_Sprite_Inactive;
	public Sprite twoWheelDrive_Button_Sprite_Inactive;
	public Sprite allWheelDrive_Button_Sprite_Inactive;
	public Sprite noSpoiler_Button_Sprite_Inactive;
	public Sprite basicWheel_Button_Sprite_Inactive;
	public Sprite sportyWheel_Button_Sprite_Inactive;
	public Sprite luxuryWheel_Button_Sprite_Inactive;
	public Sprite flame_Button_Sprite_Inactive;
	public Sprite stripe_Button_Sprite_Inactive;
	public Sprite star_Button_Sprite_Inactive;
	public Sprite noDecal_Button_Sprite_Inactive;

	//Car/Spoiler Hues
	private Color32 blue_Color = new Color32 (6, 120, 190, 255);
	private Color32 grey_Color = new Color32 (51, 51, 51, 255);

	//Previous Button to reset selections
	public GameObject previousSlide_Button;

	//Gathering the gameobject that transition is attached to so we can access the scene index
	public GameObject appSlider_ref;

	//Set Event Listeners for each button to change their image from inactive to active and vice versa
	//The Car bodies' and spoilers are the exception because we change their hue instead of swapping their image
	void Start()
	{
		//Screen 2 (Fuel)
		gas_Button.GetComponent<Button>().onClick.AddListener(() => { gas_Button.GetComponent<Image>().sprite = gas_Button_Sprite_Active;  electric_Button.GetComponent<Image>().sprite = electric_Button_Sprite_Inactive; hybrid_Button.GetComponent<Image>().sprite = hybrid_Button_Sprite_Inactive;} );
		electric_Button.GetComponent<Button>().onClick.AddListener(() => { gas_Button.GetComponent<Image>().sprite = gas_Button_Sprite_Inactive;  electric_Button.GetComponent<Image>().sprite = electric_Button_Sprite_Active; hybrid_Button.GetComponent<Image>().sprite = hybrid_Button_Sprite_Inactive;} );
		hybrid_Button.GetComponent<Button>().onClick.AddListener(() => { gas_Button.GetComponent<Image>().sprite = gas_Button_Sprite_Inactive;  electric_Button.GetComponent<Image>().sprite = electric_Button_Sprite_Inactive; hybrid_Button.GetComponent<Image>().sprite = hybrid_Button_Sprite_Active;} );
		//Screen 3 (Transmission)
		automatic_Button.GetComponent<Button>().onClick.AddListener(() => { manual_Button.GetComponent<Image>().sprite = manual_Button_Sprite_Inactive;  automatic_Button.GetComponent<Image>().sprite = automatic_Button_Sprite_Active;} );
		manual_Button.GetComponent<Button>().onClick.AddListener(() => { manual_Button.GetComponent<Image>().sprite = manual_Button_Sprite_Active;  automatic_Button.GetComponent<Image>().sprite = automatic_Button_Sprite_Inactive;} );
		//Screen 4 (Drivetrain)
		twoWheelDrive_Button.GetComponent<Button>().onClick.AddListener(() => { twoWheelDrive_Button.GetComponent<Image>().sprite = twoWheelDrive_Button_Sprite_Active; allWheelDrive_Button.GetComponent<Image>().sprite = allWheelDrive_Button_Sprite_Inactive; });
		allWheelDrive_Button.GetComponent<Button>().onClick.AddListener(() => { twoWheelDrive_Button.GetComponent<Image>().sprite = twoWheelDrive_Button_Sprite_Inactive; allWheelDrive_Button.GetComponent<Image>().sprite = allWheelDrive_Button_Sprite_Active; });
		//Screen 6 (Body Style)
		truck_Button.GetComponent<Button>().onClick.AddListener(() => { truck_Button.GetComponent<Image>().color = blue_Color; suv_Button.GetComponent<Image>().color = grey_Color; van_Button.GetComponent<Image>().color = grey_Color; coupe_Button.GetComponent<Image>().color = grey_Color; compact_Button.GetComponent<Image>().color = grey_Color; });
		suv_Button.GetComponent<Button>().onClick.AddListener(() => { truck_Button.GetComponent<Image>().color = grey_Color; suv_Button.GetComponent<Image>().color = blue_Color; van_Button.GetComponent<Image>().color = grey_Color; coupe_Button.GetComponent<Image>().color = grey_Color; compact_Button.GetComponent<Image>().color = grey_Color; });
		van_Button.GetComponent<Button>().onClick.AddListener(() => { truck_Button.GetComponent<Image>().color = grey_Color; suv_Button.GetComponent<Image>().color = grey_Color; van_Button.GetComponent<Image>().color = blue_Color; coupe_Button.GetComponent<Image>().color = grey_Color; compact_Button.GetComponent<Image>().color = grey_Color; });
		coupe_Button.GetComponent<Button>().onClick.AddListener(() => { truck_Button.GetComponent<Image>().color = grey_Color; suv_Button.GetComponent<Image>().color = grey_Color; van_Button.GetComponent<Image>().color = grey_Color; coupe_Button.GetComponent<Image>().color = blue_Color; compact_Button.GetComponent<Image>().color = grey_Color; });
		compact_Button.GetComponent<Button>().onClick.AddListener(() => { truck_Button.GetComponent<Image>().color = grey_Color; suv_Button.GetComponent<Image>().color = grey_Color; van_Button.GetComponent<Image>().color = grey_Color; coupe_Button.GetComponent<Image>().color = grey_Color; compact_Button.GetComponent<Image>().color = blue_Color; });
		//Screen 7 (Spoiler)
		spoiler_Button.GetComponent<Button>().onClick.AddListener(() => { spoiler_Button.GetComponent<Image>().color = blue_Color; noSpoiler_Button.GetComponent<Image>().sprite = noDecal_Button_Sprite_Inactive;});
		noSpoiler_Button.GetComponent<Button>().onClick.AddListener(() => { spoiler_Button.GetComponent<Image>().color = grey_Color; noSpoiler_Button.GetComponent<Image>().sprite = noDecal_Button_Sprite_Active;});
		//Screen 8 (Wheels)
		basicWheel_Button.GetComponent<Button> ().onClick.AddListener (() => { basicWheel_Button.GetComponent<Image>().sprite = basicWheel_Button_Sprite_Active; sportyWheel_Button.GetComponent<Image>().sprite = sportyWheel_Button_Sprite_Inactive; luxuryWheel_Button.GetComponent<Image>().sprite = luxuryWheel_Button_Sprite_Inactive; });
		sportyWheel_Button.GetComponent<Button> ().onClick.AddListener (() => { basicWheel_Button.GetComponent<Image>().sprite =  basicWheel_Button_Sprite_Inactive; sportyWheel_Button.GetComponent<Image>().sprite = sportyWheel_Button_Sprite_Active; luxuryWheel_Button.GetComponent<Image>().sprite = luxuryWheel_Button_Sprite_Inactive;});
		luxuryWheel_Button.GetComponent<Button> ().onClick.AddListener (() => { basicWheel_Button.GetComponent<Image>().sprite =  basicWheel_Button_Sprite_Inactive; sportyWheel_Button.GetComponent<Image>().sprite = sportyWheel_Button_Sprite_Inactive; luxuryWheel_Button.GetComponent<Image>().sprite = luxuryWheel_Button_Sprite_Active;});
		//Screen 10 (Decal)
		flame_Button.GetComponent<Button> ().onClick.AddListener (() => { flame_Button.GetComponent<Image>().sprite = flame_Button_Sprite_Active; stripe_Button.GetComponent<Image>().sprite = stripe_Button_Sprite_Inactive; star_Button.GetComponent<Image>().sprite = star_Button_Sprite_Inactive; noDecal_Button.GetComponent<Image>().sprite = noDecal_Button_Sprite_Inactive; });
		stripe_Button.GetComponent<Button> ().onClick.AddListener (() => { flame_Button.GetComponent<Image>().sprite = flame_Button_Sprite_Inactive; stripe_Button.GetComponent<Image>().sprite = stripe_Button_Sprite_Active; star_Button.GetComponent<Image>().sprite = star_Button_Sprite_Inactive; noDecal_Button.GetComponent<Image>().sprite = noDecal_Button_Sprite_Inactive; });
		star_Button.GetComponent<Button> ().onClick.AddListener (() => { flame_Button.GetComponent<Image>().sprite = flame_Button_Sprite_Inactive; stripe_Button.GetComponent<Image>().sprite = stripe_Button_Sprite_Inactive; star_Button.GetComponent<Image>().sprite = star_Button_Sprite_Active; noDecal_Button.GetComponent<Image>().sprite = noDecal_Button_Sprite_Inactive; });
		noDecal_Button.GetComponent<Button> ().onClick.AddListener (() => { flame_Button.GetComponent<Image>().sprite = flame_Button_Sprite_Inactive; stripe_Button.GetComponent<Image>().sprite = stripe_Button_Sprite_Inactive; star_Button.GetComponent<Image>().sprite = star_Button_Sprite_Inactive; noDecal_Button.GetComponent<Image>().sprite = noDecal_Button_Sprite_Active; });

		//Previous Button removes current screens selection
		previousSlide_Button.GetComponent<Button>().onClick.AddListener ( () => { RemovePreviousScreenSelection(); });


	}

	/*Gather the value of scene index and then move Selection from the previous screen
	IMPORTANT: REMOVAL IS 3 FOLD: FUNCTIONAL (DIALS) COSMETIC (CAR BODY) SELECTION (BUTTON STATES)
	THIS ONLY HANDLES BUTTON STATE REVERSION
	Values are staggered minus one because of the change in the values selection */
	void RemovePreviousScreenSelection()
	{
		Transition transition_Script = appSlider_ref.GetComponent<Transition> ();
		int localSceneIndex = transition_Script.scene_index;
		switch (localSceneIndex)
		{
		case 1:
			gas_Button.GetComponent<Image>().sprite = gas_Button_Sprite_Inactive;
			electric_Button.GetComponent<Image>().sprite = electric_Button_Sprite_Inactive;
			hybrid_Button.GetComponent<Image>().sprite = hybrid_Button_Sprite_Inactive;
			break;
		case 2:
			automatic_Button.GetComponent<Image>().sprite = automatic_Button_Sprite_Inactive;
			manual_Button.GetComponent<Image>().sprite = manual_Button_Sprite_Inactive;
			break;
		case 3: 
			allWheelDrive_Button.GetComponent<Image>().sprite = allWheelDrive_Button_Sprite_Inactive;
			twoWheelDrive_Button.GetComponent<Image>().sprite = twoWheelDrive_Button_Sprite_Inactive;
			break;
		case 5:
			truck_Button.GetComponent<Image>().color = grey_Color;
			suv_Button.GetComponent<Image>().color = grey_Color;
			van_Button.GetComponent<Image>().color = grey_Color;
			coupe_Button.GetComponent<Image>().color = grey_Color;
			compact_Button.GetComponent<Image>().color = grey_Color;
			break;
		case 6:
			spoiler_Button.GetComponent<Image>().color = grey_Color;
			noSpoiler_Button.GetComponent<Image>().sprite = noSpoiler_Button_Sprite_Active;
			break;
		case 7:
			basicWheel_Button.GetComponent<Image>().sprite = basicWheel_Button_Sprite_Inactive;
			sportyWheel_Button.GetComponent<Image>().sprite = sportyWheel_Button_Sprite_Inactive;
			luxuryWheel_Button.GetComponent<Image>().sprite = luxuryWheel_Button_Sprite_Inactive;
			break;
		case 9:
			flame_Button.GetComponent<Image>().sprite = flame_Button_Sprite_Inactive;
			stripe_Button.GetComponent<Image>().sprite = stripe_Button_Sprite_Inactive;
			star_Button.GetComponent<Image>().sprite = star_Button_Sprite_Inactive;
			noDecal_Button.GetComponent<Image>().sprite = noDecal_Button_Sprite_Active;
			break;
		default:
			break;
		}
	}
}
