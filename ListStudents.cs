using System.Collections.Generic;

namespace PR_5 {
    public class ListStudents : IEnumerable<Student> {
        private List<Student> _students = new List<Student>();

        public void Add(Student student) {
            _students.Add(student);
        }

        public void Remove(int i) {
            if (i >= 0 && i < _students.Count)
                _students.RemoveAt(i);
        }
        
        
        public void QuickSortByScore() {
            QuickSortByScore(_students, 0, _students.Count - 1);
        }

        public IEnumerator<Student> GetEnumerator() => _students.GetEnumerator();

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
        
        private void Swap(List<Student> students, int i, int j) {
            (students[i], students[j]) = (students[j], students[i]);
        }

        private int PartitionByScore(List<Student> students, int left, int right) {
            var pivot = students[right];
            var i = left - 1;

            for (var j = left; j < right; j++) {
                if (students[j].Score > pivot.Score) {
                    i++;
                    Swap(students, i, j);
                }
            }

            Swap(students, i + 1, right);
            return i + 1;
        }

        private void QuickSortByScore(List<Student> students, int left, int right) {
            if (left < right) {
                int partitionIndex = PartitionByScore(students, left, right);
                QuickSortByScore(students, left, partitionIndex - 1);
                QuickSortByScore(students, partitionIndex + 1, right);
            }
        }
    }
}