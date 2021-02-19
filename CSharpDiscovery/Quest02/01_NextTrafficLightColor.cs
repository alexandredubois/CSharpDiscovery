using CSharpDiscovery.Models;

namespace CSharpDiscovery.Quest02
{
    public class _01_NextTrafficLightColor
    {
        //Quest 2.1 : Modifie la méthode pour qu'elle retourne la prochaine couleur du feu rouge (ex : si elle reçoit rouge en entrée, en sortie elle retourne vert)
        /// <summary>
        /// Returns the next color of the traffic light
        /// </summary>
        /// <param name="currentColor">Current color</param>
        /// <returns>Next color</returns>
        public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor)
        {
            return TrafficLightColor.None;
        }
    }
}
