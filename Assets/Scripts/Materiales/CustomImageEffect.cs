﻿using UnityEngine;
using System.Collections;

public class CustomImageEffect : MonoBehaviour {

	public Material EffectMaterial;
	
	void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
		if (EffectMaterial != null)
			Graphics.Blit(src, dst, EffectMaterial);
	}
}
