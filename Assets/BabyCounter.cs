using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

public class BabyCounter : MonoBehaviour
{

    //[SerializeField] BabyScript babyScript;

    int greenBabies;
    int pinkBabies;

    [SerializeField] GameObject Loss;
    [SerializeField] GameObject Win;

    [SerializeField] TextMeshProUGUI greenBabiesCounted, pinkBabiesCounted;

    void Update()
    {
        ReadPlayerInputs();
    }

    void ReadPlayerInputs()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            greenBabies += 1;
            greenBabiesCounted.text = "Babies: " + greenBabies.ToString();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            pinkBabies += 1;
            pinkBabiesCounted.text = "Babies: " + pinkBabies.ToString();
        }
    }


    void Done()
    {
        //if(babyScript.greenBabiesSpawned = greenBabies && babyScript.pinkBabiesSpawned = pinkBabies)
        //{
        //  Win.SetActive(true);
        //  Debug.Log("You Win!!!");
        //}
        //else
        //{
        //  Loss.SetActive(true);
        //  Debug.Log("You lose...")
        //}
    }

    public void Restart()
    {
        Win.SetActive(false);
        Loss.SetActive(false);
        pinkBabies = 0;
        greenBabies = 0;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
