using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatrical_Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            Decorator decorator = new Decorator("Андрей", "Нифёдов", 39, "вуз");
            Console.WriteLine(decorator.Description());

            Actor actor = new Actor("Леонардо", "Ди Каприо", 46, "талантливый и беспринципный пройдоха", 10, 9, 8);
            Console.WriteLine(actor.Description());

            Console.ReadKey();
        }
    }
    abstract class Person
    {
        protected string name;
        protected string surname;
        protected byte age;
        public abstract string Description();
        public Person(string name, string surname, byte age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
    }
    class Actor : Person
    {
        byte craft, art_of_presentation, art_of_experiencing;
        string amplua;
        public Actor(string name, string surname, byte age, string amplua, byte craft, byte art_of_presentation, byte art_of_experiencing) : base(name, surname, age)
        {
            this.craft = craft;
            this.art_of_presentation = art_of_presentation;
            this.art_of_experiencing = art_of_experiencing;
            this.amplua = amplua;
        }
        public override string Description()
        {
            return $"{name} {surname}, {age} лет/год(а), амплуа - {amplua}\nРемесло по Станиславскому - {craft}, искусство представления - {art_of_presentation}, искусство переживания - {art_of_experiencing}";
        }
    }
    class Decorator : Person
    {
        string grade;
        public Decorator(string name, string surname, byte age, string grade) : base(name, surname, age)
        {
            this.grade = grade;
        }
        public override string Description()
        {
            return $"{name} {surname}, {age} лет/год(а), образование - {grade}";
        }
    }
    class Performance
    {
        string title;
        DateTime dateTime;
        List<Actor> cast;
        List<Decorator> maintanance;
        public Performance(string title, DateTime dateTime, List<Actor> cast, List<Decorator> maintanance)
        {
            this.title = title;
            this.cast = cast;
            this.maintanance = maintanance;
        }
    }
    class Theatre
    {
        Queue<Performance> queue;
    }
}
