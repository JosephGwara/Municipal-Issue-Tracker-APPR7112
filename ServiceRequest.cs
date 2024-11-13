using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Issue_Tracker
{
    internal class ServiceRequest
    {
        public int RequestId { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }

        public ServiceRequest(int id, string description, string status)
        {
            RequestId = id;
            Description = description;
            Status = status;
        }

        public class BSTNode
        {
            public ServiceRequest Data;
            public BSTNode Left;
            public BSTNode Right;

            public BSTNode(ServiceRequest data)
            {
                Data = data;
            }

        }

        public class BinarySearchTree
        {
            public BSTNode Root;

            public void Insert(ServiceRequest request)
            {
                Root = Insert(Root, request);
            }
            private BSTNode Insert(BSTNode node, ServiceRequest request)
            {
                if (node == null) return new BSTNode(request);

                if (request.RequestId < node.Data.RequestId)
                    node.Left = Insert(node.Left, request);
                else if (request.RequestId > node.Data.RequestId)
                    node.Right = Insert(node.Right, request);

                return node;
            }
            public ServiceRequest Search(int requestId)
            {
                return Search(Root, requestId);
            }
            private ServiceRequest Search(BSTNode node, int requestId)
            {
                if (node == null) return null;

                if (requestId < node.Data.RequestId) return Search(node.Left, requestId);
                else if (requestId > node.Data.RequestId) return Search(node.Right, requestId);
                else return node.Data;
            }


        }
        public class MinHeap
        {
            private List<ServiceRequest> _heap = new List<ServiceRequest>();

            public void Insert(ServiceRequest request)
            {
                _heap.Add(request);
                int i = _heap.Count - 1;

                while (i > 0 && _heap[i].RequestId < _heap[(i - 1) / 2].RequestId)
                {
                    int parentIndex = (i - 1) / 2;
                    (_heap[i], _heap[parentIndex]) = (_heap[parentIndex], _heap[i]);
                    i = parentIndex;
                }
            }
            public ServiceRequest ExtractMin()
            {
                if (_heap.Count == 0) throw new InvalidOperationException("Heap is empty.");
                ServiceRequest min = _heap[0];
                _heap[0] = _heap[^1];
                _heap.RemoveAt(_heap.Count - 1);
                Heapify(0);
                return min;
            }
            private void Heapify(int i)
            {
                int smallest = i;
                int left = 2 * i + 1;
                int right = 2 * i + 2;

                if (left < _heap.Count && _heap[left].RequestId < _heap[smallest].RequestId)
                    smallest = left;
                if (right < _heap.Count && _heap[right].RequestId < _heap[smallest].RequestId)
                    smallest = right;

                if (smallest != i)
                {
                    (_heap[i], _heap[smallest]) = (_heap[smallest], _heap[i]);
                    Heapify(smallest);
                }
            }

        }
    }
}
