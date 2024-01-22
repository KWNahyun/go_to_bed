using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RePosition : MonoBehaviour
{

    private void LateUpdate()
    {
        if (transform.position.x > -20)
        {
            return;
        }

        transform.Translate(40, 0, 0, Space.Self);

    }

}
