using nadena.dev.ndmf;
using UnityEngine;

namespace Sayabeans.GlobalPBInteraction.Processors
{
    internal class GlobalInteractionProcessor: Pass<GlobalInteractionProcessor>
    {
        public override string DisplayName => "GlobalInteraction";

        protected override void Execute(BuildContext context)
        {
            var components = context.AvatarRootObject.GetComponentsInChildren<GlobalInteraction>(true);
            foreach (var component in components)
            {
                Debug.Log(component.diversionPoint);
                Object.DestroyImmediate(component);
            }
        }
    }
}
