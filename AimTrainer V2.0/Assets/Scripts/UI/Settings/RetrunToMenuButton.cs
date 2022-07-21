using UnityEngine;
using UnityEngine.SceneManagement;

public class RetrunToMenuButton : MonoBehaviour
{
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
