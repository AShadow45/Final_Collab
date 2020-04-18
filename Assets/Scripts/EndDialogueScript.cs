using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndDialogueScript : MonoBehaviour
{
    //movement script
    public HoldMoveScript hmS;

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    public GameObject textImage;

    public Collider2D barrier;

    public GameObject barrierAnim;


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

        if (index == sentences.Length - 1)
        {
            //open the barrier
            barrier.GetComponent<Collider2D>().enabled = false;
            textImage.SetActive(false);
            //particle fade
            barrierAnim.SetActive(false);
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
        if (other.gameObject.CompareTag("Player"))
        {
            hmS.gameIsPaused = true;
            GetComponent<Collider2D>().enabled = false;
            textImage.SetActive(true);
            StartCoroutine(Type());
        }
    }
}
