using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SardineFish.Unity.FSM;

public class PlayerState: EntityState<Player>
{
    public PlayerState(Player player) : base(player) { }

}