using UnityEngine;
using System.Collections;

public class SelfDestructor : MonoBehaviour
{
    public void Destruct()
    {
        Destroy(gameObject);
    }
}
