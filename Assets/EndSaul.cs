﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndSaul : MonoBehaviour
{
    //movement script
    public SaulPlayer saulS;

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject textLayer2;
    public GameObject continueButton;
    public GameObject whiteFade;

    IEnumerator Type()
    {

        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Type());
        textLayer2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }

        //toggling movement and lookat function on and off after dialogue array has been reached

        if (index == sentences.Length - 1)
        {
            //textLayer2.SetActive(false);

            //white fade
            whiteFade.SetActive(true);

            //start to museum
            StartCoroutine(WaitSecToMuseum());
        }

    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }

    public void LoadMuseum()
    {
        SceneManager.LoadScene("Museum");

    }

    IEnumerator WaitSecToMuseum()
    {

        yield return new WaitForSeconds(4f);
        LoadMuseum();

    }
}