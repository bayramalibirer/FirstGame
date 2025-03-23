using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private float BottomBound = -8f;
    [SerializeField] private float speed = -2f;

    [SerializeField] public GameObject gameOverPanel; // Canvas yerine GameObject olarak tanımla


  

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.z < BottomBound)
        {
            Destroy(gameObject);
            SoundManager.instance.GameOver(); // GameOver fonksiyonunu çağır
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger tetiklendi: " + other.gameObject.name); // Hangi obje tetiklenmiş kontrol et

        // Eğer nesne zaten sınırın altındaysa Game Over yap
        SoundManager.instance.PlayExplosionSound();
        if (transform.position.z < BottomBound)
        {
            SoundManager.instance.GameOver();
        }

        Destroy(gameObject); // Nesneyi yok et
    }
}
