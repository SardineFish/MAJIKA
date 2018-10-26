using UnityEngine;
using System.Collections;

public class LifeTime : MonoBehaviour
{
    public float lifeTime;

    float time = 0;
    // Use this for initialization
    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > lifeTime)
            Destroy(gameObject);
    }
}
