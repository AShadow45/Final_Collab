using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartDahli : MonoBehaviour
{
    public CrouchingScript crouchingS;
    public WindScript windScript;

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;

    public GameObject dialogueBlock;

    

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
            
            dialogueBlock.SetActive(false);
            windScript.windIsStart = true;
            //Debug.Log("End of the Array");
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            this.GetComponent<Collider2D>().enabled = false;
            StartCoroutine(Type());

            dialogueBlock.SetActive(true);
        }
    }
}
