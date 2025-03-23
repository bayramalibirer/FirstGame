using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] private AudioSource explosionSource;

    [SerializeField] public GameObject gameOverPanel;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlayExplosionSound()
    {
        explosionSource.Play();
    }

    public void GameOver()
    {
        if (gameOverPanel != null)
        {
            Debug.Log("Oyun bitti!");
            gameOverPanel.SetActive(true); // Oyun bitti panelini aç
        }
        else
        {
            Debug.LogError("GameOver paneli bulunamadı!");
        }

        Time.timeScale = 0; // Oyunu durdur
    }
}
