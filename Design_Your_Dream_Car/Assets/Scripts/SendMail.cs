

using System.Net;
using System.Net.Mail;
using UnityEngine.UI;

using UnityEngine;

public class SendMail : MonoBehaviour {
	public string sender = "mauermcx@gmail.com";
	public string receiver = "michaelandrewauer@outlook.com";
	public string smtpPassword = "futurejag2014";
	public string smtpHost = "smtp.gmail.com";
	public GameObject mailButton;
	
	// Use this for initialization
	private void Start() {
		mailButton.GetComponent<Button>().onClick.AddListener( () => { mailTo(); });


	}
	private void mailTo() 
	{
		Application.CaptureScreenshot("Assets/Data/Dream-Car.png");

		using (var mail = new MailMessage {
			From = new MailAddress(sender),
			Subject = "test subject",
			Body = "Hello there!"
		}) {
			mail.To.Add(receiver);


			System.Net.Mail.Attachment attachment;
			attachment = new System.Net.Mail.Attachment("Assets/Data/Dream-Car.png");
			mail.Attachments.Add(attachment);

			var smtpServer = new SmtpClient(smtpHost) {
				Port = 25,
				Credentials = (ICredentialsByHost)new NetworkCredential(sender, smtpPassword)
			};
			ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
			smtpServer.EnableSsl = true;
			smtpServer.Send(mail);
		}
		
	}
}