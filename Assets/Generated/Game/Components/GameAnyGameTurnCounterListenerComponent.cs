//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnyGameTurnCounterListenerComponent anyGameTurnCounterListener { get { return (AnyGameTurnCounterListenerComponent)GetComponent(GameComponentsLookup.AnyGameTurnCounterListener); } }
    public bool hasAnyGameTurnCounterListener { get { return HasComponent(GameComponentsLookup.AnyGameTurnCounterListener); } }

    public void AddAnyGameTurnCounterListener(System.Collections.Generic.List<IAnyGameTurnCounterListener> newValue) {
        var index = GameComponentsLookup.AnyGameTurnCounterListener;
        var component = (AnyGameTurnCounterListenerComponent)CreateComponent(index, typeof(AnyGameTurnCounterListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyGameTurnCounterListener(System.Collections.Generic.List<IAnyGameTurnCounterListener> newValue) {
        var index = GameComponentsLookup.AnyGameTurnCounterListener;
        var component = (AnyGameTurnCounterListenerComponent)CreateComponent(index, typeof(AnyGameTurnCounterListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyGameTurnCounterListener() {
        RemoveComponent(GameComponentsLookup.AnyGameTurnCounterListener);
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

    static Entitas.IMatcher<GameEntity> _matcherAnyGameTurnCounterListener;

    public static Entitas.IMatcher<GameEntity> AnyGameTurnCounterListener {
        get {
            if (_matcherAnyGameTurnCounterListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnyGameTurnCounterListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnyGameTurnCounterListener = matcher;
            }

            return _matcherAnyGameTurnCounterListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddAnyGameTurnCounterListener(IAnyGameTurnCounterListener value) {
        var listeners = hasAnyGameTurnCounterListener
            ? anyGameTurnCounterListener.value
            : new System.Collections.Generic.List<IAnyGameTurnCounterListener>();
        listeners.Add(value);
        ReplaceAnyGameTurnCounterListener(listeners);
    }

    public void RemoveAnyGameTurnCounterListener(IAnyGameTurnCounterListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyGameTurnCounterListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyGameTurnCounterListener();
        } else {
            ReplaceAnyGameTurnCounterListener(listeners);
        }
    }
}
