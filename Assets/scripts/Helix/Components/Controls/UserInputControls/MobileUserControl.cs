﻿using System;
using UnityEngine;

namespace Helix.Components.Controls.UserInputControls
{
    public class MobileUserControl:UserInputControl
    {
        public MobileUserControl()
        {
        }

        public override bool ShouldPlayerFire()
        {
            return true;
        }

        public override void ShouldPlayerMove()
        {

        }
    }
}