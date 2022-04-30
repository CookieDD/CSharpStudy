namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            Student[] students = {
                new Student("Alice", 99),
                new Student("Bill", 98),
                new Student("Alice", 100),
                new Student("Alice", 95)
            };

            SortStu<Student>(students,CompareScore);
            foreach(Student stu in students){
                Console.WriteLine($"{stu.score} -> {stu.name}");
            }
        }

        static int CompareScore(Student s1, Student s2){
            return Student.Compare(s1, s2);
        }

        static void SortStu<T>(T[] data, Func<T, T, int> compare){
            bool swapped = true;
            do{
                swapped = false;
                for(int i = 0; i < data.Length - 1; i++){
                    if(compare(data[i], data[i+1])==1){
                        T temp = data[i];
                        data[i] = data[i+1];
                        data[i+1] = temp;
                        swapped = true;
                    }
                }
            }while(swapped);
        }

        // static int CompareScore(Student s1, Student s2){
        //     return Student.Compare(s1, s2);
        // }

        // static void SortStu<T>(T[] data, Func<T, T, int> compare){
        //     bool swapped = true;
        //     do{
        //         swapped = false;
        //         for(int i = 0; i < data.Length-1; i++){
        //             if(compare(data[i], data[i+1])==1){
        //                 T temp = data[i];
        //                 data[i] = data[i+1];
        //                 data[i+1] = temp;
        //                 swapped = true;
        //             }
        //         }
        //     }while(swapped);
        // }

        // static void Sort(int[] array){
        //     bool swapped = true;
        //     do{
        //         swapped = false;
        //         for(int i = 0; i < array.Length - 1; i++){
        //             if(array[i]>array[i+1]){
        //                 int temp = array[i];
        //                 array[i] = array[i+1];
        //                 array[i+1] = temp;
        //                 swapped = true;
        //             }
        //         }
        //     }
        //     while(swapped);
        //     Console.WriteLine("Sorted array:" + string.Join(",",array));
        // }
        class Student{
            public static int id=1;
            public string name {get;}
            public int score {get;}
            public Student(string name, int score = 0){
                this.name = name;
                this.score = score;
            }
            public static int Compare(Student s1, Student s2){
                if(s1.score > s2.score){
                    return 1;
                }
                else if(s1.score < s2.score){
                    return -1;
                }else{
                    return 0;
                }
            }
        }
    }

}