using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Card
{
    public int points;
    public Sprite image;
    public bool cardToPlay;
    public bool cardPlayed;
    public Card(int p, Sprite i, bool ct, bool cp)
    {
        points = p;
        image = i;
        cardToPlay = ct;
        cardPlayed = cp;
    }
}

public static class IListExtensions {
    // <summary>
    // Shuffles the element order of the specified list.
    // </summary>
    public static void Shuffle<T>(this IList<T> ts) {
        var count = ts.Count;
        var last = count - 1;
        for (var i = 0; i < last; ++i) {
            var r = UnityEngine.Random.Range(i, count);
            var tmp = ts[i];
            ts[i] = ts[r];
            ts[r] = tmp;
        }
    }
}

public class CardMaker : MonoBehaviour
{
    public string pointsText;
    public List<Card> p1Deck = new List<Card>();
    public List<Card> p1Hand = new List<Card>();
    public List<Card> p1Discard = new List<Card>();
    public List<Card> cardsDeal = new List<Card>();


    public clickP1H1 cp1h1;
    public clickP1H2 cp1h2;
    public clickP1H3 cp1h3;
    public clickP1H4 cp1h4;
    public clickP1H5 cp1h5;
    public clickP1H6 cp1h6;
    public clickP1H7 cp1h7;



    public Sprite squirelImage;
    public Sprite stegImage;
    public Sprite stingrayImage;
    public Sprite stonefishImage;
    public Sprite tigerImage;
    public Sprite trexImage;
    public Sprite triImage;
    public Sprite turtleImage;
    public Sprite vultureImage;
    public Sprite walrusImage;
    public Sprite wevilImage;
    public Sprite wolfImage;
    public Sprite yakImage;
    public Sprite yetiImage;
    public Sprite zebraImage;
    public Sprite nileCrocImage;
    public Sprite octopusImage;
    public Sprite orcaImage;
    public Sprite ostrichImage;
    public Sprite owlImage;
    public Sprite pandaImage;
    public Sprite parrotImage;
    public Sprite penguinImage;
    public Sprite pigImage;
    public Sprite pikaImage;
    public Sprite polarBearImage;
    public Sprite puffinImage;
    public Sprite rabbitImage;
    public Sprite racoonImage;
    public Sprite raptorImage;
    public Sprite ratImage;
    public Sprite rattleSnakeImage;
    public Sprite rhinoImage;
    public Sprite robinImage;
    public Sprite saberTigerImage;
    public Sprite salamanderImage;
    public Sprite saltCrocImage;
    public Sprite scorpionImage;
    public Sprite seahorseImage;
    public Sprite sealImage;
    public Sprite sheepImage;
    public Sprite slothImage;
    public Sprite snowLepImage;
    public Sprite spermWhaleImage;
    public Sprite spiderImage;
    public Sprite GWSharkImage;
    public Sprite hawkImage;
    public Sprite HHSharkImage;
    public Sprite hippoImage;
    public Sprite iguanadonImage;
    public Sprite jagImage;
    public Sprite jellyfishImage;
    public Sprite kangarooImage;
    public Sprite kingCobraImage;
    public Sprite koalaImage;
    public Sprite komoDragonImage;
    public Sprite krakenImage;
    public Sprite leopardImage;
    public Sprite leviathonImage;
    public Sprite lionImage;
    public Sprite lobsterImage;
    public Sprite mamothImage;
    public Sprite marlinImage;
    public Sprite megaladonImage;
    public Sprite mooseImage;
    public Sprite mosasaurImage;
    public Sprite mtGoatImage;
    public Sprite mtLionImage;
    public Sprite newtImage;
    public Sprite alligatorImage;
    public Sprite alpChoughImage;
    public Sprite anacondaImage;
    public Sprite ankylImage;
    public Sprite antelopeImage;
    public Sprite batImage;
    public Sprite beeImage;
    public Sprite behemothImage;
    public Sprite bigfootImage;
    public Sprite bigsquidImage;
    public Sprite bisonImage;
    public Sprite bluewhaleImage;
    public Sprite bobcatImage;
    public Sprite brachImage;
    public Sprite bulletantImage;
    public Sprite butterflyImage;
    public Sprite camelImage;
    public Sprite catfishImage;
    public Sprite cameleonImage;
    public Sprite cheetahImage;
    public Sprite chickenImage;
    public Sprite chimpImage;
    public Sprite clownfishImage;
    public Sprite cowImage;
    public Sprite crabImage;
    public Sprite cricketImage;
    public Sprite dartFrogImage;
    public Sprite dinosouchieousImage;
    public Sprite dogImage;
    public Sprite dolphinImage;
    public Sprite dragonImage;
    public Sprite dragonFlyImage;
    public Sprite duckImage;
    public Sprite dungBeetleImage;
    public Sprite eagleImage;
    public Sprite elephantImage;
    public Sprite falconImage;
    public Sprite fenFoxImage;
    public Sprite flamingoImage;
    public Sprite flyImage;
    public Sprite frogImage;
    public Sprite giraffeImage;
    public Sprite goatImage;
    public Sprite goldfishImage;
    public Sprite gooseImage;
    public Sprite gorillaImage;
    public Sprite grizzlyImage;

