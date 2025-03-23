using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    [SerializeField] public GameObject gameOverPanel;
    public void RestartGame()
    {
        Debug.Log("Restart butonuna basıldı, sahne yeniden yükleniyor...");
        Time.timeScale = 1;
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
