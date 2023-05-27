using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Object : MonoBehaviour
{
    public Transform cam;
    public float playerActivateDistance;
    bool activate = false;

    private void Update()
    {
        RaycastHit hit;
        activate = Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, playerActivateDistance);

        if (Input.GetKeyDown(KeyCode.F) && activate == true && hit.transform.CompareTag("Destroyable"))
        {
                Destroy(hit.transform.gameObject);
        }
    }
}
