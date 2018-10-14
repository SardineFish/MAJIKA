using UnityEngine;
using System.Collections;

public class GameEntity : MonoBehaviour
{
    public const string NameRenderer = "Renderer";
    public const string NameCollider = "Collider";
    public GameObject Renderer => transform.Find(NameRenderer).gameObject;
    public GameObject Collider => transform.Find(NameCollider).gameObject;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
