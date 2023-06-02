// Script Interact_Object
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using System.Threading.Tasks;

public class Interact_Object : MonoBehaviour
{
    public Transform cam;
    public float playerActivateDistance;
    bool activate = false;
    public Note_Controller noteController;
    public GameObject deathScreen;
    public GameObject bgm;
    public GameObject escape;


    private async void Update()
    {
        RaycastHit hit;
        activate = Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, playerActivateDistance);

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (noteController.IsNoteActive())
            {
                noteController.DestroyActiveNote();
            }
            else if (activate && hit.transform.CompareTag("Destroyable"))
            {
                Destroy(hit.transform.gameObject);
                PlayerPrefs.SetInt(hit.transform.name, 1);
                noteController.ActivatePanel(hit.transform.name);
            }
            else if (activate && hit.transform.CompareTag("Terminal"))
            {
                int terminalNumber = (int) Char.GetNumericValue(hit.transform.name[hit.transform.name.Length - 1]);
                PlayerPrefs.SetInt("Terminal", terminalNumber);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else if (activate && hit.transform.CompareTag("Exit"))
            {
                escape.SetActive(true);    
                await LoadMenu();            
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }

    async private void Die()
    {
        bgm.SetActive(false);
        deathScreen.SetActive(true);
        await LoadMenu();
    }

    async Task LoadMenu()
    {        
        await Task.Delay(7000);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);    
    }

}
