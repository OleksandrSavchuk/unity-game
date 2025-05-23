using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int totalArtifacts;
    private int collectedArtifacts;

    public GameObject startPanel;
    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject aboutPanel;

    void Awake()
    {
        Instance = this;
        Time.timeScale = 0f; // «упинити гру на старт≥
    }

    void Start()
    {
        collectedArtifacts = 0;
        totalArtifacts = GameObject.FindGameObjectsWithTag("Artifact").Length;

        // ’оваЇмо вс≥ панел≥
        winPanel.SetActive(false);
        losePanel.SetActive(false);
        aboutPanel.SetActive(false);
        startPanel.SetActive(true);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        startPanel.SetActive(false);
    }

    public void About()
    {
        Time.timeScale = 1f;
        startPanel.SetActive(false );
        aboutPanel.SetActive(true);
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        aboutPanel.SetActive(false);
        startPanel.SetActive(true);
    }

    public void CollectArtifact()
    {
        collectedArtifacts++;
        if (collectedArtifacts >= totalArtifacts)
        {
            WinGame();
        }
    }

    public void WinGame()
    {
        Time.timeScale = 0f;
        winPanel.SetActive(true);
    }

    public void LoseGame()
    {
        Time.timeScale = 0f;
        losePanel.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
        Debug.Log("¬их≥д з гри...");
        Application.Quit();
    }
}
