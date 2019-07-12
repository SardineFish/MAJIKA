using UnityEngine;
using System.Collections;

public interface IEntityLifeCycle
{
    void OnActive();
    void OnInactive();
}
