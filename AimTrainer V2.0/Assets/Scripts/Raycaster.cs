using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Raycaster : MonoBehaviour
{
    public event UnityAction IncreaseScore;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit))
            {
                if (hit.collider.TryGetComponent(out Target target))
                {
                    IncreaseScore?.Invoke();
                    Destroy(target.gameObject);
                }
            }
        }

    }
}
