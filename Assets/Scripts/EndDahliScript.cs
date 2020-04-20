using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndDahliScript : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject skullDialogue;
    public GameObject continueButton2;
    //public GameObject textImage;

    public GameObject skullBarrier;

    private Collider2D skullCol;

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
        continueButton2.SetActive(false);
        skullCol = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton2.SetActive(true);
        }

        if (index == sentences.Length - 1)
        {
            //open the barrier
            skullBarrier.GetComponent<Collider2D>().enabled = false;
            //textImage.SetActive(false);
        }

    }

    public void NextSentence()
    {
        continueButton2.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton2.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("skull is hitting player");
            //disable skull col
            skullCol.enabled = false;

            //textImage.SetActive(true);
            //[text panel]

            StartCoroutine(Type());

            //set barrier active
            skullBarrier.SetActive(true);
        }
    }
}
