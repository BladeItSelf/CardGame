﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject IPlayer;
    public GameObject IDeck;
    public GameObject IEnemy;
    private List<Card> AllCards;
    
    /// <summary>
    /// Функция создания галереи всех доступных карт
    /// </summary>
    private void LoadCardGallery()
    {
        AllCards.Add(new Card("Чемпион", "Несущая свет", 5, 4, "Sprites/Cards/Champ", new ManaCost(2, 2, 0) , new ManaCost (2,1,0)));
        AllCards.Add(new Card("Белый Дракон", "Дыхание Бога", 7, 2, "Sprites/Cards/WDrag", new ManaCost(4, 3, 0) , new ManaCost(3, 0, 0)));
        AllCards.Add(new Card("Имп", "Жар преисподней", 2, 3, "Sprites/Cards/Imp", new ManaCost(0, 1, 1) , new ManaCost(0, 0, 2)));
        AllCards.Add(new Card("Маг", "Жаждущий знаний", 1, 5, "Sprites/Cards/Mage", new ManaCost(1, 2, 1) , new ManaCost(0, 3, 0)));
    }

    // Start is called before the first frame update
    public void Awake()
    {
        AllCards = new List<Card>();
        LoadCardGallery();
    }
    

    public void Start()
    {
        Deck myDeck = IDeck.GetComponent<DeckManager>().GameDeck;
        Player myPlayer = IPlayer.GetComponent<Player>();
        myDeck.FormDeck(AllCards);
        myPlayer.GetHand(5,myDeck);
        IEnemy.GetComponent<Enemy>().SetEnemy(40, 5, "Sprites/Cards/Boss_Destroyer", "Разрушитель миров", "Воплощение ярости");

    }
}