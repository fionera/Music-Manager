using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModAPI;
using UnityEngine;

namespace Main
{
    class Main : TheForestAtmosphere
    {
        protected Menu.Menu manager;

        override protected void Update()
        {
            if (manager == null)
            {
                GameObject ManagerGO = GameObject.Find("Manager");
                if (ManagerGO == null)
                    ManagerGO = new GameObject("Manager");
                manager = ManagerGO.GetComponent<Menu.Menu>();
                if (manager == null)
                {
                    manager = ManagerGO.AddComponent<Menu.Menu>();
                }
            }

            base.Update();
        }
    }
}
