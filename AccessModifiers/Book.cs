using System;

namespace AccessModifiers
{
    class Book
    {
        private string _name;
        private int _pageCount;

        public Book(string name, int pageCount) {
            _name = name;
            _pageCount = pageCount;
        }

        // Properties (Shortcut for making getters and setters)
        public string Name {
            get {return _name;}
            set {_name = value;}
        }
        
        // Faster shortcut for making getters and setters!
        public int PageCount {
            get => _pageCount;
            set => _pageCount = value;
        }
        // NOTE:  You can remove a setter to make a property read-only.
        //        Similarly, you can remove a getter to make it write-only. 

        // "Computed properties" are properties that derive their values from other properties.
        public string Description {
            get => $"Name: {Name}. Page count: {PageCount}.";
        }

        // Properies can also be auto-generated - if there's no backing field, the property can hold the data.
        public decimal Price {
            get; set;
        }
    }
}