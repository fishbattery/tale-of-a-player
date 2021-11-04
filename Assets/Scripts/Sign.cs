using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{

    public GameObject openDialogueBox;
    public GameObject dialogueBox;
    public Text dialogueText;
    public string dialogue;
    public bool playerInRange;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            if(dialogueBox.activeInHierarchy)
            {
                dialogueBox.SetActive(false);
                if(openDialogueBox.activeInHierarchy)
                {
                    openDialogueBox.SetActive(false);
                }
            }else{
                dialogueBox.SetActive(true);
                dialogueText.text = dialogue;
                if(openDialogueBox.activeInHierarchy)
                {
                    openDialogueBox.SetActive(false);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerInRange = true;
            openDialogueBox.SetActive(true);
        }    
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogueBox.SetActive(false);
            openDialogueBox.SetActive(false);
        }    
    }

}
