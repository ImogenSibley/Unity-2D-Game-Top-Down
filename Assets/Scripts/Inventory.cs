using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    Dictionary<string, int> items = new Dictionary<string, int>(); //dictionary to store items
    public int GetCount(string item)
    {
        if (items.ContainsKey(item))
            return items[item];
        else
            return 0;
    }

    public void Add(string item, int count)
    {
        if (items.ContainsKey(item))
            items[item] += count;
        else
            items[item] = count;
    }

    public void Remove(string item, int count = -1)
    {
        if (items.ContainsKey(item))
        {
            if (count == -1)
                items.Remove(item);
            else
            {
                int newCount = items[item] - count;
                if (newCount < 1)
                    items.Remove(item);
                else
                    items[item] = newCount;
            }
        }
    }

    public string GetInventoryString()
    {
        string answer = "Inventory:\n";
        foreach (string item in items.Keys)
        {
            answer += items[item] + "x " + item + "\n";
        }
        return answer;
    }

}
