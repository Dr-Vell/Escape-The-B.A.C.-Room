using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject coffin1;
    public GameObject coffin2;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject exit;

    
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("Maromo"))
        {
            enemy.SetActive(true);
            coffin1.SetActive(false);
            coffin2.SetActive(true);
            cube1.SetActive(false);
            cube2.SetActive(false);
            cube3.SetActive(false);
        }
        if(PlayerPrefs.HasKey("Terminal Cube 1")&&PlayerPrefs.HasKey("Terminal Cube 2")&&PlayerPrefs.HasKey("Terminal Cube 3"))
        {
            exit.SetActive(true);
        }

    }

}
