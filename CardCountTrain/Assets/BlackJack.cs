using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

[System.Serializable]
public class Card
{
    public int cardVal; // Integer value of the cardSprite
    public Sprite cardSprite; // Sprite of the card

    public Card(int p, Sprite i)
    {
        cardVal = p;
        cardSprite = i;
    }
}

public static class IListExtensions{
    public static void Shuffle<T>(this IList<T> ts){
        var count = ts.Count;
        var last = count - 1;
        for ( var i = 0; i < last; ++i){
            var r = UnityEngine.Random.Range(i, count);
            var tmp = ts[i];
            ts[i] = ts[r];
            ts[r] = tmp;
        }
    }
}

public class BlackJack : MonoBehaviour
{
    public List<Card> cardList = new List<Card>();
    public int numCardsP1;
    public int numCardsD;
    public int numCardsDealer;
    public GameObject parentObject;
    public GameObject parentObjectDealer;
    public Image Dealt1;
    public Image Dealt2;
    public Image Dealt3;
    public Image Dealt4;
    public int card4Val;
    public Sprite card4Sprite;
    public int playerPoints;
    public int dealerPoints;
    public TextMeshProUGUI DpointsText;
    public TextMeshProUGUI PpointsText;
    public TextMeshProUGUI runText;
    public TextMeshProUGUI deckText;
    public TextMeshProUGUI trueText;
    public TMP_InputField betAmount;
    public TMP_InputField newMoney;
    public TMP_InputField numDecks;
    public TextMeshProUGUI moneyText;
    public int moneyBet;
    public float moneyToWin;
    public float money;
    public int betAccepted;
    public GameObject cardSpawner; // Reference to the prefab you want to instantiate
    public Vector3 spawnPosition; // Set the spawn position
    public GameObject StandButton;
    public GameObject HitButton;
    public GameObject SplitButton;
    public GameObject DoubleButton;
    public GameObject DealButton;
    public GameObject EndButton;
    public GameObject BetField;
    public GameObject newShoe;
    public GameObject editMoney;
    public int DHA;
    public int PHA;
    public int pAcePoints;
    public int dAcePoints;
    public int PBJ;
    public int DBJ;
    public int betweenRounds;
    public int splitMode;
    public int pAcePoints2;
    public int PHA2;
    public float moneyToWin2;
    public int playerPoints2;
    public int PBJ2;
    public int moneyBet2;
    public int inHand;
    public int numCardsH1;
    public int numCardsH2;
    public int cardsLeft;
    public float decksLeft;
    public int runCount;
    public float trueCount;
    public int trueOn;
    public int runOn;
    public float temp1;
    public GameObject hint1;
    public GameObject hint2;
    public int hintOn;
    public int togDer;
    public int decks;
    public GameObject der1;
    public GameObject der2;
    // public GameObject der3;
    // public GameObject der4;
    public GameObject hand1;
    public GameObject hand2;

    public Sprite s2;
    public Sprite h2;
    public Sprite c2;
    public Sprite d2;
    public Sprite s3;
    public Sprite h3;
    public Sprite c3;
    public Sprite d3;
    public Sprite s4;
    public Sprite h4;
    public Sprite c4;
    public Sprite d4;
    public Sprite s5;
    public Sprite h5;
    public Sprite c5;
    public Sprite d5;
    public Sprite s6;
    public Sprite h6;
    public Sprite c6;
    public Sprite d6;
    public Sprite s7;
    public Sprite h7;
    public Sprite c7;
    public Sprite d7;
    public Sprite s8;
    public Sprite h8;
    public Sprite c8;
    public Sprite d8;
    public Sprite s9;
    public Sprite h9;
    public Sprite c9;
    public Sprite d9;
    public Sprite s0;
    public Sprite h0;
    public Sprite c0;
    public Sprite d0;
    public Sprite sJ;
    public Sprite hJ;
    public Sprite cJ;
    public Sprite dJ;
    public Sprite sQ;
    public Sprite hQ;
    public Sprite cQ;
    public Sprite dQ;
    public Sprite sK;
    public Sprite hK;
    public Sprite cK;
    public Sprite dK;
    public Sprite sA;
    public Sprite hA;
    public Sprite cA;
    public Sprite dA;
    public Sprite back;

