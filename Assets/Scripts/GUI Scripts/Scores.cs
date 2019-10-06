using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Scores : MonoBehaviour
{
    public ScoreManager scoreManager;

    Text scores_txt;
    
    // Tambah Andi
    void Start(){
        scores_txt = GetComponent<Text>();
        string lokasiFile = Application.dataPath + "/Log.txt";
        string s = "";
		if(File.Exists(lokasiFile)){
			var readfile = File.OpenText(lokasiFile);
			var line = readfile.ReadLine();
			while(line != null){
                string Angka = line.Substring(line.IndexOf('-') + 1);
                string Nama  = line.Substring(0, line.IndexOf('-'));

                s += Angka + "\t\t\t" + Nama + "\n";
				line = readfile.ReadLine();
			}
            scores_txt.text = s;
		} else {
            scores_txt.text = "NULL" + "\t\t\t" + "NULL" + "\n";
        }

    }

    public void UpdateGUIText(List<ScoreManager.Score> scoreList)
    {
        scores_txt = GetComponent<Text>();
        Debug.Log("Updating GUIText: scorelist count=" + scoreList.Count);
        string s = "";
        foreach (ScoreManager.Score sc in scoreList)
        {
            if (sc.score < 1000)
                s += sc.score + "\t\t\t" + sc.name + "\n";
            else
                s += sc.score + "\t\t" + sc.name + "\n";
        }

        scores_txt.text = s;
    }

}
