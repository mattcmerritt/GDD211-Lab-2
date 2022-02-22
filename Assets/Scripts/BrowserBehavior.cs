using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrowserBehavior : MonoBehaviour
{
    // searching and loading pages
    private string currentLink;
    [SerializeField]
    private GameObject forumPage, secretPage;

    // secret site data
    private string username, password;
    public const string accUsername = "builder", accPassword = "WorkInProgress!";
    [SerializeField]
    private GameObject secretMessage;

    public void UpdateURL(string newLink)
    {
        currentLink = newLink;
    }

    public void Search()
    {
        if (currentLink == "www.forum.net")
        {
            forumPage.SetActive(true);
            secretPage.SetActive(false);
        }
        else if (currentLink == "www.secretsite.com") 
        {
            forumPage.SetActive(false);
            secretPage.SetActive(true);
        }
        else
        {
            forumPage.SetActive(false);
            secretPage.SetActive(false);
        }
    }

    public void UpdateUsername(string newUsername)
    {
        username = newUsername;
    }

    public void UpdatePassword(string newPassword)
    {
        password = newPassword;
    }

    public void SubmitLogin()
    {
        if (username == accUsername && password == accPassword)
        {
            secretMessage.SetActive(true);
        }
    }
}
