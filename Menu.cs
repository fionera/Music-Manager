using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModAPI;
using UnityEngine;

namespace Menu
{
    public class Menu : MonoBehaviour
    {
        public Functions.DisableMusic Music;
        public Commands.Commands Commands;
        public static bool DisableMusic = false;
        public static bool DisableSound = false;
        public static bool CombatMusic = false;
        public static bool StressMusic = false;
        public static bool CaveCombatMusic = false;
        public static bool CaveStressMusic = false;
        public static float Volume = 50f;
        protected bool visible;
        protected GUIStyle labelStyle;

        private void OnGUI()
        {
            if (this.visible)
            {
                GUI.skin = ModAPI.Tools.Skin;

                Matrix4x4 bkpMatrix = GUI.matrix;

                if (labelStyle == null)
                {
                    labelStyle = new GUIStyle(GUI.skin.label);
                    labelStyle.fontSize = 12;
                }

                GUI.Box(new Rect(10, 10, 400, 400), "Sound Menu", GUI.skin.window);

                float cY = 50f;
                GUI.Label(new Rect(20f, cY, 150f, 20f), "Disable Music:", labelStyle);
                Menu.DisableMusic = GUI.Toggle(new Rect(170f, cY, 20f, 30f), Menu.DisableMusic, "");
                cY += 30f;

                GUI.Label(new Rect(20f, cY, 150f, 30f), "Disable Detectsound:   (Coming Soon...)", labelStyle);
                Menu.DisableSound = GUI.Toggle(new Rect(170f, cY, 20f, 30f), Menu.DisableSound, "");
                cY += 30f;

                GUI.Label(new Rect(20f, cY, 150f, 20f), "Volume:", labelStyle);
                PlayerPreferences.Volume = GUI.HorizontalSlider(new Rect(170f, cY + 3f, 210f, 30f), PlayerPreferences.Volume, 0f, 1f);
                cY += 30f;

                if (GUI.Button(new Rect(280f, cY, 100f, 20f), "Stop Music"))
                {
                    CombatMusic = false;
                    StressMusic = false;
                    CaveCombatMusic = false;
                    CaveStressMusic = false;

                    Music.StressMusic.SetActive(false);
                    Music.CaveStressMusic.SetActive(false);
                    Music.CombatMusic.SetActive(false);
                    Music.CaveCombatMusic.SetActive(false);
                }
                cY += 30f;

            }
        }

        private void Update()
        {
            if (ModAPI.Input.GetButtonDown("Open"))
            {
                if (this.visible)
                {
                    ModAPI.Game.PlayerFreezed = false;
                    ModAPI.Game.ShowCursor = false;
                }
                else
                {
                    ModAPI.Game.PlayerFreezed = true;
                    ModAPI.Game.ShowCursor = true;
                }
                this.visible = !this.visible;
            }
        }
    }
}
