using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using System.Linq;

public class Interpreter : MonoBehaviour
{
    List<string> response = new List<string>();

    public List<string> Interpret(string userInput)
    {
        response.Clear();

        switch(userInput) 
        {
            case "A":
            case "a":
                response.Add("You select option A...");
                break;

            case "B":
            case "b":
                response.Add("You select option B...");
                break;

            case "C":
            case "c":
                response.Add("You select option C...");
                break;

            case "Go":
            case "go":
            case "Start":
            case "start":
                StartChallenge("challenge_1.txt", 5);
                break;   

            case "exit":
                response.Add("shutting down...");
                ExitTerminal();
                break; 

            default:
                response.Add("Commant not recognized. Type help for a list of commands.");
                break;
        }
        return response;
    }

    void StartChallenge(string path, int spacing)
    {
        List<string> lines = new List<string>();

        using (StreamReader file = new StreamReader(Path.Combine(Application.streamingAssetsPath, path)))
        {
            while (!file.EndOfStream)
            {
                lines.Add(file.ReadLine());
            }
        }

        response.AddRange(Enumerable.Repeat("", spacing));
        response.AddRange(lines);
        response.AddRange(Enumerable.Repeat("", spacing));
    }


    void ExitTerminal()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);       
    }


}
