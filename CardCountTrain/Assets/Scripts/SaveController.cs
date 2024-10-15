using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using TMPro;

public class SaveController : MonoBehaviour
{
    public TMP_Text scoreText;
    public BlackJack script;

    static float ConvertDollarStringToFloat(string dollarAmount)
    {
        string cleanedAmount = dollarAmount.Replace("$", "").Replace(",", "");

        if (float.TryParse(cleanedAmount, out float result))
        {
            return result;
        }
        else
        {
            throw new ArgumentException("Invalid dollar amount format");
        }
    }

    public void Save()
    {

        string path = Application.persistentDataPath + "/save_data.json";
        Debug.Log(path);

        float score = ConvertDollarStringToFloat(scoreText.text);
        string saveDataJson = JsonUtility.ToJson(new SaveData(score));

        File.WriteAllText(path, saveDataJson);
    }

    public void Load()
    {
        string path = Application.persistentDataPath + "/save_data.json";
        StreamReader reader = new StreamReader(path);
        string saveDataJson = reader.ReadToEnd();
        SaveData saveData = JsonUtility.FromJson<SaveData>(saveDataJson);
        Debug.Log(saveData.score);

        script.money = saveData.score;

        reader.Close();
    }
}

[Serializable]
public class SaveData
{
    public float score;

    public SaveData(float score) {
        this.score = score;
    }
}
