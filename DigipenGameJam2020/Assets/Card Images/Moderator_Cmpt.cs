using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pair<First, Second>
{
    public First first { get; set; }
    public Second second { get; set; }

    public Pair() { }

    public Pair(First first, Second second)
    {
        this.first = first;
        this.second = second;
    }
}
[System.Serializable]
public class Moderator_Cmpt : MonoBehaviour
{

    [SerializeField]
    public string givenString;
    public string answer;

    [SerializeField]
    public GameObject[] cardFaces;
    [SerializeField]
    public GameObject[] cards;

    [SerializeField]
    public Sprite[] cardImages;

    static List<int> designatedNums = new List<int>();


    int GetImageIndexWithCharacter(char c)
    {
        switch (c)
        {
            case 'a':
                return 0;
            case 'b':
                return 1;
            case 'c':
                return 2;
            case 'd':
                return 3;
            case 'e':
                return 4;
            case 'i':
                return 5;
            case 'o':
                return 6;
            case 'u':
                return 7;
            default:
                return -1;
        }
    }
    //char GetCharacterWithImageIndex(Sprite imageIndex)
    //{
    //    switch (imageIndex)
    //    {
    //        case 0:
    //            return 'a';
    //        case 1:
    //            return 'b';
    //        case 2:
    //            return 'c';
    //        case 3:
    //            return 'd';
    //        case 4:
    //            return 'e';
    //        case 5:
    //            return 'i';
    //        case 6:
    //            return 'o';
    //        case 7:
    //            return 'u';
    //        default:
    //            return -1;
    //    }
    //}

    void SetCards()
    {
        foreach (char c in answer)
        {
            Pair<int, int> cardIndex = GetPairNums();

            GameObject obj = cardFaces[cardIndex.first];
            obj.GetComponent<SpriteRenderer>().sprite = cardImages[GetImageIndexWithCharacter(c)];
            cards[cardIndex.first].GetComponent<CharStorage>().c = c;
            GameObject obj2 = cardFaces[cardIndex.second];
            obj2.GetComponent<SpriteRenderer>().sprite = cardImages[GetImageIndexWithCharacter(c)];
            cards[cardIndex.second].GetComponent<CharStorage>().c = c;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        GameObject.Find("Player").GetComponent<Transform>().position = new Vector3(10.0f, -3.2f, -0.01f);
        givenString = "H_ll_ World";
        answer = "eo";

        SetCards();

    }

    // Update is called once per frame
    void Update()
    {
        if (AnyTwoCardsAreFlipped())
        {
            //Check it is correct or wrong
            if(DoTwoCardsMatch())
            {
                RemoveCorrectCards();
                print("Matched!");
                Correct();
            }
            else
            {
                FlipDownAllCards();
            }

        }
    }

    void RemoveCorrectCards()
    {
        for (int i = 0; i < cards.Length; ++i)
        {
            if (cards[i] == null)
            {
                continue;
            }
            if (cards[i].GetComponent<FlipCard>().isFaceUp)
            {
                cards[i] = null;
            }
        }
    }

    bool DoTwoCardsMatch()
    {
        List<char> selectedCard = new List<char>();

        foreach(GameObject tmp in cards)
        {
            if(tmp == null)
            {
                continue;
            }
            if(tmp.GetComponent<FlipCard>().isFaceUp)
            {
                selectedCard.Add(tmp.GetComponent<CharStorage>().c);
            }
        }

        return selectedCard[0] == answer[0]
            && selectedCard[1] == answer[0];
    }

    // Answer processing
    void Correct()
    {
        // Get First character of answer
        char c = answer[0];
        print(c);
        if (answer.Length > 1)
        {
            // Remove first character from answer string
            answer = new string(answer.Substring(1).ToCharArray());
        }

        // find first location of '_'
        int indexOfUnderscore = givenString.IndexOf('_');
        print(indexOfUnderscore);

        // Replace it with given c
        char[] stringAsChars = givenString.ToCharArray();
        stringAsChars[indexOfUnderscore] = c;
        givenString = new string(stringAsChars);

        print(givenString);
        print(' ');

        if(givenString.IndexOf('_') == -1)
        {
            // TODO: End scene, get back to main scene.
            print("Done!");
            SceneManager.LoadScene("EndingScene");
        }
    }

    bool NumsAreValid(Pair<int, int> pair)
    {
        if(pair.first == pair.second)
        {
            return false;
        }

        if(designatedNums.Contains(pair.first) == false &&
            designatedNums.Contains(pair.second) == false)
        {
            return true;
        }

        return false;
    }

    Pair<int, int> GetPairNums()
    {
        Pair<int, int> nums = new Pair<int, int>();
        nums.first = Random.Range(0, 8);
        nums.second = Random.Range(0, 8);

        if(NumsAreValid(nums))
        {
            designatedNums.Add(nums.first);
            designatedNums.Add(nums.second);
            return nums;
        }
        else
        {
            // Recursive call again until get a valid pair.
            return GetPairNums();
        }
    }

    bool AnyTwoCardsAreFlipped()
    {
        int numOfFlipped = 0;
        foreach (GameObject obj in cards)
        {
            if (obj == null)
            {
                continue;
            }
            FlipCard flip = obj.GetComponent<FlipCard>();
            if (flip.isFaceUp == true)
            {
                numOfFlipped++;
            }
        }

        if (numOfFlipped >= 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void FlipDownAllCards()
    {
        foreach (GameObject obj in cards)
        {
            if (obj == null)
            {
                continue;
            }
            if (obj.GetComponent<FlipCard>().isFaceUp)
            {
                obj.GetComponent<FlipCard>().OnMouseDown();
            }
        }

        return;
    }
}
