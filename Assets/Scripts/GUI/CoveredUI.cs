using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MAJIKA.GUI
{
    public class CoveredUI : UIPanel<CoveredUI>
    {
        static List<CoveredUI> UIs;
        public CoveredUI()
        {
            if (UIs == null)
                UIs = new List<CoveredUI>();
            UIs.Add(this);
        }

        private void OnDestroy()
        {
            UIs.Remove(this);
        }

        public static CoveredUI Find(string name)
        {
            return UIs.Where(ui => ui && ui.gameObject.IsInHierarchy() && ui.name == name).FirstOrDefault();
        }
    }
}
