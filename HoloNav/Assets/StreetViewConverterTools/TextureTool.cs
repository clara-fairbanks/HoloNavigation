using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Net;

public class TextureTool : MonoBehaviour
{
		public string url = null;//http://javafx.me/files/preview_-23.303391x151.914955.jpg

		void Start ()
		{
				if (url != null) {
						StartCoroutine (download (url));
						
				}
		}
	
		void Update ()
		{
	
		}

		IEnumerator  download (string fromUrl)
		{
				Debug.Log ("download " + fromUrl);				
				WWW www = new WWW (fromUrl);
				yield return www;
				Debug.Log ("set " + fromUrl);
				try {
						Texture2D t = www.texture;
						this.gameObject.GetComponent<Renderer>().material.SetTexture ("_MainTex", t);
				} catch (Exception exception) {
						Debug.Log (exception);
				}
		}
}