    public Card S2;
    public Card H2;
    public Card C2;
    public Card D2;
    public Card S3;
    public Card H3;
    public Card C3;
    public Card D3;
    public Card S4;
    public Card H4;
    public Card C4;
    public Card D4;
    public Card S5;
    public Card H5;
    public Card C5;
    public Card D5;
    public Card S6;
    public Card H6;
    public Card C6;
    public Card D6;
    public Card S7;
    public Card H7;
    public Card C7;
    public Card D7;
    public Card S8;
    public Card H8;
    public Card C8;
    public Card D8;
    public Card S9;
    public Card H9;
    public Card C9;
    public Card D9;
    public Card S0;
    public Card H0;
    public Card C0;
    public Card D0;
    public Card SJ;
    public Card HJ;
    public Card CJ;
    public Card DJ;
    public Card SQ;
    public Card HQ;
    public Card CQ;
    public Card DQ;
    public Card SK;
    public Card HK;
    public Card CK;
    public Card DK;
    public Card SA;
    public Card HA;
    public Card CA;
    public Card DA;
    // Start is called before the first frame update
    void Awake()
    {
        S2.cardVal = 2;
        S2.cardSprite = s2;
        H2.cardVal = 2;
        H2.cardSprite = h2;
        C2.cardVal = 2;
        C2.cardSprite = c2;
        D2.cardVal = 2;
        D2.cardSprite = d2;

        S3.cardVal = 3;
        S3.cardSprite = s3;
        H3.cardVal = 3;
        H3.cardSprite = h3;
        C3.cardVal = 3;
        C3.cardSprite = c3;
        D3.cardVal = 3;
        D3.cardSprite = d3;

        S4.cardVal = 4;
        S4.cardSprite = s4;
        H4.cardVal = 4;
        H4.cardSprite = h4;
        C4.cardVal = 4;
        C4.cardSprite = c4;
        D4.cardVal = 4;
        D4.cardSprite = d4;

        S5.cardVal = 5;
        S5.cardSprite = s5;
        H5.cardVal = 5;
        H5.cardSprite = h5;
        C5.cardVal = 5;
        C5.cardSprite = c5;
        D5.cardVal = 5;
        D5.cardSprite = d5;

        S6.cardVal = 6;
        S6.cardSprite = s6;
        H6.cardVal = 6;
        H6.cardSprite = h6;
        C6.cardVal = 6;
        C6.cardSprite = c6;
        D6.cardVal = 6;
        D6.cardSprite = d6;

        S7.cardVal = 7;
        S7.cardSprite = s7;
        H7.cardVal = 7;
        H7.cardSprite = h7;
        C7.cardVal = 7;
        C7.cardSprite = c7;
        D7.cardVal = 7;
        D7.cardSprite = d7;

        S8.cardVal = 8;
        S8.cardSprite = s8;
        H8.cardVal = 8;
        H8.cardSprite = h8;
        C8.cardVal = 8;
        C8.cardSprite = c8;
        D8.cardVal = 8;
        D8.cardSprite = d8;

        S9.cardVal = 9;
        S9.cardSprite = s9;
        H9.cardVal = 9;
        H9.cardSprite = h9;
        C9.cardVal = 9;
        C9.cardSprite = c9;
        D9.cardVal = 9;
        D9.cardSprite = d9;

        S0.cardVal = 10;
        S0.cardSprite = s0;
        H0.cardVal = 10;
        H0.cardSprite = h0;
        C0.cardVal = 10;
        C0.cardSprite = c0;
        D0.cardVal = 10;
        D0.cardSprite = d0;

        SJ.cardVal = 10;
        SJ.cardSprite = sJ;
        HJ.cardVal = 10;
        HJ.cardSprite = hJ;
        CJ.cardVal = 10;
        CJ.cardSprite = cJ;
        DJ.cardVal = 10;
        DJ.cardSprite = dJ;

        SQ.cardVal = 10;
        SQ.cardSprite = sQ;
        HQ.cardVal = 10;
        HQ.cardSprite = hQ;
        CQ.cardVal = 10;
        CQ.cardSprite = cQ;
        DQ.cardVal = 10;
        DQ.cardSprite = dQ;

        SK.cardVal = 10;
        SK.cardSprite = sK;
        HK.cardVal = 10;
        HK.cardSprite = hK;
        CK.cardVal = 10;
        CK.cardSprite = cK;
        DK.cardVal = 10;
        DK.cardSprite = dK;

        SA.cardVal = 1;
        SA.cardSprite = sA;
        HA.cardVal = 1;
        HA.cardSprite = hA;
        CA.cardVal = 1;
        CA.cardSprite = cA;
        DA.cardVal = 1;
        DA.cardSprite = dA;
    }
    void Start()
    {
        trueOn = 1;
        runOn = 1;
        betweenRounds = 1;
        money = 5000.00f;
        addCards();
        addCards();
        addCards();
        addCards();
        addCards();
        addCards();
        
        cardList.Shuffle();
        HitButton.SetActive(false);
        StandButton.SetActive(false);
        SplitButton.SetActive(false);
        DoubleButton.SetActive(false);
        EndButton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "$" + money.ToString("0.00");
        if(splitMode == 0){
            if(DHA == 1){
                dAcePoints = dealerPoints + 10;
                if(dAcePoints < 22){
                    DpointsText.text = dealerPoints.ToString() + " / " + dAcePoints.ToString();
                }
                else{
                    DpointsText.text = dealerPoints.ToString();
                }
            }
            else{
                DpointsText.text = dealerPoints.ToString();
            }
            if(PHA == 1){
                pAcePoints = playerPoints + 10;
                if(pAcePoints < 22){
                    PpointsText.text = playerPoints.ToString() + " / " + pAcePoints.ToString();
                }
                else{
                    PpointsText.text = playerPoints.ToString();
                }
                
            }
            else{
                PpointsText.text = playerPoints.ToString();
            }
        }
        else{
            if(DHA == 1){
                dAcePoints = dealerPoints + 10;
                if(dAcePoints < 22){
                    DpointsText.text = dealerPoints.ToString() + " / " + dAcePoints.ToString();
                }
                else{
                    DpointsText.text = dealerPoints.ToString();
                }
            }
            else{
                DpointsText.text = dealerPoints.ToString();
            }
            
            if(PHA == 1 && PHA2 == 1){
                pAcePoints = playerPoints + 10;
                pAcePoints2 = playerPoints2 + 10;
                if(pAcePoints < 22 && pAcePoints2 < 22){
                    PpointsText.text = playerPoints2.ToString() + " / " + pAcePoints2.ToString() + "  :  " + playerPoints.ToString() + " / " + pAcePoints.ToString();
                }
                else if(pAcePoints < 22 && pAcePoints2 > 22){
                    PpointsText.text = playerPoints2.ToString() + "  :  " + playerPoints.ToString() + " / " + pAcePoints.ToString();
                }
                else if(pAcePoints > 22 && pAcePoints2 < 22){
                    PpointsText.text = playerPoints2.ToString() + " / " + pAcePoints2.ToString() + "  :  " + playerPoints.ToString();
                }
                else{
                    PpointsText.text = playerPoints2.ToString() + "  :  " + playerPoints.ToString();
                }   
            }
            else if(PHA == 1 && PHA2 == 0){
                pAcePoints = playerPoints + 10;
                if(pAcePoints < 22){
                    PpointsText.text = playerPoints2.ToString() + "  :  " + playerPoints.ToString() + " / " + pAcePoints.ToString();
                }
                else{
                    PpointsText.text = playerPoints2.ToString() + "  :  " + playerPoints.ToString();
                }   
            }
            else if(PHA == 0 && PHA2 == 1){
                pAcePoints2 = playerPoints2 + 10;
                if(pAcePoints2 < 22){
                    PpointsText.text = playerPoints2.ToString() + " / " + pAcePoints2.ToString() + "  :  " + playerPoints.ToString();
                }
                else{
                    PpointsText.text = playerPoints2.ToString() + "  :  " + playerPoints.ToString();
                }   
            }
            else{
                PpointsText.text = playerPoints2.ToString() + "  :  " + playerPoints.ToString();
            }
        }
        cardsLeft = cardList.Count;
        temp1 = cardsLeft / 52f;
        temp1 = temp1 * 4f;
        //Debug.Log(temp1);
        temp1 = Mathf.Round(temp1);
        temp1 = temp1 / 4f;
        decksLeft = temp1;
        deckText.text = "Decks Left: " + decksLeft.ToString("0.00");
        temp1 = runCount / decksLeft;
        temp1 = temp1 * 4f;
        temp1 = Mathf.Round(temp1);
        temp1 = temp1 / 4f;
        trueCount = temp1;
        trueText.text = "True Count: " + trueCount.ToString("0.00");
        runText.text = "Run Count: " + runCount.ToString();
        if(cardList.Count <= 52 && betweenRounds == 1){
            if(decks == 2){
                cardList.Clear();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
            else if(decks == 3){
                cardList.Clear();
                addCards();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
            else if(decks == 4){
                cardList.Clear();
                addCards();
                addCards();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
            else if(decks == 5){
                cardList.Clear();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
            else if(decks == 6){
                cardList.Clear();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
            else if(decks == 7){
                cardList.Clear();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
            else if(decks == 8){
                cardList.Clear();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
        }
        if(inHand == 1){
            hand1.SetActive(true);
            hand2.SetActive(false);
        }
        else if(inHand == 2){
            hand2.SetActive(true);
            hand1.SetActive(false);
        }
        else{
            hand1.SetActive(false);
            hand2.SetActive(false);
        }
    }


    public void instatiate_player_card(Sprite cardImage)
    {
        spawnPosition = new Vector3(-100f + ((numCardsP1 + 1) * 20), -100f, 100f - (numCardsP1 + 1));
        GameObject spawnedObject = Instantiate(cardSpawner, parentObject.transform);
        //GameObject spawnedObject = Instantiate(cardSpawner, spawnPosition, Quaternion.identity);
        spawnedObject.transform.localPosition = spawnPosition;
        spawnedObject.transform.localRotation = Quaternion.identity;
        Image spriteRenderer = spawnedObject.GetComponent<Image>();
        if (spriteRenderer != null)
        {
            spriteRenderer.sprite = cardImage;
        }
        numCardsP1++;
    }

    public void new_shoe(){
        string text = numDecks.text;
        int tmp3;
        if (int.TryParse(text, out tmp3))
        {
             decks = tmp3;
             if(decks == 2){
                cardList.Clear();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
            else if(decks == 3){
                cardList.Clear();
                addCards();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
            else if(decks == 4){
                cardList.Clear();
                addCards();
                addCards();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
            else if(decks == 5){
                cardList.Clear();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
            else if(decks == 6){
                cardList.Clear();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
            else if(decks == 7){
                cardList.Clear();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
            else if(decks == 8){
                cardList.Clear();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0;
            }
            else{
                cardList.Clear();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                addCards();
                cardList.Shuffle();
                runCount = 0; 
            }
        }
    }

    public void instatiate_dealer_card(Sprite cardImage)
    {
        spawnPosition = new Vector3(-100f + ((numCardsD + 1) * 20), 100f, 100f - (numCardsD + 1));
        GameObject spawnedObject = Instantiate(cardSpawner, parentObjectDealer.transform);
        //GameObject spawnedObject = Instantiate(cardSpawner, spawnPosition, Quaternion.identity);
        spawnedObject.transform.localPosition = spawnPosition;
        spawnedObject.transform.localRotation = Quaternion.identity;
        Image spriteRenderer = spawnedObject.GetComponent<Image>();
        if (spriteRenderer != null)
        {
            spriteRenderer.sprite = cardImage;
        }
        numCardsD++;
    }

    public void toggle_hint(){
        if(hintOn == 1){
            hintOn = 0;
            hint1.SetActive(false);
            hint2.SetActive(false);
        }
        else if(hintOn == 0){
            hintOn = 1;
            hint1.SetActive(true);
            hint2.SetActive(true);
            
        }
    }

    public void toggle_true(){
        if(trueOn == 1){
            trueOn = 0;
            trueText.gameObject.SetActive(false);
        }
        else if(trueOn == 0){
            trueOn = 1;
            trueText.gameObject.SetActive(true);
        }
    }

    public void toggle_run(){
        if(runOn == 1){
            runOn = 0;
            runText.gameObject.SetActive(false);
        }
        else if(runOn == 0){
            runOn = 1;
            runText.gameObject.SetActive(true);
        }
    }

    public void toggle_der(){
        if(togDer == 0){
            togDer = 1;
            der1.SetActive(true);
        }
        else if(togDer == 1){
            togDer = 0;
            der1.SetActive(false);
        }
        // else if(togDer == 3){
        //     togDer = 4;
        //     der3.SetActive(false);
        //     der4.SetActive(true);
        // }
        // else if(togDer == 4){
        //     togDer = 0;
        //     der4.SetActive(false);
        // }
    }

    public void win_lose(){
        int pp = 0;
        int dp = 0;
        int pp2 = 0;
        HitButton.SetActive(false);
        StandButton.SetActive(false);
        BetField.SetActive(false);
        DoubleButton.SetActive(false);
        DealButton.SetActive(false);
        SplitButton.SetActive(false);
        if(splitMode == 0){
            pAcePoints = playerPoints + 10;
            dAcePoints = dealerPoints + 10;

            if(PHA == 0){
                pp = playerPoints;
            }
            else if(PHA == 1){
                if(pAcePoints < 22){
                    pp = pAcePoints;
                }
                else{
                    pp = playerPoints;
                }
            }

            if(DHA == 0){
                dp = dealerPoints;
            }
            else if(DHA == 1){
                if(dAcePoints < 22){
                    dp = dAcePoints;
                }
                else{
                    dp = dealerPoints;
                }
            }

            if(PBJ == 1 && DBJ == 0){
                money += moneyToWin;
            }
            else if(PBJ == 1 && DBJ == 1){
                money += moneyBet;
            }
            else if(PBJ == 0 && DBJ == 1){
                money = money;
            }
            else if(pp > 21){
                money = money;
            }
            else if(dp > 21){
                money += moneyToWin;
            }
            else if(pp > dp){
                money += moneyToWin;
            }
            else if(pp == dp){
                money += moneyBet;
            }
            else{
                money = money;
            }
        }
        else{
            pAcePoints = playerPoints + 10;
            dAcePoints = dealerPoints + 10;
            pAcePoints2 = playerPoints2 + 10;

            if(PHA == 0){
                pp = playerPoints;
            }
            else if(PHA == 1){
                if(pAcePoints < 22){
                    pp = pAcePoints;
                }
                else{
                    pp = playerPoints;
                }
            }

            if(PHA2 == 0){
                pp2 = playerPoints2;
            }
            else if(PHA2 == 1){
                if(pAcePoints2 < 22){
                    pp2 = pAcePoints2;
                }
                else{
                    pp2 = playerPoints2;
                }
            }

            if(DHA == 0){
                dp = dealerPoints;
            }
            else if(DHA == 1){
                if(dAcePoints < 22){
                    dp = dAcePoints;
                }
                else{
                    dp = dealerPoints;
                }
            }

            if(PBJ == 1 && DBJ == 0){
                money += moneyToWin;
            }
            else if(PBJ == 1 && DBJ == 1){
                money += moneyBet;
            }
            else if(PBJ == 0 && DBJ == 1){
                money = money;
            }
            else if(pp > 21){
                money = money;
            }
            else if(dp > 21){
                money += moneyToWin;
            }
            else if(pp > dp){
                money += moneyToWin;
            }
            else if(pp == dp){
                money += moneyBet;
            }
            else{
                money = money;
            }

            if(PBJ2 == 1 && DBJ == 0){
                money += moneyToWin2;
            }
            else if(PBJ2 == 1 && DBJ == 1){
                money += moneyBet2;
            }
            else if(PBJ2 == 0 && DBJ == 1){
                money = money;
            }
            else if(pp2 > 21){
                money = money;
            }
            else if(dp > 21){
                money += moneyToWin2;
            }
            else if(pp2 > dp){
                money += moneyToWin2;
            }
            else if(pp2 == dp){
                money += moneyBet2;
            }
            else{
                money = money;
            }
        }
        EndButton.SetActive(true);
    }
    public void dealer_call(){
        if(splitMode == 0){
            StartCoroutine(dealer_turn());
        }
        else{
            if(inHand != 2){
                if(PHA2 == 1){
                    pAcePoints2 = playerPoints2 + 10;
                    if(pAcePoints2 == 21){
                        StartCoroutine(dealer_turn());
                    }
                    else{
                        inHand = 2;
                        DoubleButton.SetActive(true);
                    }
                }
                else{
                    inHand = 2;
                    DoubleButton.SetActive(true);
                }
            }
            else if(inHand == 2){
                StartCoroutine(dealer_turn());
            }
        }
    }

    IEnumerator dealer_turn()
    {
        if(splitMode == 1){
            inHand = 0;
        }
        HitButton.SetActive(false);
        StandButton.SetActive(false);
        BetField.SetActive(false);
        DoubleButton.SetActive(false);
        DealButton.SetActive(false);
        SplitButton.SetActive(false);
        yield return new WaitForSeconds(0.75f);
        Dealt4.sprite = card4Sprite;
        if(card4Val == 1 || card4Val == 10){
            runCount -= 1;
        }
        else if(card4Val == 2 || card4Val == 3 || card4Val == 4 || card4Val == 5 || card4Val == 6){
            runCount += 1;
        }
        Dealt4.GetComponent<CardVal>().thisCardVal = card4Val;
        dealerPoints += card4Val;
        if(card4Val == 1){
            DHA = 1;
        }
        yield return new WaitForSeconds(0.75f);
        if(DHA == 0){
            while(dealerPoints < 17){
                Card hitCard = cardList[0];
                instatiate_dealer_card(hitCard.cardSprite);
                dealerPoints += hitCard.cardVal;
                if(hitCard.cardVal == 1){
                    DHA = 1;
                }
                if(hitCard.cardVal == 1 || hitCard.cardVal == 10){
                        runCount -= 1;
                }
                else if(hitCard.cardVal == 2 || hitCard.cardVal == 3 || hitCard.cardVal == 4 || hitCard.cardVal == 5 || hitCard.cardVal == 6){
                    runCount += 1;
                }
                cardList.RemoveAt(0);
                if(DHA == 1){
                    dAcePoints = dealerPoints + 10;
                    if(dAcePoints >= 17 && dAcePoints <= 21){
                        break;
                    }
                }
                yield return new WaitForSeconds(0.75f);
            }
        }
        else if(DHA == 1){
            dAcePoints = dealerPoints + 10;
            while(dealerPoints < 17 && (dAcePoints < 17 || dAcePoints > 21)){
                Card hitCard = cardList[0];
                instatiate_dealer_card(hitCard.cardSprite);
                dealerPoints += hitCard.cardVal;
                if(hitCard.cardVal == 1 || hitCard.cardVal == 10){
                        runCount -= 1;
                }
                else if(hitCard.cardVal == 2 || hitCard.cardVal == 3 || hitCard.cardVal == 4 || hitCard.cardVal == 5 || hitCard.cardVal == 6){
                    runCount += 1;
                }
                cardList.RemoveAt(0);
                yield return new WaitForSeconds(0.75f);
            }
        }
        win_lose();
    }

    public void instatiate_player1_card(Sprite cardImage)
    {
        spawnPosition = new Vector3(-100f + ((numCardsH1 + 2) * 20), -100f, 100f - (numCardsH1 + 2));
        GameObject spawnedObject = Instantiate(cardSpawner, parentObject.transform);
        //GameObject spawnedObject = Instantiate(cardSpawner, spawnPosition, Quaternion.identity);
        spawnedObject.transform.localPosition = spawnPosition;
        spawnedObject.transform.localRotation = Quaternion.identity;
        Image spriteRenderer = spawnedObject.GetComponent<Image>();
        if (spriteRenderer != null)
        {
            spriteRenderer.sprite = cardImage;
        }
        numCardsH1++;
    }

    public void instatiate_player2_card(Sprite cardImage)
    {
        spawnPosition = new Vector3(-180f - ((numCardsH2 + 2) * 20), -100f, 100f - (numCardsH2 + 2));
        GameObject spawnedObject = Instantiate(cardSpawner, parentObject.transform);
        //GameObject spawnedObject = Instantiate(cardSpawner, spawnPosition, Quaternion.identity);
        spawnedObject.transform.localPosition = spawnPosition;
        spawnedObject.transform.localRotation = Quaternion.identity;
        Image spriteRenderer = spawnedObject.GetComponent<Image>();
        if (spriteRenderer != null)
        {
            spriteRenderer.sprite = cardImage;
        }
        numCardsH2++;
    }

    public void hit()
    {
        if(splitMode == 0){
            DoubleButton.SetActive(false);
            SplitButton.SetActive(false);
            Card hitCard = cardList[0];
            instatiate_player_card(hitCard.cardSprite);
            playerPoints += hitCard.cardVal;
            if(hitCard.cardVal == 1){
                PHA = 1;
            }
            if(hitCard.cardVal == 1 || hitCard.cardVal == 10){
                runCount -= 1;
            }
            else if(hitCard.cardVal == 2 || hitCard.cardVal == 3 || hitCard.cardVal == 4 || hitCard.cardVal == 5 || hitCard.cardVal == 6){
                runCount += 1;
            }
            cardList.RemoveAt(0);
            if(playerPoints >= 21){
                StartCoroutine(dealer_turn());
            }
            if(PHA == 1){
                pAcePoints = playerPoints + 10;
                if(pAcePoints == 21){
                    StartCoroutine(dealer_turn());
                }
            }
        }
        else{
            if(inHand == 1){
                DoubleButton.SetActive(false);
                SplitButton.SetActive(false);
                Card hitCard = cardList[0];
                instatiate_player1_card(hitCard.cardSprite);
                playerPoints += hitCard.cardVal;
                if(hitCard.cardVal == 1){
                    PHA = 1;
                }
                if(hitCard.cardVal == 1 || hitCard.cardVal == 10){
                    runCount -= 1;
                }
                else if(hitCard.cardVal == 2 || hitCard.cardVal == 3 || hitCard.cardVal == 4 || hitCard.cardVal == 5 || hitCard.cardVal == 6){
                    runCount += 1;
                }
                cardList.RemoveAt(0);
                if(playerPoints >= 21){
                    if(PHA2 == 1){
                        pAcePoints2 = playerPoints2 + 10;
                        if(pAcePoints2 == 21){
                            StartCoroutine(dealer_turn());
                        }
                        else{
                            inHand = 2;
                            DoubleButton.SetActive(true);
                        }
                    }
                    else{
                        inHand = 2;
                        DoubleButton.SetActive(true);
                    }
                }
                if(PHA == 1){
                    pAcePoints = playerPoints + 10;
                    if(pAcePoints == 21){
                        if(PHA2 == 1){
                            pAcePoints2 = playerPoints2 + 10;
                            if(pAcePoints2 == 21){
                                StartCoroutine(dealer_turn());
                            }
                        }
                        else{
                            inHand = 2;
                            DoubleButton.SetActive(true);
                        }
                    }
                }
            }
            else if(inHand == 2){
                DoubleButton.SetActive(false);
                SplitButton.SetActive(false);
                Card hitCard = cardList[0];
                instatiate_player2_card(hitCard.cardSprite);
                playerPoints2 += hitCard.cardVal;
                if(hitCard.cardVal == 1){
                    PHA2 = 1;
                }
                if(hitCard.cardVal == 1 || hitCard.cardVal == 10){
                    runCount -= 1;
                }
                else if(hitCard.cardVal == 2 || hitCard.cardVal == 3 || hitCard.cardVal == 4 || hitCard.cardVal == 5 || hitCard.cardVal == 6){
                    runCount += 1;
                }
                cardList.RemoveAt(0);
                if(playerPoints2 >= 21){
                    StartCoroutine(dealer_turn());
                }
                if(PHA == 1){
                    pAcePoints2 = playerPoints2 + 10;
                    if(pAcePoints2 == 21){
                        StartCoroutine(dealer_turn());
                    }
                }
            }
        }
    }

    public void double_down()
    {
        if(splitMode == 0){
            money -= moneyBet;
            moneyToWin = moneyBet * 4;
            moneyBet += moneyBet;
            Card hitCard = cardList[0];
            instatiate_player_card(hitCard.cardSprite);
            playerPoints += hitCard.cardVal;
            if(hitCard.cardVal == 1){
                PHA = 1;
                pAcePoints = playerPoints + 10;
            }
            if(hitCard.cardVal == 1 || hitCard.cardVal == 10){
                runCount -= 1;
            }
            else if(hitCard.cardVal == 2 || hitCard.cardVal == 3 || hitCard.cardVal == 4 || hitCard.cardVal == 5 || hitCard.cardVal == 6){
                runCount += 1;
            }
            cardList.RemoveAt(0);
            StartCoroutine(dealer_turn());
        }
        else{
            if(inHand == 1){
                money -= moneyBet;
                moneyToWin = moneyBet * 4;
                moneyBet += moneyBet;
                Card hitCard = cardList[0];
                instatiate_player1_card(hitCard.cardSprite);
                playerPoints += hitCard.cardVal;
                if(hitCard.cardVal == 1){
                    PHA = 1;
                    pAcePoints = playerPoints + 10;
                }
                if(hitCard.cardVal == 1 || hitCard.cardVal == 10){
                    runCount -= 1;
                }
                else if(hitCard.cardVal == 2 || hitCard.cardVal == 3 || hitCard.cardVal == 4 || hitCard.cardVal == 5 || hitCard.cardVal == 6){
                    runCount += 1;
                }
                cardList.RemoveAt(0);
                if(PHA2 == 1){
                    pAcePoints2 = playerPoints2 + 10;
                    if(pAcePoints2 == 21){
                        StartCoroutine(dealer_turn());
                    }
                    else{
                        inHand = 2;
                    }
                }
                else{
                    inHand = 2;
                }
            }
            else if(inHand == 2){
                money -= moneyBet2;
                moneyToWin2 = moneyBet2 * 4;
                moneyBet2 += moneyBet2;
                Card hitCard = cardList[0];
                instatiate_player2_card(hitCard.cardSprite);
                playerPoints2 += hitCard.cardVal;
                if(hitCard.cardVal == 1){
                    PHA2 = 1;
                    pAcePoints2 = playerPoints2 + 10;
                }
                if(hitCard.cardVal == 1 || hitCard.cardVal == 10){
                    runCount -= 1;
                }
                else if(hitCard.cardVal == 2 || hitCard.cardVal == 3 || hitCard.cardVal == 4 || hitCard.cardVal == 5 || hitCard.cardVal == 6){
                    runCount += 1;
                }
                cardList.RemoveAt(0);
                StartCoroutine(dealer_turn());
            }
        }
    }
    public void split_call(){
        StartCoroutine(split_cards());
    }
    IEnumerator split_cards(){
        splitMode = 1;
        SplitButton.SetActive(false);
        DoubleButton.SetActive(false);
        HitButton.SetActive(false);
        StandButton.SetActive(false);
        money -= moneyBet;
        moneyBet2 = moneyBet;
        moneyToWin2 = moneyBet * 2;
        inHand = 1;
        playerPoints = playerPoints / 2;
        playerPoints2 = playerPoints;
        if(PHA == 1){
            PHA2 = 1;
        }
        Card hitCard = cardList[0];
        yield return new WaitForSeconds(0.75f);
        spawnPosition = new Vector3(-80f, -100f, 99f);
        GameObject spawnedObject = Instantiate(cardSpawner, parentObject.transform);
        //GameObject spawnedObject = Instantiate(cardSpawner, spawnPosition, Quaternion.identity);
        spawnedObject.transform.localPosition = spawnPosition;
        spawnedObject.transform.localRotation = Quaternion.identity;
        Image spriteRenderer = spawnedObject.GetComponent<Image>();
        if (spriteRenderer != null)
        {
            spriteRenderer.sprite = hitCard.cardSprite;
        }
        numCardsP1++;
        playerPoints += hitCard.cardVal;
        if(hitCard.cardVal == 1){
            PHA = 1;
            pAcePoints = playerPoints + 10;
            if(pAcePoints == 21){
                //PBJ = 1;
                //moneyToWin = moneyBet * 2.5f;
                inHand = 2;
            }
        }
        if(PHA == 1){
            if(hitCard.cardVal == 10){
                pAcePoints = playerPoints + 10;
                if(pAcePoints == 21){
                    // PBJ = 1;
                    // moneyToWin = moneyBet * 2.5f;
                    inHand = 2;
                }
            }
        }
        if(hitCard.cardVal == 1 || hitCard.cardVal == 10){
                runCount -= 1;
        }
        else if(hitCard.cardVal == 2 || hitCard.cardVal == 3 || hitCard.cardVal == 4 || hitCard.cardVal == 5 || hitCard.cardVal == 6){
            runCount += 1;
        }
        cardList.RemoveAt(0);

        hitCard = cardList[0];
        yield return new WaitForSeconds(0.75f);
        spawnPosition = new Vector3(-200f, -100f, 99f);
        spawnedObject = Instantiate(cardSpawner, parentObject.transform);
        //GameObject spawnedObject = Instantiate(cardSpawner, spawnPosition, Quaternion.identity);
        spawnedObject.transform.localPosition = spawnPosition;
        spawnedObject.transform.localRotation = Quaternion.identity;
        spriteRenderer = spawnedObject.GetComponent<Image>();
        if (spriteRenderer != null)
        {
            spriteRenderer.sprite = hitCard.cardSprite;
        }
        numCardsP1++;
        playerPoints2 += hitCard.cardVal;
        DoubleButton.SetActive(true);
        HitButton.SetActive(true);
        StandButton.SetActive(true);
        if(hitCard.cardVal == 1 || hitCard.cardVal == 10){
                runCount -= 1;
        }
        else if(hitCard.cardVal == 2 || hitCard.cardVal == 3 || hitCard.cardVal == 4 || hitCard.cardVal == 5 || hitCard.cardVal == 6){
            runCount += 1;
        }
        cardList.RemoveAt(0);
        if(hitCard.cardVal == 1){
            PHA2 = 1;
            pAcePoints2 = playerPoints2 + 10;
            if(pAcePoints2 == 21){
                // PBJ2 = 1;
                // moneyToWin2 = moneyBet2 * 2.5f;
                if(inHand == 2){
                    StartCoroutine(dealer_turn());
                }
                
            }
        }

        if(PHA2 == 1){
            if(hitCard.cardVal == 10){
                pAcePoints2 = playerPoints2 + 10;
                if(pAcePoints2 == 21){
                    // PBJ2 = 1;
                    // moneyToWin2 = moneyBet2 * 2.5f;
                    if(inHand == 2){
                        StartCoroutine(dealer_turn());
                    }
                    
                }
            }
        }
    }

    public void change_money(){
        string text = newMoney.text;
        int tmp2;
        if (int.TryParse(text, out tmp2))
        {
            money = tmp2;
        }
    }

    public void bet_call(){
        StartCoroutine(bet());
    }

    IEnumerator bet()
    {
        betweenRounds = 0;
        string text = betAmount.text;
        if (int.TryParse(text, out moneyBet))
        {
            betAccepted = 1;
        }
        else
        {
            betAccepted = 0;
        }

        if(betAccepted == 1){
            money -= moneyBet;
            moneyToWin = moneyBet * 2;
            Card dealtCard = cardList[0];
            Dealt1.sprite = dealtCard.cardSprite;
            Dealt1.GetComponent<CardVal>().thisCardVal = dealtCard.cardVal;
            playerPoints += dealtCard.cardVal;
            if(dealtCard.cardVal == 1){
                PHA = 1;
            }
            if(dealtCard.cardVal == 1 || dealtCard.cardVal == 10){
                runCount -= 1;
            }
            else if(dealtCard.cardVal == 2 || dealtCard.cardVal == 3 || dealtCard.cardVal == 4 || dealtCard.cardVal == 5 || dealtCard.cardVal == 6){
                runCount += 1;
            }
            cardList.RemoveAt(0);

            yield return new WaitForSeconds(0.75f);

            dealtCard = cardList[0];
            Dealt2.sprite = dealtCard.cardSprite;
            Dealt2.GetComponent<CardVal>().thisCardVal = dealtCard.cardVal;
            dealerPoints += dealtCard.cardVal;
            cardList.RemoveAt(0);
            if(dealtCard.cardVal == 1){
                DHA = 1;
            }
            if(dealtCard.cardVal == 1 || dealtCard.cardVal == 10){
                runCount -= 1;
            }
            else if(dealtCard.cardVal == 2 || dealtCard.cardVal == 3 || dealtCard.cardVal == 4 || dealtCard.cardVal == 5 || dealtCard.cardVal == 6){
                runCount += 1;
            }

            yield return new WaitForSeconds(0.75f);

            newShoe.SetActive(false);
            editMoney.SetActive(false);
            newMoney.gameObject.SetActive(false);
            numDecks.gameObject.SetActive(false);
            HitButton.SetActive(true);
            StandButton.SetActive(true);
            BetField.SetActive(false);
            DoubleButton.SetActive(true);
            DealButton.SetActive(false);

            dealtCard = cardList[0];
            Dealt3.sprite = dealtCard.cardSprite;
            Dealt3.GetComponent<CardVal>().thisCardVal = dealtCard.cardVal;
            playerPoints += dealtCard.cardVal;
            if(dealtCard.cardVal == 1){
                PHA = 1;
            }
            if(dealtCard.cardVal == 1 || dealtCard.cardVal == 10){
                runCount -= 1;
            }
            else if(dealtCard.cardVal == 2 || dealtCard.cardVal == 3 || dealtCard.cardVal == 4 || dealtCard.cardVal == 5 || dealtCard.cardVal == 6){
                runCount += 1;
            }
            cardList.RemoveAt(0);

            dealtCard = cardList[0];
            card4Val = dealtCard.cardVal;
            card4Sprite = dealtCard.cardSprite;
            cardList.RemoveAt(0);

            if(PHA == 1){
                pAcePoints = playerPoints + 10;
            }
            if(pAcePoints == 21){
                moneyToWin = moneyBet * 2.5f;
                PBJ = 1;
                if(DHA == 1){
                    if(card4Val == 10){
                        DBJ = 1;
                    }
                }
                else if(dealerPoints == 10){
                    if(card4Val == 1){
                        DBJ = 1;
                    }
                }
                StartCoroutine(dealer_turn());
                yield break;
            }
            if(DHA == 1){
                if(card4Val == 10){
                    DBJ = 1;
                    Dealt4.sprite = card4Sprite;
                    if(card4Val == 1 || card4Val == 10){
                        runCount -= 1;
                    }
                    else if(card4Val == 2 || card4Val == 3 || card4Val == 4 || card4Val == 5 || card4Val == 6){
                        runCount += 1;
                    }
                    Dealt3.GetComponent<CardVal>().thisCardVal = card4Val;
                    dealerPoints += 10;
                    dAcePoints = dealerPoints + 10;
                    yield return new WaitForSeconds(0.75f);
                    win_lose();
                    yield break;
                }
            }
            else if(dealerPoints == 10){
                if(card4Val == 1){
                    DBJ = 1;
                    Dealt4.sprite = card4Sprite;
                    if(card4Val == 1 || card4Val == 10){
                        runCount -= 1;
                    }
                    else if(card4Val == 2 || card4Val == 3 || card4Val == 4 || card4Val == 5 || card4Val == 6){
                        runCount += 1;
                    }
                    Dealt3.GetComponent<CardVal>().thisCardVal = card4Val;
                    dealerPoints += 1;
                    DHA = 1;
                    dAcePoints = dealerPoints + 10;
                    yield return new WaitForSeconds(0.75f);
                    win_lose();
                    yield break;
                }
            }
            if(Dealt1.GetComponent<CardVal>().thisCardVal == Dealt3.GetComponent<CardVal>().thisCardVal){
                SplitButton.SetActive(true);
            }
        }
    }

    public void end_round(){
        Dealt1.sprite = back;
        Dealt2.sprite = back;
        Dealt3.sprite = back;
        Dealt4.sprite = back;
        Dealt1.GetComponent<CardVal>().thisCardVal = 0;
        Dealt2.GetComponent<CardVal>().thisCardVal = 0;
        Dealt3.GetComponent<CardVal>().thisCardVal = 0;
        Dealt4.GetComponent<CardVal>().thisCardVal = 0;
        numCardsD = 0;
        numCardsP1 = 0;
        dealerPoints = 0;
        playerPoints = 0;
        DHA = 0;
        PHA = 0;
        dAcePoints = 0;
        pAcePoints = 0;
        PBJ = 0;
        DBJ = 0;
        inHand = 0;
        PBJ2 = 0;
        playerPoints2 = 0;
        numCardsH1 = 0;
        numCardsH2 = 0;
        pAcePoints2 = 0;
        PHA2 = 0;
        splitMode = 0;
        for (int i = 2; i < parentObject.transform.childCount; i++)
        {
            Transform child = parentObject.transform.GetChild(i);
            Destroy(child.gameObject);
        }
        for (int i = 2; i < parentObjectDealer.transform.childCount; i++)
        {
            Transform child = parentObjectDealer.transform.GetChild(i);
            Destroy(child.gameObject);
        }
        betweenRounds = 1;
        HitButton.SetActive(false);
        StandButton.SetActive(false);
        SplitButton.SetActive(false);
        DoubleButton.SetActive(false);
        EndButton.SetActive(false);
        DealButton.SetActive(true);
        BetField.SetActive(true);
        newShoe.SetActive(true);
        editMoney.SetActive(true);
        newMoney.gameObject.SetActive(true);
        numDecks.gameObject.SetActive(true);
    }

    public void addCards()
    {
        //cardList = new List<Card> {S2, H2, C2, D2, S3, H3, C3, D3, S4, H4, C4, D4, S5, H5, C5, D5, S6, H6, C6, D6, S7, H7, C7, D7, S8, H8, C8, D8, S9, H9, C9, D9, S0, H0, C0, D0, SJ, HJ, CJ, DJ, SQ, HQ, CQ, DQ, SK, HK, CK, DK, SA, HA, CA, DA, S2, H2, C2, D2, S3, H3, C3, D3, S4, H4, C4, D4, S5, H5, C5, D5, S6, H6, C6, D6, S7, H7, C7, D7, S8, H8, C8, D8, S9, H9, C9, D9, S0, H0, C0, D0, SJ, HJ, CJ, DJ, SQ, HQ, CQ, DQ, SK, HK, CK, DK, SA, HA, CA, DA, S2, H2, C2, D2, S3, H3, C3, D3, S4, H4, C4, D4, S5, H5, C5, D5, S6, H6, C6, D6, S7, H7, C7, D7, S8, H8, C8, D8, S9, H9, C9, D9, S0, H0, C0, D0, SJ, HJ, CJ, DJ, SQ, HQ, CQ, DQ, SK, HK, CK, DK, SA, HA, CA, DA, S2, H2, C2, D2, S3, H3, C3, D3, S4, H4, C4, D4, S5, H5, C5, D5, S6, H6, C6, D6, S7, H7, C7, D7, S8, H8, C8, D8, S9, H9, C9, D9, S0, H0, C0, D0, SJ, HJ, CJ, DJ, SQ, HQ, CQ, DQ, SK, HK, CK, DK, SA, HA, CA, DA, S2, H2, C2, D2, S3, H3, C3, D3, S4, H4, C4, D4, S5, H5, C5, D5, S6, H6, C6, D6, S7, H7, C7, D7, S8, H8, C8, D8, S9, H9, C9, D9, S0, H0, C0, D0, SJ, HJ, CJ, DJ, SQ, HQ, CQ, DQ, SK, HK, CK, DK, SA, HA, CA, DA, S2, H2, C2, D2, S3, H3, C3, D3, S4, H4, C4, D4, S5, H5, C5, D5, S6, H6, C6, D6, S7, H7, C7, D7, S8, H8, C8, D8, S9, H9, C9, D9, S0, H0, C0, D0, SJ, HJ, CJ, DJ, SQ, HQ, CQ, DQ, SK, HK, CK, DK, SA, HA, CA, DA};
        cardList.Add(S2);
        cardList.Add(H2);
        cardList.Add(C2);
        cardList.Add(D2);
        cardList.Add(S3);
        cardList.Add(H3);
        cardList.Add(C3);
        cardList.Add(D3);
        cardList.Add(S4);
        cardList.Add(H4);
        cardList.Add(C4);
        cardList.Add(D4);
        cardList.Add(S5);
        cardList.Add(H5);
        cardList.Add(C5);
        cardList.Add(D5);
        cardList.Add(S6);
        cardList.Add(H6);
        cardList.Add(C6);
        cardList.Add(D6);
        cardList.Add(S7);
        cardList.Add(H7);
        cardList.Add(C7);
        cardList.Add(D7);
        cardList.Add(S8);
        cardList.Add(H8);
        cardList.Add(C8);
        cardList.Add(D8);
        cardList.Add(S9);
        cardList.Add(H9);
        cardList.Add(C9);
        cardList.Add(D9);
        cardList.Add(S0);
        cardList.Add(H0);
        cardList.Add(C0);
        cardList.Add(D0);
        cardList.Add(SJ);
        cardList.Add(HJ);
        cardList.Add(CJ);
        cardList.Add(DJ);
        cardList.Add(SQ);
        cardList.Add(HQ);
        cardList.Add(CQ);
        cardList.Add(DQ);
        cardList.Add(SK);
        cardList.Add(HK);
        cardList.Add(CK);
        cardList.Add(DK);
        cardList.Add(SA);
        cardList.Add(HA);
        cardList.Add(CA);
        cardList.Add(DA);
    }
}
