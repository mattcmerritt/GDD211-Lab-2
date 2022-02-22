using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionApplication : MonoBehaviour
{
    // entering IP address
    [SerializeField]
    private GameObject addressScreen;
    [SerializeField]
    private GameObject failedConnectionText;
    private string address;
    public const string serverIP = "192.168.1.1";

    // puzzle
    [SerializeField]
    private GameObject puzzleScreen;

    // information screen
    [SerializeField]
    private GameObject loginInfoScreen;

    public void CompletePuzzle()
    {
        addressScreen.SetActive(false);
        puzzleScreen.SetActive(false);
        loginInfoScreen.SetActive(true);
    }

    public void SubmitIPAddress()
    {
        if (address == serverIP)
        {
            addressScreen.SetActive(false);
            puzzleScreen.SetActive(true);
            loginInfoScreen.SetActive(false);
        }
        else
        {
            failedConnectionText.SetActive(true);
        }
    }

    public void UpdateAddress(string newAddress)
    {
        address = newAddress;
    }
}
