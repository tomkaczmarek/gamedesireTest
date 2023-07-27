using Assets.Scripts.Service;
using Assets.Scripts.Service.DataModel;
using Assets.Scripts.UI;
using Assets.Scripts.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainWindow : BaseWindow
{
    private const int FIRST_INDEX = 1;
    private IDataServer _service;

    [SerializeField] private BaseContainer _itemsContainer;
    [SerializeField] private Button _prevButton;
    [SerializeField] private Button _nextButton;

    public override void Awake()
    {
        base.Awake();
        InitializeListeners();
        InitializeContainer();
    }

    public void InitializeListeners()
    {
        _itemsContainer.OnGenerateEnd += OnGenerateEnd;
        _prevButton?.onClick.AddListener(() => PrevAction());
        _nextButton?.onClick.AddListener(() => NextAction());
    }

    private void OnGenerateEnd()
    {
        _prevButton.interactable = _itemsContainer.CurrentPage != FIRST_INDEX;
    }

    public void InitializeContainer()
    {
        _itemsContainer.Initialize(new MockServer(), new ItemGenerator());
        _itemsContainer.FillContent(FIRST_INDEX);
    }

    private void PrevAction()
    {
        _itemsContainer.FillContent(_itemsContainer.CurrentPage - 1);
    }

    private void NextAction()
    {
        _itemsContainer.FillContent(_itemsContainer.CurrentPage + 1);
    }

    public override void OnDisable()
    {
        _itemsContainer.OnGenerateEnd -= OnGenerateEnd;
        _prevButton?.onClick.RemoveAllListeners();
        _nextButton?.onClick.RemoveAllListeners();
    }
}
