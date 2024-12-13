using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseClickTest : MonoBehaviour
{
    private void OnMouseDown()
    {
        print(gameObject.name);
    }
}
