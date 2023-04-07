using System;
using UnityEngine;

namespace Bardent.EventChannels
{
    [CreateAssetMenu(fileName = "newTriggerChannel", menuName = "Event Channels/Trigger")]
    public class TriggerEventChannel : EventChannelsSO<EventArgs>
    {
    }
}