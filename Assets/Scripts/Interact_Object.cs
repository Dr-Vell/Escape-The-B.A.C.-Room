// Script Interact_Object
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact_Object : MonoBehaviour
{
    public Transform cam;
    public float playerActivateDistance;
    bool activate = false;
    public Note_Controller noteController;


    private void Update()
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
        }
    }


}
