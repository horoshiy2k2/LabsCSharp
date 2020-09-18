using System;

namespace Laba4
{

    class Factory
    {
        private static Factory _factoryInstance; // ссылка на объект класса принадлежит классу. Единственная. 
        //То есть, мы не сможем создать новый экземпляр класса, сможем, но он работать не будет.
        //Контроллирует количество экземпляров. Нарушение принципов SOLID один класс - одна ответственность
        private StorageDetails _factoryStorage; // ссылка на объект класса

        // Закрытый конструктор только единожды создадим.
        private Factory()
        {
            _factoryStorage = new StorageDetails(0, 2000);
        }

        // Статический метод создания объекта Factory. принадлежит классу, Factory.GetInstanceFactoy(), 
        // SingleTon
        public static Factory GetInstanceFactory()
        {
            if (_factoryInstance == null)
            {
                _factoryInstance = new Factory();
            }
            return _factoryInstance;
        }

        // Имя завода
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Полон ли склад
        public bool IsStorageFull
        {
            get { return _factoryStorage.IsFull; }
        }

        // Текущее количество деталей на складе
        public int StorageCurrentDetails()
        {
            return _factoryStorage.KolDetails;
        }

        // Добавить деталей на склад
        public void AddStorageDetails(int kol)
        {
            _factoryStorage.AddDetails(kol);
        }
        
        // Взять детали со склада
        public void GetStorageDetails(int kol)
        {
            _factoryStorage.GetDetails(kol);
        }
    }

    class StorageDetails
    {
        //Конструкторы
        public StorageDetails()
        {
            MaxKol = 1000; // стандартная вместимость
            IsFull = false;
            KolDetails = 0;
        }

        public StorageDetails(int kol)
        {
            MaxKol = 1000;
            KolDetails = kol;
            IsFull = false;
        }

        public StorageDetails(int kol, int maxKol)
        {
            MaxKol = maxKol;
            IsFull = kol > maxKol;
            if (IsFull)
            {
                KolDetails = maxKol; // закинули максимум в хранилище
                Console.WriteLine("Склад заполнен"); // убрать?
            }
            else
            {
                KolDetails = kol;
            }
        }

        //Поля и свойства
        private bool _isFull; // заполнен ли склад

        public bool IsFull
        {
            get { return _isFull; }
            private set { _isFull = value; }
        }

        private int _kolDetails; // текущее количество деталей

        public int KolDetails
        {
            get { return _kolDetails; }
            private set { _kolDetails = value; }
        }
        
        private int _maxKol; // максимальная вместимость склада

        public int MaxKol
        {
            get { return _maxKol; }
            private set { _maxKol = value; }
        }

        //Методы
        public void AddDetails(int kol)
        {
            IsFull = KolDetails + kol > MaxKol;
            if (IsFull)
            {
                Console.WriteLine($"Не вместилось {KolDetails + kol - MaxKol} деталей, склад заполнен");
                KolDetails = MaxKol; // заполняем склад полностью
            }
            else
            {
                KolDetails += kol;
            }
        }

        public void GetDetails(int kol)
        {
            if (KolDetails - kol >= 0)
            {
                KolDetails -= kol;
            }
            else
            {
                Console.WriteLine($"Со склада взято {KolDetails} деталей, склад пуст");
                KolDetails = 0;
            }

            IsFull = false;
        }

        //вместимость склада можно поменять методами можно и не менять

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Factory myFactory = Factory.GetInstanceFactory();
            myFactory.Name = "IKEA";
            PrintInfoOfFactory(myFactory);

            //Добавить детали в склад
            myFactory.AddStorageDetails(100);
            PrintInfoOfFactory(myFactory);

            //Взять детали со склада
            myFactory.GetStorageDetails(50);
            PrintInfoOfFactory(myFactory);

            // склад
            myFactory.AddStorageDetails(3000);
            PrintInfoOfFactory(myFactory);

            //Взять всё со склада
            myFactory.GetStorageDetails(4000);
            PrintInfoOfFactory(myFactory);
        }

        private static void PrintInfoOfFactory(Factory someFactory)
        {
            Console.WriteLine($"Cклад завода {someFactory.Name} полон: {someFactory.IsStorageFull}");
            Console.WriteLine($"Текущее количество деталей: {someFactory.StorageCurrentDetails()}\n");
        }
    }
}

//Задание к работе  
//  Спроектировать классы для выбранной предметной области.  
//  Нарисовать диаграмму классов.  
//  Применить к одному из классов шаблон проектирования Singleton.  

//Индивидуальные задания  
//Разработать  два  класса:  класс - контейнер,  управляющий
//  контейнеризируемым  классом, и  контейнеризируемый  класс.  Для  класа-
//контейнера применить шаблон проектирования Singleton. 
//4.  Завод – Склад деталей; 