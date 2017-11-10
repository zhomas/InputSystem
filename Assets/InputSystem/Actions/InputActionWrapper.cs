using System;
using UnityEngine;

namespace ISX
{
    // Base class for wrappers generated by the input asset importer.
    // Has a custom property drawer that allows dropping assets onto the
    // wrapper property.
    [Serializable]
    public class InputActionWrapper : ICloneable
    {
        public InputActionAsset asset => m_Asset;

        public void Enable()
        {
            var sets = asset.actionSets;
            for (var i = 0; i < sets.Count; ++i)
                sets[i].Enable();
        }

        public void Disable()
        {
            var sets = asset.actionSets;
            for (var i = 0; i < sets.Count; ++i)
                sets[i].Disable();
        }

        public InputActionWrapper Clone()
        {
            var clone = (InputActionWrapper)MemberwiseClone();
            return clone;
        }

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }

        [SerializeField] private InputActionAsset m_Asset;
    }
}
