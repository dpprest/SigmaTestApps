using SigmaTestApp1;

namespace MyArraiListTests
{
    public class MyArrayListTests
    {
        //1.  ���� �� �������� ������� ������
        [Fact]
        public void Constructor_CreatesEmptyList()
        {
            var list = new MyArrayList<int>();
            Assert.Equal(0, list.Count);
            Assert.Equal(4, list.Capacity); // DefaultCapacity == 4
        }

        //2. ���� �� ���������� ���������
        [Fact]
        public void Add_Items_IncreasesCount()
        {
            var list = new MyArrayList<string>();

            list.Add("A");
            list.Add("B");

            // Assert
            Assert.Equal(2, list.Count);
            Assert.Equal("A", list[0]);
            Assert.Equal("B", list[1]);
        }

        //3. ���� �� �������������� ����������
        [Fact]
        public void Add_BeyondCapacity_DoublesCapacity()
        {
            var list = new MyArrayList<int>(2);

            list.Add(1);
            list.Add(2);
            list.Add(3); // ������ ������� ����������

            Assert.Equal(3, list.Count);
            Assert.Equal(4, list.Capacity); // 2 * 2
        }

        //4. ���� �� ������� �� �������
        [Fact]
        public void Insert_AtValidIndex_ShiftsElements()
        {
            var list = new MyArrayList<string>();
            list.Add("A");
            list.Add("C");

            list.Insert(1, "B");

            Assert.Equal(3, list.Count);
            Assert.Equal("A", list[0]);
            Assert.Equal("B", list[1]);
            Assert.Equal("C", list[2]);
        }

        //5. ���� �� ������������ ������ ��� �������
        [Fact]
        public void Insert_InvalidIndex_ThrowsException()
        {
            var list = new MyArrayList<int>();
            list.Add(1);

            Assert.Throws<ArgumentOutOfRangeException>(() => list.Insert(2, 2));
            Assert.Throws<ArgumentOutOfRangeException>(() => list.Insert(-1, 0));
        }

        //6. ���� �� �������� ��������
        [Fact]
        public void Remove_ExistingItem_ReturnsTrueAndDecreasesCount()
        {
            var list = new MyArrayList<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");

            bool result = list.Remove("B");

            Assert.True(result);
            Assert.Equal(2, list.Count);
            Assert.Equal("A", list[0]);
            Assert.Equal("C", list[1]);
        }

        //7. ���� �� �������� ��������������� ��������
        [Fact]
        public void Remove_NonExistingItem_ReturnsFalse()
        {
            var list = new MyArrayList<int>();
            list.Add(1);
            list.Add(2);

            bool result = list.Remove(3);

            Assert.False(result);
            Assert.Equal(2, list.Count);
        }

        //8. ���� �� �������� �� �������
        [Fact]
        public void RemoveAt_ValidIndex_RemovesItem()
        {
            var list = new MyArrayList<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");

            list.RemoveAt(1);

            Assert.Equal(2, list.Count);
            Assert.Equal("A", list[0]);
            Assert.Equal("C", list[1]);
        }

        //9. ���� �� ��������� �������� �� �������
        [Fact]
        public void Indexer_Get_ReturnsCorrectItem()
        {
            var list = new MyArrayList<int>();
            list.Add(10);
            list.Add(20);

            Assert.Equal(10, list[0]);
            Assert.Equal(20, list[1]);
        }

        //10. ���� �� ��������� �������� �� �������
        [Fact]
        public void Indexer_Set_UpdatesItem()
        {
            var list = new MyArrayList<string>();
            list.Add("Old");

            list[0] = "New";

            Assert.Equal("New", list[0]);
        }

        //11. ���� �� ������������ ������
        [Fact]
        public void Indexer_InvalidIndex_ThrowsException()
        {
            var list = new MyArrayList<int>();

            Assert.Throws<ArgumentOutOfRangeException>(() => list[0]);
            Assert.Throws<ArgumentOutOfRangeException>(() => list[-1] = 1);
        }

        //12. ���� �� ������� ������
        [Fact]
        public void Clear_ResetsCount()
        {
            var list = new MyArrayList<int>();
            list.Add(1);
            list.Add(2);

            list.Clear();

            Assert.Equal(0, list.Count);
        }

        //13. ���� �� �������� ������� ��������
        [Fact]
        public void Contains_ReturnsCorrectResult()
        {
            var list = new MyArrayList<string>();
            list.Add("Apple");
            list.Add("Banana");

            Assert.True(list.Contains("Apple"));
            Assert.False(list.Contains("Orange"));
        }

        //14. ���� �� �������������� � ������
        [Fact]
        public void ToArray_ReturnsCopyOfItems()
        {
            var list = new MyArrayList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            int[] array = list.ToArray();

            Assert.Equal(new[] { 1, 2, 3 }, array);
        }

        
    }
}