    public Card alligator;
    public Card alpChough;
    public Card anaconda;
    public Card ankyl;
    public Card antelope;
    public Card bat;
    public Card bee;
    public Card behemoth;
    public Card bigfoot;
    public Card bigsquid;
    public Card bison;
    public Card bluewhale;
    public Card bobcat;
    public Card brach;
    public Card bulletant;
    public Card butterfly;
    public Card camel;
    public Card catfish;
    public Card cameleon;
    public Card cheetah;
    public Card chicken;
    public Card chimp;
    public Card clownfish;
    public Card cow;
    public Card crab;
    public Card cricket;
    public Card dartFrog;
    public Card dinosouchieous;
    public Card dog;
    public Card dolphin;
    public Card dragon;
    public Card dragonFly;
    public Card duck;
    public Card dungBeetle;
    public Card eagle;
    public Card elephant;
    public Card falcon;
    public Card fenFox;
    public Card flamingo;
    public Card fly;
    public Card frog;
    public Card giraffe;
    public Card goat;
    public Card goldfish;
    public Card goose;
    public Card gorilla;
    public Card grizzly;
    public Card GWShark;
    public Card hawk;
    public Card HHShark;
    public Card hippo;
    public Card iguanadon;
    public Card jag;
    public Card jellyfish;
    public Card kangaroo;
    public Card kingCobra;
    public Card koala;
    public Card komoDragon;
    public Card kraken;
    public Card leopard;
    public Card leviathon;
    public Card lion;
    public Card lobster;
    public Card mamoth;
    public Card marlin;
    public Card megaladon;
    public Card moose;
    public Card mosasaur;
    public Card mtGoat;
    public Card mtLion;
    public Card newt;
    public Card nileCroc;
    public Card octopus;
    public Card orca;
    public Card ostrich;
    public Card owl;
    public Card panda;
    public Card parrot;
    public Card penguin;
    public Card pig;
    public Card pika;
    public Card polarBear;
    public Card puffin;
    public Card rabbit;
    public Card racoon;
    public Card raptor;
    public Card rat;
    public Card rattleSnake;
    public Card rhino;
    public Card robin;
    public Card saberTiger;
    public Card salamander;
    public Card saltCroc;
    public Card scorpion;
    public Card seahorse;
    public Card seal;
    public Card sheep;
    public Card sloth;
    public Card snowLep;
    public Card spermWhale;
    public Card spider;
    public Card squirel;
    public Card steg;
    public Card stingray;
    public Card stonefish;
    public Card tiger;
    public Card trex;
    public Card tri;
    public Card turtle;
    public Card vulture;
    public Card walrus;
    public Card wevil;
    public Card wolf;
    public Card yak;
    public Card yeti;
    public Card zebra;

    public List<Card> allCards = new List<Card>();
    
