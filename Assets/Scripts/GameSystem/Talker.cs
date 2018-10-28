using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName ="Person",menuName ="Conversation/Talker")]
public class Talker : ScriptableObject
{
    public Sprite Image;
    public string Name;
}
