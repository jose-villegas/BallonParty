//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public BalloonScoreReadyListenerComponent balloonScoreReadyListener { get { return (BalloonScoreReadyListenerComponent)GetComponent(GameComponentsLookup.BalloonScoreReadyListener); } }
    public bool hasBalloonScoreReadyListener { get { return HasComponent(GameComponentsLookup.BalloonScoreReadyListener); } }

    public void AddBalloonScoreReadyListener(System.Collections.Generic.List<IBalloonScoreReadyListener> newValue) {
        var index = GameComponentsLookup.BalloonScoreReadyListener;
        var component = (BalloonScoreReadyListenerComponent)CreateComponent(index, typeof(BalloonScoreReadyListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceBalloonScoreReadyListener(System.Collections.Generic.List<IBalloonScoreReadyListener> newValue) {
        var index = GameComponentsLookup.BalloonScoreReadyListener;
        var component = (BalloonScoreReadyListenerComponent)CreateComponent(index, typeof(BalloonScoreReadyListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveBalloonScoreReadyListener() {
        RemoveComponent(GameComponentsLookup.BalloonScoreReadyListener);
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

    static Entitas.IMatcher<GameEntity> _matcherBalloonScoreReadyListener;

    public static Entitas.IMatcher<GameEntity> BalloonScoreReadyListener {
        get {
            if (_matcherBalloonScoreReadyListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.BalloonScoreReadyListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBalloonScoreReadyListener = matcher;
            }

            return _matcherBalloonScoreReadyListener;
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

    public void AddBalloonScoreReadyListener(IBalloonScoreReadyListener value) {
        var listeners = hasBalloonScoreReadyListener
            ? balloonScoreReadyListener.value
            : new System.Collections.Generic.List<IBalloonScoreReadyListener>();
        listeners.Add(value);
        ReplaceBalloonScoreReadyListener(listeners);
    }

    public void RemoveBalloonScoreReadyListener(IBalloonScoreReadyListener value, bool removeComponentWhenEmpty = true) {
        var listeners = balloonScoreReadyListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveBalloonScoreReadyListener();
        } else {
            ReplaceBalloonScoreReadyListener(listeners);
        }
    }
}
