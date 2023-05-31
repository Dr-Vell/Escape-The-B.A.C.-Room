using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

public class Interpreter : MonoBehaviour
{
    List<string> response = new List<string>();

    private bool test_active = false;
    private bool question_1 = false;
    private bool question_2 = false;

    public List<string> Interpret_1(string userInput)
    {
        response.Clear();

        if(!test_active)
        {
            switch(userInput) 
            {
                case "go":
                    StartChallenge("challenge_1.txt", 5);
                    break;   

                case "exit":
                    ExitTerminal();
                    break; 

                default:
                    NoCommand();
                    break;
            }
        }  

        else if(test_active && question_2)
        {
            switch(userInput) 
            {
                case "B":
                case "b":
                    IncorrectAnswer();
                    break;

                case "C":
                case "c":
                    CorrectAnswer();
                    test_active = false;                                         
                    response.Add("Congratz! You completed the First Challenge!");
                    response.Add("Keep it up! <3");
                    CorrectAnswerEnding();
                    break;

                case "A":
                case "a":
                    IncorrectAnswer();
                    break;

                case "exit":
                    ExitTerminal();
                    break; 

                default:
                    NoCommand();
                    break;
            }
        }   

        else if(test_active && question_1)
        {
            switch(userInput) 
            {
                case "B":
                case "b":
                    IncorrectAnswer();
                    break;

                case "A":
                case "a":
                    CorrectAnswer();
                    question_2 = true;
                    response.Add("What is the impact of a Broken Access Control vulnerability?");                     
                    response.Add("");
                    response.Add("A. Broken access control has no impact on the system.");
                    response.Add("B. Broken access control may cause minor inconveniences for users.");       
                    response.Add("C. Broken access control can result in unauthorized access to sensitive data or resources.");                     
                    response.Add("");
                    break;

                case "C":
                case "c":
                    IncorrectAnswer();
                    break;

                case "exit":
                    ExitTerminal();
                    break; 

                default:
                    NoCommand();
                    break;
            }
        }   
        

        else if(test_active)
        {
            switch(userInput) 
            {
                case "A":
                case "a":
                    IncorrectAnswer();
                    break;

                case "B":
                case "b":
                    CorrectAnswer();
                    question_1 = true;
                    response.Add("Which of these is a common type of Broken Access Control vulnerability?");                     
                    response.Add("");
                    response.Add("A. Direct Object References");
                    response.Add("B. Cross-Site Scripting (XSS)");       
                    response.Add("C. SQL Injection");                          
                    response.Add("");
                    break;

                case "C":
                case "c":
                    IncorrectAnswer();
                    break;

                case "exit":
                    ExitTerminal();
                    break; 

                default:
                    NoCommand();
                    break;
            }
        }    

        return response;
    }

    public List<string> Interpret_2(string userInput)
    {
        response.Clear();

        switch(userInput) 
        {
            case "A":
            case "a":
                response.Add("You select option Tula...");
                break;

            case "exit":
                ExitTerminal();
                break; 

            default:
                NoCommand();
                break;
        }
        return response;
    }
    public List<string> Interpret_3(string userInput)
    {
        response.Clear();

        switch(userInput) 
        {
            case "A":
            case "a":
                response.Add("You select option Pingo...");
                break;

            case "exit":
                ExitTerminal();
                break; 

            default:
                NoCommand();
                break;
        }
        return response;
    }
            
    void NoCommand()
    {
        response.Add("Command not recognized.");
        response.Add("");
        response.Add("Type 'go' for the test to start or 'exit' to shut down this terminal.");
    }
            
    void CorrectAnswer()
    {
        response.Add("You select option B...");                   
        response.Add("");
        response.Add(" Correct!     ~(^-^)~");                  
        response.Add("");
    }

    async Task CorrectAnswerEnding()
    {        
        await Task.Delay(3000);
        ExitTerminal();
    }
                
    void IncorrectAnswer()
    {
        response.Add("You select option C...");                    
        response.Add("");
        response.Add(" WRONG!!!     ( ఠൠఠ )ﾉ");
        IncorrectAnswerEnding();
    }

    async Task IncorrectAnswerEnding()
    {        
        PlayerPrefs.SetInt("Maromo", 1);
        await Task.Delay(2000);
        ExitTerminal();
    }

    void StartChallenge(string path, int spacing)
    {        
        test_active = true;
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
        response.Add("shutting down...");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);       
    }


}
