using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioDeEscena : MonoBehaviour
{
    public string nombreEscena;

    private void OnMouseDown()
    {
        if (!string.IsNullOrEmpty(nombreEscena))
        {
            SceneManager.LoadScene(nombreEscena);
        }
        else
        {
            Debug.LogWarning("No se ha asignado un nombre de escena en el Inspector.");
        }
    } 

}
