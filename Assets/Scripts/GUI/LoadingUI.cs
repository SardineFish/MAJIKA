using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;

namespace MAJIKA.GUI
{
    public class LoadingUI : UIPanel<LoadingUI>
    {
        public List<Sprite> Posters = new List<Sprite>();
        
        public void ChangePoster()
        {
            transform.Find("Image").GetComponent<Image>().sprite = Posters.RandomTake(1).FirstOrDefault();
        }

        public override IEnumerator Show(float time = 0.1F)
        {
            if (!Visible)
                ChangePoster();
            return base.Show(time);
        }
    }
}



