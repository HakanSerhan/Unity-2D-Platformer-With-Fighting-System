using UnityEngine;

namespace Bardent.Combat.Interfaces
{
    public interface IInteractable
    {
        void EnableInteraction();
        void DisableInteraction();
        Vector3 GetPosition();
        object GetInteractionContext();
        void SetContext(object obj);
    }
}