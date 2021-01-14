using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


namespace Vodgets
{
    public class SW_TouchScript : Controller
    {

        public bool triggerState = false;
        public bool temp = false;

        void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
                temp = true;
                selector.SendButtonEvent(Selector.ButtonType.Trigger, true);
            }

            if (Input.GetMouseButtonUp(0))
            {
                temp = false;
                selector.SendButtonEvent(Selector.ButtonType.Trigger, false);
            }
        }
    }
}