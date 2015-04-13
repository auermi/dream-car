using UnityEngine;
using System.Collections;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

/*JS SAVING SCREENSHOTS
 * 
 * 
 * _ScreenshotWriteToAlbum(Application.persistentDataPath + "/screenshot.png");
 * 
 */

public class SendMail : MonoBehaviour {

	//public GameObject email_field_prefab;
	public MailMessage mail = new MailMessage();

	public GameObject yes_button;
	public GameObject no_button;

	//Track Scene Index to trigger taking the screenshot
	public GameObject start_Button;
	public GameObject restart_Button;
	public GameObject next_Button;
	public GameObject previous_Button;
	private int sceneIndex;

	//Textbox where we get the user's email
	public GameObject email_TextBox;

	//Swap the parent of email_TextBox
	public GameObject hidden_Parent;
	public GameObject scene_13_Parent;

	public GameObject email_Text;
	public GameObject q_text;



	private string user_EmailAddress;

	public GameObject send_button;
	public GameObject send_blocker;

	public Sprite active_send;
	public Sprite inactive_send;

	public GameObject navigation_parent;

	public GameObject pleaseEnterEmailText;
	private GameObject pleaseEnterEmailTextInstantiate;

	public GameObject placeholderText;

	public GameObject loadingText;
	private GameObject loadingTextInstantiate;

	public GameObject confirmText;

	public GameObject emailFieldContainer;

	public const string MatchEmailPattern =
		@"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
			+ @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
			+ @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
			+ @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
	public GameObject validEmailText;
	private GameObject validEmailTextInstantiate;
	
