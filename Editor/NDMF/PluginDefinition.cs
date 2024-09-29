using nadena.dev.ndmf;
using UnityEngine;
using Sayabeans.GlobalPBInteraction;

[assembly: ExportsPlugin(typeof(PluginDefinition))]

namespace Sayabeans.GlobalPBInteraction
{
    internal sealed class PluginDefinition : Plugin<PluginDefinition>
    {
        public override string QualifiedName => "com.github.sayamame-beans.global-pb-interactions";
        public override string DisplayName => "Global PB Interactions";
        public override Color? ThemeColor => new Color(0.0f, 0.875f, 0.25f);

        protected override void Configure()
        {
            var sequence = InPhase(BuildPhase.Transforming)
                            .BeforePlugin("nadena.dev.modular-avatar");

            sequence.Run(Processors.GlobalInteractionProcessor.Instance);
        }
    }
}
