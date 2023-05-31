using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class Spawn_Controller : MonoBehaviour
{
    private Vector3 playerPosition;

    public void Awake()
    {    
        string sSpawn = PlayerPrefs.GetString("Player Spawn Position");

        if (!string.IsNullOrEmpty(sSpawn))
        {
            string[] sArray = sSpawn.Split(',');
            playerPosition = new Vector3(
                float.Parse(sArray[0], CultureInfo.InvariantCulture),
                float.Parse(sArray[1], CultureInfo.InvariantCulture),
                float.Parse(sArray[2], CultureInfo.InvariantCulture));
            
        }
    }
    public void Start()
    {
        Debug.Log(transform.position);
        transform.position = playerPosition;
        Debug.Log(transform.position);
    }
}