    public int players;
    public int allCardsLength;
    public int cardsForP1;
    public int countCards;
    public int player1Points;
    public int disLength;
    public int handLength;
    // Start is called before the first frame update
    void Awake()
    {
        pointsText = "Player1 Points:";
        players = 2;

        alligator.points = 10;
        alligator.image = alligatorImage;

        alpChough.points = 2;
        alpChough.image = alpChoughImage;
        
        anaconda.points = 7;
        anaconda.image = anacondaImage;
        
        ankyl.points = 6;
        ankyl.image = ankylImage;
        
        antelope.points = 2;
        antelope.image = antelopeImage;
        
        bat.points = 4;
        bat.image = batImage;
        
        bee.points = 4;
        bee.image = beeImage;
        
        behemoth.points = 55;
        behemoth.image = behemothImage;
        
        bigfoot.points = 30;
        bigfoot.image = bigfootImage;
        
        bigsquid.points = 9;
        bigsquid.image = bigsquidImage;
        
        bison.points = 6;
        bison.image = bisonImage;
        
        bluewhale.points = 7;
        bluewhale.image = bluewhaleImage;
        
        bobcat.points = 4;
        bobcat.image = bobcatImage;
        
        brach.points = 6;
        brach.image = brachImage;
       
        bulletant.points = 6;
        bulletant.image = bulletantImage;
        
        butterfly.points = 1;
        butterfly.image = butterflyImage;
        
        camel.points = 4;
        camel.image = camelImage;
        
        catfish.points = 4;
        catfish.image = catfishImage;
        
        cameleon.points = 3;
        cameleon.image = cameleonImage;
        
        cheetah.points = 6;
        cheetah.image = cheetahImage;
        
        chicken.points = 2;
        chicken.image = chickenImage;
        
        chimp.points = 5;
        chimp.image = chimpImage;
        
        clownfish.points = 2;
        clownfish.image = clownfishImage;
        
        cow.points = 4;
        cow.image = cowImage;
        
        crab.points = 3;
        crab.image = crabImage;
        
        cricket.points = 2;
        cricket.image = cricketImage;
        
        dartFrog.points = 6;
        dartFrog.image = dartFrogImage;
        
        dinosouchieous.points = 13;
        dinosouchieous.image = dinosouchieousImage;
        
        dog.points = 4;
        dog.image = dogImage;
        
        dolphin.points = 5;
        dolphin.image = dolphinImage;
        
        dragon.points = 65;
        dragon.image = dragonImage;
        ;
        dragonFly.points = 2;
        dragonFly.image = dragonFlyImage;
        
        duck.points = 2;
        duck.image = duckImage;
       
        dungBeetle.points = 2;
        dungBeetle.image = dungBeetleImage;
        
        eagle.points = 6;
        eagle.image = eagleImage;
        
        elephant.points = 8;
        elephant.image = elephantImage;
        ;
        falcon.points = 4;
        falcon.image = falconImage;
        
        fenFox.points = 2;
        fenFox.image = fenFoxImage;
        
        flamingo.points = 2;
        flamingo.image = flamingoImage;
        
        fly.points = 1;
        fly.image = flyImage;
        
        frog.points = 1;
        frog.image = frogImage;
        
        giraffe.points = 5;
        giraffe.image = giraffeImage;
        
        goat.points = 3;
        goat.image = goatImage;
        
        goldfish.points = 1;
        goldfish.image = goldfishImage;
       
        goose.points = 3;
        goose.image = gooseImage;
        
        gorilla.points = 7;
        gorilla.image = gorillaImage;
        
        grizzly.points = 10;
        grizzly.image = grizzlyImage;
        
        GWShark.points = 10;
        GWShark.image = GWSharkImage;
        
        hawk.points = 5;
        hawk.image = hawkImage;
        
        HHShark.points = 6;
        HHShark.image = HHSharkImage;
        
        hippo.points = 10;
        hippo.image = hippoImage;
        iguanadon.points = 5;
        iguanadon.image = iguanadonImage;
        jag.points = 10;
        jag.image = jagImage;
        jellyfish.points = 6;
        jellyfish.image = jellyfishImage;
        kangaroo.points = 4;
        kangaroo.image = kangarooImage;
        kingCobra.points = 7;
        kingCobra.image = kingCobraImage;
        koala.points = 2;
        koala.image = koalaImage;
        komoDragon.points = 9;
        komoDragon.image = komoDragonImage;
        kraken.points = 40;
        kraken.image = krakenImage;
        leopard.points = 8;
        leopard.image = leopardImage;
        leviathon.points = 75;
        leviathon.image = leviathonImage;
        lion.points = 10;
        lion.image = lionImage;
        lobster.points = 4;
        lobster.image = lobsterImage;
        mamoth.points = 9;
        mamoth.image = mamothImage;
        marlin.points = 5;
        marlin.image = marlinImage;
        megaladon.points = 15;
        megaladon.image = megaladonImage;
        moose.points = 6;
        moose.image = mooseImage;
        mosasaur.points = 12;
        mosasaur.image = mosasaurImage;
        mtGoat.points = 4;
        mtGoat.image = mtGoatImage;
        mtLion.points = 6;
        mtLion.image = mtLionImage;
        newt.points = 2;
        newt.image = newtImage;
        nileCroc.points = 11;
        nileCroc.image = nileCrocImage;
        octopus.points = 3;
        octopus.image = octopusImage;
        orca.points = 11;
        orca.image = orcaImage;
        ostrich.points = 5;
        ostrich.image = ostrichImage;
        owl.points = 5;
        owl.image = owlImage;
        panda.points = 5;
        panda.image = pandaImage;
        parrot.points = 3;
        parrot.image = parrotImage;
        penguin.points = 3;
        penguin.image = penguinImage;
        pig.points = 3;
        pig.image = pigImage;
        pika.points = 1;
        pika.image = pikaImage;
        polarBear.points = 11;
        polarBear.image = polarBearImage;
        puffin.points = 3;
        puffin.image = puffinImage;
        rabbit.points = 2;
        rabbit.image = rabbitImage;
        racoon.points = 3;
        racoon.image = racoonImage;
        raptor.points = 8;
        raptor.image = raptorImage;
        rat.points = 4;
        rat.image = ratImage;
        rattleSnake.points = 6;
        rattleSnake.image = rattleSnakeImage;
        rhino.points = 7;
        rhino.image = rhinoImage;
        robin.points = 1;
        robin.image = robinImage;
        saberTiger.points = 10;
        saberTiger.image = saberTigerImage;
        salamander.points = 4;
        salamander.image = salamanderImage;
        saltCroc.points = 11;
        saltCroc.image = saltCrocImage;
        scorpion.points = 6;
        scorpion.image = scorpionImage;
        seahorse.points = 1;
        seahorse.image = seahorseImage;
        seal.points = 5;
        seal.image = sealImage;
        sheep.points = 2;
        sheep.image = sheepImage;
        sloth.points = 2;
        sloth.image = slothImage;
        snowLep.points = 6;
        snowLep.image = snowLepImage;
        spermWhale.points = 10;
        spermWhale.image = spermWhaleImage;
        spider.points = 6;
        spider.image = spiderImage;
        squirel.points = 2;
        squirel.image = squirelImage;
        steg.points = 7;
        steg.image = stegImage;
        stingray.points = 5;
        stingray.image = stingrayImage;
        stonefish.points = 8;
        stonefish.image = stonefishImage;
        tiger.points = 9;
        tiger.image = tigerImage;
        trex.points = 12;
        trex.image = trexImage;
        tri.points = 6;
        tri.image = triImage;
        turtle.points = 3;
        turtle.image = turtleImage;
        vulture.points = 4;
        vulture.image = vultureImage;
        walrus.points = 6;
        walrus.image = walrusImage;
        wevil.points = 1;
        wevil.image = wevilImage;
        wolf.points = 8;
        wolf.image = wolfImage;
        yak.points = 4;
        yak.image = yakImage;
        yeti.points = 30;
        yeti.image = yetiImage;
        zebra.points = 4;
        zebra.image = zebraImage;
        
        allCards.Add(alligator);
        allCards.Add(alpChough);
        allCards.Add(anaconda);
        allCards.Add(ankyl);
        allCards.Add(antelope);
        allCards.Add(bat);
        allCards.Add(bee);
        allCards.Add(behemoth);
        allCards.Add(bigfoot);
        allCards.Add(bigsquid);
        allCards.Add(bison);
        allCards.Add(bluewhale);
        allCards.Add(bobcat);
        allCards.Add(brach);
        allCards.Add(bulletant);
        allCards.Add(butterfly);
        allCards.Add(camel);
        allCards.Add(catfish);
        allCards.Add(cameleon);
        allCards.Add(cheetah);
        allCards.Add(chicken);
        allCards.Add(chimp);
        allCards.Add(clownfish);
        allCards.Add(cow);
        allCards.Add(crab);
        allCards.Add(cricket);
        allCards.Add(dartFrog);
        allCards.Add(dinosouchieous);
        allCards.Add(dog);
        allCards.Add(dolphin);
        allCards.Add(dragon);
        allCards.Add(dragonFly);
        allCards.Add(duck);
        allCards.Add(dungBeetle);
        allCards.Add(eagle);
        allCards.Add(elephant);
        allCards.Add(falcon);
        allCards.Add(fenFox);
        allCards.Add(flamingo);
        allCards.Add(fly);
        allCards.Add(frog);
        allCards.Add(giraffe);
        allCards.Add(goat);
        allCards.Add(goldfish);
        allCards.Add(goose);
        allCards.Add(gorilla);
        allCards.Add(grizzly);
        allCards.Add(GWShark);
        allCards.Add(hawk);
        allCards.Add(HHShark);
        allCards.Add(hippo);
        allCards.Add(iguanadon);
        allCards.Add(jag);
        allCards.Add(jellyfish);
        allCards.Add(kangaroo);
        allCards.Add(kingCobra);
        allCards.Add(koala);
        allCards.Add(komoDragon);
        allCards.Add(kraken);
        allCards.Add(leopard);
        allCards.Add(leviathon);
        allCards.Add(lion);
        allCards.Add(lobster);
        allCards.Add(mamoth);
        allCards.Add(marlin);
        allCards.Add(megaladon);
        allCards.Add(moose);
        allCards.Add(mosasaur);
        allCards.Add(mtGoat);
        allCards.Add(mtLion);
        allCards.Add(newt);
        allCards.Add(nileCroc);
        allCards.Add(octopus);
        allCards.Add(orca);
        allCards.Add(ostrich);
        allCards.Add(owl);
        allCards.Add(panda);
        allCards.Add(parrot);
        allCards.Add(penguin);
        allCards.Add(pig);
        allCards.Add(pika);
        allCards.Add(polarBear);
        allCards.Add(penguin);
        allCards.Add(rabbit);
        allCards.Add(racoon);
        allCards.Add(raptor);
        allCards.Add(rat);
        allCards.Add(rattleSnake);
        allCards.Add(rhino);
        allCards.Add(robin);
        allCards.Add(saberTiger);
        allCards.Add(salamander);
        allCards.Add(saltCroc);
        allCards.Add(scorpion);
        allCards.Add(seahorse);
        allCards.Add(seal);
        allCards.Add(sheep);
        allCards.Add(sloth);
        allCards.Add(snowLep);
        allCards.Add(spermWhale);
        allCards.Add(spider);
        allCards.Add(squirel);
        allCards.Add(steg);
        allCards.Add(stingray);
        allCards.Add(stonefish);
        allCards.Add(tiger);
        allCards.Add(trex);
        allCards.Add(tri);
        allCards.Add(turtle);
        allCards.Add(vulture);
        allCards.Add(walrus);
        allCards.Add(wevil);
        allCards.Add(wolf);
        allCards.Add(yak);
        allCards.Add(yeti);
        allCards.Add(zebra);
        
        allCards.Shuffle();
        allCardsLength = allCards.Count;
        cardsForP1 = allCardsLength/(players + 1);
        foreach(Card cardToDeal in allCards)
        {
            cardsDeal.Add(cardToDeal);
        }
        //DEal crads to player 1
        countCards = 0;
        foreach(Card cardToDeal in cardsDeal)
        { 
            if(countCards < cardsForP1)
            {
                p1Deck.Add(cardToDeal);
                countCards++;
            }
            
        }
        for(int i = 0; i < countCards; i++)
        {
            cardsDeal.RemoveAt(0);
        }
        //fill player1 hand
        countCards = 0;
        foreach(Card cardToDeal in p1Deck)
        { 
            if(countCards < 7)
            {
                p1Hand.Add(cardToDeal);
                countCards++;
            }
            
        }
        for(int i = 0; i < countCards; i++)
        {
            p1Deck.RemoveAt(0);
        }
        countCards = 0;
    }

