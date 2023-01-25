#include <iostream>
#include <queue>
#include <stack>
#include <vector>
#include <array>
using namespace std;
const int N = 10;
int i, j;
bool* visited = new bool[N];

int graph[N][N] =
{
{0, 1, 0, 0, 1, 0, 0, 0, 0, 0},
{1, 0, 0, 0, 0, 0, 1, 1, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
{0, 0, 0, 0, 0, 1, 0, 0, 1, 0},
{1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
{0, 0, 0, 1, 1, 0, 0, 0, 1, 0},
{0, 1, 0, 0, 0, 0, 0, 1, 0, 0},
{0, 1, 1, 0, 0, 0, 1, 0, 0, 0},
{0, 0, 0, 1, 0, 1, 0, 0, 0, 1},
{0, 0, 0, 0, 0, 0, 0, 0, 1, 0}
};

void WidthFS(int start) {
    queue <int> q;
    bool visited[N];
    int view_cell;
    for (int i = 0; i < N; i++)
    {
        visited[i] = false;
    }
    q.push(start);
    visited[start] = true;
    while (!q.empty())
    {
        view_cell = q.front();
        cout << view_cell + 1 << " ";
        q.pop();
        for (int i = 0; i < N; i++)
        {
            if (!visited[i] && graph[view_cell][i])
            {
                q.push(i);
                visited[i] = true;
            }
        }
    }
}



void DeepFS(int start)
{

    stack <int> s;
    bool visited[N];
    int view_cell;
    for (int i = 0; i < N; i++)
    {
        visited[i] = false;
    }
    s.push(start);
    visited[start] = true;
    while (!s.empty())
    {
        view_cell = s.top();
        cout << view_cell + 1 << " ";
        s.pop();
        for (int i = 0; i < N; i++)
        {
            if (!visited[i] && graph[view_cell][i])
            {
                s.push(i);
                visited[i] = true;
            }
        }
    }

}


void main()
{
    setlocale(LC_ALL, "Rus");
    cout << "\nСписок рёбер: " << endl;
    int arr_1[11] = { 1,1,2,2,3,4,4,5,6,7,9 };
    int arr_2[11] = { 2,5,7,8,8,6,9,6,9,8,10 };

    for (int i = 0; i < N; i++)
    {
        cout << '{' << arr_1[i] << ", " << arr_2[i] << '}';
        cout << " {" << arr_2[i] << ", " << arr_1[i] << '}' << endl;
    }

    cout << "\nСписок смежности: " << endl;
    int arrEdges[10][10] =
    { {2,5},
        {7,8},
        {8},
        {6,9},
        {1,6},
        {4,5,9},
        {2,8},
        {2,3,7},
        {4,6,10},
        {9}
    };
    for (int i = 0; i < N; i++)
    {
        cout << i + 1 << "->";

        for (int j = 0; j < N; j++)
        {
            if (arrEdges[i][j] == 0)
            {
                break;
            }
            cout << arrEdges[i][j] << " ";
        }
        cout << endl;
    }
    cout << endl;

    int start;
    cout << "Введите Start: ";
    cin >> start;

    cout << "Матрица смежности графа: " << endl;
    for (i = 0; i < N; i++)
    {
        visited[i] = false;
        for (j = 0; j < N; j++)
            cout << " " << graph[i][j];
        cout << endl;
    }
   
    cout << "\nСтартовая вершина: " << start;
    cout << "\nПорядок обхода в глубину: ";
    DeepFS(start - 1);
    delete[]visited;
    cout << "\n\nПорядок обхода в ширину: ";
    WidthFS(start - 1);
    cout << endl << endl;
}
