using UnityEngine;

[CreateAssetMenu]
[System.Serializable]

public class Shape : ScriptableObject
{
    [System.Serializable]
    public class Row
    {
        public bool[] column;
        private int _size = 0;
        public Row()
        {

        }
        public Row(int size)
        {

        }
        public void CreateRow(int size)
        {
            _size = size;
            column = new bool[_size];
            ClearRow();
        }
        public void ClearRow()
        {
            for (int i = 0; i < _size; i++)
            {
                column[i] = false;
            }
        }
    }
}
