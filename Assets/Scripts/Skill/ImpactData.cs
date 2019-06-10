using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class ImpactData : IEffectorTrigger
{
    public Vector2 Direction;
    public Vector3 Position;
    public GameEntity Creator;
    public ImpactType ImpactType;
}
