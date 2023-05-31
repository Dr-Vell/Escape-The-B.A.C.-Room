using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Script : MonoBehaviour
{

    public void Play()
    {        
        PlayerPrefs.SetString("Player Spawn Position", "-0.4187095,1.017,-11.15717");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
