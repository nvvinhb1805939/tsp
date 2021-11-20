using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class Edge
    {
        float length;
        int startPoint, endPoint;
        bool isVisited;

        public Edge() { }

        public Edge(float length, int startPoint, int endPoint, bool isVisited)
        {
            this.length = length;
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.isVisited = isVisited;
        }

        public Edge Clone()
        {
            return (Edge) this.MemberwiseClone();
        }

        /*public Edge(Edge edge)
        {
            this.length = edge.length;
            this.startPoint = edge.startPoint;
            this.endPoint = edge.endPoint;
            this.isVisited = edge.isVisited;
        }*/

        public float getLength()
        {
            return this.length;
        }
        public int getStartPoint()
        {
            return this.startPoint;
        }
        public int getEndPoint()
        {
            return this.endPoint;
        }
        public bool getIsVisited()
        {
            return this.isVisited;
        }

        public void setLength(float length)
        {
            this.length = length;
        }
        public void setStartPoint(int startPoint)
        {
            this.startPoint = startPoint;
        }
        public void setEndPoint(int endPoint)
        {
            this.endPoint = endPoint;
        }
        public void setIsVisited(bool isVisited)
        {
            this.isVisited = isVisited;
        }
    }
}
