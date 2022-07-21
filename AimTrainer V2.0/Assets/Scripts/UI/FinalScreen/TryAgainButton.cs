using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TryAgainButton : MonoBehaviour
{

    [SerializeField] private Button _button;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnTryAgainButtonClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnTryAgainButtonClick);
    }

    private void OnTryAgainButtonClick() => SceneManager.LoadScene(2);

}
