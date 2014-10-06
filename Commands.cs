using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using ModAPI;

namespace Commands
{
    public class Commands
    {
        public Functions.DisableMusic Music;

        public void RegisterCommands()
        {
           ModAPI.Console.RegisterCommand("stopmusic", StopMusic);
        }

        public void StopMusic(string param)
            {
                Music.StopMusic();
            }
    }
}
