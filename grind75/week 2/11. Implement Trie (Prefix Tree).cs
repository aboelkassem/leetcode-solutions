// Link: https://leetcode.com/problems/implement-trie-prefix-tree

// Time: O(n) where n is the length of the word
// Space: O(n) where n is the length of the word (in worst case if empty and
// will add all word characters)

public class TrieNode {
  public bool isWord;
  public Dictionary<char, TrieNode> children;
  public TrieNode() { this.children = new(); }
}

public class Trie {
  private TrieNode root;
  public Trie() { this.root = new TrieNode(); }

  public void Insert(string word) {
    TrieNode cur = this.root;

    for (int i = 0; i < word.Length; i++) {
      char c = word[i];

      if (!cur.children.ContainsKey(c))
        cur.children.Add(c, new TrieNode());

      cur = cur.children[c]; // continue traversal
    }

    cur.isWord = true;
  }

  public bool Search(string word) {
    TrieNode cur = this.root;

    for (int i = 0; i < word.Length; i++) {
      char c = word[i];

      if (!cur.children.ContainsKey(c))
        return false;

      cur = cur.children[c]; // continue traversal
    }

    return cur.isWord; // if exist and is word
  }

  public bool StartsWith(string prefix) {
    TrieNode cur = this.root;

    for (int i = 0; i < prefix.Length; i++) {
      char c = prefix[i];

      if (!cur.children.ContainsKey(c))
        return false;

      cur = cur.children[c]; // continue traversal
    }

    return true; // if exist only
  }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
