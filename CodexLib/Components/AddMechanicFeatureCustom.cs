﻿using Kingmaker.UnitLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodexLib
{
    public class AddMechanicFeatureCustom : UnitFactComponentDelegate
    {
        public MechanicFeature Feature;

        public AddMechanicFeatureCustom(MechanicFeature feature)
        {
            this.Feature = feature;
        }

        public override void OnTurnOn()
        {
            this.Owner.Retain(Feature);
        }

        public override void OnTurnOff()
        {
            this.Owner.Release(Feature);
        }
    }
}
