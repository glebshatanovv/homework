using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // ===== BFS: кратчайший путь из start в end =====
    // Возвращает список вершин пути или null, если пути нет
    static List<string> BfsShortestPath(
        Dictionary<string, List<string>> graph,
        string start,
        string end)
    {
        // Проверка: обе вершины есть в графе
        if (!graph.ContainsKey(start) || !graph.ContainsKey(end))
            return null;

        // Очередь для BFS — FIFO
        Queue<string> queue = new Queue<string>();

        // Для каждой вершины храним, откуда мы в неё пришли
        Dictionary<string, string> parent = new Dictionary<string, string>();

        // Посещённые вершины
        HashSet<string> visited = new HashSet<string>();

        queue.Enqueue(start);
        visited.Add(start);
        parent[start] = null;   // у старта нет предка

        // Пока очередь не пуста — обходим слой за слоем
        while (queue.Count > 0)
        {
            string current = queue.Dequeue();

            // Дошли до цели — восстанавливаем путь
            if (current == end)
                return BuildPath(parent, start, end);

            foreach (string neighbor in graph[current])
            {
                if (visited.Contains(neighbor)) continue;

                visited.Add(neighbor);
                parent[neighbor] = current;   // запоминаем, откуда пришли
                queue.Enqueue(neighbor);
            }
        }

        return null;   // пути нет (граф несвязный)
    }

    // ===== Восстановление пути по словарю предков =====
    static List<string> BuildPath(
        Dictionary<string, string> parent, string start, string end)
    {
        List<string> path = new List<string>();
        string cur = end;

        // Идём от конца к началу по ссылкам parent
        while (cur != null)
        {
            path.Add(cur);
            cur = parent[cur];
        }

        path.Reverse();   // разворачиваем: было end→…→start, стало start→…→end
        return path;
    }

    static void Main()
    {
        // ===== Граф (список смежности) =====
        var graph = new Dictionary<string, List<string>>
        {
            ["A"] = new List<string> { "B", "D" },
            ["B"] = new List<string> { "A", "C", "E" },
            ["C"] = new List<string> { "B", "F" },
            ["D"] = new List<string> { "A", "E" },
            ["E"] = new List<string> { "B", "D", "F" },
            ["F"] = new List<string> { "C", "E" },
        };

        string start = "A";
        string end = "F";

        List<string> path = BfsShortestPath(graph, start, end);

        if (path == null)
        {
            Console.WriteLine($"Пути из {start} в {end} нет.");
        }
        else
        {
            Console.WriteLine($"Кратчайший путь {start} → {end}:");
            Console.WriteLine(string.Join(" → ", path));
            Console.WriteLine($"Длина (число рёбер): {path.Count - 1}");
        }
    }
}