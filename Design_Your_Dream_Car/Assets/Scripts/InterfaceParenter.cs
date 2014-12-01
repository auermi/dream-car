using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InterfaceParenter : MonoBehaviour {

	public GameObject interface1;
	public GameObject interface2;
	public GameObject interfaceContainer;

	public GameObject backArr5;
	public GameObject resetBtn;

	void Start()
	{
		backArr5.GetComponent<Button>().onClick.AddListener(() => { interfaceContainer.transform.parent = interface1.transform; } );
		resetBtn.GetComponent<Button>().onClick.AddListener(() => { interfaceContainer.transform.parent = interface1.transform; } );
	}

	void interfaceSwap()
	{
		interfaceContainer.transform.parent = interface2.transform;
	}

	void resetInterface()
	{
		interfaceContainer.transform.parent = interface1.transform;
	}
}