    // Update is called once per frame
    public void playRound()
    {
        //TODO: turn off all box colliders so changes to round cant be made until the next round
        //TODO: make next round button and text appear only after play round is clicked
        for(int c = 0; c < p1Hand.Count; c++)
        {
            if(p1Hand[c].cardToPlay == true){
                player1Points += p1Hand[c].points;
                p1Hand[c].cardToPlay = false;
                p1Hand[c].cardPlayed = true;
            }
            
        }
        pointsText = "Player1 Points: " + player1Points;
        player1Points = 0;
    }

    public void nextRound()
    {
        cp1h1.numClicks = 0;
        cp1h2.numClicks = 0;
        cp1h3.numClicks = 0;
        cp1h4.numClicks = 0;
        cp1h5.numClicks = 0;
        cp1h6.numClicks = 0;
        cp1h7.numClicks = 0;
        player1Points = 0;
        handLength = p1Hand.Count;
        for(int c = 0; c < p1Hand.Count; c++)
        {
            if(p1Hand[c].cardPlayed == true){
                //TODO: Change color of sprites back to white

                p1Hand[c].cardPlayed = false;
                p1Discard.Add(p1Hand[c]);
                p1Hand.RemoveAt(c);
                c--;
            }
            
        }
        for(int c = p1Hand.Count; c < 7; c++)
        {
            if(p1Deck.Count > 0)
            {
                p1Hand.Add(p1Deck[0]);
                p1Deck.RemoveAt(0);
            }
            else
            {
                c--;
                disLength = p1Discard.Count;
                for(int i = 0; i < disLength; i++)
                {
                    p1Deck.Add(p1Discard[0]);
                    p1Discard.RemoveAt(0);
                }
                p1Deck.Shuffle();
            }
            
        }   
        pointsText = "Player1 Points:";
    }
}
