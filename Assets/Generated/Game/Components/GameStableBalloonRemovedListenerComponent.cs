//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public StableBalloonRemovedListenerComponent stableBalloonRemovedListener { get { return (StableBalloonRemovedListenerComponent)GetComponent(GameComponentsLookup.StableBalloonRemovedListener); } }
    public bool hasStableBalloonRemovedListener { get { return HasComponent(GameComponentsLookup.StableBalloonRemovedListener); } }

    public void AddStableBalloonRemovedListener(System.Collections.Generic.List<IStableBalloonRemovedListener> newValue) {
        var index = GameComponentsLookup.StableBalloonRemovedListener;
        var component = (StableBalloonRemovedListenerComponent)CreateComponent(index, typeof(StableBalloonRemovedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceStableBalloonRemovedListener(System.Collections.Generic.List<IStableBalloonRemovedListener> newValue) {
        var index = GameComponentsLookup.StableBalloonRemovedListener;
        var component = (StableBalloonRemovedListenerComponent)CreateComponent(index, typeof(StableBalloonRemovedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveStableBalloonRemovedListener() {
        RemoveComponent(GameComponentsLookup.StableBalloonRemovedListener);
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

    static Entitas.IMatcher<GameEntity> _matcherStableBalloonRemovedListener;

    public static Entitas.IMatcher<GameEntity> StableBalloonRemovedListener {
        get {
            if (_matcherStableBalloonRemovedListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.StableBalloonRemovedListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherStableBalloonRemovedListener = matcher;
            }

            return _matcherStableBalloonRemovedListener;
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

    public void AddStableBalloonRemovedListener(IStableBalloonRemovedListener value) {
        var listeners = hasStableBalloonRemovedListener
            ? stableBalloonRemovedListener.value
            : new System.Collections.Generic.List<IStableBalloonRemovedListener>();
        listeners.Add(value);
        ReplaceStableBalloonRemovedListener(listeners);
    }

    public void RemoveStableBalloonRemovedListener(IStableBalloonRemovedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = stableBalloonRemovedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveStableBalloonRemovedListener();
        } else {
            ReplaceStableBalloonRemovedListener(listeners);
        }
    }
}
