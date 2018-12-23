using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class Locker
{
    private List<Guid> Locks = new List<Guid>();
    public bool Locked => Locks.Count > 0;
    public Guid Lock()
    {
        var id = Guid.NewGuid();
        Locks.Add(id);
        return id;
    }
    public bool UnLock(Guid id)
    {
        Locks.Remove(id);
        return !Locked;
    }
    public void UnLockAll()
    {
        Locks.Clear();
    }
}