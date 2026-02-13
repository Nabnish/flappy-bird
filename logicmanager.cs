using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicmanager : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public GameObject gameover;
    [ContextMenu("addscore")]
    public void addscore(int scoreToAdd)

    {
        if (scoreToAdd==0) {
            score = 0;
        }else if (scoreToAdd == -1)
        {
            score = 0;
            scoretext.text = score.ToString();
        }
        else
        {

            score += scoreToAdd;
            scoretext.text = score.ToString();
        }

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameover.SetActive(true);
    }

}
