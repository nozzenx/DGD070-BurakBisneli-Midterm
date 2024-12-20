//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ECS.Components.PlayerHealthComponent eCSComponentsPlayerHealth { get { return (ECS.Components.PlayerHealthComponent)GetComponent(GameComponentsLookup.ECSComponentsPlayerHealth); } }
    public bool hasECSComponentsPlayerHealth { get { return HasComponent(GameComponentsLookup.ECSComponentsPlayerHealth); } }

    public void AddECSComponentsPlayerHealth(float newValue) {
        var index = GameComponentsLookup.ECSComponentsPlayerHealth;
        var component = (ECS.Components.PlayerHealthComponent)CreateComponent(index, typeof(ECS.Components.PlayerHealthComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceECSComponentsPlayerHealth(float newValue) {
        var index = GameComponentsLookup.ECSComponentsPlayerHealth;
        var component = (ECS.Components.PlayerHealthComponent)CreateComponent(index, typeof(ECS.Components.PlayerHealthComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveECSComponentsPlayerHealth() {
        RemoveComponent(GameComponentsLookup.ECSComponentsPlayerHealth);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherECSComponentsPlayerHealth;

    public static Entitas.IMatcher<GameEntity> ECSComponentsPlayerHealth {
        get {
            if (_matcherECSComponentsPlayerHealth == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ECSComponentsPlayerHealth);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherECSComponentsPlayerHealth = matcher;
            }

            return _matcherECSComponentsPlayerHealth;
        }
    }
}
