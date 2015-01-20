#pragma strict

	// Grab a screen shot and upload it to a CGI script.
	// The CGI script must be able to hande form uploads.
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
