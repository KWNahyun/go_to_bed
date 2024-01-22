using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RePosition : MonoBehaviour
{

    public UnityEvent onMove;

    private void LateUpdate()
    {
        if (transform.position.x > -20)
        {
            return;
        }

        transform.Translate(40, 0, 0, Space.Self);
        onMove.Invoke();
    }

}
