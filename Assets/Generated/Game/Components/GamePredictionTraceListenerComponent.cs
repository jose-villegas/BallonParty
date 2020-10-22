//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PredictionTraceListenerComponent predictionTraceListener { get { return (PredictionTraceListenerComponent)GetComponent(GameComponentsLookup.PredictionTraceListener); } }
    public bool hasPredictionTraceListener { get { return HasComponent(GameComponentsLookup.PredictionTraceListener); } }

    public void AddPredictionTraceListener(System.Collections.Generic.List<IPredictionTraceListener> newValue) {
        var index = GameComponentsLookup.PredictionTraceListener;
        var component = (PredictionTraceListenerComponent)CreateComponent(index, typeof(PredictionTraceListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplacePredictionTraceListener(System.Collections.Generic.List<IPredictionTraceListener> newValue) {
        var index = GameComponentsLookup.PredictionTraceListener;
        var component = (PredictionTraceListenerComponent)CreateComponent(index, typeof(PredictionTraceListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemovePredictionTraceListener() {
        RemoveComponent(GameComponentsLookup.PredictionTraceListener);
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

    static Entitas.IMatcher<GameEntity> _matcherPredictionTraceListener;

    public static Entitas.IMatcher<GameEntity> PredictionTraceListener {
        get {
            if (_matcherPredictionTraceListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PredictionTraceListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPredictionTraceListener = matcher;
            }

            return _matcherPredictionTraceListener;
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

    public void AddPredictionTraceListener(IPredictionTraceListener value) {
        var listeners = hasPredictionTraceListener
            ? predictionTraceListener.value
            : new System.Collections.Generic.List<IPredictionTraceListener>();
        listeners.Add(value);
        ReplacePredictionTraceListener(listeners);
    }

    public void RemovePredictionTraceListener(IPredictionTraceListener value, bool removeComponentWhenEmpty = true) {
        var listeners = predictionTraceListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemovePredictionTraceListener();
        } else {
            ReplacePredictionTraceListener(listeners);
        }
    }
}
