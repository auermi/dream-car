using UnityEngine;
using System.Collections;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using UnityEngine.UI;

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


	void Start()
	{

		//email_TextBox = Instantiate(email_field_prefab) as GameObject;
		email_TextBox.transform.SetParent(hidden_Parent.transform); 
		email_TextBox.transform.localPosition = new Vector3(550f, -200f);

		yes_button.GetComponent<Button> ().onClick.AddListener (() => { yes_button.transform.SetParent(hidden_Parent.transform); email_TextBox.transform.SetParent(scene_13_Parent.transform); no_button.transform.SetParent(hidden_Parent.transform); q_text.transform.SetParent(hidden_Parent.transform); send_blocker.transform.SetParent(hidden_Parent.transform); send_button.GetComponent<Image>().sprite = active_send; previous_Button.transform.localPosition = new Vector3(-900f, 20f); send_button.transform.localPosition = new Vector3(900f, 20f); });
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 1; ;});

		restart_Button.GetComponent<Button> ().onClick.AddListener (() => { 
			Application.LoadLevel(0); 
		});

		send_button.GetComponent<Button>().onClick.AddListener(() => {
				StartCoroutine(AttachAndMail());
			});

		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; CheckToScreenshot();  });
		previous_Button.GetComponent<Button>().onClick.AddListener(()=> {yes_button.transform.SetParent(scene_13_Parent.transform); email_TextBox.transform.SetParent(hidden_Parent.transform); no_button.transform.SetParent(scene_13_Parent.transform); q_text.transform.SetParent(scene_13_Parent.transform); send_blocker.transform.SetParent(scene_13_Parent.transform); send_button.GetComponent<Image>().sprite = inactive_send;  previous_Button.transform.localPosition = new Vector3(-900f, -680f); send_button.transform.localPosition = new Vector3(900f, -680f); sceneIndex--;});
		no_button.GetComponent<Button> ().onClick.AddListener (() => { yes_button.transform.SetParent(scene_13_Parent.transform); email_TextBox.transform.SetParent(hidden_Parent.transform); no_button.transform.SetParent(scene_13_Parent.transform); q_text.transform.SetParent(scene_13_Parent.transform); sceneIndex = 0; Application.LoadLevel(0);});
	}

	static void RemoveTakeScreenshot () {

		Application.CaptureScreenshot("Dream-Car.png");
		Debug.Log ("Screenshot!");
	}
	void EnterEmail() {}
	IEnumerator AttachAndMail()
	{
		if (sceneIndex == 13) {
						user_EmailAddress = email_Text.GetComponent<Text>().text;
						MailMessage mail = new MailMessage ();
		
						mail.From = new MailAddress ("imalabadmin@imamuseum.org");
						mail.To.Add (user_EmailAddress);
						mail.Subject = "IMA Test Mail";
						mail.Body = "Hello, attached is your Dream Car from the IMA Dream Car iOS App";

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
						Application.LoadLevel(0);
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
		RemoveTakeScreenshot ();
	}
	
	
}