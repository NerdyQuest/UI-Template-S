using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gem;
    [SerializeField] private GameObject settings;
    [SerializeField] private GameObject spinWheels;
    [SerializeField] private GameObject noAds;
    [SerializeField] private GameObject upgrade;
    [SerializeField] private GameObject shop;
    [SerializeField] private GameObject buildLevel;
    [SerializeField] private GameObject pass;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject newItem;

    public void Gem()
    {
        gem.SetActive(true);
    }

    public void Settings()
    {
        settings.SetActive(true);
    }

    public void SpinWheels()
    {
        spinWheels.SetActive(true);
    }

    public void NoAds()
    {
        noAds.SetActive(true);
    }

    public void Upgrade()
    {
        upgrade.SetActive(true);
    }

    public void Shop()
    {
        shop.SetActive(true);
    }

    public void BuildLevel()
    {
        buildLevel.SetActive(true);
    }

    public void Pass()
    {
        pass.SetActive(true);
    }

    public void Back()
    {
        gem.SetActive(false);
        settings.SetActive(false);
        spinWheels.SetActive(false);
        noAds.SetActive(false);
        upgrade.SetActive(false);
        shop.SetActive(false);
        buildLevel.SetActive(false);
        pass.SetActive(false);
    }

    public void TapToPlay()
    {
        gameOver.SetActive(true);
    }

    public void Continue()
    {
        newItem.SetActive(true);
    }
}

