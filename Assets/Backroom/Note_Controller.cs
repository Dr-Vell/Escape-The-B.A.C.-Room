// Script Note_Controller
using UnityEngine;
using UnityEngine.UI;

public class Note_Controller : MonoBehaviour
{
    public Canvas canvas;
    public GameObject note_panel_1;    
    public GameObject note_panel_2;    
    public GameObject note_panel_3;    
    public GameObject note_panel_4;   
    public GameObject note_panel_5;

    private bool noteActive = false;

    private GameObject activePanel;

    public void ActivatePanel(string panel)
    {
        // Desactivar el panel actual antes de activar el nuevo
        if (activePanel != null)
        {
            activePanel.SetActive(false);
        }

        switch(panel) 
        {
            case "Note Mesh 1":
                activePanel = note_panel_1;
                break;
            case "Note Mesh 2":
                activePanel = note_panel_2;
                break;
            case "Note Mesh 3":
                activePanel = note_panel_3;
                break;
            case "Note Mesh 4":
                activePanel = note_panel_4;
                break;
            case "Note Mesh 5":
                activePanel = note_panel_5;
                break;
        }

        activePanel.SetActive(true);
        noteActive = true;
    }

    public bool IsNoteActive()
    {
        return noteActive;
    }

    public GameObject GetActivePanel()
    {
        return activePanel;
    }
}
