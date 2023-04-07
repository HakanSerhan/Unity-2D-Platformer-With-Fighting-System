using Bardent.Combat.Interfaces;
using Bardent.Modifiers;

namespace Bardent.CoreComponents
{
    public class PoiseDamageComponent : CoreComponent, IPoiseDamageable
    {
        private Stats stats;
        private Stats Stats => stats ? stats : core.GetCoreComponent(ref stats);

        public ModifierContainer<PoiseDamageModifier, PoiseDamageData> PoiseDamageModifiers { get; } = new();

        public void PoiseDamage(PoiseDamageData data)
        {
            print("Poise Damaged");
            var processedData = data;
            
            // Preprocess incoming poise damage

            processedData = PoiseDamageModifiers.ApplyModifiers(processedData);
            
            // Decrease Poise Stat
            Stats.Poise.Decrease(processedData.PoiseDamageAmount);
        }
    }
}