//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class LayerEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<ILayerListener> _listenerBuffer;

    public LayerEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<ILayerListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.Layer)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasLayer && entity.hasLayerListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.layer;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.layerListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnLayer(e, component.Value);
            }
        }
    }
}