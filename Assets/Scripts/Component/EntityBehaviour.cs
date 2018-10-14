using UnityEngine;
using System.Collections;

public class EntityBehaviour<T> : MonoBehaviour where T:GameEntity
{
    public T Entity => GetComponent<T>();
}
