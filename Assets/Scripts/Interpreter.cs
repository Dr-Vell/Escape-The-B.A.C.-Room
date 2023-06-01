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
                    test_active = true;
                    Read_File_Terminal("challenge_1.txt", 2);
                    break;   

                case "exit":
                    ExitTerminal();
                    break; 

                case "help":
                    Read_File_Terminal("help_command.txt", 2);
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
                    IncorrectAnswer(userInput);
                    break;

                case "C":
                case "c":
                    CorrectAnswer(userInput);
                    test_active = false;                                         
                    response.Add("Congratz! You completed the First Challenge!");
                    response.Add("Keep it up! <3");                    
                    PlayerPrefs.SetInt("Terminal Cube 1", 1);
                    CorrectAnswerEnding();
                    break;

                case "A":
                case "a":
                    IncorrectAnswer(userInput);
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
                    IncorrectAnswer(userInput);
                    break;

                case "A":
                case "a":
                    CorrectAnswer(userInput);
                    question_2 = true;
                    response.Add(" ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");                   
                    response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");                   
                    response.Add("");
                    response.Add("What is the impact of a Broken Access Control vulnerability?");                     
                    response.Add("");
                    response.Add("A. Broken access control has no impact on the system.");
                    response.Add("B. Broken access control may cause minor performance inconveniences for users.");       
                    response.Add("C. Broken access control can result in unauthorized access to sensitive data or resources.");                     
                    response.Add("");
                    break;

                case "C":
                case "c":
                    IncorrectAnswer(userInput);
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
                    IncorrectAnswer(userInput);
                    break;

                case "B":
                case "b":
                    CorrectAnswer(userInput);
                    question_1 = true;
                    response.Add(" ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");                   
                    response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");                   
                    response.Add("");
                    response.Add("What are some common techniques used in exploiting Broken Access Control vulnerabilities?");                     
                    response.Add("");
                    response.Add("A. Session Hijacking/Fixation and URL Tampering.");
                    response.Add("B. Man-in-the-Middle (MitM) Attacks and SQL Injection.");       
                    response.Add("C. URL Tampering and Man-in-the-Middle (MitM) Attacks.");                          
                    response.Add("");
                    break;

                case "C":
                case "c":
                    IncorrectAnswer(userInput);
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

        if(!test_active)
        {
            switch(userInput) 
            {
                case "go":
                    test_active = true;
                    Read_File_Terminal("challenge_2.txt", 2);
                    break;   

                case "exit":
                    ExitTerminal();
                    break; 

                case "help":
                    Read_File_Terminal("help_command.txt", 2);
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
                    IncorrectAnswer(userInput);
                    break;

                case "A":
                case "a":
                    CorrectAnswer(userInput);
                    test_active = false;                                         
                    response.Add("Congratz! You completed the Second Challenge!");
                    response.Add("Keep it up! <3");
                    PlayerPrefs.SetInt("Terminal Cube 2", 1);
                    CorrectAnswerEnding();
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
                    IncorrectAnswer(userInput);
                    break;

                case "A":
                case "a":
                    CorrectAnswer(userInput);
                    question_2 = true;
                    response.Add(" ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");                   
                    response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");                   
                    response.Add("");
                    response.Add("Broken Access Control can also be found in APIs.");  
                    response.Add("A user can exploit an application through API calls, to access sensitive information.");                     
                    response.Add("");
                    response.Add("A. True.");
                    response.Add("B. False.");                        
                    response.Add("");
                    break;

                case "C":
                case "c":
                    IncorrectAnswer(userInput);
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
                    IncorrectAnswer(userInput);
                    break;

                case "B":
                case "b":
                    CorrectAnswer(userInput);
                    question_1 = true;
                    response.Add(" ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");                   
                    response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");                   
                    response.Add("");
                    response.Add("Through Session Hijacking, an attacker can use a stolen session id to access the system as the user and");
                    response.Add("perform unauthorized changes?");                     
                    response.Add("");
                    response.Add("A. True.");
                    response.Add("B. False.");                           
                    response.Add("");
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
    public List<string> Interpret_3(string userInput)
    {
        response.Clear();

        if(!test_active)
        {
            switch(userInput) 
            {
                case "go":
                    test_active = true;
                    Read_File_Terminal("challenge_3.txt", 2);
                    break;   

                case "exit":
                    ExitTerminal();
                    break; 

                case "help":
                    Read_File_Terminal("help_command.txt", 2);
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
                    IncorrectAnswer(userInput);
                    break;

                case "C":
                case "c":
                    CorrectAnswer(userInput);
                    test_active = false;                                         
                    response.Add("Congratz! You completed the Third Challenge!");
                    response.Add("Keep it up! <3");
                    PlayerPrefs.SetInt("Terminal Cube 3", 1);
                    CorrectAnswerEnding();
                    break;

                case "A":
                case "a":
                    IncorrectAnswer(userInput);
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
                    IncorrectAnswer(userInput);
                    break;

                case "C":
                case "c":
                    CorrectAnswer(userInput);
                    question_2 = true;
                    response.Add(" ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");                   
                    response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");                   
                    response.Add("");
                    response.Add("How would you ensure that an application is not vulnerable to B.A.C. attacks?");                     
                    response.Add("");
                    response.Add("A. If the system has those previous techniques implemented there's nothing else to do. It's safe.");
                    response.Add("B. Rely on luck, no system is safe, you just hope not to get attacked.");       
                    response.Add("C. Conduct thorough security testing and pentesting specifically targeting BAC vulnerabilities to");             
                    response.Add("   identify and fix any potential weaknesses.");        
                    response.Add("");
                    break;

                case "A":
                case "a":
                    IncorrectAnswer(userInput);
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
                    IncorrectAnswer(userInput);
                    break;

                case "B":
                case "b":
                    CorrectAnswer(userInput);
                    question_1 = true;
                    response.Add(" ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");                   
                    response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");                   
                    response.Add("");
                    response.Add("User A, with minimum privileges on the system, makes the following change in the URL:");
                    response.Add("");
                    response.Add("http://example.com/restricted-area.html?session_id=123");
                    response.Add("to");
                    response.Add("http://example.com/restricted-area.html?session_id=456");
                    response.Add("");
                    response.Add("After that change, the website returns the restricted-area of User B.");
                    response.Add("");
                    response.Add("Which of the following techniques can avoid this URL Tampering from happening on an application?");                
                    response.Add("");
                    response.Add("A. Protecting the application from massive API calls.");
                    response.Add("B. Making ever bigger IDs and sharing each of them with a group of users.");       
                    response.Add("C. Validating input from users and implementing Access Controls.");                          
                    response.Add("");
                    break;

                case "C":
                case "c":
                    IncorrectAnswer(userInput);
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
            
    void NoCommand()
    {
        response.Add("Command not recognized.");
        response.Add("");
        response.Add("Type 'go' to start the test.");
        response.Add("     'help' to show the B.A.C Manual.");
        response.Add("     'exit' to shut down this terminal.");
        response.Add("");
        response.Add("WARNING: Once the test starts, you won't be able to use 'help'.");
    }
            
    void CorrectAnswer(string userInput)
    {
        response.Add("You select option " + userInput + "...");                 
        response.Add("");
        response.Add(" Correct!     ~(^-^)~");                  
        response.Add("");
    }

    async Task CorrectAnswerEnding()
    {        
        await Task.Delay(3000);
        ExitTerminal();
    }
                
    void IncorrectAnswer(string userInput)
    {
        response.Add("You select option " + userInput + "...");                    
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

    void Read_File_Terminal(string path, int spacing)
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
        response.Add("shutting down...");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);       
    }


}
