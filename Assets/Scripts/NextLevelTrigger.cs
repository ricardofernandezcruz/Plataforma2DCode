using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica que el objeto que entró tenga la etiqueta "Player"
        if (other.CompareTag("Player"))
        {
            Debug.Log("aqui.");
            // Obtiene el índice de la escena activa
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            // Calcula el índice de la siguiente escena
            int nextSceneIndex = currentSceneIndex + 1;

            // Verifica si el índice de la siguiente escena es válido
            if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
            {
                // Carga la siguiente escena por índice
                SceneManager.LoadScene(nextSceneIndex);
            }
            else
            {
                Debug.Log("No hay más niveles para cargar.");
            }
        }
    }
}
