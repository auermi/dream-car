using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PostRequest : MonoBehaviour {
	/*
	JS VERSION
			var screenShotURL= "fake_url";
			// Take a screen shot immediately
			function UploadPNG() {
			    // We should only read the screen after all rendering is complete
			    yield WaitForEndOfFrame();
			    // Create a texture the size of the screen, RGB24 format
			    var width = Screen.width;
			    var height = Screen.height;
			    var tex = new Texture2D( width, height, TextureFormat.RGB24, false );
			    // Read screen contents into the texture
			    tex.ReadPixels( Rect(0, 0, width, height), 0, 0 );
			    tex.Apply();
			    // Encode texture into PNG
			    var bytes = tex.EncodeToPNG();
			    Destroy( tex );
			    // Create a Web Form
			    var form = new WWWForm();
			    form.AddField("token", "fake_token");
			    form.AddBinaryData("image", bytes, "Assets/Data/Dream-Car.png", "image/png");
			    // Upload to a cgi script
			    var w = WWW(screenShotURL, form);
			    yield w;
			    if (!String.IsNullOrEmpty(w.error))
			        print(w.error);
			    else
			        print("Finished Uploading Screenshot");
			}
	 */

	//Track Screen number so we can choose when to calculate & display the information
	public GameObject start_Button;
	public GameObject restart_Button;
	public GameObject next_Button;
	public GameObject previous_Button;
	private int sceneIndex;
	public GameObject no_button;


	public static float width = 2048f;
	public static float height = 1536f;
	private string url = "fake_url";
	public byte[] bytes;
	private string token = "fake_token";
	public Rect rect = new Rect(0f, 0f, width, height);

	// Use this for initialization
	void Start () {
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++;});
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0;});
		no_button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0;});
		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; /*CheckPost();*/});
		previous_Button.GetComponent<Button>().onClick.AddListener(()=> {sceneIndex--;});
	}

	void CheckPost () {
		if (sceneIndex == 12) {
			StartCoroutine(PostImage());
			Debug.Log ("Posted!");
		}
	}

	IEnumerator PostImage() {

		yield return new WaitForSeconds(.500000001f);
		yield return new WaitForEndOfFrame();
		Texture2D tex = new Texture2D (2048, 1536, TextureFormat.RGB24, false);
		tex.ReadPixels (rect, 0, 0);
		tex.Apply();
		bytes = tex.EncodeToPNG ();
		WWWForm form = new WWWForm ();
		form.AddField ("token", token); 
		form.AddBinaryData("image", bytes, "Assets/Data/Dream-Car.png", "image/png");
		WWW w =  new WWW(url, form);
		yield return w;
	}
}
