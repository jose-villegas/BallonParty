﻿using UnityEngine;

[RequireComponent(typeof(LinkedViewController))]
public class BalloonSpriteLayerController : MonoBehaviour, ISlotIndexListener
{
    [SerializeField] private SpriteRenderer[] _renderers;

    private LinkedViewController _linkedView;
    private IGameConfiguration _configuration;

    private void Awake()
    {
        _configuration = Contexts.sharedInstance.configuration.gameConfiguration.value;

        _linkedView = GetComponent<LinkedViewController>();
        _linkedView.OnViewLinked += OnViewLinked;
    }

    private void OnViewLinked(GameEntity gameEntity)
    {
        gameEntity.AddSlotIndexListener(this);

        if (gameEntity.hasSlotIndex)
        {
            OnSlotIndex(gameEntity, gameEntity.slotIndex.Value);
        }
    }

    public void OnSlotIndex(GameEntity entity, Vector2Int value)
    {
        var baseLayer = value.x + (value.y * _configuration.SlotsSize.x) + _renderers.Length;

        for (int i = 0; i < _renderers.Length; i++)
        {
            var spriteRenderer = _renderers[i];
            spriteRenderer.sortingOrder = baseLayer + i + 1;
        }
    }
}