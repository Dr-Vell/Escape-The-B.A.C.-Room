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
        response.Add(" Correct!");                  
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
        response.Add(" WRONG!!!");
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
        response.AddRange(Enumerable.Repeat("", spacing));

        switch(path)
        {
            case "challenge_1.txt":             
                response.Add("");
                response.Add("Escape the BAC ROOM");
                response.Add("v1.0");
                response.Add("                                                                                                       "); 
                response.Add("                                                                                                        ");
                response.Add("______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");
                response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");
                response.Add("        ");
                response.Add("");
                response.Add("This is the first out of three challenges you will need to complete in order to escape. ");
                response.Add("");
                response.Add("Some simple test questions will be displayed now.");
                response.Add("");
                response.Add("To answer them, you will need to choose only one of the answers.");
                response.Add("");
                response.Add(" Use the keyboard to type the options A, B or C.");
                response.Add("");
                response.Add("WARNING: Do NOT answer them incorrectly...");
                response.Add("    ");
                response.Add("______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");
                response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");
                response.Add("        ");
                response.Add("");
                response.Add("What does Broken Access Control mean?");
                response.Add("");
                response.Add("A. Broken Access Control refers to the process of granting users access to resources based on their role ");
                response.Add("and privileges within an organization.");
                response.Add("");
                response.Add("B. Broken Access Control means a web vulnerability where restrictions on user access or actions are not ");
                response.Add("properly enforced, allowing unauthorized users to bypass security measures and gain unauthorized access ");
                response.Add("to resources.");
                response.Add("");       
                response.Add("C. Broken Access Control refers to the encryption algorithms used to secure user access to sensitive data,");
                response.Add("ensuring that only authorized users can decrypt and access the information.");
                response.Add("");
                break;

            case "challenge_2.txt":             
                response.Add("");
                response.Add("Escape the BAC ROOM");
                response.Add("v1.0");
                response.Add("                                                                                                       "); 
                response.Add("                                                                                                        ");
                response.Add("______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");
                response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");
                response.Add("        ");
                response.Add("");
                response.Add("This is the second out of three challenges you will need to complete in order to escape. ");
                response.Add("");
                response.Add("Some simple test questions will be displayed now.");
                response.Add("");
                response.Add("To answer them, you will need to choose only one of the answers.");
                response.Add("");
                response.Add(" Use the keyboard to type the options A or B.");
                response.Add("");
                response.Add("WARNING: Do NOT answer them incorrectly...");
                response.Add("    ");
                response.Add("______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");
                response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");
                response.Add("        ");
                response.Add("");
                response.Add("User A, with minimum privileges on the system, makes the following change in the URL:");

                response.Add("http://example.com/restricted-area.html?session_id=123");

                response.Add("turns into:");

                response.Add("http://example.com/restricted-area.html?session_id=456");

                response.Add("After that change, the website returns the restricted-area of User B.");

                response.Add("This is called a Man-in-the-Middle (MitM) Attack.");

                response.Add("");
                response.Add("A. True");
                response.Add("B. False ");
                response.Add("");
                break;

            case "challenge_3.txt":             
                response.Add("");
                response.Add("Escape the BAC ROOM");
                response.Add("v1.0");
                response.Add("                                                                                                       "); 
                response.Add("                                                                                                        ");
                response.Add("______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");
                response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");
                response.Add("        ");
                response.Add("");
                response.Add("This is the third out of three challenges you will need to complete in order to escape. ");
                response.Add("");
                response.Add("Some simple test questions will be displayed now.");
                response.Add("");
                response.Add("To answer them, you will need to choose only one of the answers.");
                response.Add("");
                response.Add(" Use the keyboard to type the options A, B or C.");
                response.Add("");
                response.Add("WARNING: Do NOT answer them incorrectly...");
                response.Add("    ");
                response.Add("______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");
                response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");
                response.Add("        ");
                response.Add("");
                response.Add("What are some common mitigation techniques to counter Broken Access Control attacks?");
                response.Add("");
                response.Add("A. Implement Security through Obscurity and Obfuscate Access Control Logic.");
                response.Add("");
                response.Add("B. Invalidate sessions after a some time and Implement Access Control Checks.");
                response.Add("");       
                response.Add("C. Obfuscate Access Control Logic passwords Validating.");
                response.Add("");
                break;

            case "help_command.txt":             
                response.Add("");
                response.Add("B.A.C. Manual");                                   
                response.Add("        ");                                                                                                  
                response.Add(" ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");
                response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");
                response.Add("");
                response.Add("");
                response.Add("INTRO");
                response.Add("");
                response.Add("");
                response.Add("Access control allows enforcing a policy of permissions and roles, meaning that a user can access ");
                response.Add("certain places. These restrictions imply that users cannot act beyond their permissions and, moreover,"); 
                response.Add("keep track of who accesses each resource. The vulnerability Broken Access Control allows a user without ");
                response.Add("privileges to access a resource they shouldn't have access to.");
                response.Add("   ");
                response.Add("What impact can this have on my company?");
                response.Add("");
                response.Add(" - A cybercriminal could operate within the system with user or administrator permissions.");
                response.Add(" - Access to sensitive records, directories, or files for potential disclosure later on.");
                response.Add("");
                response.Add(" ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");
                response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");
                response.Add("           ");
                response.Add("            ");
                response.Add("ATTACK");
                response.Add("         ");             
                response.Add("");
                response.Add("");
                response.Add("From the user's perspective, it is important to consider two main types of authorization attacks:");
                response.Add("");
                response.Add(" - Horizontal bypassing:  refers to the situation where an unauthorized user gains access to other ");
                response.Add("			  users' accounts that have the same level of privileges.");
                response.Add("");
                response.Add(" - Vertical bypassing:  an attacker obtains a higher level of privilege, such as root or superuser privilege, ");
                response.Add("			surpassing the intended level granted by the system.");
                response.Add("");
                response.Add("");
                response.Add("Here are some examples of Broken Access Control attacks:");
                response.Add("");
                response.Add(" - Bypassing authentication by manipulating URL or HTTP parameters");
                response.Add(" - Inadecuate session management, leading to session hijacking or fixation.");
                response.Add(" - Using forced browsing to access restricted resources.");
                response.Add(" - Lack of access control checks on APIs, leading to unauthorized acces to sensitive data.");
                response.Add("");
                response.Add("");
                response.Add("");
                response.Add("Here's an example of URL Tampering:");
                response.Add("");
                response.Add("     User A, with minimum privileges on the system, makes the following change in the URL:");
                response.Add("");
                response.Add("     http://example.com/restricted-area.html?session_id=123");
                response.Add("");
                response.Add("	turns into:");
                response.Add("");
                response.Add("     http://example.com/restricted-area.html?session_id=456");
                response.Add("");
                response.Add("     After that change, the website returns the restricted-area of User B.");
                response.Add("    ");
                response.Add(" ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ");
                response.Add("|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|");
                response.Add("           ");
                response.Add("");
                response.Add("DEFENSE");
                response.Add("          ");            
                response.Add("To guard against broken access control attacks, developers can implement several fundamental precautions. ");
                response.Add("The process should start with assessing the access control requirements of the application and creating a ");
                response.Add("security policy that aligns with those requirements. This assessment should include developing an access ");
                response.Add("control matrix, clearly defining which types of users are granted access, and specifying the allowed and ");
                response.Add("prohibited uses of that access.");
                response.Add("");
                response.Add("Implement role-based access control (RBAC) to enforce appropriate restrictions for each role. ");
                response.Add("Ensure that the access control mechanism is correctly applied on the server side, covering all pages and API ");
                response.Add("endpoints in web applications. Mere requests for direct access to a website or resource should not grant users ");
                response.Add("unauthorized functionality or access to data.");
                response.Add("");
                response.Add("Below are the guidelines to avoid broken access control:");
                response.Add("");
                response.Add(" - Avoid relying solely on obfuscation for access control.");
                response.Add(" - Define the level of access granted to each resource in the code itself, with a default denial of all access.");
                response.Add(" - By default, restrict access if a resource is not intended to be publicly shared.");
                response.Add(" - Conduct audits and comprehensive testing of access control to verify its proper functioning.");
                response.Add("");
                response.Add("");
                response.Add("");
                response.Add("");
                response.Add("");
                response.Add("Now, if you feel ready, type go to start the challenge.");
                break;
        }

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
