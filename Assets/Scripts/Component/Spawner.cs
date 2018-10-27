using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject Prefab;
    public void Spawn()
    {
        Instantiate(Prefab, transform.position, transform.rotation);
    }
}
