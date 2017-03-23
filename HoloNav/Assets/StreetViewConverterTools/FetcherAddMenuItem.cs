using UnityEngine;
using UnityEditor;
using System.Collections;
using ImageFetcherLibrary;
using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
//using System.Collections;
using System.Net;
using System.Net.Security;
using System.Collections.Generic;

public class FetcherAddMenuItem
{
		[MenuItem ("Window/Google StreetView Converter v1.7.20")]
		static void initAll ()
		{
				FetcherGUI window = (FetcherGUI)EditorWindow.GetWindow (typeof(FetcherGUI));
				window.titleContent = new GUIContent ("Google StreetView Converter v1.7.20");
				window.minSize = new Vector2 (600.0f, 300.0f);
				window.Show ();
		}
}
