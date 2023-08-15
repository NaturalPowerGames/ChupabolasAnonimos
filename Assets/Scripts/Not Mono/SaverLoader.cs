using System.IO;
using UnityEngine;

public static class SaverLoader
{
	private static string path = Application.dataPath + "/Saves/player.json";
	public static void Save(Player player)
	{		
		string saveFile = JsonUtility.ToJson(player);
		File.WriteAllText(path, saveFile);
	}

	public static Player LoadSave()
	{
		if (File.Exists(path))
		{
			string json = File.ReadAllText(path);
			Player loadedData = JsonUtility.FromJson<Player>(json);
			return loadedData;
		}
		else return null;
		
	}
}
