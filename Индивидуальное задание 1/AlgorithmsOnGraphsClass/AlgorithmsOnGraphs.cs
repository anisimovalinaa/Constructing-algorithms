using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphClass;

namespace AlgorithmsOnGraphsClass
{
    public class AlgorithmsOnGraphs
    {
        private
               Graph graph;
        public AlgorithmsOnGraphs(RichTextBox box)
        {
            graph = new Graph(box);
        }

        public bool CheckingForCorrectness()
        {
            return graph.checkCorrectlyMatrix;
        }

        /// <summary>
        /// Проверяет, содержатся ли в графе петли
        /// </summary>
        /// <returns></returns>
        private bool CheckLoop()
        {
            bool check = new bool();
            for (int i = 0; i < graph.CountOfVertex(); i++)
                if (graph.ExistEdge(i, i)) check = true;
            return check;
        }
        /// <summary>
        /// Проверяет граф на неориентированность
        /// </summary>
        /// <returns></returns>
        public bool CheckUndirected()
        {
            for (int i = 0; i < graph.CountOfVertex(); i++)
                for (int j = 0; j < graph.CountOfVertex(); j++)
                    if (graph.ExistEdge(i, j))
                        if (!graph.ExistEdge(j, i)) return false;
            return true;
        }
        /// <summary>
        /// Проверяет, является ли граф деревом
        /// </summary>
        /// <returns></returns>
        public bool CheckTree()
        {
            if (!CheckUndirected() || CheckLoop() || graph.CountOfVertex() == 1 || CountComponents() > 1 || 
                graph.CountOfVertex() - graph.CountOfEdge() != 1) return false;
            else return true;
        }
        /// <summary>
        /// Осуществляет поиск в глубину графа
        /// </summary>
        /// <param name="v"></param>
        /// <param name="visited"></param>
        private void DFS(int v, bool[] visited)
        {
            int countVertex = graph.CountOfVertex();
            Stack<int> vertex = new Stack<int>();
            vertex.Push(v);
            visited[v] = true;

            while (vertex.Count != 0)
            {
                int currentVertex = vertex.Pop();
                for (int i = 0; i < countVertex; i++)
                {
                    if (graph.ExistEdge(currentVertex, i) && !visited[i])
                    {
                        vertex.Push(currentVertex);
                        currentVertex = i;
                        visited[i] = true;
                        i = -1;
                    }
                }
            }
        }
        /// <summary>
        /// Проверяет является ли граф Эйлеровым
        /// </summary>
        /// <returns></returns>
        public bool CheckEiler()
        {
            for (int i = 0; i < graph.CountOfVertex(); i++)
                if (graph.DegreeOfVertex(i) % 2 != 0) return false;
            return true;
        }
        /// <summary>
        /// Возвращает номер вершины с минимальной степенью
        /// </summary>
        /// <returns></returns>
        private int MinIncindVertex()
        {
            int V1 = new int();
            int min = graph.CountOfVertex();
            for (int i = 0; i < graph.CountOfVertex(); i++)
            {
                if (graph.DegreeOfVertex(i) < min && graph.DegreeOfVertex(i) > 0) V1 = i;
            }
            return V1;
        }
        private void DellEdge(int V1, bool[] visited)
        {
            for (int i = 0; i < graph.CountOfVertex(); i++)
            {
                if (graph.ExistEdge(V1, i))
                {
                    visited[i] = true;
                    graph.DellEdge(V1, i);
                    graph.DellEdge(i, V1);
                    for (int j = 0; j < graph.CountOfVertex(); j++)
                    {
                        graph.DellEdge(i, j);
                        graph.DellEdge(j, i);
                    }
                }
            }
        }
        /// <summary>
        /// Строит код Прюфера для дерева
        /// </summary>
        /// <returns></returns>
        public List<int> CodeP()
        {
            if (CheckTree())
            {
                List<int> result = new List<int>();
                List<int> leaves = new List<int>();
                int[] degree = new int[graph.CountOfVertex()];
                bool[] killed = new bool[graph.CountOfVertex()];

                for (int i = 0; i < graph.CountOfVertex(); ++i)
                {
                    degree[i] = graph.DegreeOfVertex(i);
                    if (degree[i] == 1)
                        leaves.Add(i);
                }

                for (int iter = 0; iter < graph.CountOfVertex() - 2; ++iter)
                {
                    int leaf = leaves.Min();
                    leaves.Remove(leaves.Min());
                    killed[leaf] = true;

                    int v = new int();
                    for (int i = 0; i < graph.CountOfVertex(); ++i)
                        if (!killed[i] && graph.ExistEdge(leaf, i))
                            v = i;

                    result.Add(v + 1);
                    if (--degree[v] == 1)
                        leaves.Add(v);
                }
                return result;
            }
            else return null;
        }

        /// <summary>
        /// Считает количество компонент связности
        /// </summary>
        /// <returns></returns>
        public int CountComponents()
        {
            if (CheckUndirected())
            {
                bool[] visited = new bool[graph.CountOfVertex()];
                int K = new int();
                for (int i = 0; i < graph.CountOfVertex(); i++)
                {
                    if (!visited[i])
                    {
                        K++;
                        DFS(i, visited);
                    }
                }
                return K;
            }
            else return -1;
        }

        /// <summary>
        /// Строит базу графа
        /// </summary>
        /// <returns></returns>
        public List<int> Baza()
        {
            bool[] visited = new bool[graph.CountOfVertex()];
            List<int> baza = new List<int>();
            for (int i = 0; i < graph.CountOfVertex(); i++)
            {
                if (!visited[i])
                {
                    baza.Add(i + 1);
                    DFS(i, visited);
                }
            }
            return baza;
        }
        /// <summary>
        /// Строит Эйлеров путь
        /// </summary>
        /// <returns></returns>
        public List<int> EilerPath()
        {
            if (CheckEiler() && CountComponents() == 1)
            {
                List<List<int>> ListAdj = graph.CreateListAdj();
                List<int> path = new List<int>();
                Stack<int> S = new Stack<int>();
                int v = 0;// 1я вершина (произвольная)
                int u;

                S.Push(v); //сохраняем ее в стек
                while (S.Count() != 0)
                {  //пока стек не пуст
                    v = S.Peek(); // текущая вершина
                    if (ListAdj[v].Count == 0)
                    { // если нет инцидентных ребер

                        path.Add(S.Pop() + 1);//выводим вершину 
                    }
                    else
                    {
                        u = ListAdj[v][0];
                        S.Push(u);
                        ListAdj[v].Remove(u);
                        ListAdj[u].Remove(v);
                    }
                }
                return path;
            }
            else return null;
        }
        /// <summary>
        /// Возвращает мощность внутренне устойчивого множества
        /// </summary>
        /// <returns></returns>
        public int NumberOfInternalStability()
        {
            List<int> Set = new List<int>();
            bool[] visited = new bool[graph.CountOfVertex()];
            int V1 = new int();
            bool S = new bool();
            do
            {
                S = false;
                for (int i = 0; i < graph.CountOfVertex(); i++)
                    if (graph.DegreeOfVertex(i) != 0) S = true;
                if (S)
                {
                    V1 = MinIncindVertex();
                    visited[V1] = true;
                    Set.Add(V1);
                    DellEdge(V1, visited);
                }
            } while (S != false);

            for (int i = 0; i < visited.Length; i++)
                if (!visited[i]) Set.Add(i);

            return Set.Count();
        }
    }
}
