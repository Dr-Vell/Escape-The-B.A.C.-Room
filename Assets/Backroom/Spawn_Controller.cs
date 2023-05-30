using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class Spawn_Controller : MonoBehaviour
{
    public GameObject player;

    private void Awake()
    {    
        string sSpawn = PlayerPrefs.GetString("Player Spawn Position");
        Debug.Log(sSpawn);

        if (!string.IsNullOrEmpty(sSpawn))
        {
            string[] sArray = sSpawn.Split(',');
            Vector3 spawn = new Vector3(
                float.Parse(sArray[0], CultureInfo.InvariantCulture),
                float.Parse(sArray[1], CultureInfo.InvariantCulture),
                float.Parse(sArray[2], CultureInfo.InvariantCulture));
            player.transform.position = spawn;
            Debug.Log(player.transform.position);
        }
    }
}
