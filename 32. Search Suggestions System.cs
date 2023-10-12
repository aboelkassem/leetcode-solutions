// Link: https://leetcode.com/problems/search-suggestions-system

public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        var trie = new Trie();
        var result = new List<IList<string>>();
        foreach (var product in products)
        {
            trie.Insert(product);
        }
        string prefix = string.Empty;
        foreach (var c in searchWord)
        {
            prefix += c;
            result.Add(trie.Suggest(prefix));
        }

        return result;
    }
}


public class TrieNode
{
    public bool isWord;
    public Dictionary<char, TrieNode> children;
    public TrieNode()
    {
        this.children = new();
    }
}

public class Trie
{
    private TrieNode root;
    public Trie()
    {
        this.root = new TrieNode();
    }

    public void Insert(string word)
    {
        TrieNode cur = this.root;

        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];

            if (!cur.children.ContainsKey(c))
                cur.children.Add(c, new TrieNode());

            cur = cur.children[c]; // continue traversal
        }

        cur.isWord = true;
    }

    public List<string> Suggest(string prefix)
    {
        var result = new List<string>();
        TrieNode cur = this.root;

        for (int i = 0; i < prefix.Length; i++)
        {
            char c = prefix[i];

            if (!cur.children.ContainsKey(c))
                return result; // empty result

            cur = cur.children[c]; // continue traversal
        }

        // return top 3 suggestions
        SuggestTopThree(cur, prefix, ref result);
        return result;
    }

    private void SuggestTopThree(TrieNode cur, string prefix, ref List<string> result)
    {
        // Using DFS

        // Base case 1: reached max suggestions
        if (result.Count == 3)
            return;

        // Base case 2: is word
        if (cur.isWord)
            result.Add(prefix);

        // Run all possible paths
        for (char c = 'a'; c <= 'z'; c++)
        {
            if (cur.children.ContainsKey(c))
            {
                prefix += c;
                SuggestTopThree(cur.children[c], prefix, ref result);
                // backtrack // remove last character // latest added character
                // we just try with each possible character 
                // because we didn't want to add it to prefix permanently 
                prefix = prefix.Remove(prefix.Length - 1); 
            }
        }
    }
}