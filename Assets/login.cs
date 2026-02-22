using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.XR.CoreUtils;
using TMPro;
using UnityEngine.SceneManagement;


public class login : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public TMP_Text wrongInput;
    public void AttemptLogin()
    {
        if(isValidCredentials(usernameInput.text, passwordInput.text))
        {
            Debug.Log("Login Successful");
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            Debug.Log("Login Failed");
            wrongInput.text = "WRONG";
        }
    }
    private bool isValidCredentials(string username, string password)
    {
        // Placeholder for actual authentication logic
        return username == "user" && password == "pass";
    }
}
