using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OpenInsta()
    {
        Application.OpenURL("https://www.instagram.com/aitzhan_slk/");
    }
}
