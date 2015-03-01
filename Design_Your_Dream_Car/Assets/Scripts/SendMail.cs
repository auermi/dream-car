using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.IO;


public class SendMail : MonoBehaviour {

	public GameObject email_field_prefab;
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
	private GameObject email_TextBox;

	//Swap the parent of email_TextBox
	public GameObject hidden_Parent;
	public GameObject scene_13_Parent;

	public GameObject email_Text;
	public GameObject q_text;

	void Start()
	{
		email_TextBox = Instantiate(email_field_prefab) as GameObject;
		email_TextBox.transform.SetParent(hidden_Parent.transform); 
		email_TextBox.transform.localPosition = new Vector3(550f, -510f);


		yes_button.GetComponent<Button> ().onClick.AddListener (() => { yes_button.transform.SetParent(hidden_Parent.transform); email_TextBox.transform.SetParent(scene_13_Parent.transform); no_button.transform.SetParent(hidden_Parent.transform); q_text.transform.SetParent(hidden_Parent.transform);});
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 1; ;});

		restart_Button.GetComponent<Button> ().onClick.AddListener (() => { 
			Destroy(email_TextBox);
			email_TextBox = Instantiate(email_field_prefab) as GameObject;
			email_TextBox.transform.SetParent(hidden_Parent.transform); 
			email_TextBox.transform.localPosition = new Vector3(550f, -510f);
			yes_button.transform.SetParent(scene_13_Parent.transform); 
			yes_button.transform.localPosition = new Vector3(416.32f, -150f);
			no_button.transform.SetParent(scene_13_Parent.transform); 
			no_button.transform.localPosition = new Vector3(609.4f, -150f);
			q_text.transform.SetParent(scene_13_Parent.transform); 
			q_text.transform.localPosition = new Vector3(513f, -22f);
			CheckToMail(); 
			sceneIndex = 0;
		});

		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; CheckToScreenshot(); Debug.Log (sceneIndex);});
		previous_Button.GetComponent<Button>().onClick.AddListener(()=> {yes_button.transform.SetParent(scene_13_Parent.transform); email_TextBox.transform.SetParent(hidden_Parent.transform); no_button.transform.SetParent(scene_13_Parent.transform); q_text.transform.SetParent(scene_13_Parent.transform); sceneIndex--;});
		no_button.GetComponent<Button> ().onClick.AddListener (() => { yes_button.transform.SetParent(scene_13_Parent.transform); email_TextBox.transform.SetParent(hidden_Parent.transform); no_button.transform.SetParent(scene_13_Parent.transform); q_text.transform.SetParent(scene_13_Parent.transform); CheckToMail(); sceneIndex = 0; });
	}

	static void RemoveTakeScreenshot () {
		//removes the file
		File.Delete("Assets/Data/Dream-Car.png");
		Application.CaptureScreenshot("Assets/Data/Dream-Car.png");
		Debug.Log ("Screenshot!");
	}
	
	void AttachAndMail(string emailAddress)
	{
		MailMessage mail = new MailMessage();
		
		mail.From = new MailAddress("imalabadmin@imamuseum.org");
		mail.To.Add(emailAddress);
		mail.Subject = "IMA Test Mail";
		mail.Body = "Hello, attached is your Dream Car from the IMA Dream Car iOS App";

		System.Net.Mail.Attachment attachment;
		attachment = new System.Net.Mail.Attachment("Assets/Data/Dream-Car.png");
		mail.Attachments.Add(attachment);
		
		SmtpClient smtpServer = new SmtpClient("smtp.mandrillapp.com");
		smtpServer.Port = 587;
		smtpServer.Credentials = new System.Net.NetworkCredential("imalabadmin@imamuseum.org", "tessttt") as ICredentialsByHost;
		smtpServer.EnableSsl = true;
		ServicePointManager.ServerCertificateValidationCallback = 
			delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) 
		{ return true; };
		smtpServer.Send(mail);
		Debug.Log("success");
		
	}

	void MailIt2() {

				MailMessage mail = new MailMessage();
				
				mail.From = new MailAddress("imalabadmin@imamuseum.org");
				mail.To.Add("mauermcx@gmail.com");
				mail.Subject = "Test Mail";
				mail.Body = "This is for testing SMTP mail from GMAIL";
				
				SmtpClient smtpServer = new SmtpClient("smtp.mandrillapp.com");
				smtpServer.Port = 587;
				smtpServer.Credentials = new System.Net.NetworkCredential("imalabadmin@imamuseum.org", "D32RGV9XlKVZlanXsh0pIg") as ICredentialsByHost;
				smtpServer.EnableSsl = true;
				ServicePointManager.ServerCertificateValidationCallback = 
					delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) 
				{ return true; };
				smtpServer.Send(mail);
				Debug.Log("success");
				
			}
		

	void CheckToMail()
	{
		if (sceneIndex == 13)
		{
			string user_EmailAddress = email_Text.GetComponent<Text>().text;
			Debug.Log(user_EmailAddress);
			AttachAndMail(user_EmailAddress);
			MailIt2();
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