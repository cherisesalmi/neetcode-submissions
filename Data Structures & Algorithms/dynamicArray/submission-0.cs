public class DynamicArray {

    public List<int> myList;
    

        public DynamicArray(int capacity)
        {
            this.myList = new List<int>(capacity);
        }

        public int Get(int i)
        {
            return myList[i];
        }

        public void Set(int i, int n)
        {
            myList[i] = n;
        }

        public void PushBack(int n)
        {
            myList.Add(n);
        }

        public int PopBack()
        {
            int n = myList[myList.Count - 1];
            myList.RemoveAt(myList.Count - 1);
            return n;
        }

        private void Resize()
        {
            int n = myList.Count;
            myList = new List<int>(n);
        }

        public int GetSize()
        {
            return myList.Count;
        }

        public int GetCapacity()
        {
            return myList.Capacity;
        }
    
}
