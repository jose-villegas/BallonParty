//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public BalloonPowerUpActivatedListenerComponent balloonPowerUpActivatedListener { get { return (BalloonPowerUpActivatedListenerComponent)GetComponent(GameComponentsLookup.BalloonPowerUpActivatedListener); } }
    public bool hasBalloonPowerUpActivatedListener { get { return HasComponent(GameComponentsLookup.BalloonPowerUpActivatedListener); } }

    public void AddBalloonPowerUpActivatedListener(System.Collections.Generic.List<IBalloonPowerUpActivatedListener> newValue) {
        var index = GameComponentsLookup.BalloonPowerUpActivatedListener;
        var component = (BalloonPowerUpActivatedListenerComponent)CreateComponent(index, typeof(BalloonPowerUpActivatedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBalloonPowerUpActivatedListener(System.Collections.Generic.List<IBalloonPowerUpActivatedListener> newValue) {
        var index = GameComponentsLookup.BalloonPowerUpActivatedListener;
        var component = (BalloonPowerUpActivatedListenerComponent)CreateComponent(index, typeof(BalloonPowerUpActivatedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBalloonPowerUpActivatedListener() {
        RemoveComponent(GameComponentsLookup.BalloonPowerUpActivatedListener);
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

    static Entitas.IMatcher<GameEntity> _matcherBalloonPowerUpActivatedListener;

    public static Entitas.IMatcher<GameEntity> BalloonPowerUpActivatedListener {
        get {
            if (_matcherBalloonPowerUpActivatedListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.BalloonPowerUpActivatedListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBalloonPowerUpActivatedListener = matcher;
            }

            return _matcherBalloonPowerUpActivatedListener;
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

    public void AddBalloonPowerUpActivatedListener(IBalloonPowerUpActivatedListener value) {
        var listeners = hasBalloonPowerUpActivatedListener
            ? balloonPowerUpActivatedListener.value
            : new System.Collections.Generic.List<IBalloonPowerUpActivatedListener>();
        listeners.Add(value);
        ReplaceBalloonPowerUpActivatedListener(listeners);
    }

    public void RemoveBalloonPowerUpActivatedListener(IBalloonPowerUpActivatedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = balloonPowerUpActivatedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveBalloonPowerUpActivatedListener();
        } else {
            ReplaceBalloonPowerUpActivatedListener(listeners);
        }
    }
}
