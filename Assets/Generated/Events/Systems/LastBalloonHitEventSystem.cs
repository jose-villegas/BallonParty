//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class LastBalloonHitEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<ILastBalloonHitListener> _listenerBuffer;

    public LastBalloonHitEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<ILastBalloonHitListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.LastBalloonHit)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasLastBalloonHit && entity.hasLastBalloonHitListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.lastBalloonHit;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.lastBalloonHitListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnLastBalloonHit(e, component.Value);
            }
        }
    }
}
