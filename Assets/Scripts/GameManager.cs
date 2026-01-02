using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject resultPanel;
    [SerializeField] private TextMeshProUGUI resultText;
    public bool isGameFinished;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Time.timeScale = 1.0f;
        isGameFinished = false;
    }

    public void PlayerLose()
    {
        resultText.color = Color.red;
        ShowResult("You Lose");
    }

    public void PlayerWin()
    {
        ShowResult("You Win !");
    }

    private void ShowResult(string message)
    {
        resultPanel.SetActive(true);
        resultText.text = message;
        isGameFinished = true;
    }

    public void RestartGame()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
}
