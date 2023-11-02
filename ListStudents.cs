using System;
using System.Collections.Generic;

namespace PR_5 {
    public class ListStudents : IEnumerable<Student> {
        private List<Student> _students = new List<Student>();

        public void Add(Student student) {
            _students.Add(student);
        }

        public void Remove(string fullName) {
            int indexToRemove = -1;

            for (int i = 0; i < _students.Count; i++) {
                if (_students[i].FullName == fullName) {
                    indexToRemove = i;
                    break;
                }
            }

            if (indexToRemove >= 0) {
                _students.RemoveAt(indexToRemove);
            }
        }

        public void QuickSortByScore() {
            QuickSortByScore(_students, 0, _students.Count - 1);
        }

        public ListStudents findWinner() {
            var winners = this;
            winners.QuickSortByScore();
            var newWinner = new ListStudents();
            var currentRank = 0;
            var currentScore = int.MinValue;
            foreach (var student in winners) {
                if (student.Score < currentScore)
                    currentRank++;

                if (currentRank < 3)
                    newWinner.Add(student);
                else if (currentRank == 3 && student.Score == currentScore)
                    newWinner.Add(student);
                else
                    break;

                currentScore = student.Score;
            }

            return newWinner;
        }

        public ListStudents filterByCourse(int Course) {
            var filters = new ListStudents();
            foreach (var st in _students) {
                if(st.Course == Course)
                    filters.Add(st);
            }

            return filters;
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