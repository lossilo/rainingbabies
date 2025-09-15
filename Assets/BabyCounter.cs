using UnityEditor.SearchService;
using UnityEngine;

public class BabyCounter : MonoBehaviour
{

    //[SerializeField] BabyScript babyScript;

    int greenBabies;
    int pinkBabies;

    [SerializeField] GameObject Loss;
    [SerializeField] GameObject Win;

    void Update()
    {
        ReadPlayerInputs();
    }

    void ReadPlayerInputs()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            greenBabies += 1;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            pinkBabies += 1;
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
