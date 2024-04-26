using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Main : MonoBehaviour
{
    string Password; // The password
    string playerGuess; // The player's guess

    // Hookup to Unity variables
    TMP_InputField inputFieldGuess;
    TextMeshProUGUI resultText;

    // Start is called before the first frame update
    void Start()
    {
        Password = "paris";
        playerGuess = "";

        Debug.Log("The password is: " + Password);

        // Hookup the GUI
        inputFieldGuess = gameObject.transform.Find("InputFieldGuess")?.GetComponent<TMP_InputField>();
        resultText = gameObject.transform.Find("resultText")?.GetComponent<TextMeshProUGUI>();

        if (inputFieldGuess == null || resultText == null)
        {
            Debug.LogError("Input field or result text not found. Make sure they are correctly assigned in the Unity Editor.");
        }
    }

    public void SubmitClick()
    {
        playerGuess = inputFieldGuess.text; // Get the player's guess from the input field

        Debug.Log("Player Guess: " + playerGuess); // Debugging statement
        Debug.Log("Password: " + Password); // Debugging statement

        if (playerGuess == Password)
        {
            resultText.text = "Congratulations! You guessed the correct password.";
            SceneManager.LoadScene("scene2"); // Load the next scene
        }
        else
        {
            resultText.text = "Wrong password. Try again.";
        }

        inputFieldGuess.text = ""; // Clear the input field after submission
    }
}
