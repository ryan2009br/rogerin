using UnityEngine;
using UnityEngine.SceneManagement; // Necess�rio para trocar de cena

public class SceneTransition : MonoBehaviour
{
    [Header("Configura��o")]
    public string sceneToLoad; // Nome da cena de destino

    private bool isPlayerOverlapping = false;

    void Update()
    {
        // Se o player est� sobre o objeto e pressionar espa�o
        if (isPlayerOverlapping && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    // Detecta quando o player entra no trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("T�");
            isPlayerOverlapping = true;
        }  
    }

    // Detecta quando o player sai do trigger
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerOverlapping = false;
        }
    }
}
