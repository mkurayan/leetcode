using System;
using System.Collections.Generic;

public class Solution
{
    public int[] DeckRevealedIncreasing(int[] deck)
    {
        if (deck.Length <= 1)
        {
            return deck;
        }

        Array.Sort(deck);

        LinkedList<int> sequence = new LinkedList<int>();
        sequence.AddFirst(deck[deck.Length - 1]);

        for (int i = deck.Length - 2; i >= 0; i--)
        {
            var last = sequence.Last;
            sequence.RemoveLast();
            sequence.AddFirst(last);
            sequence.AddFirst(deck[i]);
        }

        int[] output = new int[deck.Length];
        int counter = 0;
        foreach (var car in sequence)
        {
            output[counter++] = car;
        }

        return output;
    }
}
