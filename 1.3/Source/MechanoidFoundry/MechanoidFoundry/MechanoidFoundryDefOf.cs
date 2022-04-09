﻿using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Verse;

namespace MechanoidFoundry
{
    [DefOf]
    public static class MechanoidFoundryDefOf
    {
        public static ThingDef MF_MechanoidFoundry;
        public static RecipeDef MF_HackMechanoid;
        public static ThingDef MF_MechanoidPad;
        public static JobDef MF_HaulCorpseToPad;
        public static WorkGiverDef MF_DoBillsMedicalMechanoidOperation;
        public static ThinkTreeDef VFE_Mechanoids_Machine_RiddableConstant;
        public static ThinkTreeDef Downed;
        public static ThinkTreeDef VFE_MainMachineBehaviourViolentActive;
    }
}