	void Start()
	{
		
		//email_TextBox = Instantiate(email_field_prefab) as GameObject;
		email_TextBox.transform.SetParent(hidden_Parent.transform); 
		email_TextBox.transform.localPosition = new Vector3(550f, -200f);

		yes_button.GetComponent<Button> ().onClick.AddListener (() => { yes_button.transform.SetParent(hidden_Parent.transform); email_TextBox.transform.SetParent(scene_13_Parent.transform); no_button.transform.SetParent(hidden_Parent.transform); q_text.transform.SetParent(hidden_Parent.transform); send_blocker.transform.SetParent(hidden_Parent.transform); send_button.GetComponent<Image>().sprite = active_send; });
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 1; ;});

		restart_Button.GetComponent<Button> ().onClick.AddListener (() => { 
			Application.LoadLevel(0); 
		});

		send_button.GetComponent<Button>().onClick.AddListener(() => {
				StartCoroutine(AttachAndMail());
			});

		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; CheckToScreenshot();  });
		previous_Button.GetComponent<Button>().onClick.AddListener(()=> {yes_button.transform.SetParent(scene_13_Parent.transform); email_TextBox.transform.SetParent(hidden_Parent.transform); no_button.transform.SetParent(scene_13_Parent.transform); q_text.transform.SetParent(scene_13_Parent.transform); send_blocker.transform.SetParent(scene_13_Parent.transform); send_button.GetComponent<Image>().sprite = inactive_send; if (pleaseEnterEmailTextInstantiate != null) {
				Destroy(pleaseEnterEmailTextInstantiate);
				placeholderText.GetComponent<Text>().color = new Color(0.196f, 0.196f, 0.196f, 0.5f);
			}sceneIndex--;});
		no_button.GetComponent<Button> ().onClick.AddListener (() => { yes_button.transform.SetParent(scene_13_Parent.transform); email_TextBox.transform.SetParent(hidden_Parent.transform); no_button.transform.SetParent(scene_13_Parent.transform); q_text.transform.SetParent(scene_13_Parent.transform); sceneIndex = 0; Application.LoadLevel(0);});
	}

	static void RemoveTakeScreenshot () {

		Application.CaptureScreenshot("Dream-Car.png");
		Debug.Log ("Screenshot!");
	}
	
	IEnumerator AttachAndMail()
	{
		
						user_EmailAddress = email_Text.GetComponent<Text>().text;
						if (user_EmailAddress == "") {
							Debug.Log ("Hey put an email in");
							Destroy(pleaseEnterEmailTextInstantiate);
							pleaseEnterEmailTextInstantiate = Instantiate(pleaseEnterEmailText) as GameObject;
							pleaseEnterEmailTextInstantiate.transform.SetParent(scene_13_Parent.transform);
							pleaseEnterEmailTextInstantiate.transform.localPosition = new Vector3(672f, -691.5f);
							placeholderText.GetComponent<Text>().color = new Color(1f, 0f, 0f, 0.7f);
							yield return null;
						} else {
							if (pleaseEnterEmailTextInstantiate != null) {
								Destroy(pleaseEnterEmailTextInstantiate);
							}
							
							if (IsEmail(user_EmailAddress))  { 
							
							
							
							restart_Button.GetComponent<Button>().interactable = false;
							previous_Button.GetComponent<Button>().interactable = false;
							send_button.GetComponent<Button>().interactable = false;
								
							loadingTextInstantiate = Instantiate(loadingText) as GameObject;
							loadingTextInstantiate.transform.SetParent(scene_13_Parent.transform);
							loadingTextInstantiate.transform.localPosition = new Vector3(860f, -691.5f);
							
							

							MailMessage mail = new MailMessage ();
			
							mail.From = new MailAddress ("activities@imamuseum.org");
							mail.To.Add (user_EmailAddress);
							mail.Subject = "Your Dream Car from the Indianapolis Museum of Art";
							mail.Body = "The attached image has been created using the Dream Cars Design Studio app available in the Car Design Studio in the Davis Lab on Floor 2 of the Indianapolis Museum of Art. For more information about our Family Spaces and related programs, check out the website: http://www.imamuseum.org/visit/family-visits/family-spaces" + Environment.NewLine + Environment.NewLine + "Want to design more dream cars? The Dream Cars Design Studio app is available for download on the iTunes App Store." + Environment.NewLine + Environment.NewLine + "The IMA team ";

							System.Net.Mail.Attachment attachment;
							attachment = new System.Net.Mail.Attachment (Application.persistentDataPath + "/Dream-Car.png");
							mail.Attachments.Add (attachment);

							SmtpClient smtpServer = new SmtpClient ("smtp.mandrillapp.com");
							smtpServer.Port = 587;
							smtpServer.Credentials = new System.Net.NetworkCredential ("imalabadmin@imamuseum.org", "") as ICredentialsByHost;
							smtpServer.EnableSsl = true;
							ServicePointManager.ServerCertificateValidationCallback = 
				delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) {
									return true;
							};
							smtpServer.Send (mail);
							yield return null;
							Debug.Log ("success");
							Destroy (loadingTextInstantiate);
							emailFieldContainer.transform.SetParent(hidden_Parent.transform);
							confirmText.GetComponent<Text>().text = "Your Dream Car has been sent to " + Environment.NewLine + user_EmailAddress; 
							yield return new WaitForSeconds(5);
							Application.LoadLevel (0);
			} else {
				placeholderText.GetComponent<Text>().color = new Color(1f, 0f, 0f, 0.7f);
				if (validEmailTextInstantiate != null) {
					Destroy(validEmailTextInstantiate);
				}
				validEmailTextInstantiate = Instantiate(validEmailText) as GameObject;
				validEmailTextInstantiate.transform.SetParent(scene_13_Parent.transform);
				validEmailTextInstantiate.transform.localPosition = new Vector3(680f, -691.5f);
				yield return null;
			}
						}
	}
	  



	void CheckToScreenshot()
	{
		if (sceneIndex == 12)
		{
			StartCoroutine(DelayScreenshot());
			Debug.Log ("Attempted to send mail!");
		}
	}

	IEnumerator DelayScreenshot()
	{
		//pause to wait for the sliding transition
		yield return new WaitForSeconds (.5f);
		//removes the file
		restart_Button.transform.SetParent (hidden_Parent.transform);
		previous_Button.transform.SetParent (hidden_Parent.transform);
		next_Button.transform.SetParent (hidden_Parent.transform);
		RemoveTakeScreenshot ();
		yield return null;
		restart_Button.transform.SetParent (navigation_parent.transform);
		previous_Button.transform.SetParent (navigation_parent.transform);
		next_Button.transform.SetParent (navigation_parent.transform);

	}

	public static bool IsEmail(string email)
	{
		if (email != null) return Regex.IsMatch(email, MatchEmailPattern);
		else return false;
	}
	
	
}