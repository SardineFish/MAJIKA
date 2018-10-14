using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SardineFish.Unity.FSM;

public class EntityState<TEntity> : State where TEntity : GameEntity
{
    public TEntity Entity { get; private set; }
    public EntityState(TEntity entity)
    {
        this.Entity = entity;
    }
}