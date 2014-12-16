using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class navigation : MonoBehaviour {
	//create array for screens/slides
	public static GameObject[] slides;
	private Vector3 startPos;
	
	void Start (){
		//set start position for slide
		startPos = transform.localPosition;
		
		//not sure why this is needed but it works
		slides = GameObject.FindGameObjectsWithTag ("Screen");
		
		//insert game objects into array
		slides [0] = GameObject.Find ("Screen_00");
		slides [1] = GameObject.Find ("Screen_01");
		slides [2] = GameObject.Find ("Screen_02");
		slides [3] = GameObject.Find ("Screen_03");
		slides [4] = GameObject.Find ("Screen_04");
		slides [5] = GameObject.Find ("Screen_05");
		slides [6] = GameObject.Find ("Screen_06");
		slides [7] = GameObject.Find ("Screen_07");
		slides [8] = GameObject.Find ("Screen_08");
		slides [9] = GameObject.Find ("Screen_09");
		slides [10] = GameObject.Find ("Screen_10");
		slides [11] = GameObject.Find ("Screen_11");
		slides [12] = GameObject.Find ("Screen_12");
	}
	
	//NAVIGATE FORWARD
	void NavigateForward () {
		
		for (var i = 0; i < slides.Length; i++) {
			
			//If slide we're in the array is the one that called the navigation code
			//then its our current slide			
			if(slides[i] == this.gameObject) {
				//Debug.Log (slides[i].transform.localPosition);
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
					}
					
					//break out of loop after one instanct;					
					break;					
				}				
			}
		}	
	}
	
	//NAVIGATE IN REVERSE
	void NavigateBackward () {
		
		for (var i = 0; i < slides.Length; i++) {
			//If slide we're in the array is the one that called the navigation code
			//then its our current slide
			
			if(slides[i] == this.gameObject) {
				
				//only slide if there's enough slides left				
								
					
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
					}
					
					//break out of loop after one instanct;					
					break;					
							
			}
		}	
	}
	
	//ANIMATIONS
	void GoToNext() {
		AnimationCurve slideLeft = AnimationCurve.EaseInOut(0f, 0f, .5f, -1024f);
		AnimationClip clip = new AnimationClip();
		clip.SetCurve("", typeof(Transform), "localPosition.x", slideLeft);
		animation.AddClip(clip, "next");
		animation.Play ("next");
	}
	void GoToPrev() {
		AnimationCurve slideRight = AnimationCurve.EaseInOut(0f, 0f, .5f, 1024f);
		AnimationClip clip = new AnimationClip();
		clip.SetCurve("", typeof(Transform), "localPosition.x", slideRight);
		animation.AddClip(clip, "prev");
		animation.Play("prev");
	}
	void SlideFromRight() {
		AnimationCurve slideFromRight = AnimationCurve.EaseInOut (0f, 1024f, .5f, 0f);
		AnimationClip clip = new AnimationClip();
		clip.SetCurve("", typeof(Transform), "localPosition.x", slideFromRight);
		animation.AddClip(clip, "upNext");
		animation.Play("upNext");
	}
	void SlideFromLeft() {
		AnimationCurve slideFromRight = AnimationCurve.EaseInOut (0f, -1024f, .5f, 0f);
		AnimationClip clip = new AnimationClip();
		clip.SetCurve("", typeof(Transform), "localPosition.x", slideFromRight);
		animation.AddClip(clip, "upNext");
		animation.Play("upNext");
	}
	
	//RESET THE SLIDES
	void Restart() {
		//if the slide isn't at it's start location, move it there
		if (this.gameObject.transform.localPosition != startPos) {
			transform.localPosition = startPos;
		}
	}
}