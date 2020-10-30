//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly BalloonScoreReadyComponent balloonScoreReadyComponent = new BalloonScoreReadyComponent();

    public bool isBalloonScoreReady {
        get { return HasComponent(GameComponentsLookup.BalloonScoreReady); }
        set {
            if (value != isBalloonScoreReady) {
                var index = GameComponentsLookup.BalloonScoreReady;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : balloonScoreReadyComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherBalloonScoreReady;

    public static Entitas.IMatcher<GameEntity> BalloonScoreReady {
        get {
            if (_matcherBalloonScoreReady == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.BalloonScoreReady);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBalloonScoreReady = matcher;
            }

            return _matcherBalloonScoreReady;
        }
    }
}
