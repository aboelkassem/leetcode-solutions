// Link: https://leetcode.com/problems/accounts-merge

// Using DFS
// Time: O(NKlogNK) N is the number of accounts and KKK is the maximum length of an account
// Space: O(NK)

public class Solution {
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts) {
        var graph = BuildGraph(accounts);
        var visited = new HashSet<string>();
        var result = new List<IList<string>>();
        foreach (var email in graph.Keys)
        {
            if (visited.Contains(email))
                continue;

            var list = new List<string>();
            DFS(email, graph, visited, list);
            list.Sort(StringComparer.Ordinal);
            list.Insert(0, accounts.First(x => x.Contains(email))[0]);
            result.Add(list);
        }

        return result;
    }

    private Dictionary<string, List<string>> BuildGraph(IList<IList<string>> accounts)
    {
        var graph = new Dictionary<string, List<string>>();
        foreach (var account in accounts)
        {
            var email = account[1];
            if (!graph.ContainsKey(email))
                graph.Add(email, new List<string>());

            for (int i = 2; i < account.Count; i++)
            {
                var neighbor = account[i];
                if (!graph.ContainsKey(neighbor))
                    graph.Add(neighbor, new List<string>());

                graph[email].Add(neighbor);
                graph[neighbor].Add(email);
            }
        }

        return graph;
    }

    private void DFS(string email, Dictionary<string, List<string>> graph, HashSet<string> visited, List<string> list)
    {
        if (visited.Contains(email))
            return;

        visited.Add(email);
        list.Add(email);
        foreach (var neighbor in graph[email])
        {
            DFS(neighbor, graph, visited, list);
        }
    }
}