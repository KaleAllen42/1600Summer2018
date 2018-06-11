using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class ColorBehavior : MonoBehaviour 
{

	public ChangeUIColor ChangeColor;
	// Use this for initialization
	void Start ()
	{
		ChangeColor.ColorUI(GetComponent<Image>());
	}
	
}
