using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEngine.UI;

public class navigation : MonoBehaviour {
	
	
	
	// Use this for initialization
	
	void Start () {	
		
	}
	
	// Update is called once per frame
	
	void Update () {		
		
	}
		
	void NavigateForward () {

		GameObject[] slides = GameObject.FindGameObjectsWithTag("Screen").OrderBy(go => go.name).ToArray();

		for (var i = 0; i < slides.Length; i++) {

			Debug.Log (slides[i].name);
			//If slide we're in the array is the one that called the navigation code
			//then its our current slide
			
			if(slides[i] == this.gameObject) {
				
				//only slide if there's enough slides left
				
				if( i+1 < slides.Length ) {					
					
					//assign variables for slides					
					var currentSlide = slides[i];					
					var nextSlide = slides[i+1];

					//assign animations					
					if(currentSlide.transform.localPosition.x == 0){						
						GoToNext();						
					}

					if(nextSlide.transform.localPosition.x == 1024){
						
						//need to send a message to call the next slide's animation code						
						nextSlide.SendMessage("SlideFromRight", SendMessageOptions.DontRequireReceiver);						
						//Debug.Log("HIT");						
						//SlideFromRight();
					}
					
					//break out of loop after one instanct;
					
					break;
					
				}				
			}
		}	
	}

	void NavigateBackward () {
		
		GameObject[] slides = GameObject.FindGameObjectsWithTag("Screen").OrderBy(go => go.name).ToArray();
		
		for (var i = 0; i < slides.Length; i++) {
			//If slide we're in the array is the one that called the navigation code
			//then its our current slide
			
			if(slides[i] == this.gameObject) {
				
				//only slide if there's enough slides left
				
				if( i-1 > 0 ) {					
					
					//assign variables for slides					
					var currentSlide = slides[i];					
					var prevSlide = slides[i-1];

					//assign animations					
					if(currentSlide.transform.localPosition.x == 0){						
						GoToPrev();						
					}
					
					if(prevSlide.transform.localPosition.x == -1024){
						
						//need to send a message to call the next slide's animation code						
						prevSlide.SendMessage("SlideFromLeft", SendMessageOptions.DontRequireReceiver);						
						//Debug.Log("HIT");						
						//SlideFromRight();
					}
					
					//break out of loop after one instanct;
					
					break;
					
				}				
			}
		}	
	}

	//animations
	void GoToNext() {
		AnimationCurve slideLeft = AnimationCurve.EaseInOut(0, 0, .5f, -1024);
		AnimationClip clip = new AnimationClip();
		clip.SetCurve("", typeof(Transform), "localPosition.x", slideLeft);
		animation.AddClip(clip, "next");
		animation.Play("next");
	}
	void GoToPrev() {
		AnimationCurve slideRight = AnimationCurve.EaseInOut(0, 0, .5f, 1024);
		AnimationClip clip = new AnimationClip();
		clip.SetCurve("", typeof(Transform), "localPosition.x", slideRight);
		animation.AddClip(clip, "prev");
		animation.Play("prev");
	}
	void SlideFromRight() {
		AnimationCurve slideFromRight = AnimationCurve.EaseInOut (0, 1024, .5f, 0);
		AnimationClip clip = new AnimationClip();
		clip.SetCurve("", typeof(Transform), "localPosition.x", slideFromRight);
		animation.AddClip(clip, "upNext");
		animation.Play("upNext");
	}
	void SlideFromLeft() {
		AnimationCurve slideFromRight = AnimationCurve.EaseInOut (0, -1024, .5f, 0);
		AnimationClip clip = new AnimationClip();
		clip.SetCurve("", typeof(Transform), "localPosition.x", slideFromRight);
		animation.AddClip(clip, "upNext");
		animation.Play("upNext");
	}
}
