using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DijkstraTest2
{
    public partial class Form1 : Form
    {
        //Khởi tạo đồ thị để lưu trữ các đỉnh và kết nối giữa chúng        
        Graph g = new Graph();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] cities = { "Đồng Nai", "TP. Hồ Chí Minh", "Tây Ninh", "Đồng Tháp", "An Giang", "Vĩnh Long", "Cần Thơ", "Cà Mau" };
            foreach (string city in cities)
            {
                g.AddVertex(city);
                cbSource.Items.Add(city);
                cbDestination.Items.Add(city);
            }

            AddEdgesToGraph();
        }

        private void AddEdgesToGraph()
        {
            g.AddEdge(0, 1, 36);   // Đồng Nai - TP. Hồ Chí Minh
            g.AddEdge(0, 2, 75);   // Đồng Nai - Tây Ninh
            g.AddEdge(1, 2, 47);  // TP. Hồ Chí Minh - Tây Ninh
            g.AddEdge(2, 3, 20);   // Tây Ninh - Đồng Tháp
            g.AddEdge(3, 4, 180);  // Đồng Tháp - An Giang
            g.AddEdge(3, 5, 70);  // Đồng Tháp - Vĩnh Long
            g.AddEdge(3, 6, 106);  // Đồng Tháp - Cần Thơ
            g.AddEdge(5, 6, 46);  // Vĩnh Long - Cần Thơ
            g.AddEdge(7, 4, 126);   // Cà Mau - An Giang
            g.AddEdge(6, 4, 95);   // Cần Thơ - An Giang
            g.AddEdge(6, 7, 137);   // Cần Thơ - Cà Mau
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (cbSource.SelectedItem == null || cbDestination.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn điểm bắt đầu và điểm kết thúc.");
                return;
            }

            if (cbSource.SelectedItem == cbDestination.SelectedItem)
            {
                MessageBox.Show("Điểm bắt đầu và kết thúc không được giống nhau.");
                return;
            }

            string startLabel = cbSource.SelectedItem.ToString();
            string endLabel = cbDestination.SelectedItem.ToString();

            int startIndex = g.GetIndexByLabel(startLabel);
            int endIndex = g.GetIndexByLabel(endLabel);

            if (startIndex == -1 || endIndex == -1)
            {
                MessageBox.Show("Không tìm thấy địa điểm đã chọn trong danh sách đỉnh.");
                return;
            }

            g.Dijkstra(startIndex);
            g.FindPath(startIndex, endIndex, tbKM, tbLiter, tbCost, tbPath);
        }
    }


    public class DistOriginal
    {
        public int distance;
        public int parentVert;
        public DistOriginal(int pv, int d) { distance = d; parentVert = pv; }
    }

    //Lớp lưu đỉnh đồ thị
    public class Vertex
    {
        public string label;
        public bool isInTree;
        public Vertex(string lab) { label = lab; isInTree = false; }
    }

    //Lớp khởi tạo đồ thị
    public class Graph
    {
        private const int max_verts = 20;
        private int infinity = 1000000;
        private Vertex[] vertexList = new Vertex[max_verts];
        private int[,] adjMat = new int[max_verts, max_verts];
        private int nVerts = 0;
        private int nTree;
        private DistOriginal[] sPath = new DistOriginal[max_verts];
        private int currentVert;
        private int startToCurrent;

        public Graph()
        {
            for (int i = 0; i < max_verts; i++)
                for (int j = 0; j < max_verts; j++)
                    adjMat[i, j] = infinity;
        }

        //Thêm đỉnh vào đồ thị
        public void AddVertex(string lab)
        {
            if (nVerts >= max_verts)
                throw new InvalidOperationException("Vượt quá số đỉnh cho phép.");
            vertexList[nVerts++] = new Vertex(lab);
        }

        //Thêm cạnh vào đồ thị
        public void AddEdge(int start, int end, int weight, bool bidirectional = true)
        {
            if (start >= 0 && start < nVerts && end >= 0 && end < nVerts)
            {
                adjMat[start, end] = weight;
                if (bidirectional)
                    adjMat[end, start] = weight;
            }
        }

        public int GetIndexByLabel(string label)
        {
            for (int i = 0; i < nVerts; i++)
                if (vertexList[i].label.Equals(label, StringComparison.OrdinalIgnoreCase))
                    return i;
            return -1;
        }

        //Cài đặt thuật 
        public void Dijkstra(int startIndex)
        {
            for (int i = 0; i < nVerts; i++)
                vertexList[i].isInTree = false;

            vertexList[startIndex].isInTree = true;
            nTree = 1;

            for (int j = 0; j < nVerts; j++)
                sPath[j] = new DistOriginal(startIndex, adjMat[startIndex, j]);

            sPath[startIndex].distance = 0;

            while (nTree < nVerts)
            {
                int indexMin = GetMin();
                if (sPath[indexMin].distance == infinity)
                    break;

                currentVert = indexMin;
                startToCurrent = sPath[indexMin].distance;
                vertexList[currentVert].isInTree = true;
                nTree++;
                AdjustShortPath();
            }
        }

        private int GetMin()
        {
            int minDist = infinity;
            int indexMin = 0;
            for (int j = 0; j < nVerts; j++)
                if (!vertexList[j].isInTree && sPath[j].distance < minDist)
                {
                    minDist = sPath[j].distance;
                    indexMin = j;
                }
            return indexMin;
        }

        private void AdjustShortPath()
        {
            for (int column = 0; column < nVerts; column++)
            {
                if (vertexList[column].isInTree) continue;

                int currentToFringe = adjMat[currentVert, column];
                if (currentToFringe == infinity) continue;

                int startToFringe = startToCurrent + currentToFringe;
                if (startToFringe < sPath[column].distance)
                {
                    sPath[column].distance = startToFringe;
                    sPath[column].parentVert = currentVert;
                }
            }
        }

        public void FindPath(int s, int v, TextBox tbKM, TextBox tbLiter, TextBox tbCost, TextBox tbPath)
        {
            List<int> path = new List<int>();
            int km = 0;
            tbPath.Clear();

            try
            {
                int current = v;
                while (current != s)
                {
                    int prev = sPath[current].parentVert;
                    if (prev == -1 || sPath[current].distance == infinity)
                    {
                        MessageBox.Show("Không tìm thấy đường đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    path.Add(current);
                    km += adjMat[prev, current];
                    current = prev;
                }
                path.Add(s);
                path.Reverse();

                tbPath.Text = string.Join(" -> ", path.Select(i => vertexList[i].label));

                double liters = Math.Round(km * 0.09, 2);
                int cost = km * 2043;

                tbKM.Text = $"{km} KM";
                tbLiter.Text = $"{liters} liters";
                tbCost.Text = $"{cost:N0} VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính đường đi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


