﻿using System;
using System.Linq;
using Entitas;
using UnityEngine;

public class LightningPowerUpController : BalloonPowerUpController, IAnyBalloonsBalanceEventListener, IAnyFreeProjectileListener
{
    [SerializeField] private ChainLightning _chainLightningPrefab;
    private ChainLightning _chainLightning;
    private GameEntity _listener;

    public override void Setup(IBalloonColorConfiguration colorConfiguration, GameEntity gameEntity)
    {
        base.Setup(colorConfiguration, gameEntity);
        
        _listener = _contexts.game.CreateEntity();
        _listener.AddAnyBalloonsBalanceEventListener(this);
        _listener.AddAnyFreeProjectileListener(this);
    }

    private void SetupLightning()
    {
        // setup chain lighting drawer
        var color = _gameEntity.balloonColor.Value;

        var balloons = _contexts.game.GetGroup(GameMatcher.Balloon);
        var targets = balloons.GetEntities().Where(x => x.balloonColor.Value == color).ToList();
        targets.Sort(Comparison);
        
        // forward to chain lightning effect handle
        if (_chainLightning == null)
        {
            _chainLightning = Instantiate(_chainLightningPrefab);
            _chainLightning.gameObject.SetActive(true);
        }

        _chainLightning.Setup(targets);
    }

    public override void Activate()
    {
        _chainLightning.Display();
        
        // mark power up as consumed
        _gameEntity.isBalloonPowerUpActivated = true;
    }

    private int Comparison(GameEntity x, GameEntity y)
    {
        var origin = _gameEntity.position.Value;
        var d1 = Vector3.Distance(x.position.Value, origin);
        var d2 = Vector3.Distance(y.position.Value, origin);
        return d1.CompareTo(d2);
    }

    public void OnAnyBalloonsBalanceEvent(GameEntity entity)
    {
        SetupLightning();
    }

    public void OnAnyFreeProjectile(GameEntity entity)
    {
        SetupLightning();
    }

    private void OnDestroy()
    {
        _listener.Destroy();
    }
}