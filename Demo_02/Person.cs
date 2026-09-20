namespace Demo_02
{
    class Person 
    { 
        private static int count = 0;
        public static int Count 
        { 
            get 
            { 
                return count; 
            }
        }

        public Person()
        {
            Person.count += 1;
        }
        public Person(string name, int age) 
        {  
            Person.count += 1;
        }

        public Person(string shcool, string city) 
        {  
           
        }
    }
}