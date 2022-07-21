using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
