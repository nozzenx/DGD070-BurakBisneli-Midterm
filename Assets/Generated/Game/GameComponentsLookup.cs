//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int ECSComponentsPlayerDamaged = 0;
    public const int ECSComponentsPlayerHealed = 1;
    public const int ECSComponentsPlayerHealth = 2;

    public const int TotalComponents = 3;

    public static readonly string[] componentNames = {
        "ECSComponentsPlayerDamaged",
        "ECSComponentsPlayerHealed",
        "ECSComponentsPlayerHealth"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(ECS.Components.PlayerDamagedComponent),
        typeof(ECS.Components.PlayerHealedComponent),
        typeof(ECS.Components.PlayerHealthComponent)
    };
}
