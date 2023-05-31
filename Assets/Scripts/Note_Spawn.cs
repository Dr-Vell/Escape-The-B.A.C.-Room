using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class Note_Spawn : MonoBehaviour
{
    private bool destroyed = false;

    public void Awake()
    {           
        if (PlayerPrefs.HasKey(this.gameObject.name))
        {
            int nSpawn = PlayerPrefs.GetInt(this.gameObject.name);
            destroyed = nSpawn != 0;            
        }
    }
    public void Start()
    {
        this.gameObject.SetActive(!destroyed);
        
    }
}
