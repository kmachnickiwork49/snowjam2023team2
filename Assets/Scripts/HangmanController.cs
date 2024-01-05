using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HangmanController : MonoBehaviour
{
    [SerializeField] GameObject wordContainer;
    [SerializeField] GameObject keyboardContainer;
    [SerializeField] GameObject letterContainer;
    [SerializeField] GameObject[] hangmanStages;
    [SerializeField] GameObject letterButton;
    [SerializeField] TextAsset possibleWord;


    [SerializeField] private GameObject roomToToggle;
    [SerializeField] private GameObject hbToToggle;


    [SerializeField] private FireplaceManage fire_mngr;
    [SerializeField] private KeypadManager key_mngr;
    [SerializeField] private ThroneManager throne_mngr;
    [SerializeField] private TrophiesRightManager trophies_mngr;
    [SerializeField] private GunsManager gun_mngr;
    [SerializeField] private DoorManager door_mngr;
    public string src = "";

    private string word;
    private int incorrectGuesses, correctGuesses;

    void Start()
    {
        InitializeButtons();
        InitializeGame();
    }

    private void InitializeButtons()
    {
        for(int i = 65; i <= 90; i++)
        {
            CreateButton(i);
        }
    }

    private void InitializeGame()
    {
        // Reset data back to original state
        incorrectGuesses = 0;
        correctGuesses = 0;
        foreach(Button child in keyboardContainer.GetComponentsInChildren<Button>())
        {
            child.interactable = true;
        }
        foreach(Transform child in wordContainer.GetComponentInChildren<Transform>())
        {
            Destroy(child.gameObject);
        }
        foreach(GameObject stage in hangmanStages)
        {
            stage.SetActive(false);
        }

        // Generate new word
        word = generateWord().ToUpper();
        foreach(char letter in word)
        {
            var temp = Instantiate(letterContainer, wordContainer.transform);
        }
    }

    private void CreateButton(int i)
    {
        GameObject temp = Instantiate(letterButton, keyboardContainer.transform);
        temp.GetComponentInChildren<TextMeshProUGUI>().text = ((char)i).ToString();
        temp.GetComponent<Button>().onClick.AddListener(delegate { CheckLetter(((char)i).ToString()); });
    }

    private string generateWord()
    {
        string[] wordList = possibleWord.text.Split("\n");
        string line = wordList[Random.Range(0, wordList.Length - 1)];
        // Removes \n at the end
        return line.Substring(0, line.Length - 1);
    }

    private void CheckLetter(string inputLetter)
    {
        bool letterInWord = false;
        for(int i = 0; i < word.Length; i++)
        {
            if(inputLetter == word[i].ToString())
            {
                letterInWord = true;
                correctGuesses++;
                wordContainer.GetComponentsInChildren<TextMeshProUGUI>()[i].text = inputLetter;
            }
        }
        if(letterInWord == false)
        {
            incorrectGuesses++;
            hangmanStages[incorrectGuesses - 1].SetActive(true);
        }
        CheckOutcome();
    }

    private void CheckOutcome()
    {
        if(correctGuesses == word.Length) // win
        {
            for(int i = 0; i < word.Length; i++)
            {
                wordContainer.GetComponentsInChildren<TextMeshProUGUI>()[i].color = Color.green;
            }
            if (roomToToggle != null) {
                Invoke("WinReturn", 3f);
            } else {
                Invoke("InitializeGame", 3f); // Waits three seconds to call InitializeGame()
            }
        }

        if(incorrectGuesses == hangmanStages.Length) //lose
        {
            for (int i = 0; i < word.Length; i++)
            {
                wordContainer.GetComponentsInChildren<TextMeshProUGUI>()[i].color = Color.red;
                wordContainer.GetComponentsInChildren<TextMeshProUGUI>()[i].text = word[i].ToString();
            }
            if (roomToToggle != null) {
                Invoke("LoseReturn", 3f);
            } else {
                Invoke("InitializeGame", 3f); // Waits three seconds to call InitializeGame()
            }

        }
    }

    private void WinReturn() {
        roomToToggle.SetActive(true);
        Debug.Log("won hb");

        if (src == "fireplace" && fire_mngr != null) {
            fire_mngr.fireOn = false;
        } else if (src == "throne" && throne_mngr != null) {
            throne_mngr.hasPlayedHangBear = true;
        } else if (src == "guns" && gun_mngr != null) {
            gun_mngr.hasPlayedHangBear = true;
        } else if (src == "trophies" && trophies_mngr != null) {
            trophies_mngr.hasPlayedHangBear = true;
        }

        if (key_mngr != null && fire_mngr != null && throne_mngr != null && gun_mngr != null && trophies_mngr != null && fire_mngr.fireOn == false && throne_mngr.hasPlayedHangBear && gun_mngr.hasPlayedHangBear && trophies_mngr.hasPlayedHangBear) {
            key_mngr.hasAllKeys = true;
        } 

        if (key_mngr != null && door_mngr != null && key_mngr.hasAllKeys == true) {
            door_mngr.isAlarmOff = true;
        }

        Invoke("InitializeGame", 3f); // Waits three seconds to call InitializeGame()
        hbToToggle.SetActive(false);
    }

    private void LoseReturn() {
        roomToToggle.SetActive(true);
        Debug.Log("lost hb");
        Invoke("InitializeGame", 3f); // Waits three seconds to call InitializeGame()
        hbToToggle.SetActive(false);
    }

}
