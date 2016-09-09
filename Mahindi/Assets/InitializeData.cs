using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;

public class InitializeData: MonoBehaviour
{

	public void getData(){
		StreamReader reader = File.OpenText("/Users/Jack/Documents/Summary_test.csv");
		string line;
		List<string> listDataDAP = new List<string> ();
		List<string> listDataCAN = new List<string> ();
		List<string> listDataL = new List<string> ();
		List<string> listDataPH = new List<string> ();
		List<string> listYieldTotal = new List<string> ();
		while ((line = reader.ReadLine()) != null) {
			string[] items = line.Split(',');
			string words = items[2];
			string lineYield = items [6];

			string[] stringSeparators = new string[] {"DAP", "_CAN", "_L", "_PH"};
			string[] result = words.Split (stringSeparators, StringSplitOptions.None);
			listDataDAP.Add(result[1]);
			listDataCAN.Add(result[2]);
			listDataL.Add(result[3]);
			listDataPH.Add(result[4]);
			listYieldTotal.Add(lineYield);
		}

		string[] dataDAP = listDataDAP.ToArray ();
		string[] dataCAN = listDataCAN.ToArray ();
		string[] dataL = listDataL.ToArray ();
		string[] dataPH = listDataPH.ToArray ();
		string[] yieldTotal = listYieldTotal.ToArray ();

		System.Console.WriteLine ("DAP:");
		foreach (string s in dataDAP) {
			Debug.Log(s);
		}
		System.Console.WriteLine ("CAN:");
		foreach (string s in dataCAN) {
			System.Console.WriteLine (s);
			Debug.Log (s);
		}
		System.Console.WriteLine ("L:");
		foreach (string s in dataL) {
			System.Console.WriteLine (s);
			Debug.Log (s);
		}
		System.Console.WriteLine ("PH:");
		foreach (string s in dataPH) {
			System.Console.WriteLine (s);
			Debug.Log (s);
		}
		System.Console.WriteLine ("Yield:");
		foreach (string s in yieldTotal) {
			System.Console.WriteLine (s);
			Debug.Log (s);
		}
	}

}


