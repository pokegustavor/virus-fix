using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace virus_fix
{
    [HarmonyPatch(typeof(PLShipInfo),"Update")]
    public class Patch
    {
        static void Postfix(PLShipInfo __instance)
        {
            List<PLShipComponent> AllShipComponents = __instance.MyStats.AllComponents;
            for (int i = AllShipComponents.Count - 1; i > -1; i--)
            {
                if (AllShipComponents[i].SlotType == ESlotType.E_COMP_CARGO && AllShipComponents[i].ActualSlotType == ESlotType.E_COMP_VIRUS)
                {
                    __instance.MyStats.RemoveShipComponent(AllShipComponents[i]);
                }
            }
        }
    }
}
