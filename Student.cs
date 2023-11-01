using System;

namespace PR_5 {
    public class Student : IComparable {
        public string FullName { get; set; }
        private int _course;
        private int _group;
        private int _score;

        public int Course {
            get => _course;
            set {
                if (value <= 0)
                    throw new Exception("Курс не може бути 0!");
                _course = value;
            }
        }

        public int Group {
            get => _group;
            set {
                if (value <= 0)
                    throw new Exception("Группа не може бути 0!");
                _group = value;
            }
        }

        public int Score {
            get => _score;
            set {
                if (value < 0)
                    throw new Exception("Результат не може бути від'ємним!");
                _score = value;
            }
        }

        public Student(string fullName, int course, int group, int score) {
            FullName = fullName;
            Course = course;
            Group = group;
            Score = score;
        }

        public int CompareTo(object obj) {
            var student = obj as Student;
            return _score.CompareTo(student._score);
        }
    }
}