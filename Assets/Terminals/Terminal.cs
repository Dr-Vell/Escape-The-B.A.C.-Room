using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Terminal : MonoBehaviour
{
    public GameObject directoryLine;
    public GameObject responseLine;

    public InputField terminalInput;
    public GameObject userInputLine;
    public ScrollRect sr;
    public GameObject msgList;

    Interpreter interpreter;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        terminalInput.ActivateInputField();
        terminalInput.Select();
        interpreter = GetComponent<Interpreter>();
    }

    private void OnGUI()
    {
        if(terminalInput.isFocused && terminalInput.text != "" && Input.GetKeyDown(KeyCode.Return))
        {
            string userInput = terminalInput.text;
            ClearInputField();
            AddDirectoryLine(userInput);
            int lines = AddInterpreterLines(interpreter.Interpret(userInput));
            ScrollToBottom(lines);
            userInputLine.transform.SetAsLastSibling();
            terminalInput.ActivateInputField();
            terminalInput.Select();
        }
    }

    private void ClearInputField()
    {
        terminalInput.text = "";
    }

    private void AddDirectoryLine(string userInput)
    {
        RectTransform msgListRectTransform = msgList.GetComponent<RectTransform>();
        msgListRectTransform.sizeDelta += new Vector2(0, 35.0f);
        GameObject msg = Instantiate(directoryLine, msgList.transform);
        msg.transform.SetSiblingIndex(msgList.transform.childCount - 1);
        msg.GetComponentsInChildren<Text>()[1].text = userInput;
    }

    private int AddInterpreterLines(List<string> interpretation)
    {
        int lineCount = interpretation.Count;
        foreach (string line in interpretation)
        {
            GameObject res = Instantiate(responseLine, msgList.transform);
            res.transform.SetAsLastSibling();
            RectTransform msgListRectTransform = msgList.GetComponent<RectTransform>();
            msgListRectTransform.sizeDelta += new Vector2(0, 35.0f);
            res.GetComponentsInChildren<Text>()[0].text = line;
        }
        return lineCount;
    }

    private void ScrollToBottom(int lines)
    {
        if (lines > 4)
        {
            sr.velocity = new Vector2(0, 600);
        }
        else
        {
            sr.verticalNormalizedPosition = 0;
        }
    }
}
