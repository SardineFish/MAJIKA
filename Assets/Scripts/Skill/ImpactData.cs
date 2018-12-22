using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class ImpactData : IEffectorTrigger
{
    public Vector3 position;
    public GameEntity Creator;
    public ImpactType ImpactType;
}
