using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
public class LoginScript : MonoBehaviour
{
    [SerializeField] private string endpoint = "http://localhost:3000/user/signin";
    [SerializeField] private string CreateEndpoint = "http://localhost:3000/user/signup";

    [SerializeField] private TMP_InputField name_inputField;
    [SerializeField] private TMP_InputField email_inputField;
    [SerializeField] private TMP_InputField password_inputField;

    [SerializeField] private TMP_InputField emailLogin_inputField;
    [SerializeField] private TMP_InputField passwordLogin_inputField;

    [SerializeField] private Button loginButton;
    [SerializeField] private Button signUpButton;
    public GameObject errorPanel;



    //[SerializeField] private TMP_Text textField;


    public void onLoginClick(){
        StartCoroutine(Login());
    }
    public void onSignUpClick() {
        StartCoroutine(SignUp());
    }

    private IEnumerator Login()

{


    WWWForm form = new WWWForm();
form.AddField("email", string.IsNullOrEmpty(emailLogin_inputField.text) ? "" : emailLogin_inputField.text);
form.AddField("password", string.IsNullOrEmpty(passwordLogin_inputField.text) ? "" : passwordLogin_inputField.text);


    
    UnityWebRequest www = UnityWebRequest.Post(endpoint, form);

    //www.chunkedTransfer = false;
    //www.useHttpContinue = false;
    
    yield return www.SendWebRequest();
    if (www.result != UnityWebRequest.Result.Success)
    {
        Debug.Log(www.error);
        Debug.Log("Response: " + www.downloadHandler.text);
        errorPanel.SetActive(true);
    }
    else
    {
        Debug.Log("Form upload complete !" + www.downloadHandler.text);
        SceneManager.LoadScene(1);
    }
}


 private IEnumerator SignUp()

{

Debug.Log(name_inputField.text + " " + email_inputField.text);
    WWWForm form = new WWWForm();
    form.AddField("name", string.IsNullOrEmpty(name_inputField.text) ? "" : name_inputField.text);
form.AddField("email", string.IsNullOrEmpty(email_inputField.text) ? "" : email_inputField.text);
form.AddField("password", string.IsNullOrEmpty(password_inputField.text) ? "" : password_inputField.text);


    
    UnityWebRequest www = UnityWebRequest.Post(CreateEndpoint, form);

    //www.chunkedTransfer = false;
    //www.useHttpContinue = false;
    
    yield return www.SendWebRequest();
    if (www.result != UnityWebRequest.Result.Success)
    {
        Debug.Log(www.error);
        Debug.Log("Response: " + www.downloadHandler.text);
        errorPanel.SetActive(true);

    }
    else
    {
        Debug.Log("Form upload complete !" + www.downloadHandler.text);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}

}