using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string GoodScene;
    public string BadScene;
    public BoomStart QuestCDone;
    public SwordQuestTrigger QuestSDone;
    // När denna metod kallas så stängs spelet av.
    public void QuitTheGame()
    {
        Application.Quit();
    }

    public void StartTheGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Om spelaren har klarat alla quest's så kommer spelaren komma till "GoodEnding" scenen. Annars i "BadEnding" scenen.
    //!! Tyvärr lyckades jag inte få det att fungera.
    public void EndScene()
    {
        if (QuestCDone == true && QuestSDone == true)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(3);
        }

        //else if (QuestCDone == true || QuestSDone == false)
        //{
        //    SceneManager.LoadScene(BadScene);
        //}
        //else if (QuestCDone == false || QuestSDone == true)
        //{
        //    SceneManager.LoadScene(BadScene);
        //}
        //else if (QuestCDone == true || QuestSDone == false)
        //{
        //    SceneManager.LoadScene(BadScene);
        //}
    }

}
