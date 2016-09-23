using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


public class DataTextManager : MonoBehaviour {

	public Text DAPText;
	public Text CANText;
	public Text LText;
	public Text cropYield;

	public string totalYield = "Total Yield";

	public int indexDAP = 0;
	public int indexCAN = 0;
	public int indexL = 0;
	public int indexYield = 0;

	public string[] dataDAP;
	public string[] dataCAN;
	public string[] dataL;
	public string[] dataPH;
	public string[] yieldTotal;

	public string[] dataDAPtest;
	public string[] dataCANtest;
	public string[] dataLtest;
	public string[] dataPHtest;
	public string[] yieldTotaltest;

	int indexPH = 0;
	List<string> listDataDAP = new List<string> ();
	List<string> listDataCAN = new List<string> ();
	List<string> listDataL = new List<string> ();
	List<string> listDataPH = new List<string> ();
	List<string> listYieldTotal = new List<string> ();

	Boolean changedIndex = false;


	// Use this for initialization
	void Start () {

		getData ();
		DAPText.text = dataDAP[indexDAP];
		CANText.text = dataCAN[indexCAN];
		LText.text = dataL[indexL];
		cropYield.text = totalYield;


	}
	
	// Update is called once per frame
	void Update () {

		if (changedIndex) {
			DAPText.text = dataDAP [indexDAP];
			CANText.text = dataCAN [indexCAN];
			LText.text = dataL [indexL];
			cropYield.text = totalYield;

		}
		
	}

	public void getData(){
		StreamReader reader = File.OpenText("/Users/Jack/Documents/Summary_test.csv");
		string line;

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

		dataDAPtest = listDataDAP.ToArray ();
		dataCANtest = listDataCAN.ToArray ();
		dataLtest = listDataL.ToArray ();
		dataPH = listDataPH.ToArray ();
		yieldTotal = listYieldTotal.ToArray ();

		dataDAP = dataDAPtest.Distinct().ToArray ();
		dataCAN = dataCANtest.Distinct().ToArray ();
		dataL = dataLtest.Distinct().ToArray ();

		Debug.Log ("DAP:");
		foreach (string s in dataDAP) {
			Debug.Log(s);
		}
		Debug.Log ("CAN:");
		foreach (string s in dataCAN) {
			//System.Console.WriteLine (s);
			Debug.Log (s);
		}
		Debug.Log ("L:");
		foreach (string s in dataL) {
			//System.Console.WriteLine (s);
			Debug.Log (s);
		}
		Debug.Log ("PH:");
		foreach (string s in dataPH) {
			//System.Console.WriteLine (s);
			Debug.Log (s);
		}
		Debug.Log ("Yield:");
		foreach (string s in yieldTotal) {
			//System.Console.WriteLine (s);
			Debug.Log (s);
		}
	}


	public void increaseDAPIndex(){
		if (indexDAP < (dataDAP.Length - 1)) {
			indexDAP++;
		}
		changedIndex = true;
	}
	public void increaseCANIndex(){
		if (indexDAP < (dataCAN.Length-1)) {
			indexCAN++;
		}
		changedIndex = true;
	}
	public void increaseLIndex(){
		if (indexDAP < (dataL.Length-1)) {
			indexL++;
		}
		changedIndex = true;
	}
	public void decreaseDAPIndex(){
		if (indexDAP > 0) {
			indexDAP--;
		}
		changedIndex = true;
	}
	public void decreaseCANIndex(){
		if (indexCAN > 0) {
			indexCAN--;
		}
		changedIndex = true;
	}
	public void decreaseLIndex(){
		if (indexL > 0) {
			indexL--;
		}
		changedIndex = true;
	}

	public void findYield(){
		changedIndex = true;
		int DAP = Int32.Parse(dataDAP[indexDAP]);
		int CAN = Int32.Parse(dataCAN[indexCAN]);
		int L = Int32.Parse(dataL[indexL]);

		indexYield = 0;
		while (Int32.Parse(dataDAPtest [indexYield]) != DAP) {
			indexYield++;
		}
		while (Int32.Parse(dataCANtest [indexYield]) != DAP) {
			indexYield++;
		}
		while (Int32.Parse(dataLtest [indexYield]) != DAP) {
			indexYield++;
		}
	
		totalYield = yieldTotal [indexYield];
	}

}
