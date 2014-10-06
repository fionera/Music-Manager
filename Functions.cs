using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functions
{
    class Volume : PlayerPreferences
    {
        protected override void Update()
        {
            base.Update();
            //TODO: Code for multiple Volume settings
        }
    }

    public class DisableMusic : sceneTracker
    {
        protected override void Update()
        {

            if (Menu.Menu.DisableMusic == false)
            {
                base.Update();
            }
            else
            {
                    this.StressMusic.SetActive(false);
                    this.CaveStressMusic.SetActive(false);
                    this.CombatMusic.SetActive(false);
                    this.CaveCombatMusic.SetActive(false);
            }
        }
        public void StopMusic()
        {
                this.StressMusic.SetActive(false);
                this.CaveStressMusic.SetActive(false);
                this.CombatMusic.SetActive(false);
                this.CaveCombatMusic.SetActive(false);
        }
    }
}
