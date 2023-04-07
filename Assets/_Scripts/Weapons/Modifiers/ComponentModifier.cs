namespace Bardent.Weapons
{
    public class ComponentModifier<T> : WeaponComponent<T> where T: WeaponComponentData
    {
        protected WeaponModifiers modifiers;

        public override void SetReferences()
        {
            base.SetReferences();
            modifiers = GetComponent<WeaponModifiers>();
        }
    }
}