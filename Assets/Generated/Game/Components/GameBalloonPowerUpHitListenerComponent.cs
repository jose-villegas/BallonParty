//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public BalloonPowerUpHitListenerComponent balloonPowerUpHitListener { get { return (BalloonPowerUpHitListenerComponent)GetComponent(GameComponentsLookup.BalloonPowerUpHitListener); } }
    public bool hasBalloonPowerUpHitListener { get { return HasComponent(GameComponentsLookup.BalloonPowerUpHitListener); } }

    public void AddBalloonPowerUpHitListener(System.Collections.Generic.List<IBalloonPowerUpHitListener> newValue) {
        var index = GameComponentsLookup.BalloonPowerUpHitListener;
        var component = (BalloonPowerUpHitListenerComponent)CreateComponent(index, typeof(BalloonPowerUpHitListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBalloonPowerUpHitListener(System.Collections.Generic.List<IBalloonPowerUpHitListener> newValue) {
        var index = GameComponentsLookup.BalloonPowerUpHitListener;
        var component = (BalloonPowerUpHitListenerComponent)CreateComponent(index, typeof(BalloonPowerUpHitListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBalloonPowerUpHitListener() {
        RemoveComponent(GameComponentsLookup.BalloonPowerUpHitListener);
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

    static Entitas.IMatcher<GameEntity> _matcherBalloonPowerUpHitListener;

    public static Entitas.IMatcher<GameEntity> BalloonPowerUpHitListener {
        get {
            if (_matcherBalloonPowerUpHitListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.BalloonPowerUpHitListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBalloonPowerUpHitListener = matcher;
            }

            return _matcherBalloonPowerUpHitListener;
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

    public void AddBalloonPowerUpHitListener(IBalloonPowerUpHitListener value) {
        var listeners = hasBalloonPowerUpHitListener
            ? balloonPowerUpHitListener.value
            : new System.Collections.Generic.List<IBalloonPowerUpHitListener>();
        listeners.Add(value);
        ReplaceBalloonPowerUpHitListener(listeners);
    }

    public void RemoveBalloonPowerUpHitListener(IBalloonPowerUpHitListener value, bool removeComponentWhenEmpty = true) {
        var listeners = balloonPowerUpHitListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveBalloonPowerUpHitListener();
        } else {
            ReplaceBalloonPowerUpHitListener(listeners);
        }
    }
}
