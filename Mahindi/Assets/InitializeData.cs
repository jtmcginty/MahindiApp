using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class InitializeData: MonoBehaviour
{

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

	int indexDAP = 0;
	int indexCAN = 0;
	int indexL = 0;
	int indexPH = 0;
	int indexYield = 0;
	List<string> listDataDAP = new List<string> ();
	List<string> listDataCAN = new List<string> ();
	List<string> listDataL = new List<string> ();
	List<string> listDataPH = new List<string> ();
	List<string> listYieldTotal = new List<string> ();


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

	public string getDAP(int index){
		return dataDAP [index];
	}
	public string getCAN(int index){
		return dataCAN [index];
	}
	public string getL(int index){
		return dataL [index];
	}
	public string getPH(int index){
		return dataPH [index];
	}
	public string getYield(int index){
		return yieldTotal [index];
	}



	public void increaseDAPIndex(){
		if ((dataDAP.Length-1) > indexDAP) {
			indexDAP++;
		}
	}
	public void increaseCANIndex(){
		if ((dataCAN.Length-1) > indexDAP) {
			indexCAN++;
		}
	}
	public void increaseLIndex(){
		if ((dataL.Length-1) > indexDAP) {
			indexL++;
		}
	}
	public void decreaseDAPIndex(){
		if (indexDAP > 0) {
			indexDAP++;
		}
	}
	public void decreaseCANIndex(){
		if (indexCAN > 0) {
			indexCAN++;
		}
	}
	public void decreaseLIndex(){
		if (indexL > 0) {
			indexL++;
		}
	}
}


