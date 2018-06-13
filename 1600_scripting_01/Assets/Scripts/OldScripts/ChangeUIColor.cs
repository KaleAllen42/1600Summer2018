using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
	
[CreateAssetMenu]
public class ChangeUIColor : ScriptableObject
{

	public Color NewColor;
	
	
	public void ColorUI(Image ImageParamater)
	{
		ImageParamater.color = NewColor;
	}
}
