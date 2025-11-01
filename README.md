# Prototype - Патерн Проєктування

Патерн **Prototype** дозволяє створювати нові об’єкти шляхом **копіювання вже існуючих**, замість створення їх через конструктор. Це корисно, коли створення об’єкта є складним або затратним.

---

## Ідея патерна

> Замість створення об’єкта «з нуля», ми **клонумо** вже готовий екземпляр.

Патерн:
- спрощує створення копій складних об’єктів;
- усуває залежність від конкретних класів під час створення нових екземплярів;
- дозволяє легко створювати **поверхневі або глибокі копії**.

---

## Структура

| Роль | Опис |
|------|------|
| `Prototype` | Абстрактний клас/інтерфейс, що визначає метод `Clone()` |
| `ConcretePrototype` | Клас, що реалізує клонування (копіювання свого стану) |

---

## Код

```csharp
abstract class Prototype { 
    public abstract Prototype Clone(); 
}

class ConcretePrototype : Prototype {
    public int Data;
    public ConcretePrototype(int data){ Data = data; }
    public override Prototype Clone() => (Prototype)MemberwiseClone();
}

## p1 - оригінальний об'єкт || p2 - його копія створена, методом Clone()
class Program {
    static void Main() {
        var p1 = new ConcretePrototype(5);
        var p2 = (ConcretePrototype)p1.Clone();
        Console.WriteLine(p2.Data);
    }
}